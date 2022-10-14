namespace Lab.TP4.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using Lab.TP4.Utils.ExtensionMethods;

    [Table("Order Details")]
    public partial class Order_Details
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductID { get; set; }

        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }

        public short Quantity { get; set; }

        public float Discount { get; set; }

        public virtual Orders Orders { get; set; }

        public virtual Products Products { get; set; }

        public override string ToString()
        {
            return string.Format("Product: {0,-45} \t Unit Price: {1,5} \t Quantity: {2,4} \t Discount: {3, 4}",
                Products.ProductName, UnitPrice.Round(), Quantity, Discount);
        }
    }
}
