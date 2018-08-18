namespace MyCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ImagesCar")]
    public partial class ImagesCar
    {
        public Guid Id { get; set; }

        public byte[] ImageCar { get; set; }

        public Guid? CarId { get; set; }

        public virtual Car Car { get; set; }
    }
}
