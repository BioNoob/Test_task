using CURS.Class;
using System;
using System.Windows.Forms;

namespace CURS
{
    public partial class Form1 : Form
    {
        string intcond;
        public Form1()
        {
            InitializeComponent();
            intcond = Cond_lbl.Text;
            dateTimePicker1.Value = DateTime.Now;
            try
            {
                base_dGV.DataSource = CurrencyBuilder.LoadBase();
                Cond_lbl.Text += "Загружено";
            }
            catch(Exception e)
            {
                Cond_lbl.Text += e.Message;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dGV_out.DataSource = CurrencyBuilder.Former(dateTimePicker1.Value);
            Update_table_btn.Enabled = true;
        }

        private void ToUpload_btn_Click(object sender, EventArgs e)
        {
            Cond_lbl.Text = intcond;
            try
            {
                CurrencyBuilder.UpdateBase_fromTable((System.Data.DataTable)dGV_out.DataSource);
                Cond_lbl.Text += "Запись произошла";
            }
            catch (Exception ee)
            {
                Cond_lbl.Text += ee.Message;
            }

        }

        private void nominal_chbx_CheckStateChanged(object sender, EventArgs e)
        {
            Options.opt.nominal = nominal_chbx.CheckState == CheckState.Checked ? true : false;
        }

        private void Update_direct_btn_Click(object sender, EventArgs e)
        {
            Cond_lbl.Text = intcond;
            try
            {
                CurrencyBuilder.UpdateBase_fromTable_xml(dateTimePicker1.Value);
                Cond_lbl.Text += "Запись произошла";
            }
            catch (Exception ee)
            {
                Cond_lbl.Text += ee.Message;
            }
        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Cond_lbl.Text = intcond;
                base_dGV.DataSource = CurrencyBuilder.LoadBase();
                Cond_lbl.Text += "Обновлено";
            }
            catch (Exception ee)
            {
                Cond_lbl.Text += ee.Message;
            }

        }

        private void Del_req_base_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Cond_lbl.Text = intcond;
                base_dGV.DataSource = CurrencyBuilder.ClearBase();
                Cond_lbl.Text += "Обновлено";
            }
            catch (Exception ee)
            {
                Cond_lbl.Text += ee.Message;
            }
        }
    }
}
