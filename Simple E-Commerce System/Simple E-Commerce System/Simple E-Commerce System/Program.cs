using System;
using System.Collections.Generic;
using System.IO;


///الكلاس Product
class Product
{
    public int Id;
    public string Name;
    public double Price;
    public int Quantity;
}

class Program
{
    /// تخزين البيانات

    static List<Product> products = new List<Product>();
    static List<Product> cart = new List<Product>();

    static void Main()
    {
        int choice = 0;

    //القائمة (Menu)

        while (choice != 7)
        {
            Console.WriteLine("\n1. Add Product");
            Console.WriteLine("2. View Products");
            Console.WriteLine("3. Search Product");
            Console.WriteLine("4. Add To Cart");
            Console.WriteLine("5. View Cart");
            Console.WriteLine("6. Checkout");
            Console.WriteLine("7. Exit");

            try
            {
                Console.Write("Choose: ");
                choice = int.Parse(Console.ReadLine());

      ///الدوال (Methods)
                switch (choice)
                {
                    case 1: AddProduct(); break;
                    case 2: ViewProducts(); break;
                    case 3: SearchMenu(); break;
                    case 4: AddToCartMenu(); break;
                    case 5: ViewCart(); break;
                    case 6: Checkout(); break;
                    case 7: SaveToFile(); break;
                    default: Console.WriteLine("Invalid choice"); break;
                }
            }
            catch
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }

    //  Add Product
    static void AddProduct()
    {
        try
        {
            Product p = new Product();

            Console.Write("Id: ");
            p.Id = int.Parse(Console.ReadLine());

            Console.Write("Name: ");
            p.Name = Console.ReadLine();

            Console.Write("Price: ");
            p.Price = double.Parse(Console.ReadLine());

            Console.Write("Quantity: ");
            p.Quantity = int.Parse(Console.ReadLine());

            products.Add(p);

            Console.WriteLine($"Added: {p.Name}");
        }
        catch
        {
            Console.WriteLine("Error adding product!");
        }
    }

    //  View Products
    static void ViewProducts()
    {
        foreach (var p in products)
        {
            Console.WriteLine($"ID: {p.Id}, Name: {p.Name}, Price: {p.Price}, Qty: {p.Quantity}");
        }
    }

    //  Method Overloading
    static Product SearchProduct(int id)
    {
        foreach (var p in products)
        {
            if (p.Id == id)
                return p;
        }
        throw new Exception("Product not found!");
    }

    static Product SearchProduct(string name)
    {
        foreach (var p in products)
        {
            if (p.Name.ToLower() == name.ToLower())
                return p;
        }
        throw new Exception("Product not found!");
    }

    static void SearchMenu()
    {
        Console.WriteLine("1. Search by ID");
        Console.WriteLine("2. Search by Name");

        int ch = int.Parse(Console.ReadLine());

        try
        {
            if (ch == 1)
            {
                Console.Write("Enter ID: ");
                int id = int.Parse(Console.ReadLine());
                var p = SearchProduct(id);
                Console.WriteLine($"Found: {p.Name}");
            }
            else
            {
                Console.Write("Enter Name: ");
                string name = Console.ReadLine();
                var p = SearchProduct(name);
                Console.WriteLine($"Found: {p.Name}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    //  ref 
    static void UpdateQuantity(ref int stock, int qty)
    {
        stock -= qty;
    }

    //  out 
    static bool TryGetProduct(int id, out Product product)
    {
        product = null;
        foreach (var p in products)
        {
            if (p.Id == id)
            {
                product = p;
                return true;
            }
        }
        return false;
    }

    static void AddToCartMenu()
    {
        try
        {
            Console.Write("Product ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Quantity: ");
            int qty = int.Parse(Console.ReadLine());

            AddToCart(id, qty);
        }
        catch
        {
            Console.WriteLine("Invalid input!");
        }
    }

    static void AddToCart(int productId, int quantity)
    {
        if (TryGetProduct(productId, out Product p))
        {
            if (p.Quantity < quantity)
                throw new Exception("Not enough stock!");

            UpdateQuantity(ref p.Quantity, quantity);

            cart.Add(new Product
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                Quantity = quantity
            });

            Console.WriteLine($"Added to cart: {p.Name}");
        }
        else
        {
            Console.WriteLine("Product not found!");
        }
    }

    //  Recursion
    static void DisplayCartRecursive(int index)
    {
        if (index >= cart.Count)
            return;

        var item = cart[index];
        Console.WriteLine($"Product: {item.Name}, Qty: {item.Quantity}");

        DisplayCartRecursive(index + 1);
    }

    static void ViewCart()
    {
        DisplayCartRecursive(0);
    }

    static void Checkout()
    {
        double total = 0;

        foreach (var item in cart)
        {
            total += item.Price * item.Quantity;
        }

        Console.WriteLine($"Total Price: {total}");
        cart.Clear();
    }

    //  File Handling (Bonus)
    static void SaveToFile()
    {
        using (StreamWriter sw = new StreamWriter("products.txt"))
        {
            foreach (var p in products)
            {
                sw.WriteLine($"{p.Id},{p.Name},{p.Price},{p.Quantity}");
            }
        }

        Console.WriteLine("Saved to file.");
    }
} 