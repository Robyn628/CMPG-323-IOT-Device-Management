using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using DeviceManagement_WebApp.Project3_Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DeviceManagement_WebApp.Project3_Repo_s
{
    public class RepoCategories : RepoGenerics<Category>, CategoriesInterface
    {
        public RepoCategories(ConnectedOfficeContext context) : base(context)
        {
        }
        public new List<Category> GetAll()
        {
            return _context.Category.ToList();
        }
    }
}
