using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTakipOtomasyonu
{
    class Mesailer
    {
        #region Mesai Kapsulleme
        int _MesaiID;
        string _BaslangicSaati;
        string _BitisSaati;
        decimal _MesaiSaatUcreti;
        decimal _Tutar;
        string _Donem;
        string _OdenmeDurumu;
        string _Aciklama;
        string _Islem;
        DateTime _Tarih;

        public int MesaiID { get => _MesaiID; set => _MesaiID = value; }
        public string BaslangicSaati { get => _BaslangicSaati; set => _BaslangicSaati = value; }
        public string BitisSaati { get => _BitisSaati; set => _BitisSaati = value; }
        public decimal MesaiSaatUcreti { get => _MesaiSaatUcreti; set => _MesaiSaatUcreti = value; }
        public decimal Tutar { get => _Tutar; set => _Tutar = value; }
        public string Donem { get => _Donem; set => _Donem = value; }
        public string OdenmeDurumu { get => _OdenmeDurumu; set => _OdenmeDurumu = value; }
        public string Aciklama { get => _Aciklama; set => _Aciklama = value; }
        public DateTime Tarih { get => _Tarih; set => _Tarih = value; }
        public string Islem { get => _Islem; set => _Islem = value; }
        #endregion


    }
}
