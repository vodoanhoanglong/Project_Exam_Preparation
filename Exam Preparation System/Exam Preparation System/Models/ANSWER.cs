namespace Exam_Preparation_System.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ANSWERS")]
    public partial class ANSWER
    {
        [Key]
        public int AnswersID { get; set; }

        [Required]
        [Column(TypeName = "NVARCHAR")]
        public string AnswersContent { get; set; }

        public bool isCorrect { get; set; }

        public int? QuestionID { get; set; }

        public virtual QUESTION QUESTION { get; set; }
    }
}
