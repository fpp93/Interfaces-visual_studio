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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Boolean control = false;
        ArrayList combo=new ArrayList();
        ArrayList list=new ArrayList();
        ArrayList combo2 = new ArrayList();
        ArrayList list2 = new ArrayList();
        public Form1(ArrayList c, ArrayList l)
        {
            combo2 = c;
            list2 = l;
            InitializeComponent();
        }

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
                    if (textbox.Text != "")
                    {
                        listBox.Items.Add(textbox.Text);
                        list.Add(textbox.Text);
                    }
                    else
                    {
                        MessageBox.Show("Inserte algo en el cuadro de texto");
                    }
                }
            
            
            
            
                if (control == true)
                {
                    if (textbox.Text != "")
                    {
                        comboBox.Items.Add(textbox.Text);
                        combo.Add(textbox.Text);
                    }
                    else
                    {
                        MessageBox.Show("Inserte algo en el cuadro de texto");
                    }
                }
            
            
            
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void btn_form2_Click(object sender, EventArgs e)
        {

            Form2 f2 = new Form2(list, combo);
            f2.ShowDialog();
            comboBox.Items.Clear();
            listBox.Items.Clear();
            foreach(String c in combo)
            {
                comboBox.Items.Add(c);
            }
            foreach(String l in list)
            {
                listBox.Items.Add(l);
            }
        }
    }
}
