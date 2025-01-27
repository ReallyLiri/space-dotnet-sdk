#nullable enable

using System;
using System.Globalization;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using JetBrains.Annotations;
using JetBrains.Space.Client;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Utilities;

namespace JetBrains.Space.Generator;

internal class DeploymentInfoClient
{
    private readonly Uri _serverUrl;
    private readonly HttpClient _httpClient;
        
    public DeploymentInfoClient(string serverUrl, HttpClient? httpClient = null)
    {
        if (string.IsNullOrEmpty(serverUrl)
            || !Uri.TryCreate(serverUrl.TrimEnd('/') + "/", UriKind.Absolute, out var serverUri))
        {
            throw new ArgumentException("The Space organization URL is invalid.", nameof(serverUrl));
        }
            
        _serverUrl = serverUri;
        _httpClient = httpClient ?? SharedHttpClient.Instance;
    }
        
    public async Task<DeploymentInfo> GetDeploymentInfoAsync()
    {
        var request = new HttpRequestMessage(HttpMethod.Get, _serverUrl + "about")
                .WithClientAndSdkHeaders(SdkInfo.Version);

        var response = await _httpClient.SendAsync(request);
        var body = await response.Content.ReadAsStringAsync();

        var deploymentInfo = new DeploymentInfo();

        if (TryGetMatch(body, @">Version (?<version>.*)", "version", out var version))
        {
            deploymentInfo.Version = version;
        }
            
        if (TryGetMatch(body, @"Built on (?<built>.*)", "built", out var built) 
            && DateTimeOffset.TryParse(built, CultureInfo.GetCultureInfo("en-US"), DateTimeStyles.None, out var buildDate))
        {
            deploymentInfo.BuildDate = buildDate;
        }
            
        if (TryGetMatch(body, @"Commit hash: (?<commit>.*)", "commit", out var commit))
        {
            deploymentInfo.CommitHash = commit;
        }
            
        if (TryGetMatch(body, @"Branch: (?<branch>.*)<", "branch", out var branch))
        {
            deploymentInfo.Branch = branch;
        }

        return deploymentInfo;
    }

    private static bool TryGetMatch(string input, [RegexPattern]string pattern, string group, out string? value)
    {
        var match = Regex.Match(input, pattern, RegexOptions.Multiline);
        if (match.Success)
        {
            value = match.Groups[group].Value;
            return true;
        }

        value = null;
        return false;
    }
}