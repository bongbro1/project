﻿using Microsoft.EntityFrameworkCore;
using ServerApp.DAL.Data;
using ServerApp.DAL.Models;
using ServerApp.DAL.Repositories.Generic;
using System.Linq.Expressions;

namespace ServerApp.DAL.Repositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
    }

    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly ShopDbContext _context;

        public UserRepository(ShopDbContext context) : base(context)
        {
            _context = context;
        }

    }


}
