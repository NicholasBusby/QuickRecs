using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using QuickRecs.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace QuickRecs.Service
{
    public class TasteKid
    {
        private Func<HttpMessageHandler> handler;
        public TasteKid(Func<HttpMessageHandler> handler)
        {
            this.handler = handler;
        }

        public async Task<TasteKidResult> GetRecs(string input)
        {
            using (var http = new HttpClient(handler.Invoke()))
            {
                var response = await http.GetAsync("https://www.tastekid.com/api/similar?q=red+hot+chili+peppers%2C+pulp+fiction&info=1");
                var Results = await response.Content.ReadAsStringAsync();
                var tasteKid = JsonConvert.DeserializeObject<TasteKidResult>(Results);
                return tasteKid;
            }
        }
    }
}
