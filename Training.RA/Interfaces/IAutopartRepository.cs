﻿using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage;
using Training.Data.Entities;

namespace Training.RA.Interfaces
{
    public interface IAutopartRepository : IRepository<Autopart>
    {
        Task<IDbContextTransaction> BeginTransaction();
    }
}
