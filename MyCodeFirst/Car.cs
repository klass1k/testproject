namespace MyCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Car")]
    public partial class Car
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Car()
        {
            ImagesCar = new HashSet<ImagesCar>();
            NewsCar = new HashSet<NewsCar>();
        }

        public Guid Id { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        public Guid? MarkId { get; set; }

        public Guid? EngineId { get; set; }

        public Guid? DriveUnitId { get; set; }

        public Guid? TypesCarBodiesId { get; set; }

        public virtual DriveUnit DriveUnit { get; set; }

        public virtual Engine Engine { get; set; }

        public virtual Mark Mark { get; set; }

        public virtual TypesCarBodies TypesCarBodies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImagesCar> ImagesCar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NewsCar> NewsCar { get; set; }
    }
}
