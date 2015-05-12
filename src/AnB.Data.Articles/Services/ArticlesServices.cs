using AnB.Data.Articles.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AnB.Data.Articles.Services
{
    public class ArticlesServices
    {
        private ArticlesContext db;        
        public ArticlesServices()
        {
            db = new ArticlesContext();
        }
        public IEnumerable<Models.Articles> GetAll()
        {
            return db.Articles;
        }
    }
}