using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Data;

namespace WebAPI.Data
{
    public class OrderService
    {
        string baseUrl = "http://localhost:50838/";
        public async Task<List<Orders>> GetOrdersAsync()
        {
            HttpClient http = new HttpClient();
            var json = await http.GetStringAsync($"{baseUrl}api/Default");
            return JsonConvert.DeserializeObject<List<Orders>>(json);
        }
        public async Task<HttpResponseMessage> InsertOrderAsync(Orders value)
        {
            var client = new HttpClient();
            return await client.PostAsync($"{baseUrl}api/Default", getStringContentFromObject(value));
        }
        public async Task<HttpResponseMessage> UpdateOrderAsync(string id,Orders value)
        {
            var client = new HttpClient();
            return await client.PutAsync($"{baseUrl}api/Default/{id}", getStringContentFromObject(value));            
        }

        public async Task<HttpResponseMessage> DeleteOrderAsync(string id)
        {
            var client = new HttpClient();
            return await client.DeleteAsync($"{baseUrl}api/Default/{id}");            
        }
        private StringContent getStringContentFromObject(object obj)
        {
            var serialized = JsonConvert.SerializeObject(obj);
            var stringContent = new StringContent(serialized, Encoding.UTF8, "application/json");
            return stringContent;
        }
    }
}
