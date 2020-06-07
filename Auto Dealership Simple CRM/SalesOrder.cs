using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerResourceManagement
{
    
    public class clsSalesOrder
    {

        public string CustomerID { get; set; }
        public string SalesOrderID { get; set; }
        public string SalespersonID { get; set; }
        public string InventoryID { get; set; }
        public decimal finalPrice { get; set; }
        public DateTime saleDate { get; set; }
        public DateTime pickUpDate { get; set; }
        public string status { get; set; }

        // default constructor to be removed; exists only to compile/test pre-DB
        public clsSalesOrder()
        {

        }
        // constructor
        public clsSalesOrder(string salesOrderID,string inventoryID,string customerID,decimal finalPrice, 
                             DateTime saleDate, DateTime pickUpDate, string salespersonID, string status)
        {
            this.SalesOrderID = salesOrderID;
            this.InventoryID = inventoryID;
            this.CustomerID = customerID;
            this.finalPrice = finalPrice;
            this.saleDate = saleDate;
            this.pickUpDate = pickUpDate;
            this.SalespersonID = salespersonID;
            this.status = status;
        }

        //copy constructor

            public clsSalesOrder(clsSalesOrder otherItem)
        {
            this.SalesOrderID = otherItem.SalesOrderID;
            this.InventoryID = otherItem.InventoryID;
            this.CustomerID = otherItem.CustomerID;
            this.finalPrice = otherItem.finalPrice;
            this.saleDate = otherItem.saleDate;
            this.pickUpDate = otherItem.pickUpDate;
            this.SalespersonID = otherItem.SalespersonID;
            this.status = otherItem.status;
        }

        // retrieve all SalesOrders from database
        public static List<clsSalesOrder> selectAllSalesOrders()
        {
            List<clsSalesOrder> SOList = new List<clsSalesOrder>();


            return SOList;
        }

        public static clsSalesOrder searchSalesOrder(string salesOrderID)
        {
            clsSalesOrder searchedSO = new clsSalesOrder();

            return searchedSO;
        }

        public static void deleteSalesOrder(string salesOrderID)
        {

        }

        public static void insertSalesOrder(clsSalesOrder newSalesOrder)
        {

        }
        public override string ToString()
        {
            return this.SalesOrderID;
        }
    }
        


    
}
