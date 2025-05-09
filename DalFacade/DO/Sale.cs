

namespace DO;

public record Sale
(int codeIndex, int ProductId, int MinAmount, double Price, bool Club, DateTime StartSaleDate, DateTime EndSaleDate)
{
    public Sale():this(0,0,0,0.0,false,DateTime.Now,DateTime.Now)       
    {

    }
}
