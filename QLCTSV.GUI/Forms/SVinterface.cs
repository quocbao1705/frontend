using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCTSV.GUI
{
    public partial class SVinterface: Form
    {
        SVdiem svdiem;
        SVhocBong svhocBong;
        public SVinterface()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void SVinterface_Load(object sender, EventArgs e)
        {

        }

        
        private void CloseAllChildForms()
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }
        }
        private void button_SVhocbong_Click(object sender, EventArgs e)
        {
            if (svhocBong != null)
            {
                svhocBong.Activate();
                return;
            }

            CloseAllChildForms();

            if (svhocBong == null)
            {
                svhocBong = new SVhocBong();
                svhocBong.FormClosed += SVHocBong_FormClosed;
                svhocBong.MdiParent = this;
                svhocBong.Dock = DockStyle.Fill;
                svhocBong.Show();
            }
            else
            {
                svhocBong.Activate();
            }
        }

        private void SVHocBong_FormClosed(object sender, FormClosedEventArgs e)
        {
            svhocBong = null;
        }

        private void button_SVdiem_Click(object sender, EventArgs e)
        {
            if (svdiem != null)
            {
                svdiem.Activate();
                return;
            }

            CloseAllChildForms();

            if (svdiem == null)
            {
                svdiem = new SVdiem();
                svdiem.FormClosed += SVdiem_FormClosed;
                svdiem.MdiParent = this;
                svdiem.Dock = DockStyle.Fill;
                svdiem.Show();
            }
            else
            {
                svdiem.Activate();
            }
        }

        private void SVdiem_FormClosed(object sender, FormClosedEventArgs e)
        {
            svdiem = null;
        }

        bool sidebarExpand = true;

        private void SVTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebarSV.Width -= 10;
                if (sidebarSV.Width <= 80)
                {
                    sidebarExpand = false;
                    SVTransition.Stop();

                    panel_SVdiem.Width = sidebarSV.Width;
                    panel_SVhocbong.Width = sidebarSV.Width;
                    panel_logout.Width = sidebarSV.Width;
                }
            }
            else
            {
                sidebarSV.Width += 10;
                if (sidebarSV.Width >= 280)
                {
                    sidebarExpand = true;
                    SVTransition.Stop();

                    panel_SVdiem.Width = sidebarSV.Width;
                    panel_SVhocbong.Width = sidebarSV.Width;
                    panel_logout.Width = sidebarSV.Width;
                }
            }
        }

        private void btn_SVmenu_Click(object sender, EventArgs e)
        {
            SVTransition.Start();
        }

        private void sidebarSV_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
