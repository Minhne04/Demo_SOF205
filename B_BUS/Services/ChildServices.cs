using A_DAL.Models;
using A_DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.Services
{
    public class ChildServices
    {
        ChildRepos _repos = new ChildRepos();
        public ChildServices() { }
        public ChildServices(ChildRepos repos)
        {
            _repos = repos;
        }
        public List<Child> GetAllChild()
        {
            return _repos.GetAllChild().ToList();
        }
        public List<Child> GetChildByName(string name)
        {
            return _repos.GetChildByName(name).ToList();
        }
    }
}
