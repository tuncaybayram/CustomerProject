using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerProject
{
    public class Customer
    {

        #region Virtual Database
        static ArrayList CustomerDatabase;

        #endregion
        #region Static Constructor Method
        static Customer()
        {
            CustomerDatabase = new ArrayList();
        }

        #endregion
        #region Feild   

        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string EmailAdress { get; set; }

        public string Password { get; set; }


        #endregion
        #region Capsulation
        private string _userName { get; set; }
        public string UserName
        {
            get { return _userName; }
            set
            {
                bool userNameCheck = CustomerUserIdCheck(value);
                if (userNameCheck)
                {
                    Console.WriteLine("Eklemek istediğiniz kullanıcı adı sistem içersinde kayıtlı");
                    this._userName = String.Empty;
                }
                else
                {
                    this._userName = value;
                }

            }
        }
        #endregion

        #region Static Methods
        static bool CustomerUserIdCheck(string _username)
        {
            bool Check = false;
            for (int i = 0; i < CustomerDatabase.Count; i++)
            {
                Customer Temp = (Customer)CustomerDatabase[i];
                if (Temp.UserName == _username)
                {
                    Check = true; break;
                }
            }
            return Check;
        }

        public static void CustomerAdd(Customer customer)
        {
            #region Parameter
            if (customer != null && !string.IsNullOrEmpty(customer.UserName)&& !string.IsNullOrEmpty(customer.EmailAdress))

            {
                bool emailAdressCheck= customerEmailAdressCheck(customer.EmailAdress);
                if (emailAdressCheck)
                {
                    Console.WriteLine("Eklemek istediğiniz kullanıcı sistemde kayıtlı");
                }
                else
                {
                    CustomerDatabase.Add(customer);
                    Console.WriteLine("Yeni kayıt işlemi başarılı");
                }
            }

            #endregion




        }
        static bool customerEmailAdressCheck(string _emailAdress)
        {
            bool check = false;
            for (int i = 0; i < CustomerDatabase.Count; i++)
            {
                Customer Temp = (Customer)CustomerDatabase[i];
                if (Temp.EmailAdress == _emailAdress)
                {
                    check = true;
                    break;
                }

            }
            return check;
        }
        #endregion


    }
}
