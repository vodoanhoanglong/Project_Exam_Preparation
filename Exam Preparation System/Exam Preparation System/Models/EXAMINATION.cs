namespace Exam_Preparation_System.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EXAMINATIONS")]
    public partial class EXAMINATION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EXAMINATION()
        {
            CADIDATELISTs = new HashSet<CADIDATELIST>();
        }

        public int ExaminationID { get; set; }

        [Required]
        [StringLength(50)]
        public string ExaminationName { get; set; }

        public DateTime TimeStart { get; set; }

        public DateTime TimeEnd { get; set; }

        [Required]
        [StringLength(50)]
        public string PINCode { get; set; }

        public int? ExamQuestionID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CADIDATELIST> CADIDATELISTs { get; set; }

        public virtual EXAMQUESTION EXAMQUESTION { get; set; }
    }
}
