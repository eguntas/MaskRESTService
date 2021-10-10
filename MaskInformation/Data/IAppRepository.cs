using MaskInformation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaskInformation.Data
{
    public interface IAppRepository
    {
        Maske GetMaske(String barkod);
        List<Maske> masklist();
    }
}
