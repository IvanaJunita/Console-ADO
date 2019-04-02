using bootcampversi2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace bootcampversi2
{
    public class ItemController : IItem
    {
        private MyContext myContext = new MyContext();
        bool status = false;
        TB_M_Suppliers supplier = new TB_M_Suppliers();
        TB_M_Items item = new TB_M_Items();

        //public bool Delete (Supplier Delete)
        //{
        // throw new NotImplementedException();
        //}
        public List<TB_M_Items> Get()
        {
            var get = myContext.TB_M_Items.Where(x => x.IsDelete == false).ToList();
            Console.WriteLine("----------------------------");
            Console.WriteLine("\t Data Item");
            Console.WriteLine("----------------------------");
            foreach (var list in get)
            {
                Console.Write("Id:");
                Console.WriteLine(list.Id);
                Console.Write("Items Name:");
                Console.WriteLine(list.Name);
                Console.Write("Price:");
                Console.WriteLine(list.Price);
                Console.Write("Stock:");
                Console.WriteLine(list.Stock);
                Console.WriteLine("");
            }
            return get;
        }
        public bool InsertItem(TB_M_Items item)
        {
            string Name, Supplier_Id;
            int Price, Stock;
            Console.Write("Insert Item name :");
            Name = Console.ReadLine();
            Console.Write("Insert Item Price:");
            Price = Convert.ToInt16(Console.ReadLine());
            Console.Write("Insert Item Stok :");
            Stock = Convert.ToInt16(Console.ReadLine());
            Console.Write("Insert Id Supplier : ");
            Supplier_Id = Console.ReadLine();

            item.Name = Name;
            item.Price = Price;
            item.Stock = Stock;
            Supplier_Id = Supplier_Id;

            myContext.TB_M_Items.Add(item);
            var result = myContext.SaveChanges();
            validation valid = new validation();
            return valid.Validation(result);
        }
        public bool DeleteItem(int Id)
        {
            Console.Write("Insert your Id:");
            Id = Convert.ToInt16(Console.ReadLine());
            var get = myContext.TB_M_Items.Find(Id);
            //var get2 = myContext.Suppliers.SingleOrDefault(x => x.Id == Id);
            myContext.Entry(get).State = EntityState.Deleted;
            var result = myContext.SaveChanges();
            validation valid = new validation();
            return valid.Validation(result);
        }
        public bool UpdateItem (int Id, TB_M_Items item)
        {
            int Price, Stock;
            string Name, Supplier_Id;
            Console.Write("insert your id:");
            Id = Convert.ToInt16(Console.ReadLine());
            var get = myContext.TB_M_Items.Find(Id);
            //var get2 = context.suppliers.singleordefault(x => x.id == id);

            Console.Write("insert Item Name:");
            Name = Console.ReadLine();
            get.Name = Name;
            Console.Write("insert Price Item");
            Price = Convert.ToInt16(Console.ReadLine());
            get.Price = Price;
            Console.Write("insert Stock Item:");
            Stock = Convert.ToInt16(Console.ReadLine());
            get.Stock = Stock;
            Console.Write("insert Id Supplier:");
            Supplier_Id = Console.ReadLine();
            Supplier_Id = Supplier_Id;
        
            myContext.Entry(get).State = EntityState.Modified;
            var result = myContext.SaveChanges();
            validation valid = new validation(); /*cari classnya dulu baru metod*/
            return valid.Validation(result);
            return status;
        }
        public TB_M_Items Get(int Id)
        {
            Console.Write("Insert your Id:");
            Id = Convert.ToInt16(Console.ReadLine());
            var get = myContext.TB_M_Items.Find(Id);
            if (get != null)
            {
                return get;
            }
            else
            {
                return null;
            }
        }
      }
 }