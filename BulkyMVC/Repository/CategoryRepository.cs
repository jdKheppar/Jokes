﻿using Jokes.Models;
using Jokes.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Jokes.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
       
        public void Save()
        {
            //throw new NotImplementedException();
            //Need to write code here, the above code is a auto generated by the ide
        }

        public void Update(Category obj)
        {
            throw new NotImplementedException();
        }
        //5:14:57
    }
}
