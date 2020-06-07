using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerResourceManagement
{
    public class clsPurchaseOrder
    {
        public string PurchaseOrderID { get; set; }
        public string Vin { get; set; }
        public string Source { get; set; }
        public string AuthorizedBy { get; set; }
        public decimal Cost { get; set; }
        public string InventoryID { get; set; }

        public clsPurchaseOrder()
        {

        }

        public clsPurchaseOrder(string purchaseOrderID, string VIN, string source, string authorizedBy, decimal cost, string inventoryID)
        {
            this.PurchaseOrderID = purchaseOrderID;
            this.Vin = VIN;
            this.Source = source;
            this.AuthorizedBy = authorizedBy;
            this.Cost = cost;
            this.InventoryID = inventoryID;
        }

        // copy constructor
        public clsPurchaseOrder(clsPurchaseOrder otherItem)
        {
            this.PurchaseOrderID = otherItem.PurchaseOrderID;
            this.Vin = otherItem.Vin;
            this.Source = otherItem.Source;
            this.AuthorizedBy = otherItem.AuthorizedBy;
            this.Cost = otherItem.Cost;
            this.InventoryID = otherItem.InventoryID;
        }

        
        public static void insertPurchaseOrder(clsPurchaseOrder newPurchaseOrder)
        {
            
            deletePurchaseOrder(newPurchaseOrder.PurchaseOrderID, true); //update version
            GlobalListForTesting.totalPOList.Add(newPurchaseOrder); //adds PO to test list
        }

        public static void deletePurchaseOrder(string purchaseOrderID) // deletes PO and associated inventory
        {
            GlobalListForTesting.totalPOList.Remove(searchPurchaseOrder(purchaseOrderID));
            if (GlobalListForTesting.totalPOList.Contains(GlobalListForTesting.totalPOList.Find(x => x.PurchaseOrderID.Equals(purchaseOrderID))))
            {
                GlobalListForTesting.totalPOList.Remove(GlobalListForTesting.totalPOList.Find(x => x.PurchaseOrderID.Equals(purchaseOrderID)));
            }
            clsInventory.deleteInventory((GlobalListForTesting.totalInventoryList.Find(x => x.PurchaseOrderID.Equals(purchaseOrderID)).InventoryID));
        }

        public static void deletePurchaseOrder(string purchaseOrderID, bool update) // update version does not delete inventory
        {
            GlobalListForTesting.totalPOList.Remove(searchPurchaseOrder(purchaseOrderID));
            if (GlobalListForTesting.totalPOList.Contains(GlobalListForTesting.totalPOList.Find(x => x.PurchaseOrderID.Equals(purchaseOrderID))))
            {
                GlobalListForTesting.totalPOList.Remove(GlobalListForTesting.totalPOList.Find(x => x.PurchaseOrderID.Equals(purchaseOrderID)));
            }
        }

        public static clsPurchaseOrder searchPurchaseOrder(string ID)
        {
            return GlobalListForTesting.totalPOList.Find(x => x.PurchaseOrderID.Equals(ID));
        }
        public static List<clsPurchaseOrder> selectAllPurchaseOrders()
        {
            return GlobalListForTesting.totalPOList; 
        }

        public override string ToString()
        {
            return PurchaseOrderID + " " + clsInventory.searchInventory(InventoryID).Make + " " + clsInventory.searchInventory(InventoryID).Model;
        }
    }
}
