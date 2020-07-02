﻿using BulkyBook.DataAccess.Data;
using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BulkyBook.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db) :base(db){
            _db = db;

        }

        public void Update(Category category)
        {
            Category obj = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if(obj!=null)
            obj.Name = category.Name;
            //_db.SaveChanges();
           
        }
    }
}
