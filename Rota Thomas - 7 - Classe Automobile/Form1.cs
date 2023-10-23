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
            Auto.AccendiSpegniAuto();
            UpdateUI();
        }
        private void accelleratore_Click(object sender, EventArgs e)
        {
            Auto.Accelera();
            UpdateUI();
        }
        private void freno_Click(object sender, EventArgs e)
        {
            Auto.Frena();
            UpdateUI();
        }
        private void marciaSu_Click(object sender, EventArgs e)
        {
            Auto.AumentaMarcia();
            UpdateUI();
        }
        private void marciaGiu_Click(object sender, EventArgs e)
        {
            Auto.DiminuisciMarcia();
            UpdateUI();
        }
        public void UpdateUI()
        {
            if (Auto.motoreAcceso == true)
                labelOnOff.Text = "On";
            else
                labelOnOff.Text = "Off";
            if (Auto.marcia == -1)
				labelNMarce.Text = "R";
			else
				labelNMarce.Text = Auto.marcia.ToString();
            labelVelocita.Text = Auto.velocità.ToString();
        }
    }
}
