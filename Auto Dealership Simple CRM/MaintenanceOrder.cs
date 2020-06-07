using System;
using System.Collections.Generic;
using System.Configuration;

namespace CustomerResourceManagement
{
    public class MaintenanceOrder
    {

        //Throws a warning about a property not being set because it can only be set once
        private void ThrowAlreadySetWarning(string propertyName)
        {
            string warningText = propertyName + " update failed! (" + propertyName + " can only be set once!)";
            throw new System.ComponentModel.WarningException(warningText);
        }

        //WorkOrderNum: unique identifier; can only be set once
        private bool workOrderNumIsSet = false;
        private string _workOrderNum;
        public string WorkOrderNum
        {
            get { return this._workOrderNum; }
            set
            {
                //WorkOrderNum can only be set one time
                if (!workOrderNumIsSet)
                {
                    workOrderNumIsSet = true;
                    this._workOrderNum = value;
                }
                else
                {
                    ThrowAlreadySetWarning("WorkOrderNum");
                }
            }
        }

        //InventoryId: foreign key to Inventory table
        private string _inventoryId;
        public string InventoryId
        {
            get { return this._inventoryId; }
            set { this._inventoryId = value; }
        }

        //CustomerId: foreign key to Customer table
        private string _customerId;
        public string CustomerId
        {
            get { return this._customerId; }
            set { this._customerId = value; }
        }

        //PartsEstimate: the estimated cost of parts for the required maintenance
        private decimal _partsEstimate;
        public decimal PartsEstimate
        {
            get { return this._partsEstimate; }
            set { this._partsEstimate = value; }
        }

        //PartsActual: the actual cost of parts for the required maintenance
        private decimal _partsActual;
        public decimal PartsActual
        {
            get { return this._partsActual; }
            set { this._partsActual = value; }
        }

        //LaborEstimate: the estimated cost of labor for the required maintenance
        private decimal _laborEstimate;
        public decimal LaborEstimate
        {
            get { return this._laborEstimate; }
            set { this._laborEstimate = value; }
        }

        //LaborActual: the estimated cost of labor for the required maintenance
        private decimal _laborActual;
        public decimal LaborActual
        {
            get { return this._laborActual; }
            set { this._laborActual = value; }
        }

        //ArrivalDate: the date the vehicle arrived; can only be set once
        private bool arrivalDateHasBeenSet = false;
        private DateTime _arrivalDate;
        public DateTime ArrivalDate
        {
            get { return this._arrivalDate; }
            set
            {
                //ArrivalDate can only be set once time
                if (!arrivalDateHasBeenSet)
                {
                    this._arrivalDate = value;
                    arrivalDateHasBeenSet = true;
                } else
                {
                    ThrowAlreadySetWarning("ArrivalDate");
                }
            }
        }

        //EstimatedCompletionDate: the estimated date of maintenance completion
        private DateTime _estimatedCompletionDate;
        public DateTime EstimatedCompletionDate
        {
            get { return this._estimatedCompletionDate; }
            set { this._estimatedCompletionDate = value; }
        }

        //ActualCompletionDate: the actual date of maintenance completion
        private DateTime _actualCompletionDate;
        public DateTime ActualCompletionDate
        {
            get { return this._actualCompletionDate; }
            set { this._actualCompletionDate = value; }
        }

        //CompletionStatus: a string describing how close to complete the work is
        private string _completionStatus;
        public string CompletionStatus

        {
            get { return this._completionStatus; }
            set { this._completionStatus = value; }
        }

        //WorkDescription: a string describing the work to be done
        private string _workDescription;
        public string WorkDescription
        {
            get { return this._workDescription; }
            set { this._workDescription = value; }
        }

        // DATABASE INTERACTION METHODS BELOW THIS POINT

        public void addRecord()
        {
            //Code to insert a new row in the MaintenanceOrder table
            Console.WriteLine("New Record Added!");
        }

        public void updateRecord(string orderId)
        {
            //Code to update an existing record
            Console.WriteLine("Record " + orderId + " updated!");
        }

        public static void deleteRecord(string orderId)
        {
            //Code to delete an existing record
            Console.WriteLine("Record " + orderId + " deleted!");
        }

        public static List<MaintenanceOrder> getRecords()
        {
            //Code to construct a list of maintenance orders from the contents of the MaintenanceOrder table

            //A dummy list is created here; this will be removed in a future update
            List<MaintenanceOrder> orderList = new List<MaintenanceOrder>();

            MaintenanceOrder order = new MaintenanceOrder();
            order.WorkOrderNum = "1";
            order.InventoryId = "5";
            order.CustomerId = "1";
            order.PartsEstimate = 50.0M;
            order.PartsActual = 55.0M;
            order.LaborEstimate = 100M;
            order.LaborActual = 100.01M;
            order.ArrivalDate = DateTime.Now;
            order.EstimatedCompletionDate = DateTime.Now.AddDays(1);
            order.ActualCompletionDate = DateTime.Now.AddDays(1).AddHours(1);
            order.CompletionStatus = "Not Complete";
            order.WorkDescription = "Muffler is completely missing";

            orderList.Add(order);
            return orderList;

        }

    }
}
