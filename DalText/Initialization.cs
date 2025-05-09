using DO;
using DalApi;

namespace DalText;

public static class Initialization
{
    private static IDal s_dal;
  
    private static void createSale()
    {
        s_dal.sale.Create(new Sale(0, 1020, 2, 45, true, DateTime.Now.AddDays(1), DateTime.Now.AddDays(7)));
        s_dal.sale.Create(new Sale(0, 1100, 1, 20, false, DateTime.Now.AddDays(0), DateTime.Now.AddDays(14)));
        s_dal.sale.Create(new Sale(0, 1160, 3, 55, true, DateTime.Now.AddDays(1), DateTime.Now.AddDays(4)));
    }
    private static void creatProduct()
    {

        s_dal.product.Create(new Product(0,"Creamy pasta", 30, 20, Categories.milky));
        s_dal.product.Create(new Product(0, "Creamy potato", 45, 15, Categories.milky));
        s_dal.product.Create(new Product(0, "Lezania", 55, 35, Categories.milky));
        s_dal.product.Create(new Product(0, "pizza", 20, 100, Categories.milky));
        s_dal.product.Create(new Product(0, "ravioli", 60, 25, Categories.milky));
        s_dal.product.Create(new Product(0, "salad with cheese", 25, 70, Categories.milky));
        s_dal.product.Create(new Product(0, "Cream soup", 40, 30, Categories.milky));

        s_dal.product.Create(new Product(0, "Salmon in mustard", 50, 40, Categories.parve));
        s_dal.product.Create(new Product(0, "Mullet fish", 45, 35, Categories.parve));
        s_dal.product.Create(new Product(0, "Fish & chips", 20, 200, Categories.parve));
        s_dal.product.Create(new Product(0, "Pumpkin soup", 25, 35, Categories.parve));
        s_dal.product.Create(new Product(0, "Mushroom quiche", 30, 20, Categories.parve));
        s_dal.product.Create(new Product(0, "Salad", 30, 60, Categories.parve));
        s_dal.product.Create(new Product(0, "tortillas", 45, 10, Categories.parve));

        s_dal.product.Create(new Product(0, "Asado", 75, 15, Categories.meaty));
        s_dal.product.Create(new Product(0, "Meat cubes", 70, 20, Categories.meaty));
        s_dal.product.Create(new Product(0, "Steaks", 60, 20, Categories.meaty));
        s_dal.product.Create(new Product(0, "Bolognese pasta", 55, 25, Categories.meaty));
        s_dal.product.Create(new Product(0, "Grilled meat", 80, 30, Categories.meaty));
        s_dal.product.Create(new Product(0, "Schnitzel & chips", 45, 50, Categories.meaty));
        s_dal.product.Create(new Product(0, "Fillo with minced meat", 45, 10, Categories.meaty));
                                     
        s_dal.product.Create(new Product(0,"Ice coffee",15,250,Categories.milkDrink));
        s_dal.product.Create(new Product(0, "Vanilla ice cream", 13, 100, Categories.milkDrink));
        s_dal.product.Create(new Product(0, "Milk shake", 20, 60, Categories.milkDrink));
        s_dal.product.Create(new Product(0, "Yogurt ang orange drink", 20, 50, Categories.milkDrink));
        s_dal.product.Create(new Product(0, "Cappuccino", 25, 125, Categories.milkDrink));
        s_dal.product.Create(new Product(0, "Chocolate drink", 25, 45, Categories.milkDrink));
        s_dal.product.Create(new Product(0, "STRAWBERRY MELON DRINK", 27, 40, Categories.milkDrink));

        s_dal.product.Create(new Product(0, "Liquer", 13, 26, Categories.parveDrink));
        s_dal.product.Create(new Product(0, "kolla", 8, 300, Categories.parveDrink));
        s_dal.product.Create(new Product(0, "Orange drink", 13, 100, Categories.parveDrink));
        s_dal.product.Create(new Product(0, "Soda", 7, 100, Categories.parveDrink));
        s_dal.product.Create(new Product(0, "Lemon Lime", 15, 110, Categories.parveDrink));
        s_dal.product.Create(new Product(0, "Natural pomegranate juice", 28, 50, Categories.parveDrink));
        s_dal.product.Create(new Product(0, "rose wine", 58, 24, Categories.parveDrink));
    }                                
    private static void createCustomer()
    {
        s_dal.customer.Create(new Customer(55678924, "David levi", "Zait 34", "053-315-9804"));
        s_dal.customer.Create(new Customer(90846483, "chani cohen", "Te'enna 2", "055-678-5635"));
        s_dal.customer.Create(new Customer(23463747, "tamar green", "chitta 6", "052-716-0975"));
        s_dal.customer.Create(new Customer(24354647, "shimon levin", "geffen 76", "058-321-3433"));
        s_dal.customer.Create(new Customer(64784947, "gad lev", "ya'allom 21", "053-414-3453"));
        s_dal.customer.Create(new Customer(97346477, "dan praga", "prachim 9", "050-415-3452"));
        s_dal.customer.Create(new Customer(56734836, "tal feldman", "narkis 54", "055-677-0989"));
        s_dal.customer.Create(new Customer(18181672, "gili lebel", "rakefet 3", "050-417-4544"));
        s_dal.customer.Create(new Customer(95673855, "tzipi waiss", "sitvanit 88", "054-845-8986"));
        s_dal.customer.Create(new Customer(78987603, "rut levi", "chamanya 1", "054-855-1234"));
        s_dal.customer.Create(new Customer(56346346, "yair ben-tov", "etrog 91", "03-678-6734"));
        s_dal.customer.Create(new Customer(86745843, "ron or-olam", "chermon 33", "054-348-4532"));
        s_dal.customer.Create(new Customer(13254657, "itammar shalom", "yerushalaim 67", "050-956-3456"));
        s_dal.customer.Create(new Customer(97634674, "pini marom", "vered 29", "054-855-1234"));
        s_dal.customer.Create(new Customer(34256576, "daniel A'aroni", "franck 50", "057-236-4532"));
       
    }
    public static void Initialize()
    {
        //s_dal = i_dal;
        s_dal = DalApi.Factory.Get;
        createSale();
        creatProduct();
        createCustomer();
    }
}
