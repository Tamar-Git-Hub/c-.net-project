namespace DO;
public record Product
(int Id, string Name, double Price, int AmountInStock, Categories category)
{
    public Product() : this(000, "", 0.0, 0, 0)
    {

    }

 
}
