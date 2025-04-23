using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_1049
{
    [Serializable]
    public class Student
    {
        private int id;
        private string nume;
        private string grupa;

        public Student(int id, string nume, string grupa)
        {
            this.id = id;
            this.nume = nume;
            this.grupa = grupa;
        }

        public int Id { get => id; set => id = value; }
        public string Nume { get => nume; set => nume = value; }
        public string Grupa { get => grupa; set => grupa = value; }

        public override string ToString()
        {
            return id+"-"+nume+"-"+grupa;
        }
    }
}
