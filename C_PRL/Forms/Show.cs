using B_BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_PRL.Forms
{
    public partial class Show : Form
    {
        ChildServices _service = new ChildServices();
        public Show()
        {
            _service = new ChildServices();
            InitializeComponent();
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            dtg_Show.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Auto kích cỡ
            int stt = 1; // đánh số thứ tự tự tăng
            dtg_Show.ColumnCount = 6; // đánh xem datagrid view sẽ có bao nhiêu cột
            // ĐỊnh dạng datagridview (Tên cột, Text hiển thị của cột
            dtg_Show.Columns[0].Name = "stt"; dtg_Show.Columns[0].HeaderText = "Số thứ tự";
            dtg_Show.Columns[1].Name = "name"; dtg_Show.Columns[1].HeaderText = "Tên";
            dtg_Show.Columns[2].Name = "age"; dtg_Show.Columns[2].HeaderText = "Tuổi";
            dtg_Show.Columns[3].Name = "address"; dtg_Show.Columns[3].HeaderText = "Địa chỉ";
            dtg_Show.Columns[4].Name = "sex"; dtg_Show.Columns[4].HeaderText = "Giới tính";
            dtg_Show.Columns[5].Name = "id";
            dtg_Show.Columns[5].Visible = false; // ẩn cột ID để không thấy
            // dtg_Show.DataSource = _service.GetAllChild();
            // Đẩy data vào dtg
            foreach (var item in _service.GetAllChild())
            {
                dtg_Show.Rows.Add(stt++, item.Name, item.Age, item.Address,
                    item.Sex ? "Nam" : "Nữ", item.ChildId); // Dùng toán tử 3 ngôi để định giới tính
            }
            // Dùng toán tử 3 ngôi để định giới tính
        }

        private void tbt_Search_TextChanged(object sender, EventArgs e)
        {
            dtg_Show.DataSource = _service.GetChildByName(tbt_Search.Text);
        }

        private void dtg_Show_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
