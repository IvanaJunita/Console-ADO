using bootcampversi2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootcampversi2
{
   public interface ISupplier
    {
        List<TB_M_Suppliers> Get();
        TB_M_Suppliers Get (int id);
        bool InsertSupplier (TB_M_Suppliers supplier);
        bool UpdateSupplier(int Id, TB_M_Suppliers supplier);
        bool DeleteSupplier(int Id);
    }
}
