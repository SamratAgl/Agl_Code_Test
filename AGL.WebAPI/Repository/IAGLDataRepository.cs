﻿using AGL.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AGL.WebAPI.Repository
{
    public interface IAGLDataRepository
    {
        List<People> GetPeopleResponse();
    }
}
