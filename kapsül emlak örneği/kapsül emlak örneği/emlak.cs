using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kapsül_emlak_örneği
{
    internal class emlak
    {
        private string şehir;
        private string mahalle;
        private int kat;
        private int odasayısı;
        private int kira;

        public string SEHİR
        {
            get { return şehir; }
            set { şehir = value.ToLower(); }
        }
        public string MAH
        {
            get { return mahalle; }
            set { mahalle = value.ToLower(); }
        }
        public int KAT
        {
            get { return kat; }
            set
            {
                if (value < 0)
                {
                    kat = Math.Abs(value);
                }
                else
                {
                    kat = value;
                }
            }
        }
        public int ODA
        {
            get { return odasayısı; }
            set
            {
                if (value < 0)
                {
                    odasayısı = Math.Abs(value);
                }
                else
                {
                    odasayısı = value;
                }
            }
        }
        public int KİRA
        {
            get { return kira; }
            set
            {
                if(value<2500)
                {
                    kira = 2500;
                }
                else
                {
                    kira = value;
                }
            }
        }
    }
}