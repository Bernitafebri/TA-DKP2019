using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TADKP
{
    class classSet
    {
        private int GajiPokok;
        private int Tunjangan;

        public classSet (int GajiPokok, int Tunjangan)
        {
            setGajiPokok(GajiPokok);
            setTunjangan(Tunjangan);
        }
        public void setGajiPokok(int a) //method set atribut
        {
            this.GajiPokok = a; //menentukan nilai atribut
        }

        public int getGajiPokok() //method get atribut
        {
            return GajiPokok; //mendapatkan nilai atribut dan mengembalikan ke fungsi yang memanggilnya
        }
        public void setTunjangan(int b)
        {
            this.Tunjangan = b;
        }
        public int getTunjangan()
        {
            return Tunjangan;
        }

    }
}
