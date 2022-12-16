using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryFreashBread.models.Interfaces
{
    public interface IOffice
    {
        public IBaker Baker { get; set; }
        public string OfficeId { get; set; }
        public OfficeType OfficeType { get; set; }
        public int BreadsRemaining { get; set; }

    }

     public enum OfficeType
    {
        MainOffice=1,
        SecondOffice = 2,
    }
}
