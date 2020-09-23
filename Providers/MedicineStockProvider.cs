using MedicineStockModule.Controllers;
using MedicineStockModule.Models;
using MedicineStockModule.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicineStockModule.Providers
{
    public class MedicineStockProvider
    {
        readonly log4net.ILog _log4net;
        MedicineStockRepo msr;
        public MedicineStockProvider(MedicineStockRepo _msr)
        {
            msr = _msr;
            _log4net = log4net.LogManager.GetLogger(typeof(MedicineStockProvider));
        }
        /// <summary>
        /// MedicineStockInfo method called by MedicinestockController
        /// </summary>
        /// <returns>return List of medicines which was getting by MedicineStockRepo to MedicineStockController</returns>
        public List<MedicineStock> MedicineStockInfo()
        {
            List<MedicineStock> medicines = msr.MedicineStockInformation();
            _log4net.Info("MedicineStockProvider's MedicineStockInfo Action Method called for " +nameof(MedicineStockController));
            _log4net.Info("MedicineStockRepository's MedicineStockInformation Action Method is calling for " + nameof(MedicineStockProvider));
            return medicines;
        }
    }
}
