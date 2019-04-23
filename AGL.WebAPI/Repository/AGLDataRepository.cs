using AGL.WebAPI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace AGL.WebAPI.Repository
{
    public class AGLDataRepository :IAGLDataRepository
    {
        /// <summary>
        /// Consume Json service 
        /// </summary>
        /// <returns>list of people</returns>
        public List<People> GetPetDetails()
        {
            List<People> response = null;
            try
            {               
                using (WebClient wc = new WebClient())
                {
                    var webresponse = wc.DownloadString("http://agl-developer-test.azurewebsites.net/people.json");
                    if (webresponse != null)
                    {
                       response = JsonConvert.DeserializeObject<List<People>>(webresponse);
                        
                    }
                };             

            }
            catch (Exception ex)
            {
                //catch exception using logger
            }
            return response;
        }
       
    }
}
