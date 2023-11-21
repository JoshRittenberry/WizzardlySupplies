// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;

List<ProductType> ProductTypes = new List<ProductType>()
{
    new ProductType() {ID = 1, Name = "Apparel"},
    new ProductType() {ID = 2, Name = "Potion"},
    new ProductType() {ID = 3, Name = "Enchanted Object"},
    new ProductType() {ID = 4, Name = "Wand"}
};
List<Product> products = new List<Product>()
{
    new Product() { ID = 1, Name = "Mystic Cloak", Price = 50, Sold = false, ProductTypeID = 1, DateStocked = new DateTime(2023, 9, 5) },
    new Product() { ID = 2, Name = "Invisibility Potion", Price = 75, Sold = true, ProductTypeID = 2, DateStocked = new DateTime(2023, 6, 24) },
    new Product() { ID = 3, Name = "Flying Carpet", Price = 120, Sold = false, ProductTypeID = 3, DateStocked = new DateTime(2023, 9, 11) },
    new Product() { ID = 4, Name = "Elder Wand", Price = 200, Sold = true, ProductTypeID = 4, DateStocked = new DateTime(2023, 10, 26) },
    new Product() { ID = 5, Name = "Phoenix Feather Hat", Price = 65, Sold = false, ProductTypeID = 1, DateStocked = new DateTime(2023, 7, 25) },
    new Product() { ID = 6, Name = "Health Elixir", Price = 55, Sold = true, ProductTypeID = 2, DateStocked = new DateTime(2023, 9, 4) },
    new Product() { ID = 7, Name = "Enchanted Mirror", Price = 130, Sold = false, ProductTypeID = 3, DateStocked = new DateTime(2023, 10, 31) },
    new Product() { ID = 8, Name = "Maple Magic Wand", Price = 80, Sold = true, ProductTypeID = 4, DateStocked = new DateTime(2023, 10, 24) },
    new Product() { ID = 9, Name = "Wizard Robe", Price = 45, Sold = false, ProductTypeID = 1, DateStocked = new DateTime(2023, 11, 15) },
    new Product() { ID = 10, Name = "Potion of Luck", Price = 90, Sold = true, ProductTypeID = 2, DateStocked = new DateTime(2023, 10, 14) },
    new Product() { ID = 11, Name = "Goblin Gold Detector", Price = 85, Sold = false, ProductTypeID = 3, DateStocked = new DateTime(2023, 7, 4) },
    new Product() { ID = 12, Name = "Dragon Scale Boots", Price = 120, Sold = true, ProductTypeID = 1, DateStocked = new DateTime(2023, 9, 30) },
    new Product() { ID = 13, Name = "Elixir of Wisdom", Price = 95, Sold = false, ProductTypeID = 2, DateStocked = new DateTime(2023, 10, 25) },
    new Product() { ID = 14, Name = "Birch Bark Wand", Price = 70, Sold = true, ProductTypeID = 4, DateStocked = new DateTime(2023, 6, 8) },
    new Product() { ID = 15, Name = "Enchanted Lantern", Price = 110, Sold = false, ProductTypeID = 3, DateStocked = new DateTime(2023, 11, 8) },
    new Product() { ID = 16, Name = "Spellbound Gloves", Price = 130, Sold = true, ProductTypeID = 1, DateStocked = new DateTime(2023, 10, 18) },
    new Product() { ID = 17, Name = "Potion of Giant Strength", Price = 100, Sold = false, ProductTypeID = 2, DateStocked = new DateTime(2023, 6, 13) },
    new Product() { ID = 18, Name = "Oakwood Magic Staff", Price = 180, Sold = true, ProductTypeID = 4, DateStocked = new DateTime(2023, 9, 3) },
    new Product() { ID = 19, Name = "Crystal Ball", Price = 200, Sold = false, ProductTypeID = 3, DateStocked = new DateTime(2023, 7, 31) },
    new Product() { ID = 20, Name = "Sorcerer's Hat", Price = 50, Sold = true, ProductTypeID = 1, DateStocked = new DateTime(2023, 9, 17) },
    new Product() { ID = 21, Name = "Potion of Night Vision", Price = 60, Sold = false, ProductTypeID = 2, DateStocked = new DateTime(2023, 10, 11) },
    new Product() { ID = 22, Name = "Invisible Shield", Price = 150, Sold = true, ProductTypeID = 3, DateStocked = new DateTime(2023, 10, 22) },
    new Product() { ID = 23, Name = "Willow Healing Wand", Price = 90, Sold = false, ProductTypeID = 4, DateStocked = new DateTime(2023, 10, 12) },
    new Product() { ID = 24, Name = "Magic Rune Stones", Price = 115, Sold = true, ProductTypeID = 3, DateStocked = new DateTime(2023, 11, 18) },
    new Product() { ID = 25, Name = "Fireproof Wizard Robe", Price = 140, Sold = false, ProductTypeID = 1, DateStocked = new DateTime(2023, 10, 29) },
    new Product() { ID = 26, Name = "Time Travel Tea", Price = 175, Sold = true, ProductTypeID = 2, DateStocked = new DateTime(2023, 10, 1) }
};
List<Product> unsoldProducts = products.Where(product => !product.Sold).ToList();

string menuchoice = null;

while (menuchoice != "0")
{
    MainMenu();
}

void MainMenu()
{
    Console.Clear();

    Console.WriteLine(@$"Welcome to Wizzardly Supplies
The best place for all of your wizzardly needs!

Please make a selection to navigate there:

0. Exit
1. View Products Catalog
2. View Available Products
3. View Products By Type
4. Add New Product
5. Remove A Product
");

    Console.Write("Please Type Your Menu Selection #: ");
    menuchoice = Console.ReadLine();

    switch (menuchoice)
    {
        case "0":
            Console.Clear();
            Console.WriteLine(@"Thank you for visiting Wizzardly Supplies!! We hope to see you again soon.

Please press any key to close the application...");
            Console.ReadKey();
            Console.Clear();
            return;
        case "1":
            Console.Clear();
            AllProducts();
            break;
        case "2":
            Console.Clear();
            AvailableProducts();
            break;
        case "3":
            Console.Clear();
            ProductsByType();
            break;
        case "4":
            Console.Clear();
            AddProduct();
            break;
        case "5":
            Console.Clear();
            RemoveProduct();
            break;
        default:
            Console.Clear();
            Console.WriteLine("That is not a valid selection! Press any key to try again...");
            Console.ReadKey();
            Console.Clear();
            break;
    }
}

void AllProducts()
{
    Console.WriteLine(@$"Wizzardly Supplies Product Catalog:
");

    foreach (Product product in products)
    {
        Console.WriteLine(ProductDescription(product));
    }

    Console.WriteLine(@"
Please press any key to return to the main menu...");

    Console.ReadKey();
    return;
}

void AvailableProducts()
{
    Console.WriteLine(@$"Wizzardly Supplies Product Catalog:
");

    foreach (Product product in unsoldProducts)
    {
        Console.WriteLine(ProductDescription(product));
    }

    Console.WriteLine(@"
Please press any key to return to the main menu...");

    Console.ReadKey();
    return;
}

void ProductsByType()
{
    int counter = 0;
    string userinput = null;

    while (true)
    {
        Console.WriteLine(@"Please Select a Wizzardly Supplies Product Type(s):
You may also type 'exit' to return to the main menu.
");

        foreach (ProductType ProductType in ProductTypes)
        {
            counter++;
            Console.WriteLine($"{counter}. {ProductType.Name}");
        }

        Console.Write(@"
Please Type Your Menu Selection # (or 'exit'): ");

        userinput = Console.ReadLine().Trim();

        if (userinput.ToLower() == "exit")
        {
            Console.Clear();
            Console.WriteLine("Please press any key to return to the main menu...");
            Console.ReadKey();
            counter = 0;
            return;
        }

        else if (int.TryParse(userinput, out _) && int.Parse(userinput) > 0 && int.Parse(userinput) <= ProductTypes.Count())
        {
            Console.Clear();
            ProductType SelectedProductType = ProductTypes.FirstOrDefault(ProductType => ProductType.ID == int.Parse(userinput));
            Console.WriteLine(@$"Wizzardly Supplies {SelectedProductType.Name} Product Catalog:
            ");
            foreach (Product product in products)
            {
                if (product.ProductTypeID == SelectedProductType.ID)
                {
                    Console.WriteLine(ProductDescription(product));
                }
            }
            Console.WriteLine(@"
Please press any key to return to the main menu...");
            Console.ReadKey();
            counter = 0;
            return;
        }

        else
        {
            Console.Clear();
            Console.WriteLine("That is not a valid input. Press any key to try again...");
            Console.ReadKey();
            counter = 0;
            Console.Clear();
        }
    }
}

void AddProduct()
{
    string userinput = null;
    string title = "Wizzardly Supplies Product Creation Tool";

    // variables needed for product creation
    int NewProductID = products.Count() + 1;
    string NewProductName = null;
    decimal NewProductPrice = 0.00M;
    bool NewProductSold = false;
    int NewProductTypeID = 0;
    DateTime ProductDateStocked = new DateTime();

    while (true)
    {
        Console.WriteLine(@$"{title}

You have chose to create a new product!
At any time you may also type 'exit' to return to the main menu.

Please press any key to continue...");

        Console.ReadKey();
        Console.Clear();

        // Step 1
        while (true)
        {
            Console.WriteLine(@$"{title}
            ");
            Console.Write(@$"(1/3) Please provide the Name of the new product: ");

            userinput = Console.ReadLine().Trim();

            if (userinput.ToLower() == "exit")
            {
                Console.Clear();
                Console.WriteLine(@"You've selected to cancel creating a new product.

Please press any key to return to the main menu...");
                Console.ReadKey();
                Console.Clear();
                return;
            }
            else if (userinput == "" || int.TryParse(userinput, out _))
            {
                Console.Clear();
                Console.WriteLine("Please provide a valid response. Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                NewProductName = userinput;
                Console.Clear();
                break;
            }
        }

        // Step 2
        while (true)
        {
            Console.WriteLine(@$"{title}
            ");
            Console.Write(@$"(2/3) Please provide the Price of the new product: ");
            userinput = Console.ReadLine().Trim();

            if (userinput.ToLower() == "exit")
            {
                Console.Clear();
                Console.WriteLine(@"You've selected to cancel creating a new product.

Please press any key to return to the main menu...");
                Console.ReadKey();
                Console.Clear();
                return;
            }
            else if (userinput == "" || !decimal.TryParse(userinput, out _))
            {
                Console.Clear();
                Console.WriteLine("Please provide a valid response. Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                NewProductPrice = decimal.Parse(userinput);
                Console.Clear();
                break;
            }
        }

        // Step 3
        while (true)
        {
            Console.WriteLine(@$"{title}

Available Product Types:");
            foreach (ProductType ProductType in ProductTypes)
            {
                Console.WriteLine($"{ProductType.ID}. {ProductType.Name}");
            }
            Console.Write(@$"
(3/3) Please provide the Product Type of the new product: ");

            userinput = Console.ReadLine().Trim();

            if (userinput.ToLower() == "exit")
            {
                Console.Clear();
                Console.WriteLine(@"You've selected to cancel creating a new product.

Please press any key to return to the main menu...");
                Console.ReadKey();
                Console.Clear();
                return;
            }
            else if (userinput == "" || !int.TryParse(userinput, out _))
            {
                Console.Clear();
                Console.WriteLine("Please provide a valid response. Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
            else if (int.Parse(userinput) > 0 && int.Parse(userinput) <= ProductTypes.Count())
            {
                NewProductTypeID = int.Parse(userinput);
                Console.Clear();
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please provide a valid response. Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        // Confirm New Product
        while (true)
        {
            Console.WriteLine(@$"{title}

Please confirm the following product is correct, then make a selection.

Product Name: {NewProductName}
Product Price: ${NewProductPrice}
Product Type: {ProductTypes.FirstOrDefault(ProductType => ProductType.ID == NewProductTypeID).Name}

Options:

1. Save and Exit
2. Make Changes
3. Discard and Exit
");

            Console.Write("Please Type Your Menu Selection #: ");
            userinput = Console.ReadLine().Trim();

            // Save and Exit
            if (userinput == "1")
            {
                Console.Clear();
                Console.WriteLine(@$"{title}

Your new product, {NewProductName}, has been created!
Please press any key to return to the main menu...");

                Product newProduct = new Product()
                {
                    ID = NewProductID,
                    Name = NewProductName,
                    Price = NewProductPrice,
                    Sold = NewProductSold,
                    ProductTypeID = NewProductTypeID,
                    DateStocked = ProductDateStocked
                };

                products.Add(newProduct);

                Console.ReadKey();
                Console.Clear();
                return;
            }
            // Make Changes
            else if (userinput == "2")
            {
                Console.Clear();
                Console.WriteLine(@$"{title}

You have chose to make changes to your new product. Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
                break;
            }
            // Exit
            else if (userinput == "3")
            {
                Console.Clear();
                Console.WriteLine(@"You've selected to cancel creating a new product.

Please press any key to return to the main menu...");
                Console.ReadKey();
                Console.Clear();
                return;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please provide a valid response. Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}

void RemoveProduct()
{
    string userinput = null;
    string title = "Wizzardly Supplies Product Remover";

    while (true)
    {
        Console.WriteLine(@$"{title}
    ");

        foreach (Product product in products)
        {
            Console.WriteLine(ProductDescription(product));
        }

        Console.WriteLine("");
        Console.Write("Please type the Product ID you wish to remove (you may also type 'exit' to return to the main menu): ");

        userinput = Console.ReadLine().Trim();

        if (userinput.ToLower() == "exit")
        {
            Console.Clear();
            Console.WriteLine(@"You've selected to cancel removing a product.

Please press any key to return to the main menu...");
            Console.ReadKey();
            Console.Clear();
            return;
        }
        else if (!int.TryParse(userinput, out _))
        {
            Console.Clear();
            Console.WriteLine("Please provide a valid response. Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
        else if (products.FirstOrDefault(product => product.ID == int.Parse(userinput)) != null)
        {
            Console.Clear();
            Product selectedProduct = products.FirstOrDefault(product => product.ID == int.Parse(userinput));
            Console.WriteLine(@$"{title}

You are about to remove the following product:
{ProductDescription(selectedProduct)}

Options:

1. Save and Exit
2. Make Changes
3. Discard and Exit
");
            Console.Write("Please provide your selection: ");
            userinput = Console.ReadLine().Trim();

            if (userinput == "1")
            {
                Console.Clear();
                Console.WriteLine(@$"You've have successfully removed {selectedProduct.Name}.

Please press any key to return to the main menu...");

                products.RemoveAt(products.IndexOf(selectedProduct));

                Console.ReadKey();
                Console.Clear();
                return;
            }
            else if (userinput == "2")
            {
                Console.Clear();
                Console.WriteLine(@$"{title}

You have chose to make changes to your new product. Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
            else if (userinput == "3")
            {
                Console.Clear();
                Console.WriteLine(@"You've selected to cancel removing a product.

Please press any key to return to the main menu...");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please provide a valid response. Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Please provide a valid response. Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}

string ProductDescription(Product product)
{
    string ProductTypeString = null;

    foreach (ProductType ProductType in ProductTypes)
    {
        if (ProductType.ID == product.ProductTypeID)
        {
            ProductTypeString = ProductType.Name;
        }
    }
    string description = $"{product.ID}. {product.Name}, a {ProductTypeString} product, is currently {(product.Sold ? "not for sale" : "for sale")} for ${product.Price}. {(!product.Sold ? $"It has been on the shelf for {product.DaysOnShelf} days" : "")}.";

    return description;
}

