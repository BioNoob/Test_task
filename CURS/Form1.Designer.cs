namespace CURS
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.getCurse_btn = new System.Windows.Forms.Button();
            this.dGV_out = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Update_table_btn = new System.Windows.Forms.Button();
            this.nominal_chbx = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Update_direct_btn = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.del_req_base_btn = new System.Windows.Forms.Button();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.Cond_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.base_dGV = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_out)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.base_dGV)).BeginInit();
            this.SuspendLayout();
            // 
            // getCurse_btn
            // 
            this.getCurse_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.getCurse_btn.Location = new System.Drawing.Point(144, 9);
            this.getCurse_btn.Name = "getCurse_btn";
            this.getCurse_btn.Size = new System.Drawing.Size(148, 23);
            this.getCurse_btn.TabIndex = 1;
            this.getCurse_btn.Text = "Получить таблицу курсов";
            this.getCurse_btn.UseVisualStyleBackColor = true;
            this.getCurse_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // dGV_out
            // 
            this.dGV_out.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV_out.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGV_out.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dGV_out.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_out.Location = new System.Drawing.Point(3, 66);
            this.dGV_out.Name = "dGV_out";
            this.dGV_out.Size = new System.Drawing.Size(296, 140);
            this.dGV_out.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 11);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(97, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Value = new System.DateTime(2019, 9, 23, 16, 47, 2, 0);
            // 
            // Update_table_btn
            // 
            this.Update_table_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Update_table_btn.Enabled = false;
            this.Update_table_btn.Location = new System.Drawing.Point(0, 212);
            this.Update_table_btn.Name = "Update_table_btn";
            this.Update_table_btn.Size = new System.Drawing.Size(301, 26);
            this.Update_table_btn.TabIndex = 2;
            this.Update_table_btn.Text = "Запись из таблицы";
            this.Update_table_btn.UseVisualStyleBackColor = true;
            this.Update_table_btn.Click += new System.EventHandler(this.ToUpload_btn_Click);
            // 
            // nominal_chbx
            // 
            this.nominal_chbx.AutoSize = true;
            this.nominal_chbx.Location = new System.Drawing.Point(12, 37);
            this.nominal_chbx.Name = "nominal_chbx";
            this.nominal_chbx.Size = new System.Drawing.Size(135, 17);
            this.nominal_chbx.TabIndex = 4;
            this.nominal_chbx.Text = "расчитывать единицу";
            this.nominal_chbx.UseVisualStyleBackColor = true;
            this.nominal_chbx.CheckStateChanged += new System.EventHandler(this.nominal_chbx_CheckStateChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.getCurse_btn);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.nominal_chbx);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 61);
            this.panel1.TabIndex = 5;
            // 
            // Update_direct_btn
            // 
            this.Update_direct_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Update_direct_btn.Location = new System.Drawing.Point(0, 238);
            this.Update_direct_btn.Name = "Update_direct_btn";
            this.Update_direct_btn.Size = new System.Drawing.Size(301, 26);
            this.Update_direct_btn.TabIndex = 3;
            this.Update_direct_btn.Text = "Запись напрямую";
            this.toolTip1.SetToolTip(this.Update_direct_btn, "Запсиать на прямую из источника в базу данных,\r\nбез использования буферной таблиц" +
        "ы");
            this.Update_direct_btn.UseVisualStyleBackColor = true;
            this.Update_direct_btn.Click += new System.EventHandler(this.Update_direct_btn_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.Update_table_btn);
            this.splitContainer1.Panel1.Controls.Add(this.Update_direct_btn);
            this.splitContainer1.Panel1.Controls.Add(this.dGV_out);
            this.splitContainer1.Panel1MinSize = 301;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.del_req_base_btn);
            this.splitContainer1.Panel2.Controls.Add(this.refresh_btn);
            this.splitContainer1.Panel2.Controls.Add(this.Cond_lbl);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.base_dGV);
            this.splitContainer1.Panel2MinSize = 0;
            this.splitContainer1.Size = new System.Drawing.Size(562, 264);
            this.splitContainer1.SplitterDistance = 301;
            this.splitContainer1.TabIndex = 6;
            // 
            // del_req_base_btn
            // 
            this.del_req_base_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.del_req_base_btn.Location = new System.Drawing.Point(183, 2);
            this.del_req_base_btn.Name = "del_req_base_btn";
            this.del_req_base_btn.Size = new System.Drawing.Size(71, 23);
            this.del_req_base_btn.TabIndex = 6;
            this.del_req_base_btn.Text = "Удалить";
            this.del_req_base_btn.UseVisualStyleBackColor = true;
            this.del_req_base_btn.Click += new System.EventHandler(this.Del_req_base_btn_Click);
            // 
            // refresh_btn
            // 
            this.refresh_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.refresh_btn.Location = new System.Drawing.Point(183, 240);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(71, 23);
            this.refresh_btn.TabIndex = 5;
            this.refresh_btn.Text = "Обновить";
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.Refresh_btn_Click);
            // 
            // Cond_lbl
            // 
            this.Cond_lbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Cond_lbl.Location = new System.Drawing.Point(0, 239);
            this.Cond_lbl.Name = "Cond_lbl";
            this.Cond_lbl.Size = new System.Drawing.Size(257, 25);
            this.Cond_lbl.TabIndex = 4;
            this.Cond_lbl.Text = "Состояние:  ";
            this.Cond_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cond_lbl.TextChanged += new System.EventHandler(this.Cond_lbl_TextChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Данные из базы данных";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // base_dGV
            // 
            this.base_dGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.base_dGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.base_dGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.base_dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.base_dGV.Location = new System.Drawing.Point(3, 30);
            this.base_dGV.Name = "base_dGV";
            this.base_dGV.Size = new System.Drawing.Size(251, 206);
            this.base_dGV.TabIndex = 2;
            // 
            // Form1
            // 
            this.AcceptButton = this.getCurse_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 264);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(578, 303);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Загрузка курса";
            ((System.ComponentModel.ISupportInitialize)(this.dGV_out)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.base_dGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getCurse_btn;
        private System.Windows.Forms.DataGridView dGV_out;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Update_table_btn;
        private System.Windows.Forms.CheckBox nominal_chbx;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Update_direct_btn;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView base_dGV;
        private System.Windows.Forms.Label Cond_lbl;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.Button del_req_base_btn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

