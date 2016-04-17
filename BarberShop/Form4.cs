using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberShop
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void staffBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.staffBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._barber_shop_dbDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_barber_shop_dbDataSet.branches". При необходимости она может быть перемещена или удалена.
            this.branchesTableAdapter.Fill(this._barber_shop_dbDataSet.branches);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_barber_shop_dbDataSet.staff". При необходимости она может быть перемещена или удалена.
            this.staffTableAdapter.Fill(this._barber_shop_dbDataSet.staff);

        }
    }
}
