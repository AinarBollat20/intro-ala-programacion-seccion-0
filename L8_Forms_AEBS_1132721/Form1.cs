using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L8_Forms_AEBS_1132721
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmb_seleccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cmb_seleccion.SelectedIndex)
            {
                case 0:
                    MessageBox.Show("Hola super humano vamos a seleccinar la pestana de sumatoria:");
                    tabControl1.SelectTab(0);
                    break;

                case 1:
                    MessageBox.Show("Estamos en la opcion 2");
                    tabControl1.SelectTab(1);
                    break;
                case 3:
                    break;


            }
        }
    }
}
