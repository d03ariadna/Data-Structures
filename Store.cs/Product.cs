using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.cs
{
    public class Product
    {

        public int id { get; set; }
        public string title { get; set; }
        public float price { get; set; }
        public int quantity { get; set; }
        public float total => price * quantity;
        public string description { get; set; }

        public Product(){
            this.id = 0;
            this.title = "";
            this.price = 0;
            this.quantity = 0;
            this.description = "";
        }
        

    


    }

}
