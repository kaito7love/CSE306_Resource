
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Asignment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text {*.txt}|*.txt|All files {*.*}|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(openFileDialog1.FileName);
            }


        }

        private void btnSelectAvatar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JPG {*.png}|*.png|All files {*.*}|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBoxAvatar.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text {*.txt}|*.txt|All files {*.*}|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(openFileDialog1.FileName);
            }
        }

        private void btnSaveAndSeialize_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Id = int.Parse(txtStudentID.Text);
            student.Name = txtFullName.Text;
            student.Address = txtAddress.Text;
            student.DateOfBirth = txtDoB.Value;
            //student.AvatarPath = saveFileDialog1.FileName;
            string json = JsonSerializer.Serialize(student);

            saveFileDialog1.Filter = "Text {*.txt}|*.txt|All files {*.*}|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = File.OpenWrite(saveFileDialog1.FileName))
                {
                    UTF8Encoding temp = new UTF8Encoding(true);
                    byte[] buffer = temp.GetBytes(json);
                    fs.Write(buffer, 0, buffer.Length);
                };
            }
            
        }

        private void btnReadAndDeserialize_Click(object sender, EventArgs e)
        {
            String filePath="";
            String json="";
            openFileDialog1.Filter = "Text {*.txt}|*.txt|All files {*.*}|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                 filePath += openFileDialog1.FileName;
            }
            using (FileStream fs = File.OpenRead(filePath)) {
                UTF8Encoding temp = new UTF8Encoding(true);
                json = File.ReadAllText(filePath);
                
                MessageBox.Show(json);
            }

            Student student = JsonSerializer.Deserialize<Student>(json);
            txtStudentID.Text = student.Id.ToString();
            txtFullName.Text = student.Name;
            txtDoB.Text = student.DateOfBirth.ToString();
            txtAddress.Text = student.Address;
            //btnSelectAvatar 
        }
    }
}
