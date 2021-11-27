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
            LISTQUESTIONs = new HashSet<LISTQUESTION>();
        }

        public int QuestionID { get; set; }

        [Column(TypeName = "NVARCHAR")]
        public string Contents { get; set; }

        public int? SubjectID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ANSWER> ANSWERS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LISTQUESTION> LISTQUESTIONs { get; set; }

        public virtual SUBJECT SUBJECT { get; set; }
    }
}
