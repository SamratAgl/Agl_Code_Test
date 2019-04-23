using AGL.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace AGL.WebAPI.Repository
{
    public class AGLDataRepository :IAGLDataRepository
    {
        /// <summary>
        /// Consume Json service 
        /// </summary>
        /// <returns>list of people</returns>
        public List<People> GetPeopleResponse()
        {
            List<People> peopleDetails = null;
            try
            {


            }
            catch (Exception ex)
            {

                //catch exception using logger
            }
            return peopleDetails;
        }
    }
}
