using SQLite;
using System.Collections.Generic;

namespace Aplicatie_Examen.Models
    {
        public class Product
        {
            [PrimaryKey, AutoIncrement]
            public int ID { get; set; }
            public string Description { get; set; }
            [OneToMany]
        public List<ListProduct> ListProducts { get; set; }

        public class ListProduct
        {
        }
    }
    }
   
   
    
