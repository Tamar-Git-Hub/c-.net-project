namespace Dal;
using DO;
internal static class DataSource
{
    internal static List<Product?> products=new List<Product?>();
    internal static List<Sale?> sales=new List<Sale?>();
    internal static List<Customer?> customers=new List<Customer?>();


    internal static class Config
    {
        internal const int productMinNumber = 1000;
        internal const int saleMinNumber = 5000;
        private static int productIndex = productMinNumber;
        private static int saleIndex = saleMinNumber;
        public static int ProductCode
        {
            get
            {
                int temp = productIndex;
                productIndex += 10;
                return temp;
            }
        }
        public static int SaleCode
        {
            get
            {
                int temp = saleIndex;
                saleIndex += 10;
                return temp;
            }
        }
    }



}
