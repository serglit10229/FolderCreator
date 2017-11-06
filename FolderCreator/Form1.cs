using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderCreator
{
    public partial class Form1 : Form
    {

        
        int folderNumber = 1;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string folderName = textBox2.Text;
            int Limit = int.Parse(textBox1.Text);
            

            while (folderNumber <= Limit)
            {
                var path = "C:\\Users\\" + Environment.UserName + "\\Desktop\\";
                var folder = Path.Combine(path, folderName + folderNumber);
                Directory.CreateDirectory(folder);
                folderNumber++;
                Console.WriteLine(folderNumber);
            }

            int folderNum = folderNumber - 1;
            Console.WriteLine(folderNum);

            if (folderNum == Limit)
            {
                MessageBox.Show("You just created " + folderNum + " folders.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label3.Text = textBox2.Text + folderNumber;
        }
    }
}
