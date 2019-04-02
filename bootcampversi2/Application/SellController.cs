using bootcampversi2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootcampversi2
{
    class SellController
    {
        public class TransactionController
        {
            public MyContext myContext = new MyContext();
            bool status = false;
            TB_M_Suppliers supplier = new TB_M_Suppliers();
            TB_M_Items item = new TB_M_Items();
            TB_T_TransactionDetail detail = new TB_T_TransactionDetail();
            TB_M_Sell sell = new TB_M_Sell();
            public List<TB_M_Sell> Get()
            {
                var get = myContext.TB_M_Sell.Where(x => x.IsDelete == false).ToList();
                Console.WriteLine("----------------------------");
                Console.WriteLine("\t Data Sell");
                Console.WriteLine("----------------------------");
                foreach (var list in get)
                {
                    Console.Write("Id:");
                    Console.WriteLine(list.Id);
                    Console.Write("Sell Orderdate:");
                    Console.WriteLine(list.Orderdate);
                    Console.WriteLine();
                }
                return get;
            }
            public bool InsertSell(TB_M_Sell sell)
            {
                DateTime Orderdate;
                Console.Write("Orderdate Sell:");
                Orderdate = Convert.ToDateTime(Console.ReadLine());

                sell.Orderdate = Orderdate;

                myContext.TB_M_Sell.Add(sell);
                var result = myContext.SaveChanges();
                validation valid = new validation();
                return valid.Validation(result);
            }
            public bool DeleteSell(int Id)
            {
                Console.Write("Insert your Id:");
                Id = Convert.ToInt16(Console.ReadLine());
                var get = myContext.TB_M_Sell.Find(Id);
                //var get2 = myContext.Suppliers.SingleOrDefault(x => x.Id == Id);
                myContext.Entry(get).State = EntityState.Deleted;
                var result = myContext.SaveChanges();
                validation valid = new validation();
                return valid.Validation(result);
            }
            public bool UpdateItem(int Id, TB_M_Sell sell)
            {
                DateTime Orderdate;
                Console.Write("insert your id:");
                Id = Convert.ToInt16(Console.ReadLine());
                var get = myContext.TB_M_Sell.Find(Id);
                //var get2 = context.suppliers.singleordefault(x => x.id == id);

                Console.Write("insert Transaction Quantity:");
                Orderdate = Convert.ToDateTime(Console.ReadLine());
                get.Orderdate = Orderdate;


                myContext.Entry(get).State = EntityState.Modified;
                var result = myContext.SaveChanges();
                validation valid = new validation(); /*cari classnya dulu baru metod*/
                return valid.Validation(result);
                return status;
            }
            public TB_M_Sell Get(int Id)
            {
                Console.Write("Insert your Id:");
                Id = Convert.ToInt16(Console.ReadLine());
                var get = myContext.TB_M_Sell.Find(Id);
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
}
