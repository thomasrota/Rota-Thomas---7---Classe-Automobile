using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rota_Thomas___7___Classe_Automobile
{
    public partial class Form1 : Form
    {
        public Automobile Auto;
        public Form1()
        {
            InitializeComponent();
            Auto = new Automobile();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void onOff_Click(object sender, EventArgs e)
        {
            if (Auto.status == false)
            {
                Auto.AccendiAuto();
                labelOnOff.Text = "On";
            }
            else
            {
                Auto.SpegniAuto();
                labelOnOff.Text = "Off";
            }
        }
    }
}