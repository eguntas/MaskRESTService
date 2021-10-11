using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaskInformation.Data;
using Microsoft.AspNetCore.Mvc;

namespace MaskInformation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaskeController : Controller
    {
        private IAppRepository _appRepository;

        public MaskeController(IAppRepository appRepository)
        {
            _appRepository = appRepository;
        }
        [HttpGet]
        [Route("find/{barkod}")]
        public ActionResult MaskInformation(String barkod)
        {
            var maske = _appRepository.GetMaske(barkod);
            if (maske != null)
                return Ok(maske);
            else
                return NotFound("Aranan barkod bulunamadı.");
        }
        [Route("findall")]
        public ActionResult MaskFindall() 
        {
            var maskelist = _appRepository.masklist();
            if (maskelist != null)
                return Ok(maskelist);
            else
                return NotFound("Barkod bulunamadı.");
        }
    }
}