namespace ProyectEF.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Suppliers
    {
        public Suppliers(int id, string companyName, string phone, string country, string city, string address, string homePage, string contactName, string contactTitle, string fax, string postalCode)
        {
            SupplierID = id;
            CompanyName = companyName;
            Phone = phone;
            Country = country;
            City = city;
            Address = address;
            HomePage = homePage;
            ContactName = contactName;
            ContactTitle = contactTitle;
            Fax = fax;
            PostalCode = postalCode;
        }

        public Suppliers() { }

        [Key]
        public int SupplierID { get; set; }

        [Required]
        [StringLength(40)]
        public string CompanyName { get; set; }

        [StringLength(30)]
        public string ContactName { get; set; }

        [StringLength(30)]
        public string ContactTitle { get; set; }

        [StringLength(60)]
        public string Address { get; set; }

        [StringLength(15)]
        public string City { get; set; }

        [StringLength(15)]
        public string Region { get; set; }

        [StringLength(10)]
        public string PostalCode { get; set; }

        [StringLength(15)]
        public string Country { get; set; }

        [StringLength(24)]
        public string Phone { get; set; }

        [StringLength(24)]
        public string Fax { get; set; }

        [Column(TypeName = "ntext")]
        public string HomePage { get; set; }

        public override string ToString()
        {
            return $"| id: {this.SupplierID} | " +
                $"|compania: {this.CompanyName} | " +
                $"| nombre de contacto: {this.ContactName} | " +
                $"| titulo: {this.ContactName} | " +
                $"| direccion: {this.Address} | " +
                $"| ciudad: {this.City} | " +
                $"| region: {this.Region} | " +
                $"| codigo postal: {this.PostalCode} | " +
                $"| pais: {this.Country} | " +
                $"| telefono: {this.Phone} | " +
                $"| fax: {this.Fax} | " +
                $"| homepage: {this.HomePage} |";
        }
    }
}
