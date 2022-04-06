using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalHooplaClient.Models
{
    public class Prescription
    {
        public Prescription(int drugId, string drugName)
        {
            DrugId = drugId;
            DrugName = drugName;                                                                     //MAY NOT NEED CONSTRUCTOR
        }

        public int DrugId { get; set; }
        public string DrugName { get; set; }
        public int DoseInMG { get; set; }
        public int QtyTakeDaily { get; set; }
    }
}
