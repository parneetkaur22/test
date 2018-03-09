namespace practice.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Table1
    {
        [Required]
        [StringLength(50)]
        public string car { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int carID { get; set; }

        [Required]
        [StringLength(50)]
        public string color { get; set; }
    }
}
