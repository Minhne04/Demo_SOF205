using A_DAL.Models;
using A_DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.Services
{
    public class ParentServices
    {
        ParentRepos repos = new ParentRepos();
        public ParentServices()
        {
        }
        public List<Parent> GetAllParents() { 
            return repos.GetParents();
        }
    }
}
