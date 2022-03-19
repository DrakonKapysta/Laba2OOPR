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
    public partial class PatientForm : Form
    {
        private mainForm _mainForm;
        public PatientForm(mainForm myMainForm)
        {
            _mainForm = myMainForm;
            InitializeComponent();
            this.FormClosing += Patient_FormClosing;
        }

        private void Patient_FormClosing(object sender, FormClosingEventArgs e)
        {
            _mainForm.Visible = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                richTextBox1.Enabled = true;
            else
            {
                richTextBox1.Enabled = false;
                richTextBox1.Clear();
            }
        }

        private void Patient_Load(object sender, EventArgs e)
        { 
            richTextBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                MessageBox.Show("Заповніть всі поля.");
            else
            {
                Patient newPatient = new Patient(textBox1.Text, textBox2.Text,comboBox1.SelectedItem.ToString(),int.Parse(textBox3.Text), richTextBox1.Text);
                PatientWritter.WritePatient(newPatient);
                Task task = new Task();
                newPatient.Work(task);
                richTextBox1.Clear();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                comboBox1.Select();
                comboBox1.SelectedIndex = -1;
                MessageBox.Show("Вас було записано на лікування.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
