using System;
using System.Windows.Forms;

namespace lesson3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dgvSchedule_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = dgvSchedule.Rows[e.RowIndex];
                if (row == null) return;
                var lecCell = row.Cells["LecUnits"];
                var labCell = row.Cells["LabUnits"];
                var credCell = row.Cells["CredUnits"];
                double lec = 0, lab = 0;
                double.TryParse(Convert.ToString(lecCell.Value), out lec);
                double.TryParse(Convert.ToString(labCell.Value), out lab);
                credCell.Value = (lec + lab).ToString("0.##");
                UpdateTotalCredits();
            }
            catch { }
        }

        private void UpdateTotalCredits()
        {
            double total = 0;
            foreach (DataGridViewRow r in dgvSchedule.Rows)
            {
                if (r.IsNewRow) continue;
                double c = 0;
                double.TryParse(Convert.ToString(r.Cells["CredUnits"].Value), out c);
                total += c;
            }
            txtTotalCred.Text = total.ToString("0.##");
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            const double lectureFee = 1500.0;
            const double laboratoryFee = 2500.0;
            const double ciscoFee = 4500.0;
            const double examFee = 450.0;
            const double sapFee = 2000.0;

            double totalLectureUnits = 0, totalLabUnits = 0;
            foreach (DataGridViewRow r in dgvSchedule.Rows)
            {
                if (r.IsNewRow) continue;
                double lec = 0, lab = 0;
                double.TryParse(Convert.ToString(r.Cells["LecUnits"].Value), out lec);
                double.TryParse(Convert.ToString(r.Cells["LabUnits"].Value), out lab);
                totalLectureUnits += lec;
                totalLabUnits += lab;
            }

            double tuition = totalLectureUnits * lectureFee;
            double comLab = totalLabUnits * laboratoryFee;

            txtTuition.Text = tuition.ToString("0.00");
            txtComLab.Text = comLab.ToString("0.00");
            txtCisco.Text = ciscoFee.ToString("0.00");
            txtSAP.Text = sapFee.ToString("0.00");
            txtExam.Text = examFee.ToString("0.00");

            double totalOther = comLab + ciscoFee + sapFee + examFee;
            txtTotalOther.Text = totalOther.ToString("0.00");
            txtMisc.Text = totalOther.ToString("0.00");

            double totalFees = tuition + totalOther;
            txtTotalFees.Text = totalFees.ToString("0.00");

            double discount = 0;
            double.TryParse(txtDiscount.Text, out discount);
            double totalAfterDiscount = totalFees - discount;
            if (totalAfterDiscount < 0) totalAfterDiscount = 0;

            if (cboMode != null && cboMode.SelectedItem != null && cboMode.SelectedItem.ToString() == "Installment")
            {
                double downpayment = 8000.0;
                if (downpayment > totalAfterDiscount) downpayment = totalAfterDiscount;
                double remaining = totalAfterDiscount - downpayment;
                double installment = remaining > 0 ? Math.Round(remaining / 3.0, 2) : 0.0;
                txtAmountDue.Text = downpayment.ToString("0.00");
            }
            else
            {
                txtAmountDue.Text = totalAfterDiscount.ToString("0.00");
            }

            UpdateTotalCredits();
        }

        private void btnClearStudent_Click(object sender, EventArgs e)
        {
            txtStudentName.Text = string.Empty;
            txtStudentNo.Text = string.Empty;
            cboProgram.SelectedIndex = -1;
            cboYear.SelectedIndex = -1;
            dtpDateEnrolled.Value = DateTime.Today;
            txtScholar.Text = string.Empty;
            if (cboMode.Items.Count > 0) cboMode.SelectedIndex = 0;
        }

        private void btnClearSchedule_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgvSchedule.Rows)
            {
                foreach (DataGridViewCell c in r.Cells) c.Value = null;
            }
            UpdateTotalCredits();
            txtTuition.Text = string.Empty;
            txtTotalOther.Text = string.Empty;
            txtTotalFees.Text = string.Empty;
            txtAmountDue.Text = string.Empty;
            txtComLab.Text = string.Empty;
            txtSAP.Text = string.Empty;
            txtCisco.Text = string.Empty;
            txtExam.Text = string.Empty;
            txtMisc.Text = "0";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
