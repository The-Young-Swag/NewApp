using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApp
{
    internal class Person
    {
        public string Pname = "";
        public int age = 0;
        public string Address = "";
        public string Bdate = "";

        public void addPerson(ListBox lb)
        {
            lb.Items.Add(Pname);

        }
        public bool searchPerson (ListBox lb)
        {
            bool exist = false;
            for (int i = 0; i < lb.Items.Count; i++)
            {
                if (Pname.ToLower() == lb.Items[i].ToString().ToLower())
                {
                    exist = true;
                    break;
                }
            }
            return exist;
        }

    }
}
