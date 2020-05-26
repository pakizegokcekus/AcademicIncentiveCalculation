using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class A1MasterPage : System.Web.UI.MasterPage
{
    
    protected void Page_Load(object sender, EventArgs e)
    {

        ASPxComboBoxUnvan.Items.Clear();
        ComboBoxAlan.Items.Clear();
        

        ASPxComboBoxUnvan.Items.Add("Profesör");
        ASPxComboBoxUnvan.Items.Add("Doçent");
        ASPxComboBoxUnvan.Items.Add("Doktor Öğretim Görevlisi");
        ASPxComboBoxUnvan.Items.Add("Araştırma Görevlisi");
        ASPxComboBoxUnvan.Items.Add("Öğretim Görevlisi");

        ComboBoxAlan.Items.Add("A1 Alanları: Eğitim Bilimleri, Fen Bilimleri ve Matematik, Mühendislik, Sağlık Bilimleri, Ziraat, Orman ve Su Ürünleri ");
        ComboBoxAlan.Items.Add("A2 Alanları: Filoloji, Hukuk, İlahiyat, Sosyal, Beşeri ve İdari Bilimler, Spor Bilimleri ");
        ComboBoxAlan.Items.Add("A3 Alanı: Mimarlık, Planlama ve Tasarım");
        ComboBoxAlan.Items.Add("A4 Alanı: Güzel Sanatlar");

        
        

        


    }










    //proje Alanı

    double deger = 0;
    string l = "";
    protected void Ekle1_Click1(object sender, EventArgs e)
    {

        if(ComboBoxAlan.Text=="" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }



        else if (ASPxComboBox37.Text == "Yürütücü")
        {
            deger = 1;
            l = "/Y";

        }
        else if (ASPxComboBox37.Text == "Araştırmacı")
        {
            deger = 0.5;
            l = "/A";

        }
      
         else if (ASPxComboBox37.Text == "")
        {

            Response.Write("<script lang='JavaScript'>alert('Y/A Alanı Boş Geçilemez');</script>");
        }
        
           
        
        
            
        

        LabelProje.Text = l + "" + LabelProje.Text;
        double sonuc = deger * 80 * 20 / 100;

        Labelp3.Text = (sonuc + Convert.ToDouble(Labelp3.Text)).ToString();//çalıyor

    }


    protected void Ekle2_Click(object sender, EventArgs e)
    {

        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }


         else if (ASPxComboBox38.Text == "Yürütücü")
        {
            deger = 1;
            l = "/Y";

        }
        else if (ASPxComboBox38.Text == "Araştırmacı")
        {
            deger = 0.5;
            l = "/A";

        }
        else if (ASPxComboBox38.Text == "")
        {

            Response.Write("<script lang='JavaScript'>alert('Y/A Alanı Boş Geçilemez');</script>");
        }



        LabelProje.Text = l + "" + LabelProje.Text;

        double sonuc = deger * 70 * 20 / 100;
        Labelp3.Text = (sonuc + Convert.ToDouble(Labelp3.Text)).ToString();

    }

    protected void Ekle3_Click(object sender, EventArgs e)
    {

        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }

        else if (ASPxComboBox39.Text == "Yürütücü")
        {
            deger = 1;
            l = "/Y";

        }
        else if (ASPxComboBox39.Text == "Araştırmacı")
        {
            deger = 0.5;
            l = "/A";

        }
        else if (ASPxComboBox39.Text == "")
        {

            Response.Write("<script lang='JavaScript'>alert('Y/A Alanı Boş Geçilemez');</script>");
        }


        LabelProje.Text = l + "" + LabelProje.Text;

        double sonuc = deger * 100 * 20 / 100;
        Labelp3.Text = (sonuc + Convert.ToDouble(Labelp3.Text)).ToString();

    }

    protected void Ekle4_Click(object sender, EventArgs e)
    {


        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }

        else if (ASPxComboBox40.Text == "Yürütücü")
        {
            deger = 1;
            l = "Y";

        }
        else if (ASPxComboBox40.Text == "Araştırmacı")
        {
            deger = 0.5;
            l = "A";

        }
         else if (ASPxComboBox40.Text == "")
        {

            Response.Write("<script lang='JavaScript'>alert('Y/A Alanı Boş Geçilemez');</script>");
        }
       


        LabelProje.Text = l + "" + LabelProje.Text;

        double sonuc = deger * 40 * 20/100;
        Labelp3.Text = (sonuc + Convert.ToDouble(Labelp3.Text)).ToString();
    }

    protected void Ekle5_Click(object sender, EventArgs e)
    {

        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }

        else if (ASPxComboBox41.Text == "Yürütücü")
        {
            deger = 1;
            l = "/Y";

        }
        else if (ASPxComboBox41.Text == "Araştırmacı")
        {
            deger = 0.5;
            l = "/A";

        }
        else if (ASPxComboBox41.Text == "")
        {

            Response.Write("<script lang='JavaScript'>alert('Y/A Alanı Boş Geçilemez');</script>");
        }

        LabelProje.Text = l + "" + LabelProje.Text;

        double sonuc = deger * 20 * 20 / 100;
        Labelp3.Text = (sonuc + Convert.ToDouble(Labelp3.Text)).ToString();
    }



    protected void TemizleProje_Click(object sender, EventArgs e)
    {
        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }


        LabelProje.Text = "";
        Labelp3.Text = 0.ToString();
    }

    //Arastırma Alanı


    protected void BtnEkleA_Click(object sender, EventArgs e)
    {




        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }
        else if (ASPxComboBox1.Text == "" || ASPxComboBox2.Text == "" || ASPxComboBox3.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Lütfen Seçimlerinizi Eksiksiz Giriniz!');</script>");
        }

        else {
            double a = Convert.ToDouble(ASPxComboBox1.Text);
            double k = Convert.ToDouble(ASPxComboBox2.Text);
            double b;
            if (ASPxComboBox2.Text == "1")
            {
                b = 1;
            }
            else if (ASPxComboBox2.Text == "2")
            {
                b = 0.8;
            }
            else if (ASPxComboBox2.Text == "3")
            {
                b = 0.6;
            }
            else if (ASPxComboBox2.Text == "4")
            {
                b = 0.45;
            }
            else { b = 1 / k; }

            double c = Convert.ToDouble(ASPxComboBox3.Text);
            double sonuc = a * b * c * 15 * 15 / 100;
            Label2Proje.Text = "YD:" + a + "/" + k + "/" + c + " " + Label2Proje.Text;


            ArastırmaAna.Text = (sonuc + Convert.ToDouble(ArastırmaAna.Text)).ToString();
        }
    }

    double b;
    protected void BtnEkleA2_Click(object sender, EventArgs e)
    {

        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }

        else if (ASPxComboBox4.Text == "" || ASPxComboBox5.Text == "" || ASPxComboBox6.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Lütfen Seçimlerinizi Eksiksiz Giriniz!');</script>");
        }
        else
        {
            double a = Convert.ToDouble(ASPxComboBox4.Text);
            double k = Convert.ToDouble(ASPxComboBox5.Text);
            double b;
            if (ASPxComboBox5.Text == "1")
            {
                b = 1;
            }
            else if (ASPxComboBox5.Text == "2")
            {
                b = 0.8;
            }
            else if (ASPxComboBox5.Text == "3")
            {
                b = 0.6;
            }
            else if (ASPxComboBox5.Text == "4")
            {
                b = 0.45;
            }
            else { b = 1 / k; }

            double c = Convert.ToDouble(ASPxComboBox6.Text);
            double sonuc2 = a * b * c * 15 * 10 / 100;
            Label2Proje.Text = "Yİ:" + a + "/" + k + "/" + c + " " + Label2Proje.Text;
            ArastırmaAna.Text = (sonuc2 + Convert.ToDouble(ArastırmaAna.Text)).ToString();
        }




    }




    protected void TemizleAraştırma_Click(object sender, EventArgs e)
    {
        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }

        Label2Proje.Text = "";
        ArastırmaAna.Text = 0.ToString();
    }


    //Yayın




    protected void BootstrapButton8_Click(object sender, EventArgs e)
    {


        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }

        else if (ASPxComboBox7.Text == "" || ASPxComboBox22.Text == "" || DergiPuan1.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Lütfen Seçimlerinizi Eksiksiz Giriniz!');</script>");
        }
        else
        {
            double c;
            double a = Convert.ToDouble(ASPxComboBox7.Text);//kac tane
            double b = Convert.ToDouble(ASPxComboBox22.Text);//kişi sayısı

            if (DergiPuan1.Text == "Q1")
            {
                c = 1;

            }
            else if (DergiPuan1.Text == "Q2")
            {
                c = 0.8;
            }
            else if (DergiPuan1.Text == "Q3")
            {
                c = 0.4;
            }
            else if (DergiPuan1.Text == "Q4")
            {
                c = 0.25;
            }
            else
                c = 0;

            double sonuc3 = 0;
            if (LabelAlan.Text == "A1 Alanları: Eğitim Bilimleri, Fen Bilimleri ve Matematik, Mühendislik, Sağlık Bilimleri, Ziraat, Orman ve Su Ürünleri ")
            {
                sonuc3 = a / b * c * 30 * 60 / 100;
            }
            else if (LabelAlan.Text == "A2 Alanları: Filoloji, Hukuk, İlahiyat, Sosyal, Beşeri ve İdari Bilimler, Spor Bilimleri ")
            {
                sonuc3 = a / b * c * 30 * 80 / 100;
            }
            else if (LabelAlan.Text == "A3 Alanı: Mimarlık, Planlama ve Tasarım")
            {
                sonuc3 = a / b * c * 30 * 60 / 100;
            }
            else if (LabelAlan.Text == "A4 Alanı: Güzel Sanatlar")
            {
                sonuc3 = a / b * c * 30 * 80 / 100;
            }
            LabelYayın.Text = "D:" + a + "/" + b + " " + LabelYayın.Text;

            LabelYayın2.Text = (sonuc3 + Convert.ToDouble(LabelYayın2.Text)).ToString();

        }
    }

    protected void BootstrapButton7_Click(object sender, EventArgs e)
    {


        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }

        else if (ASPxComboBox8.Text == "" || ASPxComboBox23.Text == "" || DergiPuan2.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Lütfen Seçimlerinizi Eksiksiz Giriniz!');</script>");
        }

        else
        {



            double c;
            double a = Convert.ToDouble(ASPxComboBox8.Text);//kac tane
            double b = Convert.ToDouble(ASPxComboBox23.Text);//kişi sayısı
            if (DergiPuan2.Text == "Q1")
            {
                c = 1;

            }
            else if (DergiPuan2.Text == "Q2")
            {
                c = 0.8;
            }
            else if (DergiPuan2.Text == "Q3")
            {
                c = 0.4;
            }
            else if (DergiPuan2.Text == "Q4")
            {
                c = 0.25;
            }
            else c = 0;

            double sonuc4 = 0;
            if (LabelAlan.Text == "A1 Alanları: Eğitim Bilimleri, Fen Bilimleri ve Matematik, Mühendislik, Sağlık Bilimleri, Ziraat, Orman ve Su Ürünleri ")
            {
                sonuc4 = a / b * c * 30 * 30 / 100;
            }
            else if (LabelAlan.Text == "A2 Alanları: Filoloji, Hukuk, İlahiyat, Sosyal, Beşeri ve İdari Bilimler, Spor Bilimleri ")
            {
                sonuc4 = a / b * c * 30 * 40 / 100;
            }
            else if (LabelAlan.Text == "A3 Alanı: Mimarlık, Planlama ve Tasarım")
            {
                sonuc4 = a / b * c * 30 * 30 / 100;
            }
            else if (LabelAlan.Text == "A4 Alanı: Güzel Sanatlar")
            {
                sonuc4 = a / b * c * 30 * 40 / 100;
            }


            LabelYayın.Text = "D:" + a + "/" + b + " " + LabelYayın.Text;

            LabelYayın2.Text = (sonuc4 + Convert.ToDouble(LabelYayın2.Text)).ToString();

        }
    }

    protected void BootstrapButton3_Click(object sender, EventArgs e)
    {

        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }

        else if (ASPxComboBox9.Text == "" || ASPxComboBox24.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Lütfen Seçimlerinizi Eksiksiz Giriniz!');</script>");
        }
        else
        {


            double a = Convert.ToDouble(ASPxComboBox9.Text);//adet sayısı
            double b = Convert.ToDouble(ASPxComboBox24.Text);//kişi sayısı

            double sonuc = 0;


            if (LabelAlan.Text == "A1 Alanları: Eğitim Bilimleri, Fen Bilimleri ve Matematik, Mühendislik, Sağlık Bilimleri, Ziraat, Orman ve Su Ürünleri ")
            {
                sonuc = a / b * 30 * 20 / 100;
            }
            else if (LabelAlan.Text == "A2 Alanları: Filoloji, Hukuk, İlahiyat, Sosyal, Beşeri ve İdari Bilimler, Spor Bilimleri ")
            {
                sonuc = a / b * 30 * 25 / 100;
            }
            else if (LabelAlan.Text == "A3 Alanı: Mimarlık, Planlama ve Tasarım")
            {
                sonuc = a / b * 30 * 20 / 100;
            }
            else if (LabelAlan.Text == "A4 Alanı: Güzel Sanatlar")
            {
                sonuc = a / b * 30 * 25 / 100;
            }

            LabelYayın.Text = a + "/" + b + " " + LabelYayın.Text;
            LabelYayın2.Text = (sonuc + Convert.ToDouble(LabelYayın2.Text)).ToString();
        }


    }

    protected void BootstrapButton5_Click(object sender, EventArgs e)
    {


        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }

        else if (ASPxComboBox11.Text == "" || ASPxComboBox26.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Lütfen Seçimlerinizi Eksiksiz Giriniz!');</script>");
        }

        else
        {
            double a = Convert.ToDouble(ASPxComboBox11.Text);//adet sayısı
            double b = Convert.ToDouble(ASPxComboBox26.Text);//kişi sayısı

            double sonuc = 0;


            if (LabelAlan.Text == "A1 Alanları: Eğitim Bilimleri, Fen Bilimleri ve Matematik, Mühendislik, Sağlık Bilimleri, Ziraat, Orman ve Su Ürünleri ")
            {
                sonuc = a / b * 30 * 15 / 100;
            }
            else if (LabelAlan.Text == "A2 Alanları: Filoloji, Hukuk, İlahiyat, Sosyal, Beşeri ve İdari Bilimler, Spor Bilimleri ")
            {
                sonuc = a / b * 30 * 20 / 100;
            }
            else if (LabelAlan.Text == "A3 Alanı: Mimarlık, Planlama ve Tasarım")
            {
                sonuc = a / b * 30 * 15 / 100;
            }
            else if (LabelAlan.Text == "A4 Alanı: Güzel Sanatlar")
            {
                sonuc = a / b * 30 * 20 / 100;
            }




            LabelYayın.Text = a + "/" + b + " " + LabelYayın.Text;
            LabelYayın2.Text = (sonuc + Convert.ToDouble(LabelYayın2.Text)).ToString();
        }
    }

    protected void BootstrapButton17_Click(object sender, EventArgs e)
    {


        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }

        else if (ASPxComboBox12.Text == "" || ASPxComboBox27.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Lütfen Seçimlerinizi Eksiksiz Giriniz!');</script>");
        }
        else
        {

            double a = Convert.ToDouble(ASPxComboBox12.Text);//adet sayısı
            double b = Convert.ToDouble(ASPxComboBox27.Text);//kişi sayısı

            double sonuc = 0;

            if (LabelAlan.Text == "A1 Alanları: Eğitim Bilimleri, Fen Bilimleri ve Matematik, Mühendislik, Sağlık Bilimleri, Ziraat, Orman ve Su Ürünleri ")
            {
                sonuc = a / b * 30 * 15 / 100;
            }
            else if (LabelAlan.Text == "A2 Alanları: Filoloji, Hukuk, İlahiyat, Sosyal, Beşeri ve İdari Bilimler, Spor Bilimleri ")
            {
                sonuc = a / b * 30 * 20 / 100;
            }
            else if (LabelAlan.Text == "A3 Alanı: Mimarlık, Planlama ve Tasarım")
            {
                sonuc = a / b * 30 * 15 / 100;
            }
            else if (LabelAlan.Text == "A4 Alanı: Güzel Sanatlar")
            {
                sonuc = a / b * 30 * 20 / 100;
            }


            LabelYayın.Text = a + "/" + b + " " + LabelYayın.Text;
            LabelYayın2.Text = (sonuc + Convert.ToDouble(LabelYayın2.Text)).ToString();
        }
    }

    //Yeni Yönetmelik 6-9-10-11Btn
    protected void BootstrapButton6_Click(object sender, EventArgs e)
    {

        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }

        else if (ASPxComboBox13.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Lütfen Seçimlerinizi Eksiksiz Giriniz!');</script>");
        }
        else
        {
            double a = Convert.ToDouble(ASPxComboBox13.Text);//Adet Sayısı
            double sonuc = a * 30 * 25 / 100;
            LabelYayın.Text = a + " " + LabelYayın.Text;
            LabelYayın2.Text = (sonuc + Convert.ToDouble(LabelYayın2.Text)).ToString();
            BootstrapButton6.Visible = false;
        }
    }

    protected void BootstrapButton9_Click(object sender, EventArgs e)
    {

        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }

        else if (ASPxComboBox14.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Lütfen Seçimlerinizi Eksiksiz Giriniz!');</script>");
        }
        else
        {
            double a = Convert.ToDouble(ASPxComboBox14.Text);//Adet Sayısı
            double sonuc = a * 30 * 15 / 100;
            LabelYayın.Text = a + " " + LabelYayın.Text;
            LabelYayın2.Text = (sonuc + Convert.ToDouble(LabelYayın2.Text)).ToString();
            BootstrapButton9.Visible = false;
        }
    }

    protected void BootstrapButton10_Click(object sender, EventArgs e)
    {
        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }

        else if (ASPxComboBox15.Text == "" )
        {
            Response.Write("<script lang='JavaScript'>alert('Lütfen Seçimlerinizi Eksiksiz Giriniz!');</script>");
        }

        else
        {
            double a = Convert.ToDouble(ASPxComboBox15.Text);//Adet Sayısı
            double sonuc = a * 30 * 10 / 100;
            LabelYayın.Text = a + " " + LabelYayın.Text;
            LabelYayın2.Text = (sonuc + Convert.ToDouble(LabelYayın2.Text)).ToString();
            BootstrapButton10.Visible = false;
        }
    }
    protected void BootstrapButton11_Click(object sender, EventArgs e)
    {
        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }

        else if (ASPxComboBox16.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Lütfen Seçimlerinizi Eksiksiz Giriniz!');</script>");
        }
        else
        {
            double a = Convert.ToDouble(ASPxComboBox16.Text);//Adet Sayısı
            double sonuc = a * 30 * 10 / 100;
            LabelYayın.Text = a + " " + LabelYayın.Text;
            LabelYayın2.Text = (sonuc + Convert.ToDouble(LabelYayın2.Text)).ToString();
            BootstrapButton11.Visible = false;
        }

    }
    protected void BootstrapButton12_Click(object sender, EventArgs e)
    {
        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }

        else if (ASPxComboBox17.Text == "" || ASPxComboBox32.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Lütfen Seçimlerinizi Eksiksiz Giriniz!');</script>");
        }
        else
        {
            double a = Convert.ToDouble(ASPxComboBox17.Text);//adet sayısı
            double b = Convert.ToDouble(ASPxComboBox32.Text);//kişi sayısı

            double sonuc = (a / b * 30 * 100) / 100;
            LabelYayın.Text = a + "/" + b + " " + LabelYayın.Text;
            LabelYayın2.Text = (sonuc + Convert.ToDouble(LabelYayın2.Text)).ToString();
        }
    }

    protected void BootstrapButton13_Click(object sender, EventArgs e)
    {

        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }

        else if (ASPxComboBox18.Text == "" || ASPxComboBox33.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Lütfen Seçimlerinizi Eksiksiz Giriniz!');</script>");
        }
        else
        {
            double a = Convert.ToDouble(ASPxComboBox18.Text);//adet sayısı
            double b = Convert.ToDouble(ASPxComboBox33.Text);//kişi sayısı

            double sonuc = (a / b * 30 * 60) / 100;
            LabelYayın.Text = a + "/" + b + " " + LabelYayın.Text;
            LabelYayın2.Text = (sonuc + Convert.ToDouble(LabelYayın2.Text)).ToString();
        }
    }

    protected void BootstrapButton14_Click(object sender, EventArgs e)
    {

        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }

        else if (ASPxComboBox19.Text == "" || ASPxComboBox34.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Lütfen Seçimlerinizi Eksiksiz Giriniz!');</script>");
        }
        else
        {


            double a = Convert.ToDouble(ASPxComboBox19.Text);//adet sayısı
            double b = Convert.ToDouble(ASPxComboBox34.Text);//kişi sayısı

            double sonuc = (a / b * 30 * 25) / 100;
            LabelYayın.Text = a + "/" + b + " " + LabelYayın.Text;
            LabelYayın2.Text = (sonuc + Convert.ToDouble(LabelYayın2.Text)).ToString();
        }
    }
    protected void BootstrapButton15_Click(object sender, EventArgs e)
    {

        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }

        else if (ASPxComboBox20.Text == "" || ASPxComboBox35.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Lütfen Seçimlerinizi Eksiksiz Giriniz!');</script>");
        }
        else
        {
            double a = Convert.ToDouble(ASPxComboBox20.Text);//adet sayısı
            double b = Convert.ToDouble(ASPxComboBox35.Text);//kişi sayısı

            double sonuc = (a / b * 30 * 50) / 100;
            LabelYayın.Text = a + "/" + b + " " + LabelYayın.Text;
            LabelYayın2.Text = (sonuc + Convert.ToDouble(LabelYayın2.Text)).ToString();
        }

    }
    protected void BootstrapButton16_Click(object sender, EventArgs e)
    {

        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }

        else if (ASPxComboBox21.Text == "" || ASPxComboBox36.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Lütfen Seçimlerinizi Eksiksiz Giriniz!');</script>");
        }
        else
        {
            double a = Convert.ToDouble(ASPxComboBox21.Text);//adet sayısı
            double b = Convert.ToDouble(ASPxComboBox36.Text);//kişi sayısı

            double sonuc = (a / b * 30 * 15) / 100;
            LabelYayın.Text = a + "/" + b + " " + LabelYayın.Text;
            LabelYayın2.Text = (sonuc + Convert.ToDouble(LabelYayın2.Text)).ToString();
        }

    }

    protected void ButtonYayın3_Click(object sender, EventArgs e)
    {

        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }


        else if (ASPxComboBox28.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Lütfen Seçimlerinizi Eksiksiz Giriniz!');</script>");
        }

        else
        {
            double a = Convert.ToDouble(ASPxComboBox28.Text);//Adet Sayısı

            double sonuc = a * 30 * 20 / 100;
            LabelYayın.Text = a + " " + LabelYayın.Text;
            LabelYayın2.Text = (sonuc + Convert.ToDouble(LabelYayın2.Text)).ToString();

        }
    }


    protected void BtnYayın2(object sender, EventArgs e)
    {

        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }
        else if (ASPxComboBox30.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Lütfen Seçimlerinizi Eksiksiz Giriniz!');</script>");
        }
        else
        {
            double a = Convert.ToDouble(ASPxComboBox30.Text);//Adet Sayısı
            double sonuc = a * 30 * 10 / 100;
            LabelYayın.Text = a + " " + LabelYayın.Text;
            LabelYayın2.Text = (sonuc + Convert.ToDouble(LabelYayın2.Text)).ToString();

        }
    }



    protected void ButtonYayın1(object sender, EventArgs e)
    {

        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }

        else if (ASPxComboBox52.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Lütfen Seçimlerinizi Eksiksiz Giriniz!');</script>");
        }
        else
        {
            double a = Convert.ToDouble(ASPxComboBox52.Text);//Adet Sayısı
            double sonuc = a * 30 * 10 / 100;
            LabelYayın.Text = a + " " + LabelYayın.Text;
            LabelYayın2.Text = (sonuc + Convert.ToDouble(LabelYayın2.Text)).ToString();

        }
    }



    protected void TemizleYayın_Click(object sender, EventArgs e)
    {

        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }

        LabelYayın.Text = "";
        LabelYayın2.Text = 0.ToString();

    }

    //Tasarım Alanı
    protected void EkleTasarım(object sender, EventArgs e)
    {

        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }

        else if (ComboboxTasarım1.Text == "" || ComboboxTasarım2.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Lütfen Seçimlerinizi Eksiksiz Giriniz!');</script>");
        }
        else
        {
            double a = Convert.ToDouble(ComboboxTasarım1.Text);
            double b = Convert.ToDouble(ComboboxTasarım2.Text);


            double sonuc4 = (a / b * 15 * 15) / 100;
            LabelTasarım2.Text = a + "/" + b + " " + LabelTasarım2.Text;
            LabelTasarım1.Text = (sonuc4 + Convert.ToDouble(LabelTasarım1.Text)).ToString();



        }
    }

    protected void TemizleTasarım_Click(object sender, EventArgs e)
    {
        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }

        LabelTasarım2.Text = "";
        LabelTasarım1.Text = 0.ToString();
    }

    //Sergi Ekle Butonları



    protected void SergiEkle1(object sender, EventArgs e)
    {


        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }

        else if (ASPxComboBox54.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Lütfen Seçimlerinizi Eksiksiz Giriniz!');</script>");
        }

        else
        {
            double sonuc4 = 0;
            double a = Convert.ToDouble(ASPxComboBox54.Text);



            if (LabelAlan.Text == "A4 Alanı: Güzel Sanatlar")
            {
                sonuc4 = a * 15 * 30 / 100;


                LabelSergi2.Text = a + "/" + LabelSergi2.Text;
                LabelSergi1.Text = (sonuc4 + Convert.ToDouble(LabelSergi1.Text)).ToString();
            }
            else
            {

                Response.Write("<script lang='JavaScript'>alert('Bu Bölümden Sadece A4 Alanındakiler Puan Alabilmektedir.');</script>");
            }





        }
    }
    protected void SergiEkle2(object sender, EventArgs e)
    {
        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }

        else if (ASPxComboBox55.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Lütfen Seçimlerinizi Eksiksiz Giriniz!');</script>");
        }
        else
        {
            double sonuc = 0;
            double a = Convert.ToDouble(ASPxComboBox55.Text);



            if (LabelAlan.Text == "A4 Alanı: Güzel Sanatlar")
            {
                sonuc = a * 15 * 15 / 100;


                LabelSergi2.Text = a + "/" + LabelSergi2.Text;
                LabelSergi1.Text = (sonuc + Convert.ToDouble(LabelSergi1.Text)).ToString();
            }
            else
            {

                Response.Write("<script lang='JavaScript'>alert('Bu Bölümden Sadece A4 Alanındakiler Puan Alabilmektedir.');</script>");
            }

        }
    }
    protected void SergiEkle3(object sender, EventArgs e)
    {

        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }

        else if (ASPxComboBox56.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Lütfen Seçimlerinizi Eksiksiz Giriniz!');</script>");
        }

        else
        {
            double sonuc = 0;
            double a = Convert.ToDouble(ASPxComboBox56.Text);



            if (LabelAlan.Text == "A4 Alanı: Güzel Sanatlar")
            {
                sonuc = a * 15 * 15 / 100;


                LabelSergi2.Text = a + "/" + LabelSergi2.Text;
                LabelSergi1.Text = (sonuc + Convert.ToDouble(LabelSergi1.Text)).ToString();
            }
            else
            {

                Response.Write("<script lang='JavaScript'>alert('Bu Bölümden Sadece A4 Alanındakiler Puan Alabilmektedir.');</script>");
            }

        }
    }
    protected void SergiEkle4(object sender, EventArgs e)
    {

        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }

        else if (ASPxComboBox57.Text == "" )
        {
            Response.Write("<script lang='JavaScript'>alert('Lütfen Seçimlerinizi Eksiksiz Giriniz!');</script>");
        }

        else
        {
            double sonuc = 0;
            double a = Convert.ToDouble(ASPxComboBox57.Text);



            if (LabelAlan.Text == "A4 Alanı: Güzel Sanatlar")
            {
                sonuc = a * 15 * 8 / 100;


                LabelSergi2.Text = a + "/" + LabelSergi2.Text;
                LabelSergi1.Text = (sonuc + Convert.ToDouble(LabelSergi1.Text)).ToString();
            }
            else
            {

                Response.Write("<script lang='JavaScript'>alert('Bu Bölümden Sadece A4 Alanındakiler Puan Alabilmektedir.');</script>");
            }

        }

    }
    protected void TemizleSergi_Click(object sender, EventArgs e)
    {

        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }

        LabelSergi2.Text = "";
        LabelSergi1.Text = 0.ToString();
    }


    protected void BtnEklePatent1_Click(object sender, EventArgs e)
    {

        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }
        else if (ComBoboxPatent1.Text == "" || ComBoboxPatent2.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Lütfen Seçimlerinizi Eksiksiz Giriniz!');</script>");
        }
        else
        {
            double a = Convert.ToDouble(ComBoboxPatent1.Text);
            double b = Convert.ToDouble(ComBoboxPatent2.Text);

            double sonuc5 = (a / b * 30 * 100) / 100;
            LabelPatent2.Text = "Uluslararası:" + a + "/" + b + " " + LabelPatent2.Text;
            LabelPatent1.Text = (sonuc5 + Convert.ToDouble(LabelPatent1.Text)).ToString();
        }
    }

    protected void BtnEklePatent2_Click(object sender, EventArgs e)
    {

        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }

        else if (ComboBoxPatent3.Text == "" || ComboboxPatent4.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Lütfen Seçimlerinizi Eksiksiz Giriniz!');</script>");
        }
        else
        {
            double a = Convert.ToDouble(ComboBoxPatent3.Text);
            double b = Convert.ToDouble(ComboboxPatent4.Text);

            double sonuc6 = (a / b * 30 * 60) / 100;
            LabelPatent2.Text = "Ulusal:" + a + "/" + b + " " + LabelPatent2.Text;
            LabelPatent1.Text = (sonuc6 + Convert.ToDouble(LabelPatent1.Text)).ToString();

        }
    }




    protected void TemizlePatent_Click(object sender, EventArgs e)
    {

        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }


        LabelPatent2.Text = "";
        LabelPatent1.Text = 0.ToString();
    }


    //Atıf Bölümü

    protected void ASPxButton1_Click(object sender, EventArgs e)
    {

        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }

        else if (ASPxComboBoxA1.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Lütfen Seçimlerinizi Eksiksiz Giriniz!');</script>");
        }
        else
        {
            double a = Convert.ToDouble(ASPxComboBoxA1.Text);
            double sonuc = 0;


            if (LabelAlan.Text == "A1 Alanları: Eğitim Bilimleri, Fen Bilimleri ve Matematik, Mühendislik, Sağlık Bilimleri, Ziraat, Orman ve Su Ürünleri ")
            {
                sonuc = a * 30 * 4 / 100;
            }
            else if (LabelAlan.Text == "A2 Alanları: Filoloji, Hukuk, İlahiyat, Sosyal, Beşeri ve İdari Bilimler, Spor Bilimleri ")
            {
                sonuc = sonuc = a * 30 * 6 / 100;
            }
            else if (LabelAlan.Text == "A3 Alanı: Mimarlık, Planlama ve Tasarım")
            {
                sonuc = sonuc = a * 30 * 4 / 100;
            }
            else if (LabelAlan.Text == "A4 Alanı: Güzel Sanatlar")
            {
                sonuc = sonuc = a * 30 * 6 / 100;
            }


            LabelAtıf2.Text = ":" + a + " " + LabelAtıf2.Text;
            LabelAtıf.Text = (sonuc + Convert.ToDouble(LabelAtıf.Text)).ToString();

        }

    }
    protected void ASPxButton2_Click(object sender, EventArgs e)
    {

        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }
        else if (ASPxComboBoxA2.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Lütfen Seçimlerinizi Eksiksiz Giriniz!');</script>");
        }
        else
        {

            double a = Convert.ToDouble(ASPxComboBoxA2.Text);
            double sonuc = 0;


            if (LabelAlan.Text == "A1 Alanları: Eğitim Bilimleri, Fen Bilimleri ve Matematik, Mühendislik, Sağlık Bilimleri, Ziraat, Orman ve Su Ürünleri ")
            {
                sonuc = a * 30 * 1.5 / 100;
            }
            else if (LabelAlan.Text == "A2 Alanları: Filoloji, Hukuk, İlahiyat, Sosyal, Beşeri ve İdari Bilimler, Spor Bilimleri ")
            {
                sonuc = sonuc = a * 30 * 3 / 100;
            }
            else if (LabelAlan.Text == "A3 Alanı: Mimarlık, Planlama ve Tasarım")
            {
                sonuc = sonuc = a * 30 * 1.5 / 100;
            }
            else if (LabelAlan.Text == "A4 Alanı: Güzel Sanatlar")
            {
                sonuc = sonuc = a * 30 * 3 / 100;
            }

            LabelAtıf2.Text = ":" + a + " " + LabelAtıf2.Text;
            LabelAtıf.Text = (sonuc + Convert.ToDouble(LabelAtıf.Text)).ToString();
        }
    }
    protected void ASPxButton3_Click(object sender, EventArgs e)
    {

        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }


        else if (ASPxComboBoxA3.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Lütfen Seçimlerinizi Eksiksiz Giriniz!');</script>");
        }
        else
        {
            double a = Convert.ToDouble(ASPxComboBoxA3.Text);
            double sonuc = 0;


            if (LabelAlan.Text == "A1 Alanları: Eğitim Bilimleri, Fen Bilimleri ve Matematik, Mühendislik, Sağlık Bilimleri, Ziraat, Orman ve Su Ürünleri ")
            {
                sonuc = a * 30 * 1 / 100;
            }
            else if (LabelAlan.Text == "A2 Alanları: Filoloji, Hukuk, İlahiyat, Sosyal, Beşeri ve İdari Bilimler, Spor Bilimleri ")
            {
                sonuc = sonuc = a * 30 * 2 / 100;
            }
            else if (LabelAlan.Text == "A3 Alanı: Mimarlık, Planlama ve Tasarım")
            {
                sonuc = sonuc = a * 30 * 1 / 100;
            }
            else if (LabelAlan.Text == "A4 Alanı: Güzel Sanatlar")
            {
                sonuc = sonuc = a * 30 * 2 / 100;
            }


            LabelAtıf2.Text = ":" + a + " " + LabelAtıf2.Text;
            LabelAtıf.Text = (sonuc + Convert.ToDouble(LabelAtıf.Text)).ToString();
        }
    }
    protected void ASPxButton4_Click(object sender, EventArgs e)
    {

        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }

        else if (ASPxComboBoxA4.Text == "" )
        {
            Response.Write("<script lang='JavaScript'>alert('Lütfen Seçimlerinizi Eksiksiz Giriniz!');</script>");
        }
        else
        {
            double a = Convert.ToDouble(ASPxComboBoxA4.Text);
            double sonuc = 0;



            if (LabelAlan.Text == "A1 Alanları: Eğitim Bilimleri, Fen Bilimleri ve Matematik, Mühendislik, Sağlık Bilimleri, Ziraat, Orman ve Su Ürünleri ")
            {
                sonuc = a * 30 * 1 / 100;
            }
            else if (LabelAlan.Text == "A2 Alanları: Filoloji, Hukuk, İlahiyat, Sosyal, Beşeri ve İdari Bilimler, Spor Bilimleri ")
            {
                sonuc = sonuc = a * 30 * 2 / 100;
            }
            else if (LabelAlan.Text == "A3 Alanı: Mimarlık, Planlama ve Tasarım")
            {
                sonuc = sonuc = a * 30 * 1 / 100;
            }
            else if (LabelAlan.Text == "A4 Alanı: Güzel Sanatlar")
            {
                sonuc = sonuc = a * 30 * 2 / 100;
            }


            LabelAtıf2.Text = ":" + a + " " + LabelAtıf2.Text;
            LabelAtıf.Text = (sonuc + Convert.ToDouble(LabelAtıf.Text)).ToString();
        }
    }
    protected void ASPxButton5_Click(object sender, EventArgs e)
    {

        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }
        else if (ASPxComboBoxA5.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Lütfen Seçimlerinizi Eksiksiz Giriniz!');</script>");
        }
        else
        {

            double a = Convert.ToDouble(ASPxComboBoxA5.Text);
            double sonuc = 0;


            if (LabelAlan.Text == "A1 Alanları: Eğitim Bilimleri, Fen Bilimleri ve Matematik, Mühendislik, Sağlık Bilimleri, Ziraat, Orman ve Su Ürünleri ")
            {
                sonuc = a * 30 * 4 / 100;
            }
            else if (LabelAlan.Text == "A2 Alanları: Filoloji, Hukuk, İlahiyat, Sosyal, Beşeri ve İdari Bilimler, Spor Bilimleri ")
            {
                sonuc = sonuc = a * 30 * 8 / 100;
            }
            else if (LabelAlan.Text == "A3 Alanı: Mimarlık, Planlama ve Tasarım")
            {
                sonuc = sonuc = a * 30 * 4 / 100;
            }
            else if (LabelAlan.Text == "A4 Alanı: Güzel Sanatlar")
            {
                sonuc = sonuc = a * 30 * 8 / 100;
            }


            LabelAtıf2.Text = ":" + a + " " + LabelAtıf2.Text;
            LabelAtıf.Text = (sonuc + Convert.ToDouble(LabelAtıf.Text)).ToString();
        }
    }
    protected void ASPxButton6_Click(object sender, EventArgs e)
    {

        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }
        else if (ASPxComboBoxA6.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Lütfen Seçimlerinizi Eksiksiz Giriniz!');</script>");
        }
        else
        {
            double a = Convert.ToDouble(ASPxComboBoxA6.Text);
            double sonuc = 0;


            if (LabelAlan.Text == "A1 Alanları: Eğitim Bilimleri, Fen Bilimleri ve Matematik, Mühendislik, Sağlık Bilimleri, Ziraat, Orman ve Su Ürünleri ")
            {
                sonuc = a * 30 * 2 / 100;
            }
            else if (LabelAlan.Text == "A2 Alanları: Filoloji, Hukuk, İlahiyat, Sosyal, Beşeri ve İdari Bilimler, Spor Bilimleri ")
            {
                sonuc = sonuc = a * 30 * 4 / 100;
            }
            else if (LabelAlan.Text == "A3 Alanı: Mimarlık, Planlama ve Tasarım")
            {
                sonuc = sonuc = a * 30 * 2 / 100;
            }
            else if (LabelAlan.Text == "A4 Alanı: Güzel Sanatlar")
            {
                sonuc = sonuc = a * 30 * 4 / 100;
            }


            LabelAtıf2.Text = ":" + a + " " + LabelAtıf2.Text;
            LabelAtıf.Text = (sonuc + Convert.ToDouble(LabelAtıf.Text)).ToString();
        }
    }

    protected void AtıfEkle2(object sender, EventArgs e)
    {

        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }

        else if (ASPxComboBox58.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Lütfen Seçimlerinizi Eksiksiz Giriniz!');</script>");
        }
        else
        {
            double a = Convert.ToDouble(ASPxComboBox58.Text);
            double sonuc = 0;
            if (ComboBoxAlan.Text == "A4 Alanı: Güzel Sanatlar")
            {
                sonuc = a * 30 * 8 / 100;
                LabelAtıf2.Text = ":" + a + " " + LabelAtıf2.Text;
                LabelAtıf.Text = (sonuc + Convert.ToDouble(LabelAtıf.Text)).ToString();
            }
            else
            {
                Response.Write("<script lang='JavaScript'>alert('Bu Alandan Sadece A4 Alanındaki Akademisyenler Puan Alabilmektedir.');</script>");
            }

        }

    }

    protected void AtıfEkle1(object sender, EventArgs e)
    {

        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }
        else if (ASPxComboBox59.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Lütfen Seçimlerinizi Eksiksiz Giriniz!');</script>");
        }

        else
        {

            double a = Convert.ToDouble(ASPxComboBox59.Text);
            double sonuc = 0;
            if (ComboBoxAlan.Text == "A4 Alanı: Güzel Sanatlar")
            {
                sonuc = a * 30 * 4 / 100;
                LabelAtıf2.Text = ":" + a + " " + LabelAtıf2.Text;
                LabelAtıf.Text = (sonuc + Convert.ToDouble(LabelAtıf.Text)).ToString();
            }
            else
            {
                Response.Write("<script lang='JavaScript'>alert('Bu Alandan Sadece A4 Alanındaki Akademisyenler Puan Alabilmektedir.');</script>");
            }
        }

    }


    protected void TemizleAtıf_Click(object sender, EventArgs e)
    {


        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }

        LabelAtıf2.Text = "";
        LabelAtıf.Text = 0.ToString();
    }

    //Tebliğ Kısmı
    protected void ASPxButton7_Click(object sender, EventArgs e)
    {


        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }

        else if (ASPxComboBox43.Text == "" || ASPxComboBox44.Text=="")
        {
            Response.Write("<script lang='JavaScript'>alert('Lütfen Seçimlerinizi Eksiksiz Giriniz!');</script>");
        }
        else
        {
            double a = Convert.ToDouble(ASPxComboBox43.Text);
            double k = Convert.ToDouble(ASPxComboBox44.Text);
            double b;
            if (ASPxComboBox44.Text == "1")
            {
                b = 1;
            }
            else if (ASPxComboBox44.Text == "2")
            {
                b = 0.8;
            }
            else if (ASPxComboBox44.Text == "3")
            {
                b = 0.6;
            }
            else if (ASPxComboBox44.Text == "4")
            {
                b = 0.45;
            }
            else
            {

                b = 1 / k;
            }

            double sonuc = a * b * 20 * 15 / 100;
            LabelTebli1.Text = (sonuc + Convert.ToDouble(LabelTebli1.Text)).ToString();
            LabelTebli2.Text = ":" + a + "/" + k + " ";
        }


    }
    protected void TemizleTeblig_Click(object sender, EventArgs e)
    {


        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }

        LabelTebli1.Text = 0.ToString();
        LabelTebli2.Text = "";
    }


    //Ödül KIsmı

    protected void BootstrapButton18_Click(object sender, EventArgs e)
    {

        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }

        else if (ASPxComboBox45.Text == "" || ComboBoxO.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Lütfen Seçimlerinizi Eksiksiz Giriniz!');</script>");
        }
        else
        {
            double k;
            double a = Convert.ToDouble(ASPxComboBox45.Text);
            double b = Convert.ToDouble(ComboBoxO.Text);
            if (ComboBoxO.Text == "1")
            {
                k = 1;
            }
            else if (ComboBoxO.Text == "2")
            {
                k = 0.8;
            }
            else if (ComboBoxO.Text == "3")
            {
                k = 0.6;
            }
            else if (ComboBoxO.Text == "4")
            {
                k = 0.45;
            }
            else
            {
                k = 1 / b;
            }

            double sonuc = a * k * 1 * 20;
            LabelOdul.Text = (sonuc + Convert.ToDouble(LabelOdul.Text)).ToString();
            LabelOdul2.Text = ":" + a + "/" + b + " " + LabelOdul2.Text;
        }
    }
    protected void BootstrapButton19_Click(object sender, EventArgs e)
    {

        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }
        else if (ASPxComboBox46.Text == "" || ComboBoxO0.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Lütfen Seçimlerinizi Eksiksiz Giriniz!');</script>");
        }
        else
        {
            double k;
            double a = Convert.ToDouble(ASPxComboBox46.Text);
            double b = Convert.ToDouble(ComboBoxO0.Text);
            if (ComboBoxO.Text == "1")
            {
                k = 1;
            }
            else if (ComboBoxO0.Text == "2")
            {
                k = 0.8;
            }
            else if (ComboBoxO0.Text == "3")
            {
                k = 0.6;
            }
            else if (ComboBoxO0.Text == "4")
            {
                k = 0.45;
            }
            else
            {
                k = 1 / b;
            }

            double sonuc = a * k * 1 * 20;
            LabelOdul.Text = (sonuc + Convert.ToDouble(LabelOdul.Text)).ToString();
            LabelOdul2.Text = ":" + a + "/" + b + " " + LabelOdul2.Text;
        }
    }
    protected void BootstrapButton20_Click(object sender, EventArgs e)
    {

        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }

        else if (ASPxComboBox47.Text == "" || ComboBoxO1.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Lütfen Seçimlerinizi Eksiksiz Giriniz!');</script>");
        }
        else
        {
            double k;
            double a = Convert.ToDouble(ASPxComboBox47.Text);
            double b = Convert.ToDouble(ComboBoxO1.Text);
            if (ComboBoxO.Text == "1")
            {
                k = 1;
            }
            else if (ComboBoxO1.Text == "2")
            {
                k = 0.8;
            }
            else if (ComboBoxO1.Text == "3")
            {
                k = 0.6;
            }
            else if (ComboBoxO1.Text == "4")
            {
                k = 0.45;
            }
            else
            {
                k = 1 / b;
            }

            double sonuc = a * k * 1 * 20;
            LabelOdul.Text = (sonuc + Convert.ToDouble(LabelOdul.Text)).ToString();
            LabelOdul2.Text = ":" + a + "/" + b + " " + LabelOdul2.Text;
        }

    }

    protected void BootstrapButton23_Click(object sender, EventArgs e)
    {

        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }
        else if (ASPxComboBox50.Text == "" || ComboBoxO4.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Lütfen Seçimlerinizi Eksiksiz Giriniz!');</script>");
        }
        else
        {
            double k;
            double a = Convert.ToDouble(ASPxComboBox50.Text);
            double b = Convert.ToDouble(ComboBoxO4.Text);
            if (ComboBoxO.Text == "1")
            {
                k = 1;
            }
            else if (ComboBoxO4.Text == "2")
            {
                k = 0.8;
            }
            else if (ComboBoxO4.Text == "3")
            {
                k = 0.6;
            }
            else if (ComboBoxO4.Text == "4")
            {
                k = 0.45;
            }
            else
            {
                k = 1 / b;
            }

            double sonuc = a * k * 40 * 20 / 100;
            LabelOdul.Text = (sonuc + Convert.ToDouble(LabelOdul.Text)).ToString();
            LabelOdul2.Text = ":" + a + "/" + b + " " + LabelOdul2.Text;
        }
    }
    protected void BootstrapButton24_Click(object sender, EventArgs e)
    {

        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }

        else if (ASPxComboBox51.Text == "" || ComboBoxO5.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Lütfen Seçimlerinizi Eksiksiz Giriniz!');</script>");
        }

        else
        {
            double k;
            double a = Convert.ToDouble(ASPxComboBox51.Text);
            double b = Convert.ToDouble(ComboBoxO5.Text);
            if (ComboBoxO5.Text == "1")
            {
                k = 1;
            }
            else if (ComboBoxO5.Text == "2")
            {
                k = 0.8;
            }
            else if (ComboBoxO5.Text == "3")
            {
                k = 0.6;
            }
            else if (ComboBoxO5.Text == "4")
            {
                k = 0.45;
            }
            else
            {
                k = 1 / b;
            }

            double sonuc = a * k * 20 / 100 * 20;
            LabelOdul.Text = (sonuc + Convert.ToDouble(LabelOdul.Text)).ToString();
            LabelOdul2.Text = ":" + a + "/" + b + " " + LabelOdul2.Text;
        }
    }


    protected void OdulEkle3(object sender, EventArgs e)
    {

        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }

        else if (ASPxComboBox60.Text == "" || ASPxComboBox61.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Lütfen Seçimlerinizi Eksiksiz Giriniz!');</script>");
        }
        else
        {
            double k;
            double a = Convert.ToDouble(ASPxComboBox60.Text);
            double b = Convert.ToDouble(ASPxComboBox61.Text);
            if (ComboBoxO5.Text == "1")
            {
                k = 1;
            }
            else if (ComboBoxO5.Text == "2")
            {
                k = 0.8;
            }
            else if (ComboBoxO5.Text == "3")
            {
                k = 0.6;
            }
            else if (ComboBoxO5.Text == "4")
            {
                k = 0.45;
            }
            else
            {
                k = 1 / b;
            }

            if (ComboBoxAlan.Text == "A4 Alanı: Güzel Sanatlar")
            {
                double sonuc = a * k * 40 / 100 * 20;
                LabelOdul.Text = (sonuc + Convert.ToDouble(LabelOdul.Text)).ToString();
                LabelOdul2.Text = ":" + a + "/" + b + " " + LabelOdul2.Text;
            }
            else
            {
                Response.Write("<script lang='JavaScript'>alert('Bu Alandan Sadece A4 Alanındaki Akademisyenler Puan Alabilmektedir.');</script>");
            }





        }
    }
    protected void OdulEkle2(object sender, EventArgs e)
    {


        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }

        else if (ASPxComboBox62.Text == "" || ASPxComboBox63.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Lütfen Seçimlerinizi Eksiksiz Giriniz!');</script>");
        }
        else
        {
            double k;
            double a = Convert.ToDouble(ASPxComboBox62.Text);
            double b = Convert.ToDouble(ASPxComboBox63.Text);
            if (ComboBoxO5.Text == "1")
            {
                k = 1;
            }
            else if (ComboBoxO5.Text == "2")
            {
                k = 0.8;
            }
            else if (ComboBoxO5.Text == "3")
            {
                k = 0.6;
            }
            else if (ComboBoxO5.Text == "4")
            {
                k = 0.45;
            }
            else
            {
                k = 1 / b;
            }

            if (ComboBoxAlan.Text == "A4 Alanı: Güzel Sanatlar")
            {
                double sonuc = a * k * 20 * 20 / 100;
                LabelOdul.Text = (sonuc + Convert.ToDouble(LabelOdul.Text)).ToString();
                LabelOdul2.Text = ":" + a + "/" + b + " " + LabelOdul2.Text;
            }
            else
            {
                Response.Write("<script lang='JavaScript'>alert('Bu Alandan Sadece A4 Alanındaki Akademisyenler Puan Alabilmektedir.');</script>");
            }

        }
    }

    protected void OdulEkle1(object sender, EventArgs e)
    {

        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }
        else if (ASPxComboBox64.Text == "" || ASPxComboBox65.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Lütfen Seçimlerinizi Eksiksiz Giriniz!');</script>");
        }
        else
        {
            double k;
            double a = Convert.ToDouble(ASPxComboBox64.Text);
            double b = Convert.ToDouble(ASPxComboBox65.Text);
            if (ComboBoxO5.Text == "1")
            {
                k = 1;
            }
            else if (ComboBoxO5.Text == "2")
            {
                k = 0.8;
            }
            else if (ComboBoxO5.Text == "3")
            {
                k = 0.6;
            }
            else if (ComboBoxO5.Text == "4")
            {
                k = 0.45;
            }
            else
            {
                k = 1 / b;
            }

            if (ComboBoxAlan.Text == "A3 Alanı: Mimarlık, Planlama ve Tasarım")
            {
                double sonuc = a * k * 20 / 100 * 20;
                LabelOdul.Text = (sonuc + Convert.ToDouble(LabelOdul.Text)).ToString();
                LabelOdul2.Text = ":" + a + "/" + b + " " + LabelOdul2.Text;
            }
            else
            {
                Response.Write("<script lang='JavaScript'>alert('Bu Alandan Sadece A3 Alanındaki Akademisyenler Puan Alabilmektedir.');</script>");
            }

        }
    }

    protected void TemizleOdul_Click(object sender, EventArgs e)
    {

        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }

        LabelOdul.Text = 0.ToString();
        LabelOdul2.Text = "";
    }


    //Hesaplama Bölümü



    protected void Btn_Hesapla_Click(object sender, EventArgs e)
    {

        if (ComboBoxAlan.Text == "" || ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alanınızı ve Unvanınızı Seçiniz!');</script>");
        }

        Label1.Text = Labelp3.Text;
        Label3.Text = ArastırmaAna.Text;
        Label5.Text = LabelYayın2.Text;
        Label7.Text = LabelTasarım1.Text;
        Label9.Text = LabelPatent1.Text;
        Label11.Text = LabelAtıf.Text;
        Label13.Text = LabelTebli1.Text;
        Label15.Text = LabelOdul.Text;
        double a = Convert.ToDouble(Label1.Text);
        double b = Convert.ToDouble(Label3.Text);
        double c = Convert.ToDouble(Label5.Text);
        double d = Convert.ToDouble(Label7.Text);
        double f = Convert.ToDouble(Label9.Text);
        double g = Convert.ToDouble(Label11.Text);
        double h = Convert.ToDouble(Label13.Text);
        double l = Convert.ToDouble(Label15.Text);

        if (a > 20)
        {
            a = 20;
            Label2.Text = "20";
        }
        else Label2.Text = a.ToString();

        if (b > 15)
        {
            b = 15;
            Label4.Text = "15";
        }
        else Label4.Text = b.ToString();

        if (c > 30)
        {
            c = 30;
            Label6.Text = "30";
        }
        else Label6.Text = c.ToString();

        if (d > 15)
        {
            d = 15;
            Label8.Text = "15";
        }
        else Label8.Text = d.ToString();

        if (f > 30)
        {
            f = 30;
            Label10.Text = "30";
        }
        else Label10.Text = f.ToString();

        if (g > 30)
        {
            g = 30;
            Label12.Text = "30";

        }
        else Label12.Text = f.ToString();

        if (h > 20)
        {
            h = 20;
            Label14.Text = "20";
        }
        else Label14.Text = h.ToString();

        if (l > 20)
        {
            l = 20;
            Label16.Text = "20";

        }
        else Label16.Text = l.ToString();

        LabelTesvikp.Text = (a + b + c + d + f + g + h + l).ToString();

        if ((a + b + c + d + f + g + h + l) >= 30)
        {


            if (ASPxComboBoxUnvan.Text == "Profesör")
            {
                LabelTesvikm.Text = (((a + b + c + d + f + g + h + l) / 100) * 1387.5795 * 1).ToString() + "tl";
            }
            else if (ASPxComboBoxUnvan.Text == "Doçent")
            {
                LabelTesvikm.Text = (((a + b + c + d + f + g + h + l) / 100) * 1387.5795 * 0.9).ToString() + "tl";
            }
            else if (ASPxComboBoxUnvan.Text == "Doktor Öğretim Görevlisi")
            {
                LabelTesvikm.Text = (((a + b + c + d + f + g + h + l) / 100) * 1387.5795 * 0.8).ToString() + "tl";
            }
            else if (ASPxComboBoxUnvan.Text == "Araştırma Görevlisi")
            {
                LabelTesvikm.Text = (((a + b + c + d + f + g + h + l) / 100) * 1387.5795 * 0.7).ToString() + "tl";
            }
            else if (ASPxComboBoxUnvan.Text == "Öğretim Görevlisi")
            {
                LabelTesvikm.Text = (((a + b + c + d + f + g + h + l) / 100) * 1387.5795 * 0.7).ToString() + "tl";
            }

        }
        else { LabelTesvikm.Text = "0 tl"; }
       
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Page.Response.Redirect(Page.Request.Url.ToString(), true);

    }


    protected void ButonTamam_Click1(object sender, EventArgs e)
    {

        LabelAlan.Text = ComboBoxAlan.Text;
        LabelUnvan.Text = ASPxComboBoxUnvan.Text;

       if(ComboBoxAlan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Alan Alanı Boş Seçiniz.');</script>");
        }
        if (ASPxComboBoxUnvan.Text == "")
        {
            Response.Write("<script lang='JavaScript'>alert('Unvan Alanı Boş Geçilemez.');</script>");
        }

      




      

        DergiPuan1.Items.Clear();
        DergiPuan1.Items.Add("Q1");
        DergiPuan1.Items.Add("Q2");
        DergiPuan1.Items.Add("Q3");
        DergiPuan1.Items.Add("Q4");

        DergiPuan2.Items.Clear();
        DergiPuan2.Items.Add("Q1");
        DergiPuan2.Items.Add("Q2");
        DergiPuan2.Items.Add("Q3");
        DergiPuan2.Items.Add("Q4");


        ASPxComboBox37.Items.Clear();
        ASPxComboBox37.Items.Add("Yürütücü");
        ASPxComboBox37.Items.Add("Araştırmacı");

        ASPxComboBox38.Items.Clear();
        ASPxComboBox38.Items.Add("Yürütücü");
        ASPxComboBox38.Items.Add("Araştırmacı");

        ASPxComboBox39.Items.Clear();
        ASPxComboBox39.Items.Add("Yürütücü");
        ASPxComboBox39.Items.Add("Araştırmacı");

        ASPxComboBox40.Items.Clear();
        ASPxComboBox40.Items.Add("Yürütücü");
        ASPxComboBox40.Items.Add("Araştırmacı");

        ASPxComboBox41.Items.Clear();
        ASPxComboBox41.Items.Add("Yürütücü");
        ASPxComboBox41.Items.Add("Araştırmacı");




        ASPxComboBox13.Items.Clear();
        ASPxComboBox13.Items.Add("1");//Yeni yönetmelikle ilgili kural 2020
        ASPxComboBox14.Items.Clear();
        ASPxComboBox14.Items.Add("1");
        ASPxComboBox15.Items.Clear();
        ASPxComboBox15.Items.Add("1");
        ASPxComboBox16.Items.Clear();
        ASPxComboBox16.Items.Add("1");



        ASPxComboBox1.Items.Clear();
        ASPxComboBox2.Items.Clear();
        ASPxComboBox3.Items.Clear();
        ASPxComboBox4.Items.Clear();
        ASPxComboBox5.Items.Clear();
        ASPxComboBox6.Items.Clear();
        ASPxComboBox7.Items.Clear();
        ASPxComboBox8.Items.Clear();
        ASPxComboBox9.Items.Clear();
        ASPxComboBox11.Items.Clear();
        ASPxComboBox12.Items.Clear();
        ASPxComboBox17.Items.Clear();
        ASPxComboBox18.Items.Clear();
        ASPxComboBox19.Items.Clear();
        ASPxComboBox20.Items.Clear();
        ASPxComboBox21.Items.Clear();
        ASPxComboBox22.Items.Clear();
        ASPxComboBox23.Items.Clear();
        ASPxComboBox24.Items.Clear();
        ASPxComboBox26.Items.Clear();
        ASPxComboBox27.Items.Clear();
        ASPxComboBox28.Items.Clear();
        ASPxComboBox30.Items.Clear();
        ASPxComboBox32.Items.Clear();
        ASPxComboBox33.Items.Clear();
        ASPxComboBox34.Items.Clear();
        ASPxComboBox35.Items.Clear();
        ASPxComboBox36.Items.Clear();
        ASPxComboBox52.Items.Clear();
        ComboboxTasarım1.Items.Clear();
        ComboboxTasarım2.Items.Clear();
        ComBoboxPatent1.Items.Clear();
        ComBoboxPatent2.Items.Clear();
        ComboBoxPatent3.Items.Clear();
        ComboboxPatent4.Items.Clear();
        ASPxComboBoxA1.Items.Clear();
        ASPxComboBoxA2.Items.Clear();
        ASPxComboBoxA3.Items.Clear();
        ASPxComboBoxA4.Items.Clear();
        ASPxComboBoxA5.Items.Clear();
        ASPxComboBoxA6.Items.Clear();
        ASPxComboBox43.Items.Clear();
        ASPxComboBox44.Items.Clear();
        ASPxComboBox45.Items.Clear();
        ASPxComboBox46.Items.Clear();
        ASPxComboBox47.Items.Clear();
       
        ASPxComboBox50.Items.Clear();
        ASPxComboBox51.Items.Clear();
        ASPxComboBox58.Items.Clear();
        ASPxComboBox59.Items.Clear();
        ComboBoxO.Items.Clear();
        ComboBoxO0.Items.Clear();
        ComboBoxO1.Items.Clear();
        
        ComboBoxO4.Items.Clear();
        ComboBoxO5.Items.Clear();
        ASPxComboBox54.Items.Clear();
        ASPxComboBox55.Items.Clear();
        ASPxComboBox56.Items.Clear();
        ASPxComboBox57.Items.Clear();

        ASPxComboBox60.Items.Clear();
        ASPxComboBox61.Items.Clear();
        ASPxComboBox62.Items.Clear();
        ASPxComboBox63.Items.Clear();
        ASPxComboBox64.Items.Clear();
        ASPxComboBox65.Items.Clear();
        //ArastırmaAna.Text = (sonuc + sonuc2).ToString();
        for (int i = 1; i < 37; i++)
        {


            ASPxComboBox58.Items.Add(i.ToString());
            ASPxComboBox59.Items.Add(i.ToString());
            ASPxComboBox60.Items.Add(i.ToString());
            ASPxComboBox61.Items.Add(i.ToString());
            ASPxComboBox62.Items.Add(i.ToString());
            ASPxComboBox63.Items.Add(i.ToString());
            ASPxComboBox64.Items.Add(i.ToString());
            ASPxComboBox65.Items.Add(i.ToString());

            ASPxComboBox1.Items.Add(i.ToString());
           
            ASPxComboBox2.Items.Add(i.ToString());
           
            ASPxComboBox3.Items.Add(i.ToString());
           
            ASPxComboBox4.Items.Add(i.ToString());
            
            ASPxComboBox5.Items.Add(i.ToString());
            
            ASPxComboBox6.Items.Add(i.ToString());

           
            ASPxComboBox7.Items.Add(i.ToString());
            
            ASPxComboBox8.Items.Add(i.ToString());
           
            ASPxComboBox9.Items.Add(i.ToString());

            
            ASPxComboBox11.Items.Add(i.ToString());
            
            ASPxComboBox12.Items.Add(i.ToString());


          
            ASPxComboBox17.Items.Add(i.ToString());
           
            ASPxComboBox18.Items.Add(i.ToString());
           
            ASPxComboBox19.Items.Add(i.ToString());
           
            ASPxComboBox20.Items.Add(i.ToString());
           
            ASPxComboBox21.Items.Add(i.ToString());

            ASPxComboBox22.Items.Add(i.ToString());
          
            ASPxComboBox23.Items.Add(i.ToString());
            
            ASPxComboBox24.Items.Add(i.ToString());


           
            ASPxComboBox26.Items.Add(i.ToString());
            
            ASPxComboBox27.Items.Add(i.ToString());
        
            ASPxComboBox28.Items.Add(i.ToString());
            
            ASPxComboBox30.Items.Add(i.ToString());
            
            ASPxComboBox32.Items.Add(i.ToString());
            
            ASPxComboBox33.Items.Add(i.ToString());
            
            ASPxComboBox34.Items.Add(i.ToString());
           
            ASPxComboBox35.Items.Add(i.ToString());
            
            ASPxComboBox36.Items.Add(i.ToString());
           
            ASPxComboBox52.Items.Add(i.ToString());

            
            ComboboxTasarım1.Items.Add(i.ToString());
           
            ComboboxTasarım2.Items.Add(i.ToString());

           
            ComBoboxPatent1.Items.Add(i.ToString());
         
            ComBoboxPatent2.Items.Add(i.ToString());
           
            ComboBoxPatent3.Items.Add(i.ToString());
           
            ComboboxPatent4.Items.Add(i.ToString());


            
            ASPxComboBoxA1.Items.Add(i.ToString());
           
            ASPxComboBoxA2.Items.Add(i.ToString());
            
            ASPxComboBoxA3.Items.Add(i.ToString());
           
            ASPxComboBoxA4.Items.Add(i.ToString());
           
            ASPxComboBoxA5.Items.Add(i.ToString());
            
            ASPxComboBoxA6.Items.Add(i.ToString());


           
            ASPxComboBox43.Items.Add(i.ToString());
           
            ASPxComboBox44.Items.Add(i.ToString());


           
            ASPxComboBox45.Items.Add(i.ToString());
           

            ASPxComboBox46.Items.Add(i.ToString());
            
            ASPxComboBox47.Items.Add(i.ToString());
            
           
            
            ASPxComboBox50.Items.Add(i.ToString());
           
            ASPxComboBox51.Items.Add(i.ToString());

            ASPxComboBox54.Items.Add(i.ToString());
            ASPxComboBox55.Items.Add(i.ToString());
            ASPxComboBox56.Items.Add(i.ToString());
            ASPxComboBox57.Items.Add(i.ToString());
           
            ComboBoxO.Items.Add(i.ToString());
           
            ComboBoxO0.Items.Add(i.ToString());
           
            ComboBoxO1.Items.Add(i.ToString());
            
          
            ComboBoxO4.Items.Add(i.ToString());
           
            ComboBoxO5.Items.Add(i.ToString());





        }



    }


































  
}




