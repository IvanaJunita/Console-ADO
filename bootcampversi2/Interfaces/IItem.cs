using bootcampversi2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootcampversi2
{
    public interface IItem
    {
        List<TB_M_Items > Get();
        TB_M_Items Get(int id);
        bool InsertItem(TB_M_Items item);
        bool UpdateItem(int Id, TB_M_Items item);
        bool DeleteItem(int Id);
    }
}
