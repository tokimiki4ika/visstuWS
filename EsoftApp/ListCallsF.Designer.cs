namespace EsoftApp
{
    partial class ListCallsF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.leadsAndCallsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leadsAndCallsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._B_7DataSet = new EsoftApp._B_7DataSet();
            this.leadsAndCallsTableAdapter = new EsoftApp._B_7DataSetTableAdapters.LeadsAndCallsTableAdapter();
            this.tableAdapterManager = new EsoftApp._B_7DataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNCallF = new System.Windows.Forms.Button();
            this.BTNExit = new System.Windows.Forms.Button();
            this.BTNAu = new System.Windows.Forms.Button();
            this.BTNLidsList = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leadsAndCallsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leadsAndCallsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._B_7DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.panel1.Controls.Add(this.BTNLidsList);
            this.panel1.Controls.Add(this.BTNCallF);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 110);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EsoftApp.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.panel2.Controls.Add(this.BTNAu);
            this.panel2.Controls.Add(this.BTNExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 545);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 87);
            this.panel2.TabIndex = 9;
            // 
            // leadsAndCallsDataGridView
            // 
            this.leadsAndCallsDataGridView.AutoGenerateColumns = false;
            this.leadsAndCallsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.leadsAndCallsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.leadsAndCallsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.leadsAndCallsDataGridView.DataSource = this.leadsAndCallsBindingSource;
            this.leadsAndCallsDataGridView.GridColor = System.Drawing.Color.White;
            this.leadsAndCallsDataGridView.Location = new System.Drawing.Point(0, 107);
            this.leadsAndCallsDataGridView.Name = "leadsAndCallsDataGridView";
            this.leadsAndCallsDataGridView.Size = new System.Drawing.Size(1000, 442);
            this.leadsAndCallsDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Login";
            this.dataGridViewTextBoxColumn1.HeaderText = "Пользователь";
            this.dataGridViewTextBoxColumn1.MaxInputLength = 80;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 130;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NomerTelefonaKlienta";
            this.dataGridViewTextBoxColumn2.HeaderText = "Контактные данные лида";
            this.dataGridViewTextBoxColumn2.MaxInputLength = 80;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 230;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DataVremiaZvonkaPoLidy";
            this.dataGridViewTextBoxColumn8.HeaderText = "Дата совершения звонка";
            this.dataGridViewTextBoxColumn8.MaxInputLength = 80;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 230;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "DlitelnostZvonka";
            this.dataGridViewTextBoxColumn9.HeaderText = "Длительность звонка";
            this.dataGridViewTextBoxColumn9.MaxInputLength = 80;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 230;
            // 
            // leadsAndCallsBindingSource
            // 
            this.leadsAndCallsBindingSource.DataMember = "LeadsAndCalls";
            this.leadsAndCallsBindingSource.DataSource = this._B_7DataSet;
            // 
            // _B_7DataSet
            // 
            this._B_7DataSet.DataSetName = "_B_7DataSet";
            this._B_7DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // leadsAndCallsTableAdapter
            // 
            this.leadsAndCallsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LeadsAndCallsTableAdapter = this.leadsAndCallsTableAdapter;
            this.tableAdapterManager.UpdateOrder = EsoftApp._B_7DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.label1.Location = new System.Drawing.Point(404, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список звонков";
            // 
            // BTNCallF
            // 
            this.BTNCallF.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTNCallF.Location = new System.Drawing.Point(698, 12);
            this.BTNCallF.Name = "BTNCallF";
            this.BTNCallF.Size = new System.Drawing.Size(290, 35);
            this.BTNCallF.TabIndex = 7;
            this.BTNCallF.Text = "Переход на форму вызова";
            this.BTNCallF.UseVisualStyleBackColor = true;
            this.BTNCallF.Click += new System.EventHandler(this.BTNCallF_Click);
            // 
            // BTNExit
            // 
            this.BTNExit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTNExit.Location = new System.Drawing.Point(783, 40);
            this.BTNExit.Name = "BTNExit";
            this.BTNExit.Size = new System.Drawing.Size(205, 35);
            this.BTNExit.TabIndex = 8;
            this.BTNExit.Text = "Выйти";
            this.BTNExit.UseVisualStyleBackColor = true;
            this.BTNExit.Click += new System.EventHandler(this.BTNExit_Click);
            // 
            // BTNAu
            // 
            this.BTNAu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTNAu.Location = new System.Drawing.Point(18, 40);
            this.BTNAu.Name = "BTNAu";
            this.BTNAu.Size = new System.Drawing.Size(205, 35);
            this.BTNAu.TabIndex = 9;
            this.BTNAu.Text = "Выйти из учётной записи";
            this.BTNAu.UseVisualStyleBackColor = true;
            this.BTNAu.Click += new System.EventHandler(this.BTNAu_Click);
            // 
            // BTNLidsList
            // 
            this.BTNLidsList.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTNLidsList.Location = new System.Drawing.Point(698, 56);
            this.BTNLidsList.Name = "BTNLidsList";
            this.BTNLidsList.Size = new System.Drawing.Size(290, 35);
            this.BTNLidsList.TabIndex = 12;
            this.BTNLidsList.Text = "Переход на форму лидов";
            this.BTNLidsList.UseVisualStyleBackColor = true;
            this.BTNLidsList.Click += new System.EventHandler(this.BTNLidsList_Click);
            // 
            // ListCallsF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 632);
            this.Controls.Add(this.leadsAndCallsDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListCallsF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список звонков";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ListCallsF_FormClosed);
            this.Load += new System.EventHandler(this.ListCallsF_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leadsAndCallsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leadsAndCallsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._B_7DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private _B_7DataSet _B_7DataSet;
        private System.Windows.Forms.BindingSource leadsAndCallsBindingSource;
        private _B_7DataSetTableAdapters.LeadsAndCallsTableAdapter leadsAndCallsTableAdapter;
        private _B_7DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView leadsAndCallsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNCallF;
        private System.Windows.Forms.Button BTNAu;
        private System.Windows.Forms.Button BTNExit;
        private System.Windows.Forms.Button BTNLidsList;
    }
}