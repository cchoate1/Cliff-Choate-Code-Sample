using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerResourceManagement
{
    public class Customer
    {
        //Throws a warning about a property not being set because it can only be set once
        private void ThrowAlreadySetWarning(string propertyName)
        {
            string warningText = propertyName + " update failed! (" + propertyName + " can only be set once!)";
            throw new System.ComponentModel.WarningException(warningText);
        }

        //WorkOrderNum: unique identifier; can only be set once
        private bool customerIdIsSet = false;
        private string _customer_id;
        public string CustomerIDa
        {
            get { return this._customer_id; }
            set
            {
                if (!customerIdIsSet)
                {
                    customerIdIsSet = true;
                    this._customer_id = value;
                }
                else
                {
                    ThrowAlreadySetWarning("Can't create new Customer");
                }
            }
        }

        /* First Name */
        private string _firstName;
        public void setFirstName (string firstName)
        {
            this._firstName = firstName;
        }
        public string FirstName
        {
            get { return this._firstName; }
            set { this._firstName = value; }
        }

        /* Last Name */
        private string _lastName;
        public string LastName
        {
            get { return this._lastName; }
            set { this._lastName = value; }
        }

        /* Address1 */
        private string _address1;
        public string Address1
        {
            get { return this._address1; }
            set { this._address1 = value; }
        }

        /* Address2 */
        private string _address2;
        public string Address2
        {
            get { return this._address2; }
            set { this._address2 = value; }
        }

        /* City */
        private string _city;
        public string City
        {
            get { return this._city; }
            set { this._city = value; }
        }

        /* State */
        private string _state;
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        /* ZipCode */
        private string _zipCode;
        public string ZipCode
        {
            get { return this._zipCode; }
            set { this._zipCode = value; }
        }

        /* Phone */
        private string _phone;
        public string Phone
        {
            get { return this._phone; }
            set { this._phone = value; }
        }

        /* Email */
        private string _email;
        public string Email
        {
            get { return this._email; }
            set { this._email = value; }
        }

        /* PreferredContactID */
        private int _preferredContact_id;
        public int PreferredContactID
        {
            get { return this._preferredContact_id; }
            set { this._preferredContact_id = value; }
        }

        /* Interests */
        private string _interests;
        public string Interests
        {
            get { return this._interests; }
            set { this._interests = value; }
        }

        /* MinPrice */
        private decimal _minPrice;
        public decimal MinPrice
        {
            get { return this._minPrice; }
            set { this._minPrice = value; }
        }

        /* MaxPrice */
        private decimal _maxPrice;
        public decimal MaxPrice
        {
            get { return this._maxPrice; }
            set { this._maxPrice = value; }
        }

        /* UserLastUpd */
        private string _userLastUpd;
        public string UserLastUpd
        {
            get { return this._userLastUpd; }
            set { this._userLastUpd = value; }
        }

        /* LastUpd */
        private DateTime _lastUpd;
        public DateTime LastUpd
        {
            get { return this._lastUpd; }
            set { this._lastUpd = value; }
        }

        /* DBAction */
        private DBactionType _dbAction;
        public DBactionType DBAction
        {
            get { return this._dbAction; }
            set { this._dbAction = value; }
        }

        /* default constructor */
        public Customer() { }

        /* Constructor for DB Insert */
        public Customer(string firstName, string LastName, string address1, string address2,
                        string city, string state, string zipCode, string phone, string email,
                        int preferredContact, string interests, decimal minPrice, decimal maxPrice)
        {
            this._firstName = firstName;
            this._lastName = LastName;
            this._address1 = address1;
            this._address2 = address2;
            this._city = city;
            this._state = state;
            this._zipCode = zipCode;
            this._phone = phone;
            this._email = email;
            this._preferredContact_id = preferredContact;
            this._interests = interests;
            this._minPrice = minPrice;
            this._maxPrice = maxPrice;
        }
        public void InsertCustomer()
        {

            CrmDb crmCustDB = new CrmDb();
   
        }

        public override string ToString()
        {
            return (FirstName + " " + LastName);
        }
    }

}