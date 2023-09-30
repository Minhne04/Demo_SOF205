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
            dtg_Show.DataSource = _service.GetAllChild();
        }

        private void tbt_Search_TextChanged(object sender, EventArgs e)
        {
            dtg_Show.DataSource = _service.GetChildByName(tbt_Search.Text);
        }
    }
}
