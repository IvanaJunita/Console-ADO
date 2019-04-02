using bootcampversi2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootcampversi2
    {
    class validation
    {
        bool status = false;
        public bool Validation(int result)
        {
            if (result > 0)
            {
                Console.Write("Success");
                status = true;
            }
            else
            {
                Console.Write("Not Success");
            }
            return status;
        }
    }  
}
