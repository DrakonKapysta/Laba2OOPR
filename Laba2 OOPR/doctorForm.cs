using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Laba2_OOPR
{
    public partial class doctorForm : Form
    {
        private void ChechProblem()
        {
            if (comboBox1.SelectedIndex < 0 && проблемаToolStripMenuItem1.Text == "Показати проблему")
            {
                MessageBox.Show("Виберіть пацієнта.");
            }
            else if (проблемаToolStripMenuItem1.Text == "Приховати проблему")
            {
                panel1.Visible = false;
                panel2.Visible = true;
                richTextBox1.Clear();
                проблемаToolStripMenuItem1.Text = "Показати проблему";
            }
            else
            {
                if (проблемаToolStripMenuItem1.Text == "Показати проблему")
                {
                    panel1.Visible = true;
                    panel2.Visible = false;
                    PatientReader.ReadPatientProblemDescription(this);
                    проблемаToolStripMenuItem1.Text = "Приховати проблему";
                }
                else
                {
                    panel1.Visible = false;
                    panel2.Visible = true;
                    richTextBox1.Clear();
                    проблемаToolStripMenuItem1.Text = "Показати проблему";
                }
            }
        }
        private Doctor _doctor = new Doctor();
        private mainForm _mainForm;
        public doctorForm(mainForm form)
        {
            _mainForm = form;
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void doctorForm_Load(object sender, EventArgs e)
        {
            PatientReader.ReadPatientToComboBox(this);
            
        }

        private void doctorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _mainForm.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PatientReader.ReadPatientInfo(this);
            if(проблемаToolStripMenuItem1.Text == "Приховати проблему")
            {
                PatientReader.ReadPatientProblemDescription(this);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void проблемаToolStripMenuItem1_Click(object sender, EventArgs e)
        {   
            if(comboBox1.SelectedIndex < 0 && проблемаToolStripMenuItem1.Text == "Показати проблему")
            {
                MessageBox.Show("Виберіть пацієнта.");
            }
            else if (проблемаToolStripMenuItem1.Text == "Приховати проблему")
            {
                panel1.Visible = false;
                panel2.Visible = true;
                richTextBox1.Clear();
                проблемаToolStripMenuItem1.Text = "Показати проблему";
            }
            else 
            {
                if (проблемаToolStripMenuItem1.Text == "Показати проблему")
                {
                    panel1.Visible = true;
                    panel2.Visible = false;
                    PatientReader.ReadPatientProblemDescription(this);
                    проблемаToolStripMenuItem1.Text = "Приховати проблему";
                }
                else
                {
                    panel1.Visible = false;
                    panel2.Visible = true;
                    richTextBox1.Clear();
                    проблемаToolStripMenuItem1.Text = "Показати проблему";
                }
            }
        }

        private void назначитиДоглядальникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox2.SelectAll();
            if (comboBox2.SelectedText == "Медсестра" || comboBox2.SelectedText == "Лікар")
            {
               PatientWritter.AppointDoctor(this);
                MessageBox.Show("Доглядача призначенно.");
            }
            else
            {
                MessageBox.Show("Вибиріть доглядача!");
            }
        }

        private void назначитиЛікуванняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text ==""||textBox2.Text == ""|| textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Виберіть пацієнта.");
            }
            else
            {
                Task task = new Task();
                task.TreatForm = new treatmentForm(this);
                _doctor.Work(task);
                task.TreatForm.Visible = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void виписатиПацієнтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DischargePatient.Discharge(textBox1.Text, textBox2.Text);
            DischargePatient.DischargeTherapy(textBox1.Text, textBox2.Text);
            comboBox1.Items.Remove(comboBox1.SelectedItem);
            comboBox2.Items.Remove(comboBox2.SelectedItem);
            richTextBox1.Clear();
            if (comboBox1.Items.Count == 0)
            {
                comboBox1.SelectedIndex = -1;
                comboBox1.Text = "";
                comboBox1.Enabled = false;
                comboBox2.SelectedIndex = -1;
                comboBox2.Text = "";
                comboBox2.Enabled = false;
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            ChechProblem();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ChechProblem();
        }
    }
}
