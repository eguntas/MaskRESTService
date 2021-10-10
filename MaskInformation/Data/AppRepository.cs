using MaskInformation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaskInformation.Data
{
    public class AppRepository : IAppRepository
    {
        private MaskTypeContext _db;

        public AppRepository(MaskTypeContext db)
        {
            _db = db;
        }
        public Maske GetMaske(String barkod)
        {
            var maske = _db.Maske.FirstOrDefault(p => p.Barkod == barkod);
            return maske;
        }
        public List<Maske> masklist()
        {
            var masklist = _db.Maske.ToList();
            return masklist;
        }
    }
}
