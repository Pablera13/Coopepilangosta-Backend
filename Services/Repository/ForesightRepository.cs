﻿using DataAccess.Data;
using DataAccess.Models;
using Services.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public class ForesightRepository : GenericRepository<Foresight>, IForesightRepository
    {
        public ForesightRepository(ApiContext context) : base(context)
        {

        }
    }
}
