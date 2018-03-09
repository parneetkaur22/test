namespace practice.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Table2
    {
        [Required]
        [StringLength(50)]
        public string brand { get; set; }

        [Key]
        [Column("vehno.")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int vehno_ { get; set; }

        public int carID { get; set; }
    }
}
