namespace Nano.Electric
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("SafeDegree")]
    public partial class SafeDegree
    {
        public int? Covered { get; set; }

        public string Degree { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int? OrderNumber { get; set; }

        public string Description { get; set; }

        public int? CwPCode { get; set; }

        public bool? InImport { get; set; }
    }
}
