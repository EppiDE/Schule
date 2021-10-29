using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressVerwaltung
{
    class CEmployee
    {
        public CEmployee() {} //initializing a new emp will put the ID counter 1 up
        public static int empID = 1;
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
        public struct stNumber
        {
            public stNumber(string cat, string num)
            {
                sCategory = cat;
                sNumber = num;
            }
            string sCategory;
            string sNumber;
        }

        public List<stAddress> lAddress = new List<stAddress>();
        public List<stNumber> lNumber = new List<stNumber>();
        public string SPreName { get => sPreName; set => sPreName = value; }
        public string SSurName { get => sSurName; set => sSurName = value; }
        public int EmpID { get => empID; set => empID = value; }
        public void clearObject()
        {
            sPostition = null;
            sPreName = null;
            sSurName = null;
            lAddress.Clear();
            lNumber.Clear();
        }
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
        
    }
}
