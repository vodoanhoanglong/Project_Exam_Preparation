namespace Exam_Preparation_System.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CADIDATELIST")]
    public partial class CADIDATELIST
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string UserID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ExaminationID { get; set; }

        public DateTime? DateCreate { get; set; }

        public virtual EXAMINATION EXAMINATION { get; set; }

        public virtual USER USER { get; set; }
    }
}
