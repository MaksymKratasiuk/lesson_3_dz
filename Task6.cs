using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_3_dz
{
    internal class Task6
    {
        private string name;
        private string address;
        private string profileDescription;
        private string phone;
        private string email;

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void SetAddress(string address)
        {
            this.address = address;
        }

        public string GetAddress()
        {
            return address;
        }

        public void SetProfileDescription(string description)
        {
            this.profileDescription = description;
        }

        public string GetProfileDescription()
        {
            return profileDescription;
        }

        public void SetPhone(string phone)
        {
            this.phone = phone;
        }

        public string GetPhone()
        {
            return phone;
        }

        public void SetEmail(string email)
        {
            this.email = email;
        }

        public string GetEmail()
        {
            return email;
        }

        public void InputData()
        {
            Console.Write("Enter the name of the shop: ");
            SetName(Console.ReadLine());

            Console.Write("Enter the address of the shop: ");
            SetAddress(Console.ReadLine());

            Console.Write("Enter the profile description of the shop: ");
            SetProfileDescription(Console.ReadLine());

            Console.Write("Enter the phone number of the shop: ");
            SetPhone(Console.ReadLine());

            Console.Write("Enter the email address of the shop: ");
            SetEmail(Console.ReadLine());
        }

        public void PrintData()
        {
            Console.WriteLine("Shop Name: " + GetName());
            Console.WriteLine("Address: " + GetAddress());
            Console.WriteLine("Profile Description: " + GetProfileDescription());
            Console.WriteLine("Phone: " + GetPhone());
            Console.WriteLine("Email: " + GetEmail());
        }
    }
}
