using bootcampversi2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootcampversi2
{
   public class TransactionController
   {
        public MyContext myContext = new MyContext();
        bool status = false;
        TB_M_Suppliers supplier = new TB_M_Suppliers();
        TB_M_Items item = new TB_M_Items();
        TB_T_TransactionDetail detail = new TB_T_TransactionDetail();
        TB_M_Sell sell = new TB_M_Sell();

        public List<TB_T_TransactionDetail> Get()
        {
            var get = myContext.TB_T_TransactionDetail.Where(x => x.IsDelete == false).ToList();
            Console.WriteLine("----------------------------");
            Console.WriteLine("\t Data Transaction");
            Console.WriteLine("----------------------------");
            foreach (var list in get)
            {
                Console.Write("Id:");
                Console.WriteLine(list.Id);
                Console.Write("Transaction Quantity:");
                Console.WriteLine(list.Quantity);
                Console.Write("Transaction Sell :");
                Console.WriteLine(list.TB_M_Sell);
                Console.Write("Transaction Item:");
                Console.WriteLine(list.TB_M_Items);
                Console.WriteLine();
            }
            return get;
        }
        public bool InsertDetail(TB_T_TransactionDetail detail)
        {
            string TB_M_Sell_Sell_id, TB_M_Item_Item_id;
            int Quantity;
            Console.Write("Insert Quantity Transaction :");
            Quantity = Convert.ToInt16(Console.ReadLine());
            Console.Write("Insert Transaction Sell:");
            TB_M_Sell_Sell_id = Console.ReadLine();
            Console.Write("Insert Transaction Item:");
            TB_M_Item_Item_id = Console.ReadLine();

            detail.Quantity = Quantity;
            TB_M_Sell_Sell_id = TB_M_Sell_Sell_id;
            TB_M_Item_Item_id = TB_M_Item_Item_id;

            myContext.TB_T_TransactionDetail.Add(detail);
            var result = myContext.SaveChanges();
            validation valid = new validation();
            return valid.Validation(result);
        }
        public bool DeleteDetail(int Id)
        {
            Console.Write("Insert your Id:");
            int Id = Convert.ToInt16(Console.ReadLine());
            var get = myContext.TB_T_TransactionDetail.Find(Id);
            //var get2 = myContext.Suppliers.SingleOrDefault(x => x.Id == Id);
            myContext.Entry(get).State = EntityState.Deleted;
            var result = myContext.SaveChanges();
            validation valid = new validation();
            return valid.Validation(result);
        }
        public bool UpdateItem(int Id, TB_T_TransactionDetail detail)
        {
            string TB_M_Sell_Sell_id, TB_M_Items_Item_id;
            int Quantity;
            Console.Write("insert your id:");
            Id = Convert.ToInt16(Console.ReadLine());
            var get = myContext.TB_T_TransactionDetail.Find(Id);
            //var get2 = context.suppliers.singleordefault(x => x.id == id);

            Console.Write("insert Transaction Quantity:");
            Quantity = Convert.ToInt16(Console.ReadLine());
            get.Quantity = Quantity;
            Console.Write("insert Transaction Sell");
            Sell_id = Console.ReadLine();
            get.t = Sell_id;
            Console.Write("insert Transaction Item:");
            Item_id = Console.ReadLine();
            get.TB_M_Items = Item_id;

            myContext.Entry(get).State = EntityState.Modified;
            var result = myContext.SaveChanges();
            validation valid = new validation(); /*cari classnya dulu baru metod*/
            return valid.Validation(result);
            return status;
        }
        public TB_T_TransactionDetail Get(int Id)
        {
            Console.Write("Insert your Id:");
            Id = Convert.ToInt16(Console.ReadLine());
            var get = myContext.TB_T_TransactionDetail.Find(Id);
            if (get != null)
            {
                return get;
            }
            else
            {
                return null;
                //            }
            }
        }
}
