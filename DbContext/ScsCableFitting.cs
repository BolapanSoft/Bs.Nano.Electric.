namespace Nano.Electric
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("ScsCableFitting")]
    public partial class ScsCableFitting
    {
        public string Code { get; set; }

        public string DbDocument { get; set; }

        public string DbOtherName { get; set; }

        public double? Depth { get; set; }

        public string Description { get; set; }

#if !InitDbContextEnums
        public int? FittingType { get; set; } 
#endif

        public double? Height { get; set; }

        public double? HeightMainBranch { get; set; }

        public double? HeightOutBranch { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("id")] public int Id { get; set; }

        public string Manufacturer { get; set; }

        public string Mass { get; set; }

        public string Name { get; set; }

        public int? OrderNumber { get; set; }

        public string Series { get; set; }

        public string SpecDescription { get; set; }

        public double? WidthMainBranch { get; set; }

        public double? WidthOutBranch { get; set; }

        public int? CwPCode { get; set; }

        public int? DbImageRef { get; set; }

        public string EtmCode { get; set; }

        public bool? InImport { get; set; }

        public string Url { get; set; }

#if DBNE23
        public string DbClassificatorCode { get; set; }
#endif
    }
}
