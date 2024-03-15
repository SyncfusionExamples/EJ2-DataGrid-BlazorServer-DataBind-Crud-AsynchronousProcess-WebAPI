using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using CrudAsynchronousSample.Data;

namespace CrudAsynchronousSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        // GET: api/Default1
        public static List<Orders> order = new List<Orders>();
        // GET: api/Default

        [HttpGet]
        public object Get()
        {

            //IQueryable<Order> data = db.GetAllOrders().AsQueryable();
            if (order.Count == 0)
            {
                BindDataSource();
            }
            var data = order.AsQueryable();
            var count = data.Count();
            var queryString = Request.Query;
            string sort = queryString["$orderby"];   //sorting      
            string filter = queryString["$filter"];
            string auto = queryString["$inlineCount"];
            if (sort != null) //Sorting 
            {
                var sortfield = sort.Split(',');
                for (var i = sortfield.Length; i > 0; i--)
                {
                    var sortColumn = sortfield[i - 1].Split(" ");
                    var sorttype = sortColumn[0];
                    if (sortColumn.Length == 2)
                    {
                        switch (sorttype)
                        {
                            case "OrderID":
                                data = data.OrderByDescending(x => x.OrderID);
                                break;
                            case "CustomerID":
                                data = data.OrderByDescending(x => x.CustomerID);
                                break;
                            case "Freight":
                                data = data.OrderByDescending(x => x.Freight);
                                break;
                            case "EmployeeID":
                                data = data.OrderByDescending(x => x.EmployeeID);
                                break;
                            case "OrderDate":
                                data = data.OrderByDescending(x => x.OrderDate);
                                break;

                        }
                    }
                    else
                    {
                        switch (sorttype)
                        {
                            case "OrderID":
                                data = data.OrderBy(x => x.OrderID);
                                break;
                            case "CustomerID":
                                data = data.OrderBy(x => x.CustomerID);
                                break;
                            case "Freight":
                                data = data.OrderBy(x => x.Freight);
                                break;
                            case "EmployeeID":
                                data = data.OrderBy(x => x.EmployeeID);
                                break;
                            case "OrderDate":
                                data = data.OrderBy(x => x.OrderDate);
                                break;
                        }
                    }
                }
            }
            if (queryString.Keys.Contains("$inlinecount"))
            {
                StringValues Skip;
                StringValues Take;
                int skip = (queryString.TryGetValue("$skip", out Skip)) ? Convert.ToInt32(Skip[0]) : 0;
                int top = (queryString.TryGetValue("$top", out Take)) ? Convert.ToInt32(Take[0]) : data.Count();
                return new { Items = data.Skip(skip).Take(top), Count = count };
            }
            else
            {
                return data;
            }
        }
        private void BindDataSource()
        {
            int i = 1, code = 10247;
            order.Add(new Orders(code + 1, "VINET", i + 1, 2.3 * i, DateTime.Now.AddMilliseconds(12345), "Berlin"));
            order.Add(new Orders(code + 2, "ALFKI", i + 2, 3.3 * i, new DateTime(1990, 04, 04), "Madrid"));
            order.Add(new Orders(code + 3, "ANTON", i + 1, 4.3 * i, new DateTime(1957, 11, 30), "Cholchester"));
            order.Add(new Orders(code + 4, "BLONP", i + 3, 5.3 * i, new DateTime(1930, 10, 22), "Marseille"));
            order.Add(new Orders(code + 5, "BOLID", i + 4, 6.3 * i, new DateTime(1953, 02, 18), "Tsawassen"));

        }
        //// GET: api/Default1/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/Default1
        [HttpPost]
        public object Post([FromBody]Orders value)
        {
            order.Insert(0, value);
            return value;
        }

        // PUT: api/Default1/5
        [HttpPut("{id}")]
        public object Put(int id, [FromBody]Orders value)
        {
            var data = order.Where(or => or.OrderID == value.OrderID).FirstOrDefault();
            if (data != null)
            {
                data.OrderID = value.OrderID;
                data.CustomerID = value.CustomerID;
                data.Freight = value.Freight;
                data.CustomerID = value.CustomerID;
                data.OrderDate = value.OrderDate;
            }
            return value;
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            order.Remove(order.Where(or => or.OrderID.ToString() == id).FirstOrDefault());
        }
    }
}
