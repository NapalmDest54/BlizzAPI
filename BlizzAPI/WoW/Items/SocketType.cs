using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace BlizzAPI.WoW.Items
{
    public enum SocketType
    {
        [EnumMember(Value = "None")]
        None = 0,

        [EnumMember(Value = "RED")]
        Red,

        [EnumMember(Value = "YELLOW")]
        Yellow,

        [EnumMember(Value = "BLUE")]
        Blue,

        [EnumMember(Value = "META")]
        Meta,

        [EnumMember(Value = "COGWHEEL")]
        Cogwheel,

        [EnumMember(Value = "HYDRAULIC")]
        Hydraulic,

        [EnumMember(Value = "PRISMATIC")]
        Prismatic,

        [EnumMember(Value = "ORANGE")]
        Orange,

        [EnumMember(Value = "PURPLE")]
        Purple,

        [EnumMember(Value = "GREEN")]
        Green
    }
}
