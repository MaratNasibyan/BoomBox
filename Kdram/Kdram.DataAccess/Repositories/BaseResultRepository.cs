﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kdram.DbMap.Entities;

namespace Kdram.DataAccess.Repositories
{
    public abstract class BaseResultRepository
    {
        private static KdramResultsEntities kdramResultsEntities;

        protected KdramResultsEntities KdramResultsEntities
        {
            get
            {
                return kdramResultsEntities ?? (kdramResultsEntities = new KdramResultsEntities());
            }
        }
    }    
}
