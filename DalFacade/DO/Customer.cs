namespace DO;

public record Customer
    (int Identity, string Name, string Address, string Phone)
{
    public Customer():this(000,"","-----","0000000000")
    {
    }
}
