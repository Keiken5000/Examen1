using Microsoft.VisualBasic;
using System.Security.Cryptography.X509Certificates;

namespace Examen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            selection SelectionForm = new selection();

            SelectionForm.ShowDialog();
        }
    }
}