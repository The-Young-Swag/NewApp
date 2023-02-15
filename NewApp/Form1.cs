using FirstApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NewApp
{
    public partial class GUI1 : Form
    {
        public GUI1()
        {
            InitializeComponent();
        }
       
        private void SaveButton_Click (object sender, EventArgs e)
        {
            Person pr = new Person();
            pr.Pname = txtBoxName.Text;
            pr.age = int.Parse(txtBoxAge.Value.ToString());
            pr.Address = txtBoxAddress.Text;
            pr.Bdate = txtBoxBdate.Text;
            bool exist = pr.searchPerson(listBox1);
            if (exist == false)
            {
                pr.addPerson(listBox1);
            }
            else
            {
                MessageBox.Show("Record Exist");
            }
        }
        private void txtBoxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
