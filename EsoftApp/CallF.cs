using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EsoftApp
{
    public partial class CallF : Form
    {
        public CallF()
        {
            InitializeComponent();
        }

        private void leadsAndCallsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.leadsAndCallsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._B_7DataSet);

        }

        private void leadsAndCallsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.leadsAndCallsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._B_7DataSet);

        }

        private void leadsAndCallsBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.leadsAndCallsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._B_7DataSet);

        }

        private void CallF_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_B_7DataSet.LeadsAndCalls". При необходимости она может быть перемещена или удалена.
            this.leadsAndCallsTableAdapter.Fill(this._B_7DataSet.LeadsAndCalls);

        }

        private void CallF_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BTNLidsList_Click(object sender, EventArgs e)
        {
        }

        private void BTNListCallsF_Click(object sender, EventArgs e)
        {
            ListCallsF lcf = new ListCallsF();
            this.Hide();
            lcf.Show();
        }
    }
}
