using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiNotePad.FORMULARIOS
{
    public partial class frmACERCA : Form
    {
        public frmACERCA()
        {
            InitializeComponent();
        }

        private void lbLINK_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://daedcoder.blogspot.com");
        }
    }
}
