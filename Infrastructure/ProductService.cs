using Domain;

namespace Infrastructure;

public class ProductService
{
    List<Product> products = [];


    public void Id()
    {
        int a = 1;
        foreach(var p in products)
        {
            p.Id = a;
            a ++;
        }
    }
    public bool FindProduct(int id)
    {
        bool a = false;
        foreach(var p in products)
        {
            if(p.Id == id)
            {
                a = true;
                break;
            }
        }
        return a;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
        System.Console.WriteLine($"The product was created sucessfuly.");
    }
    public void UpdateProduct(Product product, int id)
    {
        foreach(var prod in products)
        {
            if(prod.Id == id)
            {
                prod.Name = product.Name;
                prod.Price = product.Price;
                System.Console.WriteLine($"Product was updated sucessfuly.\n");
                break;
            }
        }
    }
    public void DeleteProduct (int id)
    {
        bool a = false;
        foreach(var prod in products)
        {
            if(prod.Id == id)
            {
                products.Remove(prod);
                a = true;
                System.Console.WriteLine($"Product was deleted sucessfuly!");
                break;
            }
        }
        if(a == false)
        {
            System.Console.WriteLine($"Product with this id was not found!");
        }
    }
    public void GetProductById(int id)
    {
        bool a = false;
        foreach(var prod in products)
        {
            if(prod.Id == id)
            {
                System.Console.WriteLine($"Id: {prod.Id} \nName: {prod.Name} \nPrice: {prod.Price}");
                a = true;
                break;
            }
        }
        if(a == false)
        {
            System.Console.WriteLine($"Product with this id was not found!");
        }
    }
    public void GetAllProducts()
    {
        int cnt = 1;
        foreach(var prod in products)
        {
            System.Console.WriteLine($"-------------------- Product {cnt} --------------------");

            System.Console.WriteLine($"Id: {prod.Id} \nName: {prod.Name} \nPrice: {prod.Price}");
            cnt ++;
        }
    }
    public void FindProductsByName(string name)
    {
        int cnt = 1;
        bool a = false;
        foreach(var prod in products)
        {
            if(prod.Name.ToLower() == name.ToLower())
            {
            System.Console.WriteLine($"-------------------- Product {cnt} --------------------");

            System.Console.WriteLine($"Id: {prod.Id} \nName: {prod.Name} \nPrice: {prod.Price}");
            a = true;
            cnt ++;
            }
        }
        if(a == false)
        {
            System.Console.WriteLine($"Product with this name was not found!");
        }
    }
    public void FindProductsByPrice(decimal price)
    {
        int cnt = 1;
        bool a = false;
        foreach(var prod in products)
        {
            if(prod.Price == price)
            {
            System.Console.WriteLine($"-------------------- Product {cnt} --------------------");

            System.Console.WriteLine($"Id: {prod.Id} \nName: {prod.Name} \nPrice: {prod.Price}");
            a = true;
            cnt ++;
            }
        }
        if(a == false)
        {
            System.Console.WriteLine($"Product with this price was not found!");
        }
    }
    public void GetProductsByDIapason(int a1, int a2)
    {
        int cnt = 1;
        bool a = false;
        foreach(var prod in products)
        {
            if(prod.Price > a1 && prod.Price < a2)
            {
            System.Console.WriteLine($"-------------------- Product {cnt} --------------------");

            System.Console.WriteLine($"Name: {prod.Name} \nPrice: {prod.Price}");
            a = true;
            cnt ++;
            }
        }
        if(a == false)
        {
            System.Console.WriteLine($"Product with this price was not found!");
        }
    }
    public void Clear()
    {
        products.Clear();
    }
}
