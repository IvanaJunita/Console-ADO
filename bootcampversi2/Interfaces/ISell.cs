using bootcampversi2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootcampversi2
{
    interface ISell
    {
        List<TB_M_Sell> Get();
        TB_M_Sell Get(int id);
        bool InsertSell(TB_M_Sell sell);
        bool UpdateSell(int Id, TB_M_Sell sell);
        bool DeleteSell(int Id);
    }
}
