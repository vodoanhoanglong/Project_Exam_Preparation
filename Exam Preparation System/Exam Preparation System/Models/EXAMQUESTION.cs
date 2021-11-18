namespace Exam_Preparation_System.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EXAMQUESTIONS")]
    public partial class EXAMQUESTION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EXAMQUESTION()
        {
            EXAMRESULTS = new HashSet<EXAMRESULT>();
            QUESTIONLISTs = new HashSet<QUESTIONLIST>();
        }

        public int ExamQuestionID { get; set; }

        public int Quantity { get; set; }

        [Required]
        [StringLength(1)]
        public string ExecutionTime { get; set; }

        public int? SubjectID { get; set; }

        public virtual SUBJECT SUBJECT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EXAMRESULT> EXAMRESULTS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QUESTIONLIST> QUESTIONLISTs { get; set; }
    }
}
