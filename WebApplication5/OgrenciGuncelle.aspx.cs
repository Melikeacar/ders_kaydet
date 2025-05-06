using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayerr;
using DataAccessLayer;
using BusinessLogicLayer;

namespace WebApplication5
{
    public partial class OgrenciGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)

        {

            int x = Convert.ToInt32(Request.QueryString["OGRID"].ToString());
            Txtıd.Text = x.ToString();
            Txtıd.Enabled = false;

            if (Page.IsPostBack == false)
            {

            

            List<Entityogrenci> OgrList = BLLOgrenci.BllDetay(x);
           
            TxtAd.Text = OgrList[0].Ad.ToString();
            TxtSoyad.Text = OgrList[0].Soyad.ToString();
            TxtNumara.Text = OgrList[0].Numara.ToString();
            TxtFoto.Text = OgrList[0].Fotograf.ToString();
            TxtSifre.Text = OgrList[0].Sifre.ToString();
        }

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Entityogrenci ent = new Entityogrenci();
            ent.Ad = TxtAd.Text;
            ent.Soyad = TxtSoyad.Text;
            ent.Sifre = TxtSifre.Text;
            ent.Numara = TxtNumara.Text;
            ent.Fotograf = TxtFoto.Text;
            ent.Id = Convert.ToInt32(Txtıd.Text);
            BLLOgrenci.OgrenciGuncelleBLL(ent);
            Response.Redirect("OgrenciGuncelle.aspx");

        }
    }
}
