using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClient
{
    class MusicClass
    {
        int id;
        string author;
        string name;
        string albom;
        int year;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string AUTHOR
        {
            get { return author; }
            set { author = value; }
        }

        public string NAME
        {
            get { return name; }
            set { name = value; }
        }

        public string ALBOM
        {
            get { return albom; }
            set { albom = value; }
        }

        public int YEAR
        {
            get { return year; }
            set { year = value; }
        }

        public MusicClass(int id, string author, string name, string albom, int year)
        {
            this.author = author;
            this.name = name;
            this.albom = albom;
            this.year = year;
        }
    }
}
