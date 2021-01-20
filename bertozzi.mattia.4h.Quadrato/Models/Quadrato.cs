using System;
using System.Collections.Generic;
using System.Text;

namespace bertozzi.mattia._4h.Quadrato.Models
{
    class Q
    {
        private int _lposx;
        private int _lposy;

        //costruttore
        public Q(int x, int y, double l)
        {
            _lposx = x;
            _lposy = y;
            _lato = l;
        }

        public int LposX
        {
            get
            {
                return _lposx;
            }
            set
            {
                _lposx = value;
            }
        }

        public int LposY
        {
            get
            {
                return _lposy;
            }
            set
            {
                _lposy = value;
            }
        }

        private double _lato;

        public double Lato
        {
            get
            {
                return _lato;
            }
            set
            {
                _lato = value;
            }
        }

        private double _area;

        public double Area
        {
            get
            {
                return _area;
            }
            set
            {
                _area = value;
            }
        }

        private double _perimetro;

        public double Perimetro
        {
            get
            {
                return _perimetro;
            }
            set
            {
                _perimetro = value;
            }
        }

        //METODI

        //calcolo dell'area
        public double CArea()
        {
            Area = _lato * _lato;
            return Area;
        }

        //calcolo del perimetro
        public double CPerimetro()
        {
            Perimetro = _lato * 4;
            return Perimetro;
        }

        //calcolo della diagonale
        public double CDiagonale()
        {
            return _lato * Math.Sqrt(2);
        }

        //metodo dell'output del punto
        public string OutPunto()
        {
            return $"Punto({_lposx},{_lposy})";
        }

        //Overload del Segno ">"
        public static bool operator >(Q Q1, Q Q2)
            {
                if(Q1.Area > Q2.Area)
                {
                    return true;
                }
                else 
                {
                    return false;
                }
            }

        //Overload del Segno "<"
        public static bool operator <(Q Q1, Q Q2)
        {
            if (Q1.Area < Q2.Area)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
