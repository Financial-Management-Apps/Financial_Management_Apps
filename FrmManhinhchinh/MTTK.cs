using FrmManhinhchinh.Connection;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
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
    public partial class MTTK : Form
    {
        private QLCTDAO con;

        private int currentUserId = -1;
        public MTTK(int currentUserId)
        {
            InitializeComponent();
            this.currentUserId = currentUserId;
            con = new QLCTDAO();
        }

        private void MTTK_Load(object sender, EventArgs e)
        {
            InitializeDgvSavingGoals();
            LoadSavingsGoals();
        }
        private void InitializeDgvSavingGoals()
        {
            dgvMT.Columns.Clear();
            dgvMT.Columns.Add("GoalId", "ID");
            dgvMT.Columns.Add("GoalName", "Tên mục tiêu");
            dgvMT.Columns.Add("TargetAmount", "Tiền mục tiêu");
            dgvMT.Columns.Add("CurrentAmount", "Tiền đang có");
            dgvMT.Columns.Add("DueDate", "Ngày hết hạn");
        }
        private void LoadSavingsGoals()
        {
            try
            {
                var savingsGoals = con.GetSavingsGoals(currentUserId);
                dgvMT.Rows.Clear();
                foreach (var goal in savingsGoals)
                {
                    dgvMT.Rows.Add(
                        goal.GoalId,
                        goal.GoalName,
                        goal.TargetAmount,
                        goal.CurrentAmount,
                        goal.DueDate.ToString("dd-MM-yyyy HH:mm:ss")
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách mục tiêu tiết kiệm: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dueDate;
                if (DateTime.TryParse(txtNgayHH.Text, out dueDate))
                {
                    var newGoal = new ModelTB.DTO.SavingGoal
                    {
                        UserId = currentUserId,
                        GoalName = txtMucTieu.Text,
                        TargetAmount = decimal.Parse(txtTienTietKiem.Text),
                        CurrentAmount = decimal.Parse(txtTienDangCo.Text),
                        DueDate = dueDate
                    };
                    con.AddSavingsGoal(newGoal);
                    con.SendSavingsGoalNotifications(currentUserId);
                    LoadSavingsGoals();
                    MessageBox.Show("Mục tiêu tiết kiệm đã được thêm thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm mục tiêu: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int goalId = (int)dgvMT.SelectedRows[0].Cells[0].Value;
            con.DeleteSavingsGoal(goalId);
            con.SendSavingsGoalNotifications(currentUserId);
            LoadSavingsGoals();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvMT.SelectedRows.Count > 0)
            {
                int goalId = (int)dgvMT.SelectedRows[0].Cells[0].Value;
                var updatedGoal = new ModelTB.DTO.SavingGoal
                {
                    GoalId = goalId,
                    GoalName = txtMucTieu.Text,
                    TargetAmount = decimal.Parse(txtTienTietKiem.Text),
                    CurrentAmount = decimal.Parse(txtTienDangCo.Text),
                    DueDate = DateTime.Parse(txtNgayHH.Text)
                };
                con.UpdateSavingsGoal(updatedGoal);
                con.SendSavingsGoalNotifications(currentUserId);
                MessageBox.Show("Cập nhật mục tiêu thành công");
                LoadSavingsGoals();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mục tiêu để cập nhật.");
            }
        }

        private void dgvMT_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMT.SelectedRows.Count > 0)
            {
                var selectedRow = dgvMT.SelectedRows[0];
                txtMucTieu.Text = selectedRow.Cells["GoalName"].Value.ToString();
                txtTienTietKiem.Text = selectedRow.Cells["TargetAmount"].Value.ToString();
                txtTienDangCo.Text = selectedRow.Cells["CurrentAmount"].Value.ToString();
                txtNgayHH.Text = selectedRow.Cells["DueDate"].Value.ToString();
            }
        }
    }
}
