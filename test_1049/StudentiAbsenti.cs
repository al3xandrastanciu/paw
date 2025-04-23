using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_1049
{
    public class StudentiAbsenti
    {
        public List<Student> lista;
        public StudentiAbsenti()
        {
            lista = new List<Student>();
        }
        public static StudentiAbsenti operator +(StudentiAbsenti stud, Student s)
        {
            stud.lista.Add(s);
            return stud;
        }
    }
}
