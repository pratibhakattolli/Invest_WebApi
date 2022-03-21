using Invest_WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Invest_WebApi.ApiServices
{
    public class InvestorService : Interface_Api_Service
    {
        private readonly InvestContext db;

        public InvestorService(InvestContext Db)
        {
            db = Db;
        }


        public IEnumerable<Invest> GetAll()
        {
            return db.Invest.ToList();
        }
        public Invest Add_Invest(Invest prod)
        {
             db.Invest.Add(prod);
            db.SaveChanges();
            return prod;

        }

        public Invest Delete_Invest(int id)
        {
            var dd = db.Invest.Find(id);
            db.Invest.Remove(dd);
            db.SaveChanges();
            return dd;
        }

       

        public Invest Update_Invest(Invest prod)
        {
            db.Entry(prod).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return prod;
        }
    }
}
