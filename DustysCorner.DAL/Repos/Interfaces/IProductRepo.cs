﻿using DustysCorner.DAL.Entities;
using DustysCorner.DAL.Repos.Base;
using System.Collections.Generic;

namespace DustysCorner.DAL.Repos.Interfaces
{
    public interface IProductRepo : IRepo<Product>
    {
        IEnumerable<Product> GetCategory(int categoryId);
    }
}
