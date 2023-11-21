using System.Security.Cryptography.X509Certificates;

public class Product
{
    public int ID { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public bool Sold { get; set; }
    public int ProductTypeID { get; set; }
    public DateTime DateStocked { get; set; }
    public int DaysOnShelf
    {
        get
        {
            TimeSpan timeOnShelf = DateTime.Now - DateStocked;
            return timeOnShelf.Days;
        }
    }
}

public class ProductType
{
    public int ID { get; set; }
    public string Name { get; set; }
}