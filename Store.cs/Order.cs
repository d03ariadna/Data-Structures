using Store.cs;
using System;

public class Order
{
	public float shipping { get; set; }
    public float discount { get; set; }
    public float totalPrice => getTotal();

	public List<Product> products;

	public Order()
	{
		this.products = new List<Product>();
	}

    public void checkExistency(int id, string tit, float pri, int qua, string desc)
    {

        for(int i = 0; i < products.Count; i++)
        {
            if (products[i].id == id){
                products[i].quantity += qua;
                return;
            }
        }

        Product Nproduct = new Product();
        Nproduct.id = id;
        Nproduct.title = tit;
        Nproduct.price = pri;
        Nproduct.quantity = qua;
        Nproduct.description = desc;
        products.Add(Nproduct);
    }


    private float getTotal()
    {
        float totP = 0;

        foreach(Product Nproduct in products)
        {
            totP += Nproduct.total;
        }

        totP = totP + shipping - discount;

        return totP;

    }
    
}
