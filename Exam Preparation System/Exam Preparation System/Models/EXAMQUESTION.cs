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
            EXAMINATIONS = new HashSet<EXAMINATION>();
            EXAMRESULTS = new HashSet<EXAMRESULT>();
        }

        public int ExamQuestionID { get; set; }

        public int? HardRate { get; set; }

        public int? EasyRate { get; set; }

        public int Quantity { get; set; }

        public DateTime ExecutionTime { get; set; }

        public int? QuestionID { get; set; }

        public int? SubjectID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EXAMINATION> EXAMINATIONS { get; set; }

        public virtual QUESTION QUESTION { get; set; }

        public virtual SUBJECT SUBJECT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EXAMRESULT> EXAMRESULTS { get; set; }
    }
}
