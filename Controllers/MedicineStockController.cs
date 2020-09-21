using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedicineStockModule.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MedicineStockModule.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicineStockController : ControllerBase
    {
        readonly log4net.ILog _log4net;
        MedicineStockRepo db;
       

        public MedicineStockController(MedicineStockRepo _db)
        {
            db = _db;
            _log4net = log4net.LogManager.GetLogger(typeof(MedicineStockController));
        }


        [HttpGet]
        public IActionResult Get()
        {
            _log4net.Info("ProjectsController GET ALL Action Method called");
            try
            {
                var obj = db.MedicineStockInformation();
                if (obj == null)
                    return NotFound();
                return Ok(obj);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
