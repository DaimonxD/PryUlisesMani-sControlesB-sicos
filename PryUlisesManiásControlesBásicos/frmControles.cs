using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryUlisesManiásControlesBásicos
{
    public partial class frmControles : Form
    {
        public frmControles()
        {
            InitializeComponent();
        }

        private void frmControles_MouseMove(object sender, MouseEventArgs e)
        {
            lblX.Text = e.X.ToString();
            lblY.Text = e.Y.ToString();
        }

        private void cmdIngresar_MouseEnter(object sender, EventArgs e)
        {
            cmdIngresar.ForeColor = Color.Black;
        }

        private void cmdIngresar_MouseLeave(object sender, EventArgs e)
        {
            cmdIngresar.ForeColor = Color.Red;
        }

        private void txtAlgo_TextChanged(object sender, EventArgs e)
        {
            txtAlgo.MaxLength = 10;
        }

        private void cmdIngresar_Click(object sender, EventArgs e)
        {
            lblSample.Text = txtAlgo.Text;


            switch(true)
            {
                case var _ when chkBlue.Checked:
                    lblSample.ForeColor = Color.Blue;
                    break;
                case var _ when chkRed.Checked:
                    lblSample.ForeColor = Color.Red;
                    break;
                default:
                    MessageBox.Show("Selecciona algo pete xd");
                    break;
            }
        }

        private void cmdIngresar2_Click(object sender, EventArgs e)
        {
            cboxCosas.Items.Add(txtAlgo.Text);
        }

        private void cmdIngresar2_MouseEnter(object sender, EventArgs e)
        {
            cmdIngresar2.ForeColor = Color.Black;
        }

        private void cmdIngresar2_MouseLeave(object sender, EventArgs e)
        {
            cmdIngresar2.ForeColor= Color.Red;
        }

        private void cmdQuitar_Click(object sender, EventArgs e)
        {
            cboxCosas.Items.Remove(txtAlgo.Text);
        }

        private void cmdQuitar_MouseEnter(object sender, EventArgs e)
        {
            cmdQuitar.ForeColor = Color.Black;
        }

        private void cmdQuitar_MouseLeave(object sender, EventArgs e)
        {
            cmdQuitar.ForeColor = Color.Red;
        }
    }
}
