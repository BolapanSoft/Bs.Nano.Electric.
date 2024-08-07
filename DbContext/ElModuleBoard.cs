namespace Nano.Electric
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("ElModuleBoard")]
    public partial class ElModuleBoard
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("id")] public int Id { get; set; }

        public string Name { get; set; }

        public string Series { get; set; }

        public string Description { get; set; }

        public string SpecDescription { get; set; }

        public string DbDocument { get; set; }

        public string Manufacturer { get; set; }

        public string Code { get; set; }

        public double? DbVoltage { get; set; }

        public double? DbInom { get; set; }

        public double? ShockIkz { get; set; }

        public int? CableLeadIn { get; set; }

        public int? DbInstType { get; set; }

        public int? IsExplSafe { get; set; }

        public string Mass { get; set; }

        public double? DbHeight { get; set; }

        public double? DbWidth { get; set; }

        public double? DbDepth { get; set; }

        public int? RowCount { get; set; }

        public int? ModuleCountInRow { get; set; }

        public int? OrderNumber { get; set; }

        public int? CwPCode { get; set; }

        public int? DbImageRef { get; set; }

        public int? DbClimate { get; set; }

        public int? ExplodeLevel { get; set; }

        public int? DbSafeDegree { get; set; }

        public bool? InImport { get; set; }

        public string Url { get; set; }

#if DBNE23
        public string DbClassificatorCode { get; set; }
#endif
    }
}
