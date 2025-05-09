using BO;

namespace BlTest
{
    internal class Program
    {
        static readonly BlApi.IBI s_bl = BlApi.Factory.Get();

        static void makeOrder()
        {
            Console.WriteLine("enter id or 0 for not Exist customer:");
            int id = int.Parse(Console.ReadLine());
            //Customer customer = s_bl.customer.Read(id);

            bool continue_order = true;
            int amount, productId;
            BO.Order order = new BO.Order();
            while (continue_order)
            {
                Console.WriteLine("enter product id:");
                productId = int.Parse(Console.ReadLine());
                Console.WriteLine("enter amount:");
                amount = int.Parse(Console.ReadLine());
               List<SaleInProduct> productInOrder= s_bl.order.AddProductToOrder(order, productId, amount);
                Console.WriteLine("sales for this product:");
                productInOrder.ForEach(p =>
                {
                    Console.WriteLine("for amount: "+p.Amount+", the price is: "+p.Price);
                });
                Console.WriteLine("add more products? Y/N");
                char c = char.Parse(Console.ReadLine());
                if (c != 'Y') continue_order = false;
            }
            s_bl.order.DoOrder(order);
            Console.WriteLine("order details: ");
            foreach (var item in order.ProductsInOrder)
            {
                Console.WriteLine(item.Name+ "---"+item.Price);
            }

        }
        static void Main(string[] args)
        {
            makeOrder();
            char c;
            Console.WriteLine("do another order? Y/N");
            c=char.Parse(Console.ReadLine());
            while (c == 'Y')
            {
                makeOrder();
                Console.WriteLine("do another order? Y/N");
                c = char.Parse(Console.ReadLine());
            }
            
        }
    }
}
