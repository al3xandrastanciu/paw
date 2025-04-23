using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subiect_1048
{
    class RezervariDinZi
    {
        public DateTime data;
        public List<Rezervare> list;

        public RezervariDinZi(List<Rezervare> list)
        {
            this.data = DateTime.Now;
            this.list = list;
        }
        public RezervariDinZi()
        {
            this.data = DateTime.Now;
            list = new List<Rezervare>();
        }
        public static RezervariDinZi operator+(RezervariDinZi rez, Rezervare r)
        {
            rez.list.Add(r);
            return rez;
        }
    }
}
