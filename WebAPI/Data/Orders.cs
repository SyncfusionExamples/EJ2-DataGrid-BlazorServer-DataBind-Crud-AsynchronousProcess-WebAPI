using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Data
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
            //this.Time = Time;
            this.OrderDate = OrderDate;
            //this.HireDate = HireDate;
           // this.HireDate1 = HireDate1;
            this.ShipCity = ShipCity;
        }
        public long OrderID { get; set; }
        public string CustomerID { get; set; }
        public Nullable<int> EmployeeID { get; set; }

      //  public TimeSpan? Time { get; set; }
        public double Freight { get; set; }
        public DateTime OrderDate { get; set; }
        //public DateTimeOffset? HireDate { get; set; }
        //public DateTimeKind? HireDate1 { get; set; }
        public string ShipCity { get; set; }
    }
}
