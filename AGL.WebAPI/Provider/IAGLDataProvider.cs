﻿using AGL.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AGL.WebAPI.Provider
{
    public interface IAGLDataProvider
    {
        Dictionary<string, List<PetDetails>> GetPetDetails();
    }
}
