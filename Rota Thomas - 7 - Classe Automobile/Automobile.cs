using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Rota_Thomas___7___Classe_Automobile
{
    public class Automobile
    {
        protected bool _motoreAcceso;
        protected int _vel;
        protected int _marcia;
        protected int _giriMotore;

        public double[,] rap = new double[,]
        {
	        { 4, 3.5, 2.5, 1.8, 1.3, 1.0, 0.8 },
	        { 20, 20, 40, 60, 90, 130, 180 },
        };

		public Automobile()
        {
            motoreAcceso = false;
            velocità = 0;
            marcia = 0;
            giriMotore = 0;
        }

        public bool motoreAcceso { get { return _motoreAcceso; } set { _motoreAcceso = value; } }
        public int velocità { get { return _vel; } set { _vel = value; } }
        public int marcia { get { return _marcia; } set { _marcia = value; } }
        public int giriMotore { get { return _giriMotore; } set { _giriMotore = value;} }

        public void AccendiSpegniAuto()
        {
            if (motoreAcceso == false)
            {
                motoreAcceso = true;
            }
            else
                motoreAcceso = false;
        }
        public virtual void Accelera()
        {
	        if (motoreAcceso && marcia > 0 && velocità < rap[1, marcia])
	        {
		        giriMotore += 500;
		        velocità = CalcolaVelocita();
	        }
	        if (motoreAcceso && marcia == -1 && velocità < rap[1, 0])
	        {
		        giriMotore += 500;
		        velocità = CalcolaVelocita();
	        }
		}
        public virtual void Frena()
        {
	        if (motoreAcceso && marcia > 1 && velocità > rap[1, marcia - 1])
	        {
		        giriMotore -= 500;
		        velocità = CalcolaVelocita();
	        }
	        if (motoreAcceso && marcia == -1)
	        {
		        giriMotore -= 500;
		        if (giriMotore < 0)
			        giriMotore = 0;
		        velocità = CalcolaVelocita();
	        }
	        if (motoreAcceso && marcia == 1 && velocità > 0)
	        {
		        giriMotore -= 500;
		        if (giriMotore < 0)
			        giriMotore = 0;
		        velocità = CalcolaVelocita();
	        }
		}
        public void AumentaMarcia()
        {
	        if (motoreAcceso && marcia < 6)
	        {
		        marcia++;
		        giriMotore = CalcolaGiriMotore();
	        }
		}
        public void DiminuisciMarcia()
        {
	        if (motoreAcceso && marcia > -1)
	        {
		        if (marcia == 1)
		        {
			        if (velocità != 0)
			        {
				        return;
			        }
			        else
			        {
				        marcia--;
				        return;
			        }
		        }
		        if (marcia > 1 && velocità <= rap[1, marcia - 1] || marcia == 0)
		        {
			        marcia--;
			        giriMotore = CalcolaGiriMotore();
		        }
	        }
		}
        public int CalcolaVelocita()
        {
	        double rapT;
	        if (marcia == -1)
	        {
		        rapT = rap[0, 0];
	        }
	        else
	        {
		        rapT = rap[0, marcia];
	        }
	        return (int)(giriMotore / (rapT * 60) * 3.6);
        }
        public int CalcolaGiriMotore()
        {
	        double rapT;
	        if (marcia == -1)
	        {
		        rapT = rap[0, 0];
	        }
	        else
	        {
		        rapT = rap[0, marcia];
	        }
	        return (int)(velocità / 3.6 * rapT * 60);
        }
	}

    public class AutomobileAutomatica : Automobile
    {
	    public AutomobileAutomatica() : base()
	    {
			
		}
		public override void Accelera()
		{
			base.Accelera();
			CambioAutomatico();
        }
        public override void Frena()
        {
            base.Frena();
			CambioAutomatico();
        }
        public void CambioAutomatico()
		{
            if (motoreAcceso && marcia < 6 && velocità > rap[1, marcia - 1])
            {
				AumentaMarcia();
                giriMotore = CalcolaGiriMotore();
            }

            if (motoreAcceso && marcia > -1 && velocità < rap[1, marcia])
			{
                DiminuisciMarcia();
                giriMotore = CalcolaGiriMotore();
            }
        }
    }
}
