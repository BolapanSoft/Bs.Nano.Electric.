﻿#pragma warning disable VSSpell001 // Spell Check

using Nano.Electric.Enums;

namespace Nano.Electric {
    public interface IHaveId {
        int Id { get; set; }
    }
    public partial class SafeDegree : IHaveId { }
    public partial class ClimateTable : IHaveId { }
    public interface IProduct : IHaveId {
        string Code { get; }
        //int Id { get; set; }
        int? DbImageRef { get; set; }
        string Name { get; set; }
        string Manufacturer { get; set; }
    }

    public partial class ScsGutterCanal : IProduct { }
    public partial class DbScsGutterCover : IProduct { }
    public partial class DbScsGutterPartition : IProduct { }
    public partial class ScsGcFitting : IProduct { }
    public partial class DbScsGcCoverUnit : IProduct { }
    public partial class DbScsGcAccessoryUnit : IProduct { }
    public partial class ScsGutterBolting : IProduct { }
    public partial class DbScsGcBoltingAccessoryUnit : IProduct { }
    public partial class CaeMaterialUtility : IProduct { }
    public partial class ElBoard : IProduct, IHaveExplodeLevel, IHaveSafeDegree, IHaveDbClimate { }
    public partial class ElBox : IProduct, IHaveExplodeLevel, IHaveSafeDegree, IHaveDbClimate { }
    public partial class ElShieldingUnit : IProduct, IHaveExplodeLevel, IHaveSafeDegree, IHaveDbClimate { }
    public partial class ElAutomat : IProduct, IHaveExplodeLevel, IHaveSafeDegree, IHaveDbClimate { }
    public partial class ElSafeDevice : IProduct, IHaveExplodeLevel, IHaveSafeDegree, IHaveDbClimate { }
    public partial class ElKnifeSwitch : IProduct, IHaveExplodeLevel, IHaveSafeDegree, IHaveDbClimate { }
    public partial class ElUzo : IProduct, IHaveExplodeLevel, IHaveSafeDegree, IHaveDbClimate { }
    public partial class ElStarter : IProduct, IHaveExplodeLevel, IHaveSafeDegree, IHaveDbClimate { }
    public partial class ElOvervoltageSuppressor : IProduct, IHaveExplodeLevel, IHaveSafeDegree, IHaveDbClimate { }
    public partial class ElFrequenceTransformer : IProduct, IHaveExplodeLevel, IHaveSafeDegree, IHaveDbClimate { }
    public partial class ElCasing : IProduct, IHaveExplodeLevel, IHaveSafeDegree, IHaveDbClimate { }
    public partial class ElFiderUtility : IProduct, IHaveExplodeLevel, IHaveSafeDegree, IHaveDbClimate { }
    public partial class ElBoardUtility : IProduct { }
    public partial class ElBlock : IProduct { }
    public partial class ElPushButtonStation : IProduct, IHaveExplodeLevel, IHaveSafeDegree, IHaveDbClimate { }
    public partial class ElControlDevice : IProduct, IHaveExplodeLevel, IHaveSafeDegree, IHaveDbClimate { }
    public partial class ElCurrentTransformer : IProduct, IHaveExplodeLevel, IHaveSafeDegree, IHaveDbClimate { }
    public partial class ElCounter : IProduct, IHaveExplodeLevel, IHaveSafeDegree, IHaveDbClimate { }
    public partial class ElVoltmeter : IProduct, IHaveExplodeLevel, IHaveSafeDegree, IHaveDbClimate { }
    public partial class ElAmperemeter : IProduct, IHaveExplodeLevel, IHaveSafeDegree, IHaveDbClimate { }
    //public partial class ElCasing : IProduct, IHaveExplodeLevel, IHaveSafeDegree, IHaveDbClimate {  }
    //public partial class ElStarter : IProduct, IHaveExplodeLevel, IHaveSafeDegree, IHaveDbClimate {  }
}
