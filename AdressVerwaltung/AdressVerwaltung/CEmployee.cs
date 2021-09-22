using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressVerwaltung
{
    class CEmployee
    {
        public CEmployee() { empID++; } //initializing a new emp will put the ID counter 1 up
        static int empID = 0;
        string sPreName;
        string sSurName;
        DateTime dtBirthday = new DateTime();
        string sPostition;
        public struct stAddress
        {
            public stAddress(string cat, string street, string num, string zip, string add)
            {
                sCategory = cat;
                sStreet = street;
                sNumber = num;
                sZipcode = zip;
                sAdditional = add;
            }
            string sCategory;
            string sStreet;
            string sNumber;
            string sZipcode;
            string sAdditional;
            public override string ToString()
            {
                return sCategory + ":" +
                        "\n" + sStreet + " " + sNumber + 
                        "\n" + sZipcode + 
                        "\n" + sAdditional;
            }
        }
        public List<stAddress> lAddress = new List<stAddress>();
        public List<string> lNumber = new List<string>();
        public string SPreName { get => sPreName; set => sPreName = value; }
        public string SSurName { get => sSurName; set => sSurName = value; }
        public string getDtBirthdayAsString 
        {
            get
            {
                string[] arDt = DtBirthday.GetDateTimeFormats();
                return arDt[5];
            }  
        }
        public string SPostition { get => sPostition; set => sPostition = value; }
        public DateTime DtBirthday { get => dtBirthday; set => dtBirthday = value; }
        public static int EmpID { get => empID; set => empID = value; }
    }
}
