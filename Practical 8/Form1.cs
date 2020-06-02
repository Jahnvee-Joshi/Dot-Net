using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FontIncDec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void lblFont_Click(object sender, EventArgs e)
        {

        }

        private void btnInc_Click(object sender, EventArgs e)
        {
            float fontSize = lblFont.Font.Size;
            lblFont.Font = new Font(lblFont.Font.FontFamily, ++fontSize);
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            float fontSize = lblFont.Font.Size;
            lblFont.Font = new Font(lblFont.Font.FontFamily, --fontSize);
        }
    }
}
