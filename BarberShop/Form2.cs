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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._barber_shop_dbDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_barber_shop_dbDataSet.sex". При необходимости она может быть перемещена или удалена.
            this.sexTableAdapter.Fill(this._barber_shop_dbDataSet.sex);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_barber_shop_dbDataSet.clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this._barber_shop_dbDataSet.clients);

        }
    }
}
