namespace MyCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NewsCar")]
    public partial class NewsCar
    {
        public Guid Id { get; set; }

        public Guid? CarId { get; set; }

        public string Description { get; set; }

        public byte[] ImageCar { get; set; }

        public virtual Car Car { get; set; }
    }
}
