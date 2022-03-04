using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_DB_2
{
    internal class student
    {
        public int ID { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public birthdate birthdate { get; set; }

        public student(int id)
        {
            ID = id;
        }

        public override string ToString()
        {
            return $"ID:[{ID}] Fornavn:[{FirstName}] Efternavn:[{LastName}] Fødselsdato [{birthdate.day}-{birthdate.month}-{birthdate.year}]";
        }



    }
}
