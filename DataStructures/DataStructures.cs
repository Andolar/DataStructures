using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStructures
{
    public partial class DataStructures : Form
    {
        public DataStructures()
        {
            InitializeComponent();
        }

        private void DataStructures_Load(object sender, EventArgs e)
        {
            var sc = new StandardStuff();
        }
    }
}
