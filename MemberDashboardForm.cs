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
    public partial class MemberDashboardForm: Form
    {
        public MemberDashboardForm()
        {
            InitializeComponent();
        }

        private void btnViewMyTeamBoard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("내 팀 게시판 보기 버튼 클릭됨!");

            // TODO: 실제 팀 게시판 폼 열기 등 구현
            // new TeamBoardForm().ShowDialog();
        }

    }
}
