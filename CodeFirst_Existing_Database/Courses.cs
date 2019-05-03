namespace CodeFirst_Existing_Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Courses
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Courses()
        {
            Tags = new HashSet<Tags>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(255)]

        public string Name { get; set; }

        [Required]
        [MaxLength(2000)]
        public string Description { get; set; }

        public Category Category { get; set; }

        public int level { get; set; }

        public float FullPrice { get; set; }
        [ForeignKey("Authors")]
        public int? Author_Id { get; set; }

        public virtual Authors Authors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tags> Tags { get; set; }
    }
}
