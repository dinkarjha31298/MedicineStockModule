using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedicineStockModule.Providers;
using MedicineStockModule.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace MedicineStockModule.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MedicineStockController : ControllerBase
    {
        readonly log4net.ILog _log4net;
        MedicineStockProvider db;
       

        public MedicineStockController(MedicineStockProvider _db)
        {
            db = _db;
            _log4net = log4net.LogManager.GetLogger(typeof(MedicineStockController));
        }


        [HttpGet]
        public IActionResult Get()
        {
            _log4net.Info("MedicineStockController  Action Method called");
            try
            {
                var obj = db.MedicineStockInfo();
                if (obj == null)
                {
                    _log4net.Error("Null Value is sending");
                    return NotFound();
                }
                _log4net.Info("MedicleStockInfo Method works");
                return Ok(obj);
            }
            catch (Exception)
            {
                _log4net.Error("Internal Error Occurs");
                return StatusCode(500);
            }
        }
    }
}
