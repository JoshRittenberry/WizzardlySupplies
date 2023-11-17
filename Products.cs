public class Product
{
    public int ID { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public bool Sold { get; set; }
    public int ProductTypeID { get; set; }
    public DateOnly DateStocked { get; set; }
}

public class ProductType
{
    public int ID { get; set; }
    public string Name { get; set; }
}