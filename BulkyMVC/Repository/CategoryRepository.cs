﻿using Jokes.Data;
using Jokes.Models;
using Jokes.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Jokes.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db): base(db) 
        {
            _db = db;
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }
    }
}
