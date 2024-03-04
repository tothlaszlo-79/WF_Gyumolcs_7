using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Gyumolcs_7
{
    public partial class frmPrices : Form
    {
        public DataGridView DGV { get { return dgv; } }

        public frmPrices()
        {
            InitializeComponent();
        }
    }
}
