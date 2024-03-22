using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsOld
{
    public partial class Ablak : Form
    {
        public Ablak()
        {
            InitializeComponent();
        }

        private void buttonKiir_Click(object sender, EventArgs e)
        {
            labelOutput.Text = textBoxSzoveg.Text;
            labelForm.Text=textBoxSzoveg.Text;
        }

        private void textBoxSzoveg_TextChanged(object sender, EventArgs e)
        {
            labelOutput.Text=textBoxSzoveg.Text;
        }
    }
}
