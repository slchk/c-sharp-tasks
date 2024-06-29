using task_6_2;

public class ProductComparer : IComparer<Product>
{
    public int Compare(Product x, Product y)
    {
        if (x == null || y == null) return 0;
        return x.Price.CompareTo(y.Price);
    }
}