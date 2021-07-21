using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TezAPPV2.Abstract;

namespace TezAPPV2.Entities
{
    public class TalepDataInfo:IEntity
    {

        public int Talep_No { get; set; }//261
        public string Birlik_Ismi { get; set; }
        public string Talep_Miktar { get; set; }
        public string Olcu_Tipi { get; set; }
        public short MilimetreDip { get; set; }
        public short MilimetreTepe { get; set; }


    }
}
