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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_barber_shop_dbDataSet.services_view". При необходимости она может быть перемещена или удалена.
            this.services_viewTableAdapter.Fill(this._barber_shop_dbDataSet.services_view);
        }
    }
}
