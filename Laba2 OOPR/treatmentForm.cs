using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba2_OOPR
{
    public partial class treatmentForm : Form
    {
        private doctorForm _docForm;
        public treatmentForm(doctorForm docForm)
        {
            _docForm = docForm;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
                MessageBox.Show("Випишіть лікування.");
            else
            {
                PatientWritter.WriteTherapy(_docForm, this);
                richTextBox1.Clear();
                this.Close();
            }
        }
    }
}
