using AGL.WebAPI.Models;
using AGL.WebAPI.Provider;
using AGL.WebAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace AGL.WebAPI.Controllers
{
    /// <summary>
    /// controller contains api related to pet
    /// </summary>
    [RoutePrefix("api/PetDetils")]
    public class AGLDataController : ApiController
    {
        IAGLDataProvider Provider = new AGLDataProvider(null);
        //IAGLDataRepository Repository;
       
        /// <summary>
        /// api to retrieve pet details
        /// </summary>
        /// <returns></returns>
        [HttpGet,Route("retreive")]
        public Dictionary<string, List<PetDetails>> GetPetDetails()
        {
            Dictionary<string, List<PetDetails>> response = null;
            try
            {
                response = Provider.GetPetDetails();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;
        }
    }
}
