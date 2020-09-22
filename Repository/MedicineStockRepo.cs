using MedicineStockModule.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MedicineStockModule.Repository
{
    public class MedicineStockRepo:IMedicineStockRepo
    {
        
        private static List<MedicineStock> Medicines = new List<MedicineStock>
        {
            new MedicineStock{ Name= "Aciloc",ChemicalComposition="Domperidone,Omeprazole",TargetAilment="General",DateOfExpiry=new DateTime(2022,05,25),NumberOfTabletsInStock=1000},
            new MedicineStock{ Name= "Demerol",ChemicalComposition="Meperidine Hydrochloride,USP",TargetAilment="Orthopaedics",DateOfExpiry=new DateTime(2021,03,05),NumberOfTabletsInStock=2500},
            new MedicineStock{ Name= "Becosules",ChemicalComposition="Pyridoxine Hydrochloride,Thiamine,Nicotinamide,Folate",TargetAilment="General",DateOfExpiry=new DateTime(2023,12,28),NumberOfTabletsInStock=1500},
            new MedicineStock{ Name= "Cytotec",ChemicalComposition="Misoprostol,Prostaglandin E1 Analog",TargetAilment="Gynaecology",DateOfExpiry=new DateTime(2022,10,10),NumberOfTabletsInStock=1800},
            new MedicineStock{ Name= "Volini 50mg",ChemicalComposition="Diclofenac",TargetAilment="Orthopaedics",DateOfExpiry=new DateTime(2025,07,13),NumberOfTabletsInStock=600}
        };
    public List<MedicineStock> MedicineStockInformation()
        {
           
            return Medicines;
        }
    }
}
