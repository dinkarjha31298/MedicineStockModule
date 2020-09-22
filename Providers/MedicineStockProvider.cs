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
        MedicineStockRepo msr;
        public MedicineStockProvider(MedicineStockRepo _msr)
        {
            msr = _msr;
        }
        public List<MedicineStock> MedicineStockInfo()
        {
            //List<MedicineStock> msi = new List<MedicineStock> { };
            return msr.MedicineStockInformation();
            //return msi;
        }
    }
}
