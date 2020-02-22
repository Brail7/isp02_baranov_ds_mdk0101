using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDefinitionTask1
{
    class Product
    {
        public string NameProduct{get;set;}
        public int QuantityProduct{get;set;}
        public double Cost{get;set;}
        public DateTime ShelfLife { get; set; }

        public Product(string nameProduct, int quanityProduct, double cost, DateTime shelfLife)
        {
            NameProduct = nameProduct;
            QuantityProduct = quanityProduct;
            Cost = cost;
            ShelfLife = shelfLife;
        }
        public override string ToString()
        {
            return $"Наименование: {NameProduct}, Количество: {QuantityProduct}, " +
                $"Стоимость: {Cost}, Годен до: {ShelfLife}";
        }
    }
}
