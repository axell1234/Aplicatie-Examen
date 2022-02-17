using SQLite;
using System;
namespace Aplicatie_Examen.Models
{
    public class CarList
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }  
     }
}