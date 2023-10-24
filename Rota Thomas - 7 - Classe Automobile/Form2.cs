using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rota_Thomas___7___Classe_Automobile
{
	public partial class Form2 : Form
	{
		public AutomobileAutomatica Auto;
		public Form2()
		{
			InitializeComponent();
			Auto = new AutomobileAutomatica();
		}
		private void onOff_Click(object sender, EventArgs e)
		{
			Auto.AccendiSpegniAuto();
			UpdateUI();
		}
		private void accelleratore_Click(object sender, EventArgs e)
		{
			if (Auto.marcia == 0 && Auto.motoreAcceso)
				Auto.marcia = 1;
			Auto.Accelera();
			UpdateUI();
		}
		private void freno_Click(object sender, EventArgs e)
		{
			/*if (Auto.marcia == 0 && Auto.motoreAcceso)
			{
                Auto.marcia = -1;
				return;
            }*/
            Auto.Frena();
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
