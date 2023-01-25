using System;
using System.Net;
using System.IO;
using System.Net.Mail;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University3
{
    public partial class Form1 : Form
    {
        private listTeacher teachers;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            teachers = new listTeacher(); 
            comboBox2.Visible = false; comboBox3.Visible = false;
            button2.Visible = false; button3.Visible = false; button4.Visible = false;
            label15.Visible = false; label16.Visible = false; label17.Visible = false;
            textBox10.Visible = false; textBox12.Visible = false; textBox13.Visible = false; textBox14.Visible = false; textBox15.Visible = false;
            label11.Visible = false; label14.Visible = false; label18.Visible = false; label19.Visible = false; label20.Visible = false; label21.Visible = false; 
            textBox16.Visible = false; textBox17.Visible = false; textBox18.Visible = false; treeView1.Visible = false;

            dataGridView1.Columns.Add("column1", "Имя");
            dataGridView1.Columns.Add("column2", "Фамилия");
            dataGridView1.Columns.Add("column3", "Возраст");
            dataGridView2.Columns.Add("column1", "Имя");
            dataGridView2.Columns.Add("column2", "Фамилия");
            dataGridView2.Columns.Add("column3", "Возраст");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Student")
            {
                button1.Visible = false; button2.Visible = true; button3.Visible = false; button4.Visible = false;
                textBox10.Visible = true; textBox12.Visible = true; label11.Visible = true; label14.Visible = true;
                comboBox1.Visible = false; comboBox2.Visible = true; treeView1.Visible = true;
            }
            if (comboBox1.SelectedItem.ToString() == "Teacher")
            {
                button1.Visible = false; button2.Visible = false; button3.Visible = true; button4.Visible = false;
                label15.Visible = true; label16.Visible = true; label17.Visible = true; textBox13.Visible = true; textBox14.Visible = true;
                textBox15.Visible = true; comboBox1.Visible = false; treeView1.Visible = true;
            }
            if (comboBox1.SelectedItem.ToString() == "CourseWork")
            {
                button1.Visible = false; button2.Visible = false; button3.Visible = false; button4.Visible = true;
                label18.Visible = true; label19.Visible = true; label20.Visible = true; label21.Visible = true; 
                textBox16.Visible = true; textBox17.Visible = true; textBox18.Visible = true; comboBox1.Visible = false; comboBox3.Visible = true;
                treeView1.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(label12.Text);
            bool habbits = true;
            if (radioButton1.Checked == true)
            {
                habbits = true;
            }
            else if (radioButton2.Checked == true)
                habbits = false;
            Student student = new Student(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text),
                Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), habbits, Nation.Ukranian,
                new Address(textBox6.Text, textBox7.Text, textBox8.Text, Convert.ToInt32(textBox9.Text)),
                textBox11.Text, Convert.ToInt32(textBox10.Text), Convert.ToInt32(textBox12.Text), Key.python);

            comboBox3.Items.Add(textBox2.Text); Bind(student);
            treeView1.Nodes[comboBox2.SelectedIndex].Nodes.Add(textBox2.Text);

            if (count == 0)
            {
                dataGridView1.Rows[count].Cells[0].Value = (textBox1.Text);
                dataGridView1.Rows[count].Cells[1].Value = (textBox2.Text);
                dataGridView1.Rows[count].Cells[2].Value = (textBox3.Text);
            }
            else
            {
                dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text);
            }
            label12.Text = Convert.ToString(Convert.ToInt32(label12.Text) + 1);

            textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
            textBox4.Clear(); textBox5.Clear(); textBox6.Clear();
            textBox7.Clear(); textBox8.Clear(); textBox9.Clear();
            textBox10.Clear(); textBox11.Clear();

            radioButton1.Checked = false; radioButton2.Checked = false;
            textBox10.Visible = false; textBox12.Visible = false; comboBox2.Visible = false; label11.Visible = false;
            label14.Visible = false; button2.Visible = false; button1.Visible = true; comboBox1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(label22.Text);
            bool habbits = false;
            if (radioButton1.Checked == true)
            {
                habbits = true;
            }
            else if (radioButton2.Checked == true)
                habbits = false;
            Teacher teacher = new Teacher(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), 
                Convert.ToInt32(textBox5.Text), habbits, Nation.Ukranian, new Address(textBox6.Text, textBox7.Text, textBox8.Text, 
                Convert.ToInt32(textBox9.Text)), textBox11.Text, Convert.ToInt32(textBox13.Text), textBox14.Text, KeyWords.python, Convert.ToInt32(textBox15.Text));
            teachers.add(teacher); comboBox2.Items.Add(textBox2.Text); treeView1.Nodes.Add(textBox2.Text);

            if (count == 0)
            {
                dataGridView2.Rows[count].Cells[0].Value = textBox1.Text;
                dataGridView2.Rows[count].Cells[1].Value = textBox2.Text;
                dataGridView2.Rows[count].Cells[2].Value = textBox3.Text;
            }
            else
            {
                dataGridView2.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text);
            }
            label22.Text = Convert.ToString(Convert.ToInt32(label22.Text) + 1);



            textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
            textBox4.Clear(); textBox5.Clear(); textBox6.Clear();
            textBox7.Clear(); textBox8.Clear(); textBox9.Clear();
            textBox11.Clear(); textBox13.Clear(); textBox14.Clear(); textBox15.Clear();

            radioButton1.Checked = false; radioButton2.Checked = false; label15.Visible = false; 
            label16.Visible = false; label17.Visible = false; textBox13.Visible = false; textBox14.Visible = false;
            textBox15.Visible = false; comboBox1.Visible = true; button3.Visible = false; button1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CourseWork cursova = new CourseWork(textBox18.Text, textBox17.Text, Convert.ToDateTime(textBox16.Text));
            for (int i = 0; i < teachers.List.Count; i++)
                for (int j = 0; j < teachers.List[i].List.Count; j++)
                {
                    if (teachers.List[i].List[j].Surname == comboBox3.SelectedItem.ToString())
                    {
                        treeView1.Nodes[i].Nodes[j].Nodes.Add(textBox17.Text);
                    }
                }

            label18.Visible = false; label19.Visible = false; label20.Visible = false; label21.Visible = false;
            textBox16.Visible = false; textBox17.Visible = false; textBox18.Visible = false;
            button1.Visible = true; button4.Visible = false;
            comboBox1.Visible = true; comboBox3.Visible = false;
        }

        public void Bind(Student student)
        {
            for (int i = 0; i < teachers.List.Count; i++)
            {
                if (teachers.List[i].Surname == comboBox2.SelectedItem.ToString())
                {
                    teachers.List[i].List.Add(student);
                    break;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            const string file = @"D:\Saved.json";
            string json = JsonSerializer.Serialize(teachers);
            File.WriteAllText(file, json);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MailAddress from = new MailAddress("teacher@gmail.com");
            MailAddress to = new MailAddress("skoryij@gmail.com");
            MailMessage m = new MailMessage(from, to);
            m.Subject = "Курсовая";
            m.Body = "<h1Вашакурсовая просрочена/h1>";
            m.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential("teacher@gmail.com", "password");
            smtp.EnableSsl = true;
            smtp.Send(m);
        }
    }
}
