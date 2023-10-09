using A_DAL.Models;
using A_DAL.Repositories;
using B_BUS.ViewModels;
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
        ParentRepos _prepos = new ParentRepos();
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
        public bool AddNewChild(string name, string age, string address, bool sex, int parentID) // truyền vào các thuộc tính
        {
            var child = new Child
            {
                Name = name,
                Age = Convert.ToInt32(age),
                Address = address,
                Sex = sex,
                ParentId = parentID

            };
            return _repos.CreateChild(child);
        }
        public bool DeleteChild(int Id)
        {
            return _repos.DeleteChild(Id);
        }
        public bool UpdateChild(int Id, string name, string age, string address,
            bool sex, int parentID)
        {
            Child child = new Child
            {
                ChildId = Id,
                Name = name,
                Age = Convert.ToInt32(age),
                Address = address,
                Sex = sex,
                ParentId = parentID
            };
            return _repos.UpdateChild(child);
        }
        // Cách 2: Sử dụng dynamic là kiểu trả về (làm được nhưng phải rất cẩn thận trong
        // việc xác định thuộc tính cần dùng)
        // Về cơ bản cách này và cách đầu tiên có cùng 1 logic nhưng nếu chúng ta sử dụng
        // kiểu dữ liệu là dynamic thì chúng ta có thể áp dụng cho mô hình 3 lớp vì chúng ta
        // xử lý dữ liệu và logic ở các lớp DAL và BUS chứ không hề động đến lớp PRL
        public dynamic GetChildsWithParentName()
        {
            var joinData = from child in _repos.GetAllChild()
                           join parent in _prepos.GetParents()
                           on child.ParentId equals parent.ParentId
                           select new
                           {
                               Name = child.Name,
                               Address = child.Address,
                               Age = child.Age,
                               ParentName = parent.Name
                           };
            return joinData.ToList();
        }
        // Cách 3: Sử dụng ViewModel để làm kiểu dữ liệu trả về
        public List<ChildViewModel> GetChildModels()
        {
            var joinData = from child in _repos.GetAllChild()
                           join parent in _prepos.GetParents()
                           on child.ParentId equals parent.ParentId
                           select new ChildViewModel
                           {
                               Name = child.Name,
                               Address = child.Address,
                               Age = child.Age,
                               ParentName = parent.Name
                           };
            return joinData.ToList();
        }
    }
}
