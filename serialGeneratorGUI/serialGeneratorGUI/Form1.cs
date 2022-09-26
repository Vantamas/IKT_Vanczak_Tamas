using serialGenerator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace serialGeneratorGUI
{
    public partial class Form1 : Form
    {
        Queries q = new Queries();
        public Form1()
        {
            InitializeComponent();
            q.dbRead(listBox1);//címszerinti paraméter átadás

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            //q.dbCreate(textBox1, textBox2);
            q.dbUpdate(textBox1, textBox2);
            q.dbRead(listBox1);
            
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sure you wanna delete? ", "Item deleted", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                q.dbDelete(listBox1);
                q.dbRead(listBox1);
            }
            
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            q.textPaste(listBox1, textBox1, textBox2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            q.dbCreate();
            q.dbRead(listBox1);
        }
    }
}
