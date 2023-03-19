using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EditPerson
{
    [Serializable, XmlRoot(Namespace = "http://www.MyCompany.com")]
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public int Age { get; set; }
        [NonSerialized]
        int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public override string ToString()
        {
            return LastName + " " + FirstName + "\nВозраст: " + Age + "\n";
        }

    }
}
