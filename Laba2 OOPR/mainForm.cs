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
    public partial class mainForm : Form
    {
        private PatientForm _myPatient;
        private doctorForm _myDoctor;
        public mainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _myPatient = new PatientForm(this);
            this.Hide();
            _myPatient.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _myDoctor = new doctorForm(this);
            this.Hide();
            _myDoctor.Visible = true;
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(212, 51, 78);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(39, 125, 217);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
        }
    }
}
