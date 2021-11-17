namespace Exam_Preparation_System.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QUESTIONS")]
    public partial class QUESTION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QUESTION()
        {
            ANSWERS = new HashSet<ANSWER>();
            EXAMQUESTIONS = new HashSet<EXAMQUESTION>();
        }

        public int QuestionID { get; set; }

        [Column(TypeName = "NVARCHAR")]
        public string Contents { get; set; }

        public string Images { get; set; }

        public int Levels { get; set; }

        public bool? Forms { get; set; }

        public int? SubjectID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ANSWER> ANSWERS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EXAMQUESTION> EXAMQUESTIONS { get; set; }

        public virtual SUBJECT SUBJECT { get; set; }
    }
}
