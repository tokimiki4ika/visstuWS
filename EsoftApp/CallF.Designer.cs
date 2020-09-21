namespace EsoftApp
{
    partial class CallF
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
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label nomerTelefonaKlientaLabel;
            System.Windows.Forms.Label dataVremiaZvonkaPoLidyLabel;
            System.Windows.Forms.Label dlitelnostZvonkaLabel;
            System.Windows.Forms.Label kommentsLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CallF));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._B_7DataSet = new EsoftApp._B_7DataSet();
            this.leadsAndCallsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leadsAndCallsTableAdapter = new EsoftApp._B_7DataSetTableAdapters.LeadsAndCallsTableAdapter();
            this.tableAdapterManager = new EsoftApp._B_7DataSetTableAdapters.TableAdapterManager();
            this.leadsAndCallsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.leadsAndCallsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.nomerTelefonaKlientaTextBox = new System.Windows.Forms.TextBox();
            this.dataVremiaZvonkaPoLidyTextBox = new System.Windows.Forms.TextBox();
            this.dlitelnostZvonkaTextBox = new System.Windows.Forms.TextBox();
            this.kommentsTextBox = new System.Windows.Forms.TextBox();
            this.BTNListCallsF = new System.Windows.Forms.Button();
            loginLabel = new System.Windows.Forms.Label();
            nomerTelefonaKlientaLabel = new System.Windows.Forms.Label();
            dataVremiaZvonkaPoLidyLabel = new System.Windows.Forms.Label();
            dlitelnostZvonkaLabel = new System.Windows.Forms.Label();
            kommentsLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._B_7DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leadsAndCallsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leadsAndCallsBindingNavigator)).BeginInit();
            this.leadsAndCallsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new System.Drawing.Point(122, 164);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(271, 19);
            loginLabel.TabIndex = 10;
            loginLabel.Text = "Пользователь совершивший звонок";
            // 
            // nomerTelefonaKlientaLabel
            // 
            nomerTelefonaKlientaLabel.AutoSize = true;
            nomerTelefonaKlientaLabel.Location = new System.Drawing.Point(122, 239);
            nomerTelefonaKlientaLabel.Name = "nomerTelefonaKlientaLabel";
            nomerTelefonaKlientaLabel.Size = new System.Drawing.Size(273, 19);
            nomerTelefonaKlientaLabel.TabIndex = 12;
            nomerTelefonaKlientaLabel.Text = "Лид, которому был совешен звонок";
            // 
            // dataVremiaZvonkaPoLidyLabel
            // 
            dataVremiaZvonkaPoLidyLabel.AutoSize = true;
            dataVremiaZvonkaPoLidyLabel.Location = new System.Drawing.Point(122, 308);
            dataVremiaZvonkaPoLidyLabel.Name = "dataVremiaZvonkaPoLidyLabel";
            dataVremiaZvonkaPoLidyLabel.Size = new System.Drawing.Size(146, 19);
            dataVremiaZvonkaPoLidyLabel.TabIndex = 24;
            dataVremiaZvonkaPoLidyLabel.Text = "Дата время звонка";
            // 
            // dlitelnostZvonkaLabel
            // 
            dlitelnostZvonkaLabel.AutoSize = true;
            dlitelnostZvonkaLabel.Location = new System.Drawing.Point(122, 376);
            dlitelnostZvonkaLabel.Name = "dlitelnostZvonkaLabel";
            dlitelnostZvonkaLabel.Size = new System.Drawing.Size(191, 19);
            dlitelnostZvonkaLabel.TabIndex = 26;
            dlitelnostZvonkaLabel.Text = "Длительность разговора";
            // 
            // kommentsLabel
            // 
            kommentsLabel.AutoSize = true;
            kommentsLabel.Location = new System.Drawing.Point(122, 444);
            kommentsLabel.Name = "kommentsLabel";
            kommentsLabel.Size = new System.Drawing.Size(108, 19);
            kommentsLabel.TabIndex = 28;
            kommentsLabel.Text = "Комментарий";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.label1.Location = new System.Drawing.Point(473, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Интерфейс звонка";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 590);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1082, 68);
            this.panel2.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.panel1.Controls.Add(this.BTNListCallsF);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 94);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EsoftApp.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(18, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // _B_7DataSet
            // 
            this._B_7DataSet.DataSetName = "_B_7DataSet";
            this._B_7DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // leadsAndCallsBindingSource
            // 
            this.leadsAndCallsBindingSource.DataMember = "LeadsAndCalls";
            this.leadsAndCallsBindingSource.DataSource = this._B_7DataSet;
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
            // leadsAndCallsBindingNavigator
            // 
            this.leadsAndCallsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.leadsAndCallsBindingNavigator.BindingSource = this.leadsAndCallsBindingSource;
            this.leadsAndCallsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.leadsAndCallsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.leadsAndCallsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.leadsAndCallsBindingNavigatorSaveItem});
            this.leadsAndCallsBindingNavigator.Location = new System.Drawing.Point(0, 94);
            this.leadsAndCallsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.leadsAndCallsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.leadsAndCallsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.leadsAndCallsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.leadsAndCallsBindingNavigator.Name = "leadsAndCallsBindingNavigator";
            this.leadsAndCallsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.leadsAndCallsBindingNavigator.Size = new System.Drawing.Size(1082, 25);
            this.leadsAndCallsBindingNavigator.TabIndex = 10;
            this.leadsAndCallsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // leadsAndCallsBindingNavigatorSaveItem
            // 
            this.leadsAndCallsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.leadsAndCallsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("leadsAndCallsBindingNavigatorSaveItem.Image")));
            this.leadsAndCallsBindingNavigatorSaveItem.Name = "leadsAndCallsBindingNavigatorSaveItem";
            this.leadsAndCallsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.leadsAndCallsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.leadsAndCallsBindingNavigatorSaveItem.Click += new System.EventHandler(this.leadsAndCallsBindingNavigatorSaveItem_Click_2);
            // 
            // loginTextBox
            // 
            this.loginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leadsAndCallsBindingSource, "Login", true));
            this.loginTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.loginTextBox.Location = new System.Drawing.Point(421, 164);
            this.loginTextBox.Multiline = true;
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(278, 30);
            this.loginTextBox.TabIndex = 11;
            // 
            // nomerTelefonaKlientaTextBox
            // 
            this.nomerTelefonaKlientaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leadsAndCallsBindingSource, "NomerTelefonaKlienta", true));
            this.nomerTelefonaKlientaTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.nomerTelefonaKlientaTextBox.Location = new System.Drawing.Point(421, 239);
            this.nomerTelefonaKlientaTextBox.Multiline = true;
            this.nomerTelefonaKlientaTextBox.Name = "nomerTelefonaKlientaTextBox";
            this.nomerTelefonaKlientaTextBox.Size = new System.Drawing.Size(278, 30);
            this.nomerTelefonaKlientaTextBox.TabIndex = 13;
            // 
            // dataVremiaZvonkaPoLidyTextBox
            // 
            this.dataVremiaZvonkaPoLidyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leadsAndCallsBindingSource, "DataVremiaZvonkaPoLidy", true));
            this.dataVremiaZvonkaPoLidyTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.dataVremiaZvonkaPoLidyTextBox.Location = new System.Drawing.Point(421, 308);
            this.dataVremiaZvonkaPoLidyTextBox.Multiline = true;
            this.dataVremiaZvonkaPoLidyTextBox.Name = "dataVremiaZvonkaPoLidyTextBox";
            this.dataVremiaZvonkaPoLidyTextBox.Size = new System.Drawing.Size(278, 30);
            this.dataVremiaZvonkaPoLidyTextBox.TabIndex = 25;
            // 
            // dlitelnostZvonkaTextBox
            // 
            this.dlitelnostZvonkaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leadsAndCallsBindingSource, "DlitelnostZvonka", true));
            this.dlitelnostZvonkaTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.dlitelnostZvonkaTextBox.Location = new System.Drawing.Point(421, 376);
            this.dlitelnostZvonkaTextBox.Multiline = true;
            this.dlitelnostZvonkaTextBox.Name = "dlitelnostZvonkaTextBox";
            this.dlitelnostZvonkaTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dlitelnostZvonkaTextBox.Size = new System.Drawing.Size(278, 30);
            this.dlitelnostZvonkaTextBox.TabIndex = 27;
            // 
            // kommentsTextBox
            // 
            this.kommentsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leadsAndCallsBindingSource, "Komments", true));
            this.kommentsTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.kommentsTextBox.Location = new System.Drawing.Point(421, 444);
            this.kommentsTextBox.Multiline = true;
            this.kommentsTextBox.Name = "kommentsTextBox";
            this.kommentsTextBox.Size = new System.Drawing.Size(278, 30);
            this.kommentsTextBox.TabIndex = 29;
            // 
            // BTNListCallsF
            // 
            this.BTNListCallsF.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTNListCallsF.Location = new System.Drawing.Point(780, 18);
            this.BTNListCallsF.Name = "BTNListCallsF";
            this.BTNListCallsF.Size = new System.Drawing.Size(290, 35);
            this.BTNListCallsF.TabIndex = 25;
            this.BTNListCallsF.Text = "Переход на форму список звонков";
            this.BTNListCallsF.UseVisualStyleBackColor = true;
            this.BTNListCallsF.Click += new System.EventHandler(this.BTNListCallsF_Click);
            // 
            // CallF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1082, 658);
            this.Controls.Add(loginLabel);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(nomerTelefonaKlientaLabel);
            this.Controls.Add(this.nomerTelefonaKlientaTextBox);
            this.Controls.Add(dataVremiaZvonkaPoLidyLabel);
            this.Controls.Add(this.dataVremiaZvonkaPoLidyTextBox);
            this.Controls.Add(dlitelnostZvonkaLabel);
            this.Controls.Add(this.dlitelnostZvonkaTextBox);
            this.Controls.Add(kommentsLabel);
            this.Controls.Add(this.kommentsTextBox);
            this.Controls.Add(this.leadsAndCallsBindingNavigator);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CallF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CallF";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CallF_FormClosed);
            this.Load += new System.EventHandler(this.CallF_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._B_7DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leadsAndCallsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leadsAndCallsBindingNavigator)).EndInit();
            this.leadsAndCallsBindingNavigator.ResumeLayout(false);
            this.leadsAndCallsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private _B_7DataSet _B_7DataSet;
        private System.Windows.Forms.BindingSource leadsAndCallsBindingSource;
        private _B_7DataSetTableAdapters.LeadsAndCallsTableAdapter leadsAndCallsTableAdapter;
        private _B_7DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator leadsAndCallsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton leadsAndCallsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox nomerTelefonaKlientaTextBox;
        private System.Windows.Forms.TextBox dataVremiaZvonkaPoLidyTextBox;
        private System.Windows.Forms.TextBox dlitelnostZvonkaTextBox;
        private System.Windows.Forms.TextBox kommentsTextBox;
        private System.Windows.Forms.Button BTNListCallsF;
    }
}