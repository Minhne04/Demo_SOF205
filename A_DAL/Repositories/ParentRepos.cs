using A_DAL.IRepositories;
using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Repositories
{
    public class ParentRepos : IParentRepos
    {
        Relation_DbfirstContext _context = new Relation_DbfirstContext();
        public ParentRepos()
        {

        }
        public List<Parent> GetParents()
        {
            return _context.Parents.ToList();
        }
    }
}
