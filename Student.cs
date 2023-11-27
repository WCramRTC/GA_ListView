using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_ListView
{
    public class Student
    {
        private string _idNumber;
        private string _firstName;
        private string _lastName;

        public string IDNumber => _idNumber;
        public string FirstName => _firstName;
        public string LastName => _lastName;

        public Student(string firstName, string lastName)
        {
            Random rand = new Random();
            _idNumber = rand.Next(100000000, 1000000000).ToString();
            _firstName = firstName;
            _lastName = lastName;
        }
    }
}
