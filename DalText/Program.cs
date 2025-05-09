//using Dal;
using DalApi;

using DO;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Threading.Channels;
using System.Reflection;



namespace DalText
{
    internal class Program
    {
        private static readonly IDal s_dal = DalApi.Factory.Get;
        public delegate void CreateUpdateDal();

        public static int PrintMenu()
        {
            int select;
            Console.WriteLine("For Products press 1");
            Console.WriteLine("For Sales press 2");
            Console.WriteLine("For Customer press 3");
            Console.WriteLine("For Clean Log folder press 4");
            Console.WriteLine("To exit press 0");
            if (!(int.TryParse(Console.ReadLine(), out select)) )
                select = -1;
            return select;
        }
        private static void SubMenu<T>(ICrud<T> crud,string title,CreateUpdateDal createDal,CreateUpdateDal updateDal)
        {
            int select = PrintSubMenu(title);
            while (select != 0)
            {
                switch (select)
                {
                    case 1:
                        createDal();
                        break;
                    case 2:
                        Read(crud);
                        break;
                    case 3:
                        ReadAll(crud);
                        break;
                    case 4:
                        updateDal();
                        break;
                    case 5:
                        Delete(crud);
                        break;
                    case 0:
                        PrintMenu();
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
                select = PrintSubMenu(title);
            }
        }
        private static int PrintSubMenu(string title)
        {
            int select;
            Console.WriteLine($"To add {title} press 1");
            Console.WriteLine($"To read one {title} press 2");
            Console.WriteLine($"To read all {title} press 3");
            Console.WriteLine($"To update {title} press 4");
            Console.WriteLine($"To delete {title} press 5");
            Console.WriteLine("To go back press 0");
            if (!(int.TryParse(Console.ReadLine(), out select)))
                select = -1;
            return select;
        }

        public static void UpdateProduct()
        {
            try
            {
                Console.WriteLine("Enter code");
                int code = int.Parse(Console.ReadLine());
                Console.WriteLine(s_dal.product.Read(code));
                Product p = AskProduct();
                s_dal.product.Update(p);
            }
            catch (DalIdNotFoundException e)
            {
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name,e.Message);
                Console.WriteLine(e.Message);
            }

        }
        public static void UpdateSale()
        {
            try
            {
                Console.WriteLine("Enter code");
                int code = int.Parse(Console.ReadLine());
                Console.WriteLine(s_dal.sale.Read(code));
                Sale s = AskSale();
                s_dal.sale.Update(s);
            }
            catch (DalIdNotFoundException e)
            {
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name,e.Message);
                Console.WriteLine(e.Message);
            }

        }
        public static void UpdateCustomer()
        {
            try
            {
                Console.WriteLine("Enter code");
                int code = int.Parse(Console.ReadLine());
                Console.WriteLine(s_dal.customer.Read(code));
                Customer c = AskCustomer();
                s_dal.customer.Update(c);
               
            }
            catch (DalIdNotFoundException e)
            {
               Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name,e.Message);
                Console.WriteLine(e.Message);
            }

        }
       
        public static Customer AskCustomer()
        {
            int Identity;
            string Name;
            string Address;
            string Phone;
            Console.WriteLine("Enter ID customer");
            if (!int.TryParse(Console.ReadLine(), out Identity)) Identity = 323747115;
            Console.WriteLine("Enter Name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Address");
            Address = Console.ReadLine();
            Console.WriteLine("Enter Phone");
            Phone = Console.ReadLine();
            return new Customer(Identity, Name, Address, Phone);
        }
        private static void AddCustomer()
        {
            Customer c = AskCustomer();
            int code = s_dal.customer.Create(c);
            c = c with { Identity = code };
            Console.WriteLine("customer create successfully");
            Console.WriteLine(c);
        }
       
        private static Product AskProduct()
        {
            int id=0;
            string name;
            double price;
            int amountInStock;
            Categories category;
            int select;
            Console.WriteLine("enter name of product:");
            name = Console.ReadLine();
            int cat;
            Console.WriteLine("enter number of cateroty between 0-4:");
            if (!int.TryParse(Console.ReadLine(), out cat))
                category = 0;
            else
                category=(Categories)cat;
            Console.WriteLine("enter price");
            if (!double.TryParse(Console.ReadLine(), out price))
                price = 30;
            Console.WriteLine("enter amount of stock:");
            if (!int.TryParse(Console.ReadLine(),out amountInStock))
                amountInStock = 10;
            return new Product(id,name,price,amountInStock,category);
        }
        private static void AddProduct()
        {
            Product p= AskProduct();
            int code= s_dal.product.Create(p);
            p=p with { Id=code };
            Console.WriteLine("product create successfully");
            Console.WriteLine(p);
        }

        public static Sale AskSale()
        {
            int select;
            int saleCode;
            int ProductId;
            int MinAmount;
            double Price;
            bool Club;
            DateTime StartSaleDate;
            DateTime EndSaleDate;
            Console.WriteLine("Enter Product code");
            if (!int.TryParse(Console.ReadLine(), out saleCode)) saleCode = 6000;
            Console.WriteLine("Enter count for sale");
            if (!int.TryParse(Console.ReadLine(), out MinAmount)) MinAmount = 14;
            Console.WriteLine("Enter price");
            if (!double.TryParse(Console.ReadLine(), out Price)) Price = 40;
            Console.WriteLine("Enter if you have Club(0/1)");
            if (!bool.TryParse(Console.ReadLine(), out Club)) Club = false;
            Console.WriteLine("Enter how many days form today it starts");
            if (!int.TryParse(Console.ReadLine(), out select)) select = 1;
            StartSaleDate = DateTime.Now.AddDays(select);
            Console.WriteLine("Enter how many days form it start it end");
            if (!int.TryParse(Console.ReadLine(), out select)) select = 7;
            EndSaleDate = StartSaleDate.AddDays(select);

            return new Sale(saleCode, saleCode, MinAmount, Price, Club, StartSaleDate, EndSaleDate);
        }
        private static void AddSale()
        {
            Sale s = AskSale();
            int code = s_dal.sale.Create(s);
            s = s with {codeIndex=code };
            Console.WriteLine("sale create successfully");
            Console.WriteLine(s);
        }

        public static void Read<T>(ICrud<T> crud)
        {
            try
            {
                Console.WriteLine("Enter Code");
                int code = int.Parse(Console.ReadLine());
                Console.WriteLine(crud.Read(code));
            }
            catch (DalIdNotFoundException e)
            {
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name,e.Message);
                Console.WriteLine(e.Message);
            }
        }
        public static void Delete<T>(ICrud<T> crud)
        {
            try
            {
                Console.WriteLine("Enter code");
                int code = int.Parse(Console.ReadLine());
                Console.WriteLine(crud.Read(code));
                crud.Delete(code);
            }
            catch (DalIdNotFoundException e)
            {
                Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name,e.Message);
                Console.WriteLine(e.Message);
            }
        }
        public static void ReadAll<T>(ICrud<T> crud)
        {
            foreach (var item in crud.ReadAll())
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to initialize data? (yes/no)");
            string initResponse = Console.ReadLine()?.ToLower();

            if (initResponse == "yes")
            {
                Initialization.Initialize();
            }
   
            try
            {
                int select = PrintMenu();
                while (select != -1)
                {
                    switch (select)
                    {
                        case 1:
                            SubMenu(s_dal.product,"product",AddProduct,UpdateProduct);
                            break;
                        case 2:
                            SubMenu(s_dal.sale, "sale",AddSale,UpdateSale);
                            break;
                        case 3:
                            SubMenu(s_dal.customer, "customer", AddCustomer, UpdateCustomer);
                            break;
                        case 4:
                            Tools.LogManager.DeleteLog();
                            break;
                        default:
                            Console.WriteLine( "error!!!!");
                            break;
                    }
                    select = PrintMenu();
                }
            }
            catch { }
           
        }
    }
}