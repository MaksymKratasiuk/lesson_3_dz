using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_3_dz
{
    internal class Task4
    {
        private string name;
        private string url;
        private string description;
        private string ipAddress;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Url
        {
            get { return url; }
            set { url = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string IpAddress
        {
            get { return ipAddress; }
            set { ipAddress = value; }
        }

        public void InputData()
        {
            Console.Write("Enter the name of the website: ");
            name = Console.ReadLine();
            Console.Write("Enter the URL of the website: ");
            url = Console.ReadLine();
            Console.Write("Enter the description of the website: ");
            description = Console.ReadLine();
            Console.Write("Enter the IP address of the website: ");
            ipAddress = Console.ReadLine();
        }

        public void DisplayData()
        {
            Console.WriteLine("Website Name: {0}", name);
            Console.WriteLine("Website URL: {0}", url);
            Console.WriteLine("Website Description: {0}", description);
            Console.WriteLine("Website IP Address: {0}", ipAddress);
        }

        public string GetName()
        {
            return name;
        }

        public string GetUrl()
        {
            return url;
        }

        public string GetDescription()
        {
            return description;
        }

        public string GetIpAddress()
        {
            return ipAddress;
        }

        public void SetName(string newName)
        {
            name = newName;
        }

        public void SetUrl(string newUrl)
        {
            url = newUrl;
        }

        public void SetDescription(string newDescription)
        {
            description = newDescription;
        }

        public void SetIpAddress(string newIpAddress)
        {
            ipAddress = newIpAddress;
        }
    }
}
