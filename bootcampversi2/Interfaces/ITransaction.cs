using bootcampversi2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootcampversi2
{
    public interface ITransaction
    {
        List<TB_T_TransactionDetail> Get();
        TB_T_TransactionDetail Get(int id);
        bool InsertDetail(TB_T_TransactionDetail detail);
        bool UpdateDetail(TB_T_TransactionDetail detail);
        bool DeleteDetail();
    }
}
