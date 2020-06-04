// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client.StickerContentDetailsDtoExtensions
{
    public static class StickerContentDetailsDtoPartialExtensions
    {
        public static Partial<StickerContentDetailsDto> WithSticker(this Partial<StickerContentDetailsDto> it)    => it.AddFieldName("sticker");
        
        public static Partial<StickerContentDetailsDto> WithSticker(this Partial<StickerContentDetailsDto> it, Func<Partial<StickerDto>, Partial<StickerDto>> partialBuilder)    => it.AddFieldName("sticker", partialBuilder(new Partial<StickerDto>()));
        
        public static Partial<StickerContentDetailsDto> WithPack(this Partial<StickerContentDetailsDto> it)    => it.AddFieldName("pack");
        
        public static Partial<StickerContentDetailsDto> WithPack(this Partial<StickerContentDetailsDto> it, Func<Partial<StickerPackInfoDto>, Partial<StickerPackInfoDto>> partialBuilder)    => it.AddFieldName("pack", partialBuilder(new Partial<StickerPackInfoDto>()));
        
    }
    
}
