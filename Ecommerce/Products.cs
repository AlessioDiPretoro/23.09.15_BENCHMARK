using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce
{
    public class CartItem
    {
        //public static List<CartItem> cartList = new List<CartItem>();
        public List<CartItem> cartList = new List<CartItem>();

        public int quantity { get; set; }

        public Products Products { get; set; }

        public CartItem()
        { }

        public CartItem(int quantity, Products products)
        {
            this.quantity = quantity;
            Products = products;
        }
    }

    public class Products
    {
        public static List<Products> productList = new List<Products>();
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Code { get; set; }

        public Products()
        { }

        public Products(int id, string name, string description, double price, string code)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            Code = code;
        }

        public static void GenerateProducts()
        {
            productList.Add(new Products(1, "DIVANO 2P C/CASSETTONE NORA YOUNG BEIGE ", "Peso lordo: 40,000 kg Dimensione LxPxH 126,0 x 110,0 x 62,0 cm", 250.00, "3109"));
            productList.Add(new Products(2, "DIVANO 2P C/CASSETTONE NORA YOUNG BLUE ", "Peso lordo: 40,000 kg Dimensione LxPxH 126,0 x 110,0 x 62,0 cm", 250.00, "3115"));
            productList.Add(new Products(3, "DIVANO 2P C/CASSETTONE NORA YOUNG GREY ", "Peso lordo: 40,000 kg Dimensione LxPxH 126,0 x 110,0 x 62,0 cm", 250.00, "3101"));
            productList.Add(new Products(4, "KIT ARMADIO 1A/4R MULTIUSO ", "Peso lordo: 28,000 kg Dimensione LxPxH 186,0 x 38,0 x 7,0 cm", 65.00, "94623"));
            productList.Add(new Products(5, "KIT ARMADIO 2A MULTIUSO ", "Peso lordo: 44,000 kg Dimensione LxPxH 189,5 x 40,0 x 12,0 cm", 129.00, "94624"));
            productList.Add(new Products(6, "KIT ARMADIO 2A ROVERE ", "Peso lordo: 52,000 kg Dimensione LxPxH 194,0 x 52,5 x 11,0 cm", 99.00, "500622"));
            productList.Add(new Products(7, "KIT ARMADIO 2A GRIGIO ", "Peso lordo: 52,000 kg Dimensione LxPxH 194,0 x 52,5 x 11,0 cm", 99.00, "500632"));
            productList.Add(new Products(8, "KIT ARMADIO 2A VINTAGE ", "Peso lordo: 52,000 kg Dimensione LxPxH 194,0 x 52,5 x 11,0 cm", 99.00, "500627"));
        }

        public static List<Products> GetAllProducts()
        {
            productList.Clear();
            productList.Add(new Products(1, "DIVANO 2P C/CASSETTONE NORA YOUNG BEIGE ", "Peso lordo: 40,000 kg Dimensione LxPxH 126,0 x 110,0 x 62,0 cm", 250.00, "3109"));
            productList.Add(new Products(2, "DIVANO 2P C/CASSETTONE NORA YOUNG BLUE ", "Peso lordo: 40,000 kg Dimensione LxPxH 126,0 x 110,0 x 62,0 cm", 250.00, "3115"));
            productList.Add(new Products(3, "DIVANO 2P C/CASSETTONE NORA YOUNG GREY ", "Peso lordo: 40,000 kg Dimensione LxPxH 126,0 x 110,0 x 62,0 cm", 250.00, "3101"));
            productList.Add(new Products(4, "KIT ARMADIO 1A/4R MULTIUSO ", "Peso lordo: 28,000 kg Dimensione LxPxH 186,0 x 38,0 x 7,0 cm", 65.00, "94623"));
            productList.Add(new Products(5, "KIT ARMADIO 2A MULTIUSO ", "Peso lordo: 44,000 kg Dimensione LxPxH 189,5 x 40,0 x 12,0 cm", 129.00, "94624"));
            productList.Add(new Products(6, "KIT ARMADIO 2A ROVERE ", "Peso lordo: 52,000 kg Dimensione LxPxH 194,0 x 52,5 x 11,0 cm", 99.00, "500622"));
            productList.Add(new Products(7, "KIT ARMADIO 2A GRIGIO ", "Peso lordo: 52,000 kg Dimensione LxPxH 194,0 x 52,5 x 11,0 cm", 99.00, "500632"));
            productList.Add(new Products(8, "KIT ARMADIO 2A VINTAGE ", "Peso lordo: 52,000 kg Dimensione LxPxH 194,0 x 52,5 x 11,0 cm", 99.00, "500627"));

            return productList;
        }
    }
}