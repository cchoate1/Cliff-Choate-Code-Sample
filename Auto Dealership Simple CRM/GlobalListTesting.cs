using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerResourceManagement
{
    public static class GlobalListForTesting
    {
        public static List<clsInventory> totalInventoryList = new List<clsInventory>();
        public static List<clsPurchaseOrder> totalPOList = new List<clsPurchaseOrder>();
        public static List<clsSalesOrder> totalSOList = new List<clsSalesOrder>();
        public static List<MaintenanceOrder> totalMOList = new List<MaintenanceOrder>();
        public static List<Customer> totalCustomerList = new List<Customer>();
        public static List<Lead> totalLeadList = new List<Lead>();
    }
}
