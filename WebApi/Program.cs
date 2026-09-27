using Domain;
using Infrastructure;

Product product1 = new Product("Potato", 23);
Product product2 = new Product("Tomato", 35);
Product product3 = new Product("Carrot", 18);
Product product4 = new Product("Onion", 12);
Product product5 = new Product("Cucumber", 27);
Product product6 = new Product("Cabbage", 15);
Product product7 = new Product("Pepper", 42);
Product product8 = new Product("Garlic", 8);
Product product9 = new Product("Beet", 20);
Product product10 = new Product("Zucchini", 30);
ProductService ser = new ProductService(){};
ser.AddProduct(product1);
ser.AddProduct(product2);
ser.AddProduct(product3);
ser.AddProduct(product4);
ser.AddProduct(product5);
ser.AddProduct(product6);
ser.AddProduct(product7);
ser.AddProduct(product8);
ser.AddProduct(product9);
ser.AddProduct(product10);

while(true)
{
    ser.Id();
    System.Console.WriteLine($"==================== Choose option ====================\n");
    System.Console.WriteLine($"1. Add product. ");
    System.Console.WriteLine($"2. Update product. ");
    System.Console.WriteLine($"3. Delete product. ");
    System.Console.WriteLine($"4. Find product by name. ");
    System.Console.WriteLine($"5. Find product by price. ");
    System.Console.WriteLine($"6. Get all products. ");
    System.Console.WriteLine($"7. Get product by id. ");
    System.Console.WriteLine($"8. Get product by deaposon. ");
    System.Console.WriteLine($"9. Delete all products. ");
    System.Console.WriteLine($"0. Exit.");
    int a = Convert.ToInt16(Console.ReadLine());
    switch (a)
    {
        case 1 :
        System.Console.WriteLine($"==================== Adding the product ====================\n");
        System.Console.Write($"Enter product's name: ");
        string name = Console.ReadLine();
        System.Console.Write($"Enter product's price: ");
        decimal price = Convert.ToDecimal(Console.ReadLine());
        Product product = new Product(name, price);
        ser.AddProduct(product);
        break;


        case 2 :
        System.Console.WriteLine($"==================== Updaing the product ====================\n");
        System.Console.Write($"Enter id of product you want to update: ");
        int id = Convert.ToInt32(Console.ReadLine());
        if (ser.FindProduct(id) == true)
            {
                ser.GetProductById(id);
                System.Console.Write($"Enter Name of product you want to update: ");
                string nameforupdate = Console.ReadLine();
                System.Console.Write($"Enter price of product you want to update: ");
                decimal priceforupdate = Convert.ToDecimal(Console.ReadLine());
                Product productforupdate = new Product(nameforupdate, priceforupdate);
                ser.UpdateProduct(productforupdate, id);
            }
        else
            {
                System.Console.WriteLine($"There is not product with this id! ");
            }
        break;


        case 3 :
        System.Console.WriteLine($"==================== Deleting the product ====================\n");
        System.Console.Write($"Enter id of product do you want to delete: ");
        int idfordelete = Convert.ToInt32(Console.ReadLine());
        ser.DeleteProduct(idfordelete);
        break;

        case 4 :
        System.Console.WriteLine($"==================== Finding the product by name ====================\n");
        System.Console.Write($"Enter name of product: ");
        string nameforfind = Console.ReadLine();
        ser.FindProductsByName(nameforfind);
        break;

        case 5 :
        System.Console.WriteLine($"==================== Finding the product by price ====================\n");
        System.Console.Write($"Enter price of product: ");
        decimal pricefofind = Convert.ToDecimal(Console.ReadLine());
        ser.FindProductsByPrice(pricefofind);
        break;

        case 6 :
        System.Console.WriteLine($"==================== Getting all products ====================\n");
        ser.GetAllProducts();
        break;

        case 7 :
        System.Console.WriteLine($"==================== Getting product by id ====================\n");
        System.Console.Write($"Enter id of product: ");
        int idforget = Convert.ToInt32(Console.ReadLine());
        ser.GetProductById(idforget);
        break;
        
        case 8: 
        System.Console.WriteLine($"==================== Getting product by deapason ====================\n");
        System.Console.Write($"The product's price must be more than: ");
        int a1 = Convert.ToInt32(Console.ReadLine());
        System.Console.Write($"And less than: ");
        int a2 = Convert.ToInt32(Console.ReadLine());
        ser.GetProductsByDIapason(a1, a2);
        break;

        case 9 :
        System.Console.WriteLine($"==================== Clearing ====================\n");
        ser.Clear();
        break;

        case 0 :
        return;

        default:
        System.Console.WriteLine($"Wrong number, please try again.");
        break;

    }
}