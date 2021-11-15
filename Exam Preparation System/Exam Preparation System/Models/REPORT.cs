namespace Exam_Preparation_System.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("REPORTS")]
    public partial class REPORT
    {
        public int ReportID { get; set; }

        [Required]
        public string Contents { get; set; }

        public DateTime? CreateAt { get; set; }
    }
}
