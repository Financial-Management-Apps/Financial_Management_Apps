using FrmManhinhchinh.Data;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmManhinhchinh
{
    public partial class User : Form
    {
        private Form activeForm;
        private NguoiDung currentUser;
        public User(NguoiDung user)
        {
            InitializeComponent();
            currentUser = user;
        }
        private void OpenChildForm(Form childForm, object sender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelUser.Controls.Add(childForm);
            this.panelUser.Tag = childForm; childForm.BringToFront();
            childForm.Show();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GYCTpopup(), sender);
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {

            OpenChildForm(new TTCNpopup(currentUser), sender);

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Notification(currentUser.ID), sender);
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MTTK(currentUser.ID), sender);
            OpenChildForm(new GYCT2(), sender);
        }
    }
}
