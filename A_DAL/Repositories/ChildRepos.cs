using A_DAL.IRepositories;
using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Repositories
{
    public class ChildRepos : IChildRepos
    {
        // Tạo Constructor
        Relation_DbfirstContext _context = new Relation_DbfirstContext();
        public ChildRepos()
        {
        }
        public ChildRepos(Relation_DbfirstContext context)
        {
            _context = context;
        }
        public bool CreateChild(Child child)
        {
            return true;
        }

        public bool DeleteChild(Guid ID)
        {
            return true;
        }

        public IEnumerable<Child> GetAllChild()
        {
            return _context.Children.ToList();
            // _context là đối tượng dbContext
            // _context.Children là DBSet ứng với Bảng Children
            // ToList để dữ liệu lấy được convert sang dạng List
        }
        // Tìm kiếm theo tên mà có chứa chuỗi name vừa nhập vào
        public List<Child> GetChildByName(string name)
        {
            return _context.Children.Where(p => p.Name.Contains(name)).ToList();
            // p ở trong biếu thức lambda expression là một định danh đại diện
            // cho một đối tượng trong DBset
            // p.Name.Contains(name) là điều kiện để thực hiện truy vấn
            // Where đánh dấu điều kiện
        }

        public bool UpdateChild(Child child)
        {
            return true;
        }
    }
}
