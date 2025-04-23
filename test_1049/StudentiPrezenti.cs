using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_1049
{
    public class StudentiPrezenti
    {
        public List<Student> lista;
        public StudentiPrezenti()
        {
            lista = new List<Student>();
        }
        public static StudentiPrezenti operator+(StudentiPrezenti stud,Student s)
        {
            stud.lista.Add(s);
            return stud;
        }
    }
}
