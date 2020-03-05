using System;
using System.Collections.Generic;
using System.Text;

namespace OOPnet.Lab5
{
    class Book
    {
        private string firstName;
        private string secondName;

        private string bookName;
        private string code;
        private int year;
        private int numberOfPage;
        private string type;

        public Book()
        {
            firstName= String.Empty;
            secondName = String.Empty;
            bookName = String.Empty;
            code = String.Empty;
            year=0;
            numberOfPage=0;
            type = String.Empty;
        }

        public Book(string f, string s, string b,string c, int y, int n, string t)
        {
            firstName = f;
            secondName = s;
            bookName = b;

            bool flag = true;
            for (int i = 0; i != c.Length; i++)
            {
                if (!char.IsDigit(c[i]))
                    flag = false;
            }

            if (flag) code = c;
            else code = String.Empty;
            if (y >= 0) year = y; else year = 0;
            if (n >= 0) numberOfPage = n; else numberOfPage = 0;
            type = t;
        }

        
        public string FirstName
        {
            get { return firstName; }
            set { }
        }
        public string SecondName
        {
            get { return secondName; }
            set { }
        }
        public string BookName
        {
            get { return bookName; }
            set { }
        }

        //read and write \/
        public string Code
        {
            get { return code; }
            set {
                bool flag = true;
                for (int i = 0; i != value.Length; i++)
                {
                    if (!char.IsDigit(value[i]))
                        flag = false;
                }
                if (flag) code = value;
            } 
        }
        public int Year
        {
            get { return year; }
            set { }
        }
        public int NumberOfPage
        {
            get { return numberOfPage; }
            set { }
        }
        public string Type
        {
            get { return type; }
            set { }
        }
       

        public int CompareByYear(Book a)
        {
            return year.CompareTo(a.year);
        }

        public int CompareByPages(Book a)
        {
            return numberOfPage.CompareTo(a.numberOfPage);
        }



        public static Book findByCode(Book[] array, string c)
        {
            bool flag = true;
            for (int i = 0; i != c.Length; i++)
            {
                if (!char.IsDigit(c[i]))
                    flag = false;
            }
            if (!flag) return null;

            if (array == null)
                return null;

            for (int i = 0; i != array.Length; i++)
            {
                if (c == array[i].code)
                    return array[i];
            }
            return null;

        }

        public override string ToString()
        {
            string line = String.Empty;
            line += ("\nFirstName : " + firstName);
            line += ("\nSecondName : " + secondName);
            line += ("\nBookName : " + bookName);
            line += ("\nCode of book : " + code);
            line += ("\nYear of release : " + year);
            line += ("\nNumber of pages : " + numberOfPage);
            line += ("\nType of book : " + type);
            return line;
        }



    }
}
