using bootcampversi2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootcampversi2
{
    public class SupplierController : ISupplier
    {
        private MyContext myContext = new MyContext();
        bool status = false;
        TB_M_Suppliers tB_M_Suppliers = new TB_M_Suppliers();        

        //public bool Delete (Supplier Delete)
        //{
        // throw new NotImplementedException();
        //}
        public List<TB_M_Suppliers> Get()
        {
            var get = myContext.TB_M_Suppliers.Where(x => x.IsDelete == false).ToList();
            Console.WriteLine("----------------------------");
            Console.WriteLine("\t Data Supplier");
            Console.WriteLine("----------------------------");
            foreach (var list in get)
            {
                Console.Write("Id:");
                Console.WriteLine(list.Id);
                Console.Write("Supplier Name:");
                Console.WriteLine(list.Name);
                Console.WriteLine("");
            }
            return get;
        }
        public bool InsertSupplier(TB_M_Suppliers supplier)
        {
            Console.Write("Insert your name :");
            string Name = Console.ReadLine();
            supplier.Name = Name;
            myContext.TB_M_Suppliers.Add(supplier);
            var result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
                Console.Write("Insert Successfully");
            }
            else
            {
                Console.Write("Insert Failed");
            }
            return status;
        }
        public bool DeleteSupplier(int Id)
        {
            Console.Write("Insert your Id:");
            Id = Convert.ToInt16(Console.ReadLine());
            var get = myContext.TB_M_Suppliers.Find(Id);
            //var get2 = myContext.Suppliers.SingleOrDefault(x => x.Id == Id);
            if (get != null)
            {
                myContext.Entry(get).State = EntityState.Deleted;
                var result = myContext.SaveChanges();
                if (result > 0)
                {
                    status = true;
                    Console.Write("Delete Successfully");
                }
                else
                {
                    Console.Write("Delete Failed");
                }
            }
            else
            {
                Console.Write("Data Not Found");
               // var result = false;
            }
                return status;
        }
        public bool UpdateSupplier(int Id, TB_M_Suppliers supplier)
        {
            Console.Write("insert your Id : ");
            Id = Convert.ToInt16(Console.ReadLine());
            var get = myContext.TB_M_Suppliers.Find(Id);
            //var get2 = context.suppliers.singleordefault(x => x.id == id);
            if (get != null)
            {
                Console.Write("insert your name:");
                String Name = Console.ReadLine();
                get.Name = Name;
                myContext.Entry(get).State = EntityState.Modified;
                var result = myContext.SaveChanges();
                if (result > 0)
                {
                    status = true;
                    Console.Write("update successfully");
                }
                else
                {
                    Console.Write("update failed");
                }
            }
            else
            {
                Console.Write("no data found");
            }
            return status;
        }
        public TB_M_Suppliers Get(int Id)
        {
            Console.Write("Insert your Id:");
            Id = Convert.ToInt16(Console.ReadLine());
            var get = myContext.TB_M_Suppliers.Find(Id);
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