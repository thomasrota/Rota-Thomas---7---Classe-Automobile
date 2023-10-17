using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rota_Thomas___7___Classe_Automobile
{
    public class Automobile
    {
        protected bool _status;
        protected int _vel;
        protected int _marcia;

        public Automobile()
        {
            _status = false;
            _vel = 0;
            _marcia = 0;
        }

        public bool status { get { return _status; } set { _status = value; } }
        public int velocità { get { return _vel; } set { _vel = value; } }
        public int marcia { get { return _marcia; } set { _marcia = value; } }

        public int AccendiAuto()
        {
            if (status == false)
            {
                status = true;
                return 1;
            }
            return 0;
        }
        public int SpegniAuto()
        {
            if (status == true)
            {
                status = false;
                return 1;
            }
            return 0;
        }
        public int Accellera()
        {
            if (status == true && marcia > 0)
            {
                velocità += 30;
                return 1;
            }
            return 0;
        }
        public int Frena()
        {
            if (status == true && marcia > 0)
            {
                velocità -= 30;
                return 1;
            }
            return 0;
        }
    }
}
