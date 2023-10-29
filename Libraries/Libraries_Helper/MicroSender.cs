using Microsoft.AspNetCore.WebUtilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Libraries_Helper
{
    public class MicroSender
    {
        readonly HttpClient _httpClient;

        public MicroSender() : this(new HttpClient()) { }

        public MicroSender(HttpClient httpClient) => _httpClient = httpClient;

        public async Task<bool> CheckItem(string address,string nameField,string value)
        {
            var result = await _httpClient.GetAsync(
                QueryHelpers.AddQueryString("http://localhost:5010/"+ address, nameField, value)
            );
            var json = await result.Content.ReadAsStringAsync();


            //var myobjList = JSON.Deserialize<List<MyStok>>(sc);
            //var myObj = myobjList[0]
            var myDeserializedClass = JsonConvert.DeserializeObject<List<MyArray>>(json);
         
            
            
            return true;
        }


        public class MyArray
        {
            public bool exists { get; set; }
        }

        public class Root
        {
            public List<MyArray> MyArray { get; set; }
        }
    }
}
