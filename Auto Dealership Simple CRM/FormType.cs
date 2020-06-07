
namespace CustomerResourceManagement
{
    enum FormType
    {
        CUSTOMER_NEW,
        CUSTOMER_EDIT,
        CUSTOMER_DELETE,
        CUSTOMER_SEARCH,
        
        EMPLOYEE_NEW,
        EMPLOYEE_EDIT,
        EMPLOYEE_DELETE,
        EMPLOYEE_SEARCH,

        LEADS_NEW,
        LEADS_EDIT,
        LEADS_DELETE,
        LEADS_SEARCH,

        INVENTORY_NEW,
        INVENTORY_EDIT,
        INVENTORY_DELETE,
        INVENTORY_SEARCH,

        MAINTENANCE_NEW,
        MAINTENANCE_EDIT,
        MAINTENANCE_DELETE,
        MAINTENANCE_SEARCH,

        PURCHASES_NEW,
        PURCHASES_EDIT,
        PURCHASES_DELETE,
        PURCHASES_SEARCH
    }

    public enum DBactionType
    {
        INSERT,
        DELETE,
        UPDATE,
        SELECT,
        UNKNOWN
    }
}
