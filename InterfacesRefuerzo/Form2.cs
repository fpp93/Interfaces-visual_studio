using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacesRefuerzo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        ArrayList list=new ArrayList();
        ArrayList combo=new ArrayList();
        public Form2(ArrayList l,ArrayList c)
        {
            list = l;
            combo = c;
            InitializeComponent();
        }
        Boolean control = false;
        private void btn_conmutar_Click(object sender, EventArgs e)
        {
            if (control == false)
            {
                control = true;
            }
            else
            {
                control = false;
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (control == false)
            {
                if (textBox.Text != "")
                {
                    listbox.Items.Add(textBox.Text);
                    combo.Add(textBox.Text);
                    
                }
                else
                {
                    MessageBox.Show("Inserte algo en el cuadro de texto");
                }
            }
            if (control == true)
            {
                if (textBox.Text != "")
                {
                    combobox.Items.Add(textBox.Text);
                    list.Add(textBox.Text);
                    
                }
                else
                {
                    MessageBox.Show("Inserte algo en el cuadro de texto");
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            combobox.Items.Clear();
            listbox.Items.Clear();
            foreach(String l in list)
            {
                combobox.Items.Add(l);
            }
            foreach (String c in combo)
            {
                listbox.Items.Add(c);
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            
            
        }
    }
}
