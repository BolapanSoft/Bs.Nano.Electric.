﻿
/* Unmerged change from project 'Iek.MakeModelStudioCS'
Before:
//using Cadwise.ObjectLib.WireCommon.Db.Localization;
After:
using System.ComponentModel;
//using Cadwise.ObjectLib.WireCommon.Db.Localization;
*/
//using Cadwise.ObjectLib.WireCommon.Db.Localization;
//using Cadwise.Reflection;
using
/* Unmerged change from project 'Iek.MakeModelStudioCS'
Before:
using System.ComponentModel;
using DescriptionAttribute = System.ComponentModel.DescriptionAttribute;
After:
using DescriptionAttribute = System.ComponentModel.DescriptionAttribute;
*/
DescriptionAttribute = System.ComponentModel.DescriptionAttribute;

namespace Nano.Electric.Enums {
    public enum KitStructureType {
        Undefined=0,
        [Description("Лоток")]
        Gutter=1,
        [Description("Полка")]
        DbShelf = 2,
        [Description("Крепление ярусов")]
        Bolting = 3,
        [Description("Комплектующие")]
        DbUtilityUnit = 7,
    }
}
