﻿using Register.Common.Interfaces;
using Register.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register.Repository.Interfaces
{
    public interface IBikeRepository : IRepository
    {
        IList<Bike> SearchBikes();
        IList<Bike> GetAll();
    }
}
