using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final1
{
    class Student : Person
    {
        public string Year;
        public string Major;
        public Student(string sName, int nAge, PictureBox pPhoto, string sYear, string sMajor) {
            Name = sName;
            Age = nAge;
            photo = pPhoto;
            Year = sYear;
            Major = sMajor;
        }
    }
}
