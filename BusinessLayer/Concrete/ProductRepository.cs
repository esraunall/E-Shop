﻿using BusinessLayer.Abstract;
using DataAccessLayer.Context;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductRepository : GenericRepository<Product>
    {
        DataContext db=new DataContext();

        public List<Product> GetProductList()
        {
            return db.Products.Include("Category").ToList();
        }
        public List<Product> GetPopularProduct()
        {
            return db.Products.Include("Category").Where(x => x.Popular == true).Take(3).ToList();
        }
    }
}
