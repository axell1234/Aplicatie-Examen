using SQLite;
using System;

namespace Aplicatie_Examen.Models
{
    internal class ListProducts
    {
[PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public ListProducts(int shopListID)
        {
            ShopListID = shopListID;
        }

        [ForeignKey(typeof(ShopList))]
        public int ShopListID { get; set; }
        public int ProductID { get; set; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

    internal class ForeignKeyAttribute : Attribute
    {
    }
}
