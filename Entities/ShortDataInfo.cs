using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TezAPPV2.Abstract;

namespace TezAPPV2.Entities
{
    public class ShortDataInfo:IEntity
    {
        public int Id { get; set; }  //0
        public string Tc { get; set; }  //1
        public string Ad { get; set; } //2
        public string Soyad { get; set; }  //3
        public short A77 { get; set; }  //4
        public short A87 { get; set; }  //5
        public short A8 { get; set; }  //6



    }
}
