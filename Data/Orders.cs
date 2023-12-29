using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudAsynchronousSample.Data
{
    public class Orders
    {
        public Orders()
        {

        }
        public Orders(long OrderId, string CustomerId, Nullable<int> EmployeeId, double Freight, DateTime OrderDate, string ShipCity)
        {
            this.OrderID = OrderId;
            this.CustomerID = CustomerId;
            this.EmployeeID = EmployeeId;
            this.Freight = Freight;
            this.OrderDate = OrderDate;
            this.ShipCity = ShipCity;
        }
        public long OrderID { get; set; }
        public string CustomerID { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public double Freight { get; set; }
        public DateTime OrderDate { get; set; }
        public string? ShipCity { get; set; }
    }
}
