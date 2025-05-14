using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlockChainValleyFE
{
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent();
        }

        private void LoadContent(UserControl control)
        {
            contentPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(control);
        }

        private void btnManageMembers_Click(object sender, EventArgs e)
        {
            LoadContent(new MemberManagementControl());
        }

        //private void btnManagePosts_Click(object sender, EventArgs e)
        //{
        //    LoadContent(new PostManagementControl());
        //}

        //private void btnRegisterMember_Click(object sender, EventArgs e)
        //{
        //    LoadContent(new MemberRegisterControl());
        //}
    }
}