using AGL.WebAPI.Models;
using AGL.WebAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AGL.WebAPI.Provider
{
    public class AGLDataProvider : IAGLDataProvider
    {
        IAGLDataProvider Provider;
        IAGLDataRepository Repository;
        public AGLDataProvider(IAGLDataRepository repository)
        {
            if (repository == null)
            {
                Repository = new AGLDataRepository();
            }
            else
            {
                Repository = repository;
            }
        }

        public Dictionary<string, List<PetDetails>> GetPetDetails()
        {
            var context = Repository.GetPetDetails();

            var query = from x in context.ToList()
                        where x.Pets != null
                        group x by Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(x.Gender) into y
                        select new
                        {
                            Gender = y.Key,
                            Pets = y.SelectMany(x => x.Pets)
                            .Where(p => p.PetType.Equals("cat", StringComparison.InvariantCultureIgnoreCase))
                            .OrderBy(p => p.PetName)
                            .ToList()
                        };


           var  response = query.ToDictionary(x => x.Gender, x => x.Pets);
            return response;
        }
    }
}
