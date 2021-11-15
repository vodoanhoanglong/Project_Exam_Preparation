namespace Exam_Preparation_System.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EXAMRESULTS")]
    public partial class EXAMRESULT
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string UserID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ExamQuestionID { get; set; }

        public DateTime? ExamDate { get; set; }

        public double Points { get; set; }

        public TimeSpan TimeComplete { get; set; }

        public virtual EXAMQUESTION EXAMQUESTION { get; set; }

        public virtual USER USER { get; set; }
    }
}
