using System;

namespace IZSU.Entity.Model
{
    public class Fatura
    {
        public int FaturaID { get; set; }
        public int AboneID { get; set; }
        public decimal OdemeTutari { get; set; }
        public int OncekiSayac { get; set; }
        public int GuncelSayac { get; set; }
        
        public DateTime FaturaTarihi { get; set; }
        public bool Tahsilat { get; set; }

        public Abone Abone { get; set; }

        public double OdemeHesapla(int _aboneTuruID)
        {
            double result = 0;           
            

            if (_aboneTuruID == 1) //Ev
                result = (GuncelSayac - OncekiSayac) * 0.3;

            else if (_aboneTuruID == 2) //İş
                result = (GuncelSayac - OncekiSayac) * 0.5;

            return result;
        }

    }
}
