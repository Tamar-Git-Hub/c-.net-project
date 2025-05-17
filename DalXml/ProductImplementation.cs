using DalApi;
using DO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dal
{
    internal class ProductImplementation : IproductAble
    {
        const string filePath = "..\\xml\\products.xml";
        const string PRODUCT = "Product";
        const string ID = "Id";
        const string NAME = "Name";
        const string PRICE = "Price";
        const string AMOUNT_IN_STOCK = "AmountInStock";
        const string CATEGORY = "category";

        public int Create(Product item)
        {
            int id = Config.CodeProduct;

            XElement productXml = XElement.Load(filePath);
            productXml.Add(new XElement(PRODUCT,
                   new XElement(ID, id),
                   new XElement(NAME, item.Name),
                   new XElement(PRICE, item.Price),
                   new XElement(AMOUNT_IN_STOCK, item.AmountInStock),
                   new XElement(CATEGORY, item.category)));

            productXml.Save(filePath);
            return id;
        }

        public void Delete(int id)
        {
            XElement productXml = XElement.Load(filePath);
            XElement elementToRemove = productXml.Descendants(ID).FirstOrDefault(p => p.Value.Equals(id.ToString()));

            if (elementToRemove != null)
            {
                elementToRemove.Parent.Remove();
                productXml.Save(filePath);
            }
            else
            {
                throw new InvalidOperationException($"לא נמצא מוצר עם ID '{id}'.");
            }
        }

        public Product? Read(int id)
        {
            try
            {
                XElement productXml = XElement.Load(filePath);
                var xel = productXml.Descendants(ID).FirstOrDefault(p => p.Value == id.ToString())?.Parent;

                if (xel != null)
                {
                    Product product = new Product(
                        int.Parse(xel.Element(ID)?.Value ), 
                        xel.Element(NAME)?.Value ,
                        double.Parse(xel.Element(PRICE)?.Value ),
                        int.Parse(xel.Element(AMOUNT_IN_STOCK)?.Value),
                        (Categories)Enum.Parse(typeof(Categories), xel.Element(CATEGORY)?.Value )
                    );
                    return product;
                }
                return null;

            }
            catch (Exception ex)
            {
               
                return null;
            }
        }

        public Product? Read(Func<Product, bool>? filter)
        {
            XElement productXml = XElement.Load(filePath);

            var product = productXml.Descendants(PRODUCT).Select(p =>
                                                               new Product(int.Parse(p.Element(ID).Value),
                                                                p.Element(NAME).Value,
                                                                double.Parse(p.Element(PRICE).Value),
                                                                int.Parse(p.Element(AMOUNT_IN_STOCK).Value),
                                                                (Categories)Enum.Parse(typeof(Categories), p.Element(CATEGORY).Value)));

            return product.FirstOrDefault(filter);
        }

        public List<Product?> ReadAll(Func<Product, bool>? filter = null)
        {
            XElement productXml = XElement.Load(filePath);

            var products = productXml.Descendants(PRODUCT).Select(p =>
                                                             new Product(int.Parse(p.Element(ID).Value),
                                                             p.Element(NAME).Value,
                                                             double.Parse(p.Element(PRICE).Value),
                                                             int.Parse(p.Element(AMOUNT_IN_STOCK).Value),
                                                              (Categories)Enum.Parse(typeof(Categories), p.Element(CATEGORY).Value))).ToList();

            return filter != null ? products.Where(filter).ToList() : products;

        }

        public void Update(Product item)
        {
            XElement productXml = XElement.Load(filePath);
            XElement p = productXml.Descendants(ID).First(id => int.Parse(id.Value) == item.Id).Parent;
            p.Element(PRICE).SetValue(item.Price);
            p.Element(NAME).SetValue(item.Name);
            p.Element(AMOUNT_IN_STOCK).SetValue(item.AmountInStock);
            p.Element(CATEGORY).SetValue(item.category);
            productXml.Save(filePath);

        }
    }
}
