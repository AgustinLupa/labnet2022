namespace ProyectEF.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Shippers
    {

        public Shippers(int id, string companyName, string phone)
        {
            this.ShipperID = id;
            CompanyName = companyName;
            Phone = phone;
        }

        public Shippers() { }

        [Key]
        public int ShipperID { get; set; }

        [Required]
        [StringLength(40)]
        public string CompanyName { get; set; }

        [StringLength(24)]
        public string Phone { get; set; }

        public override string ToString()
        {
            return $"| id: {this.ShipperID} | compania: {this.CompanyName} | telefono: {this.Phone} |";
        }
    }
}
