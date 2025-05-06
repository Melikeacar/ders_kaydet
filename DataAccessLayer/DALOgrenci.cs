using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayerr;

namespace DataAccessLayer
{
    public class DALOgrenci
    {
        public static int OgrenciEkle(Entityogrenci parametre)
        {
            SqlCommand komut1 = new SqlCommand("insert into TBLOGRENCI (OGRAD,OGRSOYAD,OGRNUMARA,OGRFOTO,OGRSIFRE) VALUES (@p1,@p2,@p3,@p4,@p5)",Baglantı.BGL);
            if(komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            komut1.Parameters.AddWithValue("@p1", parametre.Ad);
            komut1.Parameters.AddWithValue("@p2", parametre.Soyad);
            komut1.Parameters.AddWithValue("@p3", parametre.Numara);
            komut1.Parameters.AddWithValue("@p4", parametre.Fotograf);
            komut1.Parameters.AddWithValue("@p5", parametre.Sifre);
            return komut1.ExecuteNonQuery();
        }
        public static List<Entityogrenci>OgrenciListesi()
        {
            List<Entityogrenci> degerler = new List<Entityogrenci>();
            SqlCommand komut2 = new SqlCommand("Select * from TBLOGRENCI",Baglantı.BGL);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                Entityogrenci ent = new Entityogrenci();
                ent.Id = Convert.ToInt32(dr["OGRID"].ToString());
                ent.Ad = dr["OGRAD"].ToString();
                ent.Soyad = dr["OGRSOYAD"].ToString();
                ent.Numara = dr["OGRNUMARA"].ToString();
                ent.Fotograf = dr["OGRFOTO"].ToString();
                ent.Sifre = dr["OGRSIFRE"].ToString();
                ent.Bakiye = Convert.ToDouble(dr["OGRBAKIYE"].ToString());
                degerler.Add(ent);

            }
            dr.Close();
            return degerler;
        }
        public static bool OgrenciSil(int parametre)
        {
            SqlCommand komut3 = new SqlCommand("Delete from TBLOGRENCI where OGRID=@p1",Baglantı.BGL);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@p1",parametre);
            return komut3.ExecuteNonQuery() > 0;
        }

        public static List<Entityogrenci> OgrenciDetay(int id)
        {
            List<Entityogrenci> degerler = new List<Entityogrenci>();
            SqlCommand komut4 = new SqlCommand("Select * from TBLOGRENCI where OGRID=@p1", Baglantı.BGL);
            komut4.Parameters.AddWithValue("@p1",id);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            SqlDataReader dr = komut4.ExecuteReader();
            while (dr.Read())
            {
                Entityogrenci ent = new Entityogrenci();
              
                ent.Ad = dr["OGRAD"].ToString();
                ent.Soyad = dr["OGRSOYAD"].ToString();
                ent.Numara = dr["OGRNUMARA"].ToString();
                ent.Fotograf = dr["OGRFOTO"].ToString();
                ent.Sifre = dr["OGRSIFRE"].ToString();
                ent.Bakiye = Convert.ToDouble(dr["OGRBAKIYE"].ToString());
                degerler.Add(ent);

            }
            dr.Close();
            return degerler;
        }

        public static bool OgrenciGuncelle(Entityogrenci deger )
        {
            SqlCommand komut5 = new SqlCommand("Update TBLOGRENCI set OGRAD=@P1,OGRSOYAD=@P2,OGRNUMARA=@P3,OGRFOTO=@P4,OGRSIFRE=@P5 WHERE OGRID=@P6",Baglantı.BGL);
            if (komut5.Connection.State != ConnectionState.Open)
            {
                komut5.Connection.Open();
            }
            komut5.Parameters.AddWithValue("@P1", deger.Ad);
            komut5.Parameters.AddWithValue("@P2",deger.Soyad);
            komut5.Parameters.AddWithValue("@P3",deger.Numara);
            komut5.Parameters.AddWithValue("@P4",deger.Fotograf);
            komut5.Parameters.AddWithValue("@P5",deger.Sifre);
            komut5.Parameters.AddWithValue("@P6",deger.Id);
            return komut5.ExecuteNonQuery() > 0;

        }
    }
}
