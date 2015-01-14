﻿
using System.Runtime.Serialization;

namespace Chj.Plugin.Shipping.CanadaPost.Domain
{
    [DataContract(Name = "Language")]
    public enum CanadaPostLanguageEnum
    {
        [EnumMember]
        English = 0,
        [EnumMember]
        French = 1
    }
}
