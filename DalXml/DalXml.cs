using DalApi;


namespace Dal
{
    class DalXml : IDal
    {

        private DalXml() { }
        private static readonly DalXml instance = new DalXml();
        public static DalXml Instance
        {
            get { return instance; }
        }
        public IcustomerAble customer => new CustomerImplementation();

        public IsaleAble sale => new SaleImplementation();

        public IproductAble product => new ProductImplementation();
    }
}
