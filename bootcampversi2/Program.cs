using bootcampversi2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootcampversi2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int Id;
            ISupplier iSupplier = new SupplierController();
            TB_M_Suppliers supplier = new TB_M_Suppliers();

            IItem iItem = new ItemController();
            TB_M_Items item = new TB_M_Items();

            //ITransaction iTransaction = new TransactionController();
            //TB_T_TransactionDetail detail = new TB_T_TransactionDetail();

            ISell iSell = new SellController();
            TB_M_Sell sell = new TB_M_Sell();

            Console.WriteLine("=========================");
            Console.WriteLine("||     Pilihan Menu    ||");
            Console.WriteLine("=========================");
            Console.WriteLine("1. Supplier");
            Console.WriteLine("2. Item");
            Console.WriteLine("3. Transaction");
            Console.WriteLine("4. Sell");
            Console.WriteLine("--------------------------");
            Console.Write("Tentukan Pilihanmu: ");
            int menu = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("=========================");
            Console.WriteLine("||        Action       ||");
            Console.WriteLine("=========================");
            Console.WriteLine("1. View All Data");
            Console.WriteLine("2. insert");
            Console.WriteLine("3. Delete");
            Console.WriteLine("4. Update");
            Console.WriteLine("--------------------------");
            Console.Write("Tentukan Pilihanmu: ");
            int action = Convert.ToInt32(Console.ReadLine());

            if (menu == 1)
            {
                switch (action)
                {
                    case 1:
                        iSupplier.Get();
                        Console.Read();
                        break;
                    case 2:
                        iSupplier.InsertSupplier(supplier);
                        Console.Read();
                        break;
                    case 3:
                        Console.Write("Insert your Id:");
                        Id = Convert.ToInt16(Console.ReadLine());
                        iSupplier.DeleteSupplier(Id);
                        Console.Read();
                        break;
                    case 4:
                        Console.Write("Insert your Id:");
                        Id = Convert.ToInt16(Console.ReadLine());
                        iSupplier.UpdateSupplier(Id, supplier);
                        Console.Read();
                        break;
                    default:
                        Console.WriteLine("data Not Found");
                        Console.Read();
                        break;
                }
            }
            else if (menu == 2)
            {
                switch (action)
                {
                    case 1:
                        iItem.Get();
                        Console.Read();
                        break;
                    case 2:
                        iItem.InsertItem(item);
                        Console.Read();
                        break;
                    case 3:
                        Console.Write("Insert your Id:");
                        Id = Convert.ToInt16(Console.ReadLine());
                        iItem.DeleteItem(Id);
                        Console.Read();
                        break;
                    case 4:
                        Console.Write("insert your Id : ");
                        Id = Convert.ToInt16(Console.ReadLine());
                        iItem.UpdateItem(Id, item);
                        Console.Read();
                        break;
                    default:
                        Console.WriteLine("data Not Found");
                        Console.Read();
                        break;
                }
            }
            //else if (menu == 3)
            // {
            //    switch (action)
            //    {
            //        case 1:
            //            iItem.Get();
            //            Console.Read();
            //            break;
            //        case 2:
            //            iItem.InsertItem(item);
            //            Console.Read();
            //            break;
            //        case 3:
            //            Console.Write("Insert your Id:");
            //            Id = Convert.ToInt16(Console.ReadLine());
            //            iItem.DeleteItem(Id);
            //            Console.Read();
            //            break;
            //        case 4:
            //            Console.Write("insert your Id : ");
            //            Id = Convert.ToInt16(Console.ReadLine());
            //            iItem.UpdateItem(Id, item);
            //            Console.Read();
            //            break;
            //        default:
            //            Console.WriteLine("data Not Found");
            //            Console.Read();
            //            break;
            //    }
            //}
            else if (menu == 4)
            {
                switch (action)
                {
                    case 1:
                        iSell.Get();
                        Console.Read();
                        break;
                    case 2:
                        iSell.InsertSel(sell);
                        Console.Read();
                        break;
                    case 3:
                        Console.Write("Insert your Id:");
                        Id = Convert.ToInt16(Console.ReadLine());
                        iSell.DeleteSell(Id);
                        Console.Read();
                        break;
                    case 4:
                        Console.Write("insert your Id : ");
                        Id = Convert.ToInt16(Console.ReadLine());
                        iSell.UpdateSell(Id, sell);
                        Console.Read();
                        break;
                    default:
                        Console.WriteLine("data Not Found");
                        Console.Read();
                        break;
                }
            }
            Console.Read();
        }
    }
}
