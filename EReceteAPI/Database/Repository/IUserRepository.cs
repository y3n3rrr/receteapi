using Data.Database;
using EReceteAPI.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EReceteAPI.Database
{
    public interface IUserRepository : IGenericRepository<Users>
    {
        Task<Users> GetCoolestCategory();
        Task<List<Users>> GetAllByAsync();
    }
}
