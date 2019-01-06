using EReceteAPI.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EReceteAPI.Database
{
    public interface IEntity
    {
        long ID { get; set; }
    }
}
