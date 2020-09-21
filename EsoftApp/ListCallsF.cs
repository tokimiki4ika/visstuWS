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
    public partial class ListCallsF : Form
    {
        public ListCallsF()
        {
            InitializeComponent();
        }

        private void leadsAndCallsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.leadsAndCallsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._B_7DataSet);

        }

        private void ListCallsF_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_B_7DataSet.LeadsAndCalls". При необходимости она может быть перемещена или удалена.
            this.leadsAndCallsTableAdapter.Fill(this._B_7DataSet.LeadsAndCalls);

        }

        private void ListCallsF_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BTNCallF_Click(object sender, EventArgs e)
        {
            CallF cf = new CallF();
            this.Hide();
            cf.Show();
        }

        private void BTNAu_Click(object sender, EventArgs e)
        {
            AutorezF au = new AutorezF();
            this.Hide();
            au.Show();
        }

        private void BTNExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTNLidsList_Click(object sender, EventArgs e)
        {
            LidsList ll = new LidsList();
            this.Hide();
            ll.Show();
        }
    }
}
