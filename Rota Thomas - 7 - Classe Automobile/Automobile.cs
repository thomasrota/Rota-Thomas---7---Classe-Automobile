using System;
using System.Collections.Generic;
using System.Linq;
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

        public Automobile()
        {
            _motoreAcceso = false;
            _vel = 0;
            _marcia = 0;
            _giriMotore = 0;
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
        public int CalcolaVelocitaDaGiriMotore()
        {
            double rapportoGiriVelocita = 0.1;
            return (int)(giriMotore * rapportoGiriVelocita);
        }
        public void Accelera()
        {
            if (motoreAcceso == true)
            {
                giriMotore += 500;
                velocità = CalcolaVelocitaDaGiriMotore();
            }
        }
        public void Frena()
        {
            if (motoreAcceso == true)
            {
                giriMotore -= 500;
                if (giriMotore < 0)
                {
                    giriMotore = 0;
                }
                velocità = CalcolaVelocitaDaGiriMotore();
            }
        }
        public void AumentaMarcia()
        {
            if (motoreAcceso == true && marcia < 6)
            {
                marcia++;
            }
        }
        public void DiminuisciMarcia()
        {
            if (motoreAcceso == true && marcia > 1)
            {
                marcia--;
            }
        }
    }
}
