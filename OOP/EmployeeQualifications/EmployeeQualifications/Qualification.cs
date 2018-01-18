using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeQualifications
{
    class Qualification
    {

        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public Qualification()
        {
            Title = "";
            Year = 1990;
        }

        public Qualification(string iTitle, int iYear)
        {
            Title = iTitle;
            Year = iYear;
        }

        public override string ToString()
        {
            return "Title: " + Title + "\tYear: " + Year;
        }

    }
}
