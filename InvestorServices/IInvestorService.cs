using Generate_Invest_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generate_Invest_Api.ApiServices
{
   public interface IInvestorService
    {
        public IEnumerable<Invest> GetAll();
        Invest Add_Invest(Invest prod);
        Invest Update_Invest(Invest prod);
        Invest Delete_Invest(int id);
    }
}
