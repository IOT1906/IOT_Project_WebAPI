using IOT_Priject_Domin.Model;
using IOT_Project_IRepository;
using IOT_Project_IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT_Project_Services
{
    public class AcceptanceServices : AcceptanceIServices
    {
        private readonly IRepository<Assetacceptance> db;
        private readonly IRepository<AcceptanceDetails> bb;
        private readonly IRepository<Acceptanceannex> dd;
        public AcceptanceServices(IRepository<Assetacceptance> _db, IRepository<AcceptanceDetails> _bb, IRepository<Acceptanceannex> _dd) 
        {
            db = _db;
            bb = _bb;
            dd = _dd;
        }

        public int Aadd(Assetacceptance A)
        {
            return db.Add(A);
        }

        public int Badd(AcceptanceDetails B)
        {
            return bb.Add(B);
        }

        public int Cadd(Acceptanceannex C)
        {
            return dd.Add(C);
        }
    }
}
