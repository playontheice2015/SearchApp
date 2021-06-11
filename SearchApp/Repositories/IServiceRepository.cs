﻿using SearchApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchApp.Repositories
{
    public interface IServiceRepository
    {
        SearchResultDto GetSearchResult(SearchDto service);
    }
}
