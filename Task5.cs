using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_3_dz
{
    internal class Task5
    {
        private string name;
        private int foundedYear;
        private string description;
        private string phone;
        private string email;

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetFoundedYear(int foundedYear)
        {
            this.foundedYear = foundedYear;
        }

        public void SetDescription(string description)
        {
            this.description = description;
        }

        public void SetPhone(string phone)
        {
            this.phone = phone;
        }

        public void SetEmail(string email)
        {
            this.email = email;
        }

        public void PrintJournalInfo()
        {
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Founded year: " + this.foundedYear);
            Console.WriteLine("Description: " + this.description);
            Console.WriteLine("Phone: " + this.phone);
            Console.WriteLine("Email: " + this.email);
        }
    }
}
