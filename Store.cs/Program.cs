using Store.cs;

class Program
{
    private static void Main(string[] args)
    {
        Order[] orders = new Order[20];

        Order ord1 = new Order();
        ord1.checkExistency(1,"Apple", 150, 5, "The yummiest apples");

        ord1.checkExistency(2,"Orange", 120, 10, "The yummiest oranges");

        ord1.checkExistency(1, "Apple", 150, 7, "The yummiest apples");

        ord1.checkExistency(2, "Orange", 120, 5, "The yummiest oranges");

        ord1.discount = 100;
        ord1.shipping = 250;
        orders[0] = ord1;

        // string text = string.Format("Product1: {0}{1}", orders[0].products[0].title, 1);
        Console.WriteLine("Product1: " + orders[0].products[0].title + "\nProduct1 Quantity: " + orders[0].products[0].quantity + "\nProduct2: " + orders[0].products[1].title + "\nProduct2 Quantity: " + orders[0].products[1].quantity + "\nTotal Price: " + orders[0].totalPrice);
    }
}