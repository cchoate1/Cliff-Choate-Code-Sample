using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerResourceManagement
{
    public class clsInventory
    {
        
            public string InventoryID { get; set; }
            public string Make { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public int Year { get; set; }
            public int Mileage { get; set; }
            public DateTime ArrivedOnLot { get; set; }
            public decimal CostPaid { get; set; }
            public decimal StickerPrice { get; set; }
            public string BodyType { get; set; }
            public string Vin { get; set; }
            public string PurchaseOrderID { get; set; } // references PO inventory was received on
            public string SalespersonID { get; set; } // populated after sale; used in earnings reports etc.
            public string CustomerHold { get; set; } // populated with customer ID if being held for that customer
            public bool Available { get; set; }

            // "default" constructor, for development only 
            public clsInventory()
            {
                
                this.Make = "Cadillac";
                this.Model = "El Dorado";
                this.Color = "Hot Pink";
                this.Year = 1957;
                this.Mileage = 2000;
                this.ArrivedOnLot = DateTime.Now;
                this.CostPaid = 100;
                this.StickerPrice = 600;
                this.BodyType = "Convertible";
                this.Vin = "123ABC";
                this.PurchaseOrderID = "12345678";
                this.Available = true;
            }

            // copy constructor
            public clsInventory(clsInventory otherItem, int marker)
            {
                this.InventoryID = otherItem.InventoryID;
                this.Make = otherItem.Make;
                this.Model = otherItem.Model;
                this.Color = otherItem.Color;
                this.Year = otherItem.Year;
                this.Mileage = otherItem.Mileage;
                this.ArrivedOnLot = otherItem.ArrivedOnLot;
                this.CostPaid = otherItem.CostPaid;
                this.StickerPrice = otherItem.StickerPrice;
                this.BodyType = otherItem.BodyType;
                this.Vin = otherItem.Vin;
                this.PurchaseOrderID = otherItem.PurchaseOrderID;
                this.SalespersonID = otherItem.SalespersonID;
                this.CustomerHold = otherItem.CustomerHold;
                this.Available = otherItem.Available;
            }

            

            

            public clsInventory(string inventoryID, string make, string model, string color, int year, int mileage, DateTime arrivedOnLot,
                        decimal costPaid, decimal stickerPrice, string bodyType, string vin, string purchaseOrderID, string salespersonID,
                        string customerHold, bool available)
            {
                this.InventoryID = inventoryID;
                this.Make = make;
                this.Model = model;
                this.Color = color;
                this.Year = year;
                this.Mileage = mileage;
                this.ArrivedOnLot = arrivedOnLot;
                this.CostPaid = costPaid;
                this.StickerPrice = stickerPrice;
                this.BodyType = bodyType;
                this.Vin = vin;
                this.PurchaseOrderID = purchaseOrderID;
                this.SalespersonID = salespersonID;
                this.CustomerHold = customerHold;
                this.Available = available;
            }

            public override string ToString()
            {
                return (Make + " " + Model);
            }

            public static List<clsInventory> selectAllInventory()
            {
                return GlobalListForTesting.totalInventoryList;
            }

            public static clsInventory searchInventory(string ID)
            {
                return GlobalListForTesting.totalInventoryList.Find(x => x.InventoryID.Equals(ID));
            }

            public static void deleteInventory(string inventoryID)
            {
            if (GlobalListForTesting.totalInventoryList.Contains(GlobalListForTesting.totalInventoryList.Find(x => x.InventoryID.Equals(inventoryID))))
            {
                GlobalListForTesting.totalInventoryList.Remove(GlobalListForTesting.totalInventoryList.Find(x => x.InventoryID.Equals(inventoryID)));
            }
        }

            public static void insertInventory(clsInventory newVehicle)
            {
            deleteInventory(newVehicle.InventoryID);
            GlobalListForTesting.totalInventoryList.Add(newVehicle);
            }


        
    }
}
