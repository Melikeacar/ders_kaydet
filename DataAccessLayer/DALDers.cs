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
    public class DALDers
    {
        public static List<EntityDers>DersListesi()
        {
            List<EntityDers> degerler = new List<EntityDers>();
            SqlCommand komut2 = new SqlCommand("Select * from TBLDERSLER", Baglantı.BGL);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                EntityDers ent = new EntityDers();
                ent.Id = Convert.ToInt32(dr["DERSID"].ToString());
                ent.Dersad = dr["DERSAD"].ToString();
                ent.Min =int.Parse( dr["DERSMİNKONTEJAN"].ToString());
                ent.Max =int.Parse (dr["DERSMAKSKONTENJAN"].ToString());
                degerler.Add(ent);

            }
            dr.Close();
            return degerler;
        }
        public static int TalepEkle(EntityBasvuruForm parametre)
        {
            SqlCommand komut = new SqlCommand("İnsert into TBLBASVURUFORM (OGRENCIID,DERSID) values (@P1,@P2)", Baglantı.BGL);
            komut.Parameters.AddWithValue("@P1",parametre.Basogrid);
            komut.Parameters.AddWithValue("@P2",parametre.Basdersid);
            if(komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            return komut.ExecuteNonQuery();
        }
    }
}
