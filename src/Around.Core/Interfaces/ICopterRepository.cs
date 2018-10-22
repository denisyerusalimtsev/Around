﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Around.Core.Entities;

namespace Around.Core.Interfaces
{
    public interface ICopterRepository
    {
        Task<List<Copter>> GetAllAsync();

        Task<Copter> Get(int id);

        void Create(Copter copter);

        void Update(Copter copter);

        List<Copter> Search(string search);

        void Delete(int id);
    }
}