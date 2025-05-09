namespace DO;

public record Customer
    (int Identity, string Name, string Address, string Phon)
{
    public Customer():this(000,"","-----","0000000000")
    {
    }
}
