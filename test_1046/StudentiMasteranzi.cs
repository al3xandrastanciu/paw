using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_1046
{
    public class StudentiMasteranzi
    {

        public string specializare;
        public List<Candidat> candidati;

        public StudentiMasteranzi(string specializare)
        {
            this.specializare = specializare;
            candidati = new List<Candidat>();
        }
        public static StudentiMasteranzi operator +(StudentiMasteranzi e, Candidat c)
        {
            e.candidati.Add(c);
            return e;
        }

    }
}
