using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_SoftWare
{
    public partial class FormManagement : Form
    {
        public FormManagement()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void customizeDesing()
        {
            panelHeThong.Visible = false;
            panelChucNang.Visible = false;
            panelQuanLy.Visible = false;
            
        }

        private void HideMenu()
        {
            if (panelHeThong.Visible == true) panelHeThong.Visible = false;
            if (panelChucNang.Visible == true) panelChucNang.Visible = false;
            if (panelQuanLy.Visible == true) panelQuanLy.Visible = false;
        }

        private void ShowMenu(Panel menu)
        {
            if (menu.Visible == false)
            {
                HideMenu();
                menu.Visible = true;
            }
            else
                menu.Visible = false;
        }

        private void FormManagement_Load(object sender, EventArgs e)
        {

        }

        #region Show/Hide
        private void btnHeThong_Click(object sender, EventArgs e)
        {
            ShowMenu(panelHeThong);
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            openChildForm(new ChangePassForm());
            HideMenu();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            HideMenu();
        }

        private void btnChucNang_Click(object sender, EventArgs e)
        {
            ShowMenu(panelChucNang);
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            HideMenu();
        }

        private void btnNhanPhong_Click(object sender, EventArgs e)
        {
            HideMenu();
        }

        private void btnHuyDatPhong_Click(object sender, EventArgs e)
        {
            HideMenu();
        }

        private void btnTraPhong_Click(object sender, EventArgs e)
        {
            HideMenu();
        }

        private void btnDichVuPhong_Click(object sender, EventArgs e)
        {
            HideMenu();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            HideMenu();
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            ShowMenu(panelQuanLy);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            HideMenu();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            HideMenu();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            HideMenu();
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            HideMenu();
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            openChildForm(new QLDichVuForm());
            HideMenu();
        }
        #endregion


        private void btnStatusRoom_Click(object sender, EventArgs e)
        {
            openChildForm(new RoomStatusForm());
            HideMenu();
        }


        private void btnThongKe_Click(object sender, EventArgs e)
        {
            HideMenu();
        }

        //private void openChildForm<listForm>() where listForm : Form, new()
        //{
        //    Form childForm;
        //    childForm = panelChildForm.Controls.OfType<listForm>().FirstOrDefault();
        //    if (childForm == null)
        //    {
        //        childForm = new listForm();
        //        childForm.TopLevel = false;
        //        childForm.FormBorderStyle = FormBorderStyle.None;
        //        childForm.Dock = DockStyle.Fill;
        //        panelChildForm.Controls.Add(childForm);
        //        panelChildForm.Tag = childForm;
        //        childForm.Show();
        //    }
        //    else
        //    {
        //        childForm.Close();
        //        childForm.BringToFront();
                
        //    }
        //}
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelChildForm.Controls.Add(childForm);
                panelChildForm.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();

        }
    }
}
