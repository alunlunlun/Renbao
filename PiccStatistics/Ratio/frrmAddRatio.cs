using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PiccStatistics.Ratio
{
    public partial class frrmAddRatio : Office2007Form
    {
        public frrmAddRatio()
        {
            InitializeComponent();
            this.EnableGlass = false;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbox.Items.Count; i++)
            {
                lbox.SelectedIndex = i;
            }
        }

        private void btnNoAll_Click(object sender, EventArgs e)
        {
            lbox.ClearSelected();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dtpStart.Value.ToShortDateString() == "")
            {
                MsgBox.Show("请选择开始日期!", "提示", MsgBox.MyButtons.OK, MsgBox.MyIcon.Information);
                dtpStart.Focus();
                return;
            }

            if (dtpStart.Value.ToShortDateString() == "")
            {
                MsgBox.Show("请选择结束日期!", "提示", MsgBox.MyButtons.OK, MsgBox.MyIcon.Information);
                dtpEnd.Focus();
                return;
            }

            if (tbJQ.Text.Trim() == "")
            {
                MsgBox.Show("请输入交强日比例!", "提示", MsgBox.MyButtons.OK, MsgBox.MyIcon.Information);
                tbJQ.Focus();
                return;
            }

            if (tbXS.Text.Trim() == "")
            {
                MsgBox.Show("请输入新商日比例!", "提示", MsgBox.MyButtons.OK, MsgBox.MyIcon.Information);
                tbXS.Focus();
                return;
            }
            if (tbXUS.Text.Trim() == "")
            {
                MsgBox.Show("请输入续商日比例!", "提示", MsgBox.MyButtons.OK, MsgBox.MyIcon.Information);
                tbXUS.Focus();
                return;
            }
            if (tbZS.Text.Trim() == "")
            {
                MsgBox.Show("请输入转商日比例!", "提示", MsgBox.MyButtons.OK, MsgBox.MyIcon.Information);
                tbZS.Focus();
                return;
            }
            if ((dtpEnd.Value - dtpStart.Value).Days < 0)
            {
                MsgBox.Show("结束日期必须大于开始日期!", "提示", MsgBox.MyButtons.OK, MsgBox.MyIcon.Information);
                dtpEnd.Focus();
                return;
            }
            if ((dtpEnd.Value - dtpStart.Value).Days == 0)
            {
                foreach (DataRowView item in lbox.SelectedItems)
                {
                    Maticsoft.DBUtility.DbHelperOleDb.ExecuteSql("delete * from bili where riqi=#" + dtpStart.Value.ToShortDateString() + "# and shopcode='" + item["code"].ToString() + "'");
                    Classes.Ratio.Add(dtpStart.Value.ToShortDateString(), double.Parse(tbJQ.Text), double.Parse(tbXS.Text), double.Parse(tbXUS.Text), double.Parse(tbXUS1.Text), double.Parse(tbXUS2.Text), double.Parse(tbXUS3.Text), double.Parse(tbXUS4.Text), double.Parse(tbXUS5.Text), double.Parse(tbZS.Text), double.Parse(tbZS1.Text), double.Parse(tbZS2.Text), double.Parse(tbZS3.Text), double.Parse(tbZS4.Text), item["code"].ToString(), item["shopname"].ToString());
                }
                MsgBox.Show("添加成功!", "提示", MsgBox.MyButtons.OK, MsgBox.MyIcon.Information);
                frmRatio frm1 = (frmRatio)this.Owner;
                frm1.refreshData();
                this.Close();
                return;
            }

            for (int i = 0; i < (dtpEnd.Value - dtpStart.Value).Days + 1; i++)
            {
                foreach (DataRowView item in lbox.SelectedItems)
                {
                    Maticsoft.DBUtility.DbHelperOleDb.ExecuteSql("delete * from bili where riqi=#" + dtpStart.Value.AddDays(i).ToShortDateString() + "#");
                    Classes.Ratio.Add(dtpStart.Value.ToShortDateString(), double.Parse(tbJQ.Text), double.Parse(tbXS.Text), double.Parse(tbXUS.Text), double.Parse(tbXUS1.Text), double.Parse(tbXUS2.Text), double.Parse(tbXUS3.Text), double.Parse(tbXUS4.Text), double.Parse(tbXUS5.Text), double.Parse(tbZS.Text), double.Parse(tbZS1.Text), double.Parse(tbZS2.Text), double.Parse(tbZS3.Text), double.Parse(tbZS4.Text), item["code"].ToString(), item["shopname"].ToString());
                }
            }
            MsgBox.Show("添加成功!", "提示", MsgBox.MyButtons.OK, MsgBox.MyIcon.Information);
            frmRatio frm = (frmRatio)this.Owner;
            frm.refreshData();
            this.Close();
        }

        private void frrmAddRatio_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = Maticsoft.DBUtility.DbHelperOleDb.Query("select * from shop");
            lbox.DataSource = ds.Tables[0];
            lbox.DisplayMember = "shopname";
            lbox.ValueMember = "code";

            cmbType.Items.Add(new ComboBoxItem("6", "新车"));
            cmbType.Items.Add(new ComboBoxItem("1", "转保"));
            cmbType.Items.Add(new ComboBoxItem("-1", "续保"));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
