using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;

namespace CustomerResourceManagement
{
    public class Lead
    {

        //Throws a warning about a property not being set because it can only be set once
        private void ThrowAlreadySetWarning(string propertyName)
        {
            string warningText = propertyName + " update failed! (" + propertyName + " can only be set once!)";
            throw new System.ComponentModel.WarningException(warningText);
        }

        //LeadId: unique identifier; can only be set once
        private bool leadIdIsSet = false;
        private string _leadId;
        public string LeadId
        {
            get { return this._leadId; }
            set
            {
                if (!leadIdIsSet)
                {
                    this._leadId = value;
                }
                else
                {
                    ThrowAlreadySetWarning("LeadId");
                }
            }
        }

        //CustomerId: foreign key to Customer table
        private string _customerId;
        public string CustomerId
        {
            get { return this._customerId; }
            set { this._customerId = value; }
        }

        //MinPrice: minimum price lead is likely to buy at
        private decimal _minPrice;
        public decimal MinPrice
        {
            get { return this._minPrice; }
            set { this._minPrice = value; }
        }

        //MaxPrice: minimum price lead is likely to buy at
        private decimal _maxPrice;
        public decimal MaxPrice
        {
            get { return this._maxPrice; }
            set { this._maxPrice = value; }
        }

        //LeadTemperatureId: foreign key to LeadTemperature table
        private string _leadTemperatureId;
        public string leadTemperatureId
        {
            get { return this._leadTemperatureId; }
            set { this._leadTemperatureId = value; }
        }

        //CreateDate: the date this lead was created
        private DateTime _createDate;
        public DateTime CreateDate
        {
            get { return this._createDate; }
            set { this._createDate = value; }
        }

        //ExpirationDate: the date this lead will expire
        private DateTime _expirationDate;
        public DateTime ExpirationDate
        {
            get { return this._expirationDate; }
            set { this._expirationDate = value; }
        }

        //Priority: priority of lead
        private int _priority;
        public int Priority
        {
            get { return this._priority; }
            set { this._priority = value; }
        }

        //InterestList and supporting methods: a list of vehicles the lead may be interested in
        private Collection<string> _interestList;
        public void InterestListAdd(string newEntry)
        {
            this._interestList.Add(newEntry);
        }
        public void InterestListRemove(string removeEntry)
        {
            this._interestList.Remove(removeEntry);
        }
        public Collection<string> GetInterestList()
        {
            return this._interestList;
        }

        // DATABASE INTERACTION METHODS BELOW THIS POINT

        public void addRecord()
        {
            //Code to insert a new row in the MaintenanceOrder table
            Console.WriteLine("New Record Added!");
        }

        public void updateRecord(string leadId)
        {
            //Code to update an existing record
            Console.WriteLine("Record " + leadId + " updated!");
        }

        public static void deleteRecord(string leadId)
        {
            //Code to delete an existing record
            Console.WriteLine("Record " + leadId + " deleted!");
        }

        public static List<Lead> getRecords()
        {
            //Code to construct a list of maintenance orders from the contents of the MaintenanceOrder table

            //A dummy list is created here; this will be removed in a future update
            List<Lead> leadList = new List<Lead>();

            Lead lead = new Lead();

            lead.LeadId = "leadId0";
            lead.CustomerId = "custId0";
            lead.MinPrice = 100m;
            lead.MaxPrice = 10000m;
            lead.CreateDate = DateTime.Now;
            lead.ExpirationDate = DateTime.Now.AddDays(1);

            leadList.Add(lead);
            return leadList;

        }

    }
}
