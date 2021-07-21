using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using TezAPPV2;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Mime;

namespace TezAPPV2.Model
{
    class Postman
    {
        public int totalsoldier { get; set; }
        public int karakuvvet { get; set; }
        public int denizkuvvet { get; set; }//270
        public int havakuvvet { get; set; }
        public int karatotalchest { get; set; }
        public int havatotalchest { get; set; }
        public int deniztotalchest { get; set; }
        public int kara_xs_chest { get; set; }
        public int kara_s_chest { get; set; }
        public int kara_m_chest { get; set; }
        public int kara_l_chest { get; set; }
        public int kara_xl_chest { get; set; }
        public int kara_2xl_chest { get; set; }//280
        public int hava_xs_chest { get; set; }
        public int hava_s_chest { get; set; }
        public int hava_m_chest { get; set; }
        public int hava_l_chest { get; set; }
        public int hava_2l_chest { get; set; }
        public int hava_xxl_chest { get; set; }
        public int deniz_xs_chest { get; set; }
        public int deniz_s_chest { get; set; }
        public int deniz_m_chest { get; set; }
        public int deniz_l_chest { get; set; }
        public int deniz_xl_chest { get; set; }
        public int deniz_2xl_chest { get; set; }
        public int karatotalbot { get; set; }
        public int havatotalbot { get; set; }
        public int deniztotalbot { get; set; }
        public int kara_34_bot { get; set; }
        public int kara_35_bot { get; set; }
        public int kara_36_bot { get; set; }
        public int kara_37_bot { get; set; }
        public int kara_38_bot { get; set; }//300
        public int kara_39_bot { get; set; }
        public int kara_40_bot { get; set; }
        public int kara_41_bot { get; set; }
        public int kara_42_bot { get; set; }
        public int kara_43_bot { get; set; }
        public int kara_44_bot { get; set; }
        public int kara_45_bot { get; set; }
        public int kara_46_bot { get; set; }
        public int kara_47_bot { get; set; }
        public int kara_48_bot { get; set; }
        public int hava_34_bot { get; set; }
        public int hava_35_bot { get; set; }
        public int hava_36_bot { get; set; }
        public int hava_37_bot { get; set; }
        public int hava_38_bot { get; set; }
        public int hava_39_bot { get; set; }
        public int hava_40_bot { get; set; }
        public int hava_41_bot { get; set; }
        public int hava_42_bot { get; set; }
        public int hava_43_bot { get; set; }
        public int hava_44_bot { get; set; }
        public int hava_45_bot { get; set; }
        public int hava_46_bot { get; set; }
        public int hava_47_bot { get; set; }
        public int hava_48_bot { get; set; }
        public int deniz_34_bot { get; set; }
        public int deniz_35_bot { get; set; }
        public int deniz_36_bot { get; set; }
        public int deniz_37_bot { get; set; }
        public int deniz_38_bot { get; set; }
        public int deniz_39_bot { get; set; }
        public int deniz_40_bot { get; set; }
        public int deniz_41_bot { get; set; }
        public int deniz_42_bot { get; set; }
        public int deniz_43_bot { get; set; }
        public int deniz_44_bot { get; set; }
        public int deniz_45_bot { get; set; }
        public int deniz_46_bot { get; set; }
        public int deniz_47_bot { get; set; }
        public int deniz_48_bot { get; set; }
        public int karatotalpant { get; set; }
        public int havatotalpant { get; set; }
        public int deniztotalpant { get; set; }
        public int kara_xs_pant { get; set; }
        public int kara_s_pant { get; set; }
        public int kara_m_pant { get; set; }
        public int kara_l_pant { get; set; }
        public int kara_xl_pant { get; set; }
        public int kara_2xl_pant { get; set; }
        public int kara_3xl_pant { get; set; }
        public int kara_bxl_pant { get; set; }
        public int hava_xs_pant { get; set; }
        public int hava_s_pant { get; set; }
        public int hava_m_pant { get; set; }
        public int hava_l_pant { get; set; }
        public int hava_xl_pant { get; set; }
        public int hava_2xl_pant { get; set; }
        public int hava_3xl_pant { get; set; }
        public int hava_bxl_pant { get; set; }
        public int deniz_xs_pant { get; set; }
        public int deniz_s_pant { get; set; }
        public int deniz_m_pant { get; set; }
        public int deniz_l_pant { get; set; }
        public int deniz_xl_pant { get; set; }
        public int deniz_2xl_pant { get; set; }
        public int deniz_3xl_pant { get; set; }
        public int deniz_bxl_pant { get; set; }
        public int karatotalhands { get; set; }
        public int havatotalhands { get; set; }
        public int deniztotalhands { get; set; }
        public int kara_xs_hands { get; set; }
        public int kara_s_hands { get; set; }
        public int kara_m_hands { get; set; }
        public int kara_l_hands { get; set; }
        public int kara_xl_hands { get; set; }
        public int kara_2xl_hands { get; set; }
        public int hava_xs_hands { get; set; }
        public int hava_s_hands { get; set; }
        public int hava_m_hands { get; set; }
        public int hava_l_hands { get; set; }
        public int hava_xl_hands { get; set; }
        public int hava_2xl_hands { get; set; }
        public int deniz_xs_hands { get; set; }
        public int deniz_s_hands { get; set; }
        public int deniz_m_hands { get; set; }
        public int deniz_l_hands { get; set; }
        public int deniz_xl_hands { get; set; }
        public int deniz_2xl_hands { get; set; }
    

        public void Getmessagestodikimevi()
        {
            MailMessage mesajkara = new MailMessage();
            mesajkara.From = new MailAddress("ilionsystem@gmail.com");
            SmtpClient smtpkara = new SmtpClient();
            smtpkara.Host = "smtp.gmail.com";
            smtpkara.Port = 587;
            smtpkara.EnableSsl = true;
            mesajkara.To.Add("askeridikimevi.demo@gmail.com");
            mesajkara.Subject = "GONDERILECEK URUN MIKTARLARI!";
            mesajkara.IsBodyHtml = false;
            mesajkara.BodyEncoding = System.Text.Encoding.UTF8;
            mesajkara.Body = "TOPLAM ASKER :"+totalsoldier.ToString()+"\n"+"Toplam Kara Kuvvetleri :"+karakuvvet.ToString()+"\n"+"Toplam Hava Kuvvetleri :" + havakuvvet.ToString() + "\n" + "Toplam Deniz Kuvvetleri :" + denizkuvvet.ToString() + "\n\n" + "Toplam Kara Kuvvetleri UstGiyim :" + karatotalchest.ToString() + "\n" + "Toplam Hava Kuvvetleri UstGiyim :" + havatotalchest.ToString() + "\n" + "Toplam Deniz Kuvvetleri UstGiyim :" + deniztotalchest.ToString() + "\n\n" + "Kara Kuvvetleri UstGiyim(XS) :" + kara_xs_chest.ToString() + "\n" + "Kara Kuvvetleri UstGiyim(S) :"+kara_s_chest.ToString() + "\n" + "Kara Kuvvetleri UstGiyim(M) :" + kara_m_chest.ToString() +"\n"+ "Kara Kuvvetleri UstGiyim(L) :" + kara_l_chest.ToString() + "\n" + "Kara Kuvvetleri UstGiyim(XL) :" + kara_xl_chest.ToString() + "\n" + "Kara Kuvvetleri UstGiyim(2XL) :" + kara_2xl_chest.ToString() + "\n\n" + "Hava Kuvvetleri UstGiyim(XS) :" + hava_xs_chest.ToString() + "\n" + "Hava Kuvvetleri UstGiyim(S) :" + hava_s_chest.ToString() + "\n" + "Hava Kuvvetleri UstGiyim(M) :" + hava_m_chest.ToString() + "\n" + "Hava Kuvvetleri UstGiyim(L) :" + hava_l_chest.ToString() + "\n" + "Hava Kuvvetleri UstGiyim(XL) :" + hava_2l_chest.ToString()+"\n" + "Hava Kuvvetleri UstGiyim(2XL) :" + hava_xxl_chest.ToString() + "\n\n" + "Deniz Kuvvetleri UstGiyim(XS) :" + deniz_xs_chest.ToString() + "\n" + "Deniz Kuvvetleri UstGiyim(S) :" + deniz_s_chest.ToString() + "\n" + "Deniz Kuvvetleri UstGiyim(M) :" + deniz_m_chest.ToString() + "\n" + "Deniz Kuvvetleri UstGiyim(L) :" + deniz_l_chest.ToString() + "\n" + "Deniz Kuvvetleri UstGiyim(XL) :" + deniz_xl_chest.ToString() + "\n" + "Deniz Kuvvetleri UstGiyim(2XL) :" + deniz_2xl_chest.ToString() + "\n\n" +"Kara Kuvvetleri Toplam Bot: " +karatotalbot.ToString() + "\n" + "Hava Kuvvetleri Toplam Bot: " + havatotalbot.ToString() + "\n" + "Deniz Kuvvetleri Toplam Bot: " + deniztotalbot.ToString() + "\n\n" + "Kara Kuvvetleri Bot (34 Numara): " + kara_34_bot.ToString() + "\n" + "Kara Kuvvetleri Bot (35 Numara): " + kara_35_bot.ToString() + "\n" + "Kara Kuvvetleri Bot (36 Numara): " + kara_36_bot.ToString() + "\n" + "Kara Kuvvetleri Bot (37 Numara): " + kara_37_bot.ToString() + "\n" + "Kara Kuvvetleri Bot (38 Numara): " + kara_38_bot.ToString() + "\n" + "Kara Kuvvetleri Bot (39 Numara): " + kara_39_bot.ToString() + "\n" + "Kara Kuvvetleri Bot (40 Numara): " + kara_40_bot.ToString() + "\n" + "Kara Kuvvetleri Bot (41 Numara): " + kara_41_bot.ToString() + "\n" + "Kara Kuvvetleri Bot (42 Numara): " + kara_42_bot.ToString() + "\n" + "Kara Kuvvetleri Bot (43 Numara): " + kara_43_bot.ToString() + "\n" + "Kara Kuvvetleri Bot (44 Numara): " + kara_44_bot.ToString() + "\n" + "Kara Kuvvetleri Bot (45 Numara): " + kara_45_bot.ToString() + "\n" + "Kara Kuvvetleri Bot (46 Numara): " + kara_46_bot.ToString() + "\n" + "Kara Kuvvetleri Bot (47 Numara): " + kara_47_bot.ToString() + "\n" + "Kara Kuvvetleri Bot (48 Numara): " + kara_48_bot.ToString() + "\n\n" + "Hava Kuvvetleri Bot (34 Numara): " + hava_34_bot.ToString() + "\n" + "Hava Kuvvetleri Bot (35 Numara): " + hava_35_bot.ToString() + "\n" + "Hava Kuvvetleri Bot (36 Numara): " + hava_36_bot.ToString() + "\n" + "Hava Kuvvetleri Bot (37 Numara): " + hava_37_bot.ToString() + "\n" + "Hava Kuvvetleri Bot (38 Numara): " + hava_38_bot.ToString() + "\n" + "Hava Kuvvetleri Bot (39 Numara): " + hava_39_bot.ToString() + "\n" + "Hava Kuvvetleri Bot (40 Numara): " + hava_40_bot.ToString() + "\n" + "Hava Kuvvetleri Bot (41 Numara): " + hava_41_bot.ToString() + "\n" + "Hava Kuvvetleri Bot (42 Numara): " + hava_42_bot.ToString() + "\n" + "Hava Kuvvetleri Bot (43 Numara): " + hava_43_bot.ToString() + "\n" + "Hava Kuvvetleri Bot (44 Numara): " + hava_44_bot.ToString() + "\n" + "Hava Kuvvetleri Bot (45 Numara): " + hava_45_bot.ToString() + "\n" + "Hava Kuvvetleri Bot (46 Numara): " + hava_46_bot.ToString() + "\n" + "Hava Kuvvetleri Bot (47 Numara): " + hava_47_bot.ToString() + "\n" + "Hava Kuvvetleri Bot (48 Numara): " + hava_48_bot.ToString() + "\n\n" + "Deniz Kuvvetleri Bot (34 Numara): " + deniz_34_bot.ToString() + "\n" + "Deniz Kuvvetleri Bot (35 Numara): " + deniz_35_bot.ToString() + "\n" + "Deniz Kuvvetleri Bot (36 Numara): " + deniz_36_bot.ToString() + "\n" + "Deniz Kuvvetleri Bot (37 Numara): " + deniz_37_bot.ToString() + "\n" + "Deniz Kuvvetleri Bot (38 Numara): " + deniz_38_bot.ToString() + "\n" + "Deniz Kuvvetleri Bot (39 Numara): " + deniz_39_bot.ToString() + "\n" + "Deniz Kuvvetleri Bot (40 Numara): " + deniz_40_bot.ToString() + "\n" + "Deniz Kuvvetleri Bot (41 Numara): " + deniz_41_bot.ToString() + "\n" + "Deniz Kuvvetleri Bot (42 Numara): " + deniz_42_bot.ToString() + "\n" + "Deniz Kuvvetleri Bot (43 Numara): " + deniz_43_bot.ToString() + "\n" + "Deniz Kuvvetleri Bot (44 Numara): " + deniz_44_bot.ToString() + "\n" + "Deniz Kuvvetleri Bot (45 Numara): " + deniz_45_bot.ToString() + "\n" + "Deniz Kuvvetleri Bot (46 Numara): " + deniz_46_bot.ToString() + "\n" + "Deniz Kuvvetleri Bot (47 Numara): " + deniz_47_bot.ToString() + "\n" + "Deniz Kuvvetleri Bot (48 Numara): " + deniz_48_bot.ToString() + "\n\n" + "Kara Kuvvetleri Toplam Pantolon : " + karatotalpant.ToString() + "\n" + "Hava Kuvvetleri Toplam Pantolon : " + havatotalpant.ToString() + "\n" + "Deniz Kuvvetleri Toplam Pantolon : " + deniztotalpant.ToString() + "\n\n" + "Kara Kuvvetleri Pantolon (XS) : " + kara_xs_pant.ToString() + "\n" + "Kara Kuvvetleri Pantolon (S) : " + kara_s_pant.ToString() + "\n" + "Kara Kuvvetleri Pantolon (M) : " + kara_m_pant.ToString() + "\n" + "Kara Kuvvetleri Pantolon (L) : " + kara_l_pant.ToString() + "\n" + "Kara Kuvvetleri Pantolon (XL) : " + kara_xl_pant.ToString() + "\n" + "Kara Kuvvetleri Pantolon (2XL) : " + kara_2xl_pant.ToString() + "\n" + "Kara Kuvvetleri Pantolon (3XL) : " + kara_3xl_pant.ToString() + "\n" + "Kara Kuvvetleri Pantolon (BXL) : " + kara_bxl_pant.ToString() + "\n\n" + "Hava Kuvvetleri Pantolon (XS) : " + hava_xs_pant.ToString() + "\n" + "Hava Kuvvetleri Pantolon (S) : " + hava_s_pant.ToString() + "\n" + "Hava Kuvvetleri Pantolon (M) : " + hava_m_pant.ToString() + "\n" + "Hava Kuvvetleri Pantolon (L) : " + hava_l_pant.ToString() + "\n" + "Hava Kuvvetleri Pantolon (XL) : " + hava_xl_pant.ToString() + "\n" + "Hava Kuvvetleri Pantolon (2XL) : " + hava_2xl_pant.ToString() + "\n" + "Hava Kuvvetleri Pantolon (3XL) : " + hava_3xl_pant.ToString() + "\n" + "Hava Kuvvetleri Pantolon (BXL) : " + hava_bxl_pant.ToString() + "\n\n" + "Deniz Kuvvetleri Pantolon (XS) : " + deniz_xs_pant.ToString() + "\n" + "Deniz Kuvvetleri Pantolon (S) : " + deniz_s_pant.ToString() + "\n" + "Deniz Kuvvetleri Pantolon (M) : " + deniz_m_pant.ToString() + "\n" + "Deniz Kuvvetleri Pantolon (L) : " + deniz_l_pant.ToString() + "\n" + "Deniz Kuvvetleri Pantolon (XL) : " + deniz_xl_pant.ToString() + "\n" + "Deniz Kuvvetleri Pantolon (2XL) : " + deniz_2xl_pant.ToString() + "\n" + "Deniz Kuvvetleri Pantolon (3XL) : " + deniz_3xl_pant.ToString() + "\n" + "Deniz Kuvvetleri Pantolon (BXL) : " + deniz_bxl_pant.ToString() + "\n\n" + "Kara Kuvvetleri Toplam Eldiven : " + karatotalhands.ToString() + "\n"+"Hava Kuvvetleri Toplam Eldiven : " + havatotalhands.ToString() + "\n" + "Deniz Kuvvetleri Toplam Eldiven : " + deniztotalhands.ToString() + "\n\n" + "Kara Kuvvetleri Eldiven (XS) : " + kara_xs_hands.ToString() + "\n" + "Kara Kuvvetleri Eldiven (S) : " + kara_s_hands.ToString() + "\n" + "Kara Kuvvetleri Eldiven (M) : " + kara_m_hands.ToString() + "\n" + "Kara Kuvvetleri Eldiven (L) : " + kara_l_hands.ToString() + "\n" + "Kara Kuvvetleri Eldiven (XL) : " + kara_xl_hands.ToString() + "\n" + "Kara Kuvvetleri Eldiven (2XL) : " + kara_2xl_hands.ToString() + "\n\n" + "Hava Kuvvetleri Eldiven (XS) : " + hava_xs_hands.ToString() + "\n" + "Hava Kuvvetleri Eldiven (S) : " + hava_s_hands.ToString() + "\n" + "Hava Kuvvetleri Eldiven (M) : " + hava_m_hands.ToString() + "\n" + "Hava Kuvvetleri Eldiven (L) : " + hava_l_hands.ToString() + "\n" + "Hava Kuvvetleri Eldiven (XL) : " + hava_xl_hands.ToString() + "\n" + "Hava Kuvvetleri Eldiven (2XL) : " + hava_2xl_hands.ToString() + "\n\n" + "Deniz Kuvvetleri Eldiven (XS) : " + deniz_xs_hands.ToString() + "\n" + "Deniz Kuvvetleri Eldiven (S) : " + deniz_s_hands.ToString() + "\n" + "Deniz Kuvvetleri Eldiven (M) : " + deniz_m_hands.ToString() + "\n" + "Deniz Kuvvetleri Eldiven (L) : " + deniz_l_hands.ToString() + "\n" + "Deniz Kuvvetleri Eldiven (XL) : " + deniz_xl_hands.ToString() + "\n" + "Deniz Kuvvetleri Eldiven (2XL) : " + deniz_2xl_hands.ToString() + "\n\n";
            //mesaj.Attachments.Add(new Attachment(@"C:\Users\sufuk\OneDrive\Masaüstü\DETECTEDS\" + DateTime.Now.ToString("yyyyMdd") + @"\" + "YAKALA(" + Convert.ToString(dcrptm * dcrpdd) + ").png")); // Burada Resmi Maile ekledik. 
            smtpkara.Credentials = new System.Net.NetworkCredential("ilionsystem@gmail.com", "134679Renes");
            smtpkara.Send(mesajkara);





        }

        public void Getmessagestobirlikler()
        {

            MailMessage mesajkara = new MailMessage();
            mesajkara.From = new MailAddress("ilionsystem@gmail.com");
            SmtpClient smtpkara = new SmtpClient();
            smtpkara.Host = "smtp.gmail.com";
            smtpkara.Port = 587;
            smtpkara.EnableSsl = true;
            mesajkara.To.Add("Karakuvvetleri.demo@gmail.com");
            mesajkara.Subject = "GONDERILECEK URUN MIKTARLARI!";
            mesajkara.IsBodyHtml = false;
            mesajkara.BodyEncoding = System.Text.Encoding.UTF8;
            mesajkara.Body = "TOPLAM ASKER :" + totalsoldier.ToString() + "\n" + "Toplam Kara Kuvvetleri :" + karakuvvet.ToString() + "\n" + "Toplam Kara Kuvvetleri UstGiyim :" + karatotalchest.ToString() + "\n" + "Toplam Hava Kuvvetleri UstGiyim :" + havatotalchest.ToString() + "\n" + "Toplam Deniz Kuvvetleri UstGiyim :" + deniztotalchest.ToString() + "\n\n" + "Kara Kuvvetleri UstGiyim(XS) :" + kara_xs_chest.ToString() + "\n" + "Kara Kuvvetleri UstGiyim(S) :" + kara_s_chest.ToString() + "\n" + "Kara Kuvvetleri UstGiyim(M) :" + kara_m_chest.ToString() + "\n" + "Kara Kuvvetleri UstGiyim(L) :" + kara_l_chest.ToString() + "\n" + "Kara Kuvvetleri UstGiyim(XL) :" + kara_xl_chest.ToString() + "\n" + "Kara Kuvvetleri UstGiyim(2XL) :" + kara_2xl_chest.ToString() + "\n\n" + "Kara Kuvvetleri Toplam Bot: " + karatotalbot.ToString() + "\n" + "Kara Kuvvetleri Bot (34 Numara): " + kara_34_bot.ToString() + "\n" + "Kara Kuvvetleri Bot (35 Numara): " + kara_35_bot.ToString() + "\n" + "Kara Kuvvetleri Bot (36 Numara): " + kara_36_bot.ToString() + "\n" + "Kara Kuvvetleri Bot (37 Numara): " + kara_37_bot.ToString() + "\n" + "Kara Kuvvetleri Bot (38 Numara): " + kara_38_bot.ToString() + "\n" + "Kara Kuvvetleri Bot (39 Numara): " + kara_39_bot.ToString() + "\n" + "Kara Kuvvetleri Bot (40 Numara): " + kara_40_bot.ToString() + "\n" + "Kara Kuvvetleri Bot (41 Numara): " + kara_41_bot.ToString() + "\n" + "Kara Kuvvetleri Bot (42 Numara): " + kara_42_bot.ToString() + "\n" + "Kara Kuvvetleri Bot (43 Numara): " + kara_43_bot.ToString() + "\n" + "Kara Kuvvetleri Bot (44 Numara): " + kara_44_bot.ToString() + "\n" + "Kara Kuvvetleri Bot (45 Numara): " + kara_45_bot.ToString() + "\n" + "Kara Kuvvetleri Bot (46 Numara): " + kara_46_bot.ToString() + "\n" + "Kara Kuvvetleri Bot (47 Numara): " + kara_47_bot.ToString() + "\n" + "Kara Kuvvetleri Bot (48 Numara): "+"\n" + "Kara Kuvvetleri Toplam Pantolon : " + karatotalpant.ToString() + "\n" + "Kara Kuvvetleri Pantolon (XS) : " + kara_xs_pant.ToString() + "\n" + "Kara Kuvvetleri Pantolon (S) : " + kara_s_pant.ToString() + "\n" + "Kara Kuvvetleri Pantolon (M) : " + kara_m_pant.ToString() + "\n" + "Kara Kuvvetleri Pantolon (L) : " + kara_l_pant.ToString() + "\n" + "Kara Kuvvetleri Pantolon (XL) : " + kara_xl_pant.ToString() + "\n" + "Kara Kuvvetleri Pantolon (2XL) : " + kara_2xl_pant.ToString() + "\n" + "Kara Kuvvetleri Pantolon (3XL) : " + kara_3xl_pant.ToString() + "\n" + "Kara Kuvvetleri Pantolon (BXL) : " + kara_bxl_pant.ToString() + "\n\n" + "Kara Kuvvetleri Eldiven (XS) : " + kara_xs_hands.ToString() + "\n" + "Kara Kuvvetleri Eldiven (S) : " + kara_s_hands.ToString() + "\n" + "Kara Kuvvetleri Eldiven (M) : " + kara_m_hands.ToString() + "\n" + "Kara Kuvvetleri Eldiven (L) : " + kara_l_hands.ToString() + "\n" + "Kara Kuvvetleri Eldiven (XL) : " + kara_xl_hands.ToString() + "\n" + "Kara Kuvvetleri Eldiven (2XL) : " + kara_2xl_hands.ToString() + "\n\n";






            //mesaj.Attachments.Add(new Attachment(@"C:\Users\sufuk\OneDrive\Masaüstü\DETECTEDS\" + DateTime.Now.ToString("yyyyMdd") + @"\" + "YAKALA(" + Convert.ToString(dcrptm * dcrpdd) + ").png")); // Burada Resmi Maile ekledik. 
            smtpkara.Credentials = new System.Net.NetworkCredential("ilionsystem@gmail.com", "134679Renes");
            smtpkara.Send(mesajkara);

            MailMessage mesajhava = new MailMessage();
            mesajhava.From = new MailAddress("ilionsystem@gmail.com");
            SmtpClient smtphava = new SmtpClient();
            smtphava.Host = "smtp.gmail.com";
            smtphava.Port = 587;
            smtphava.EnableSsl = true;
            mesajhava.To.Add("Havakuvvetleri.demo@gmail.com");
            mesajhava.Subject = "GONDERILECEK URUN MIKTARLARI!";
            mesajhava.IsBodyHtml = false;
            mesajhava.BodyEncoding = System.Text.Encoding.UTF8;
            mesajhava.Body = "TOPLAM ASKER :" + totalsoldier.ToString() + "\n" + "Toplam Hava Kuvvetleri :" + havakuvvet.ToString() + "\n"+"Toplam Hava Kuvvetleri UstGiyim :" + havatotalchest.ToString() + "\n" + "Hava Kuvvetleri UstGiyim(XS) :" + hava_xs_chest.ToString() + "\n" + "Hava Kuvvetleri UstGiyim(S) :" + hava_s_chest.ToString() + "\n" + "Hava Kuvvetleri UstGiyim(M) :" + hava_m_chest.ToString() + "\n" + "Hava Kuvvetleri UstGiyim(L) :" + hava_l_chest.ToString() + "\n" + "Hava Kuvvetleri UstGiyim(XL) :" + hava_2l_chest.ToString() + "\n" + "Hava Kuvvetleri UstGiyim(2XL) :" + hava_xxl_chest.ToString() + "\n\n"+ "Hava Kuvvetleri Toplam Bot: " + havatotalbot.ToString() + "\n"+"Hava Kuvvetleri Bot (34 Numara): " + hava_34_bot.ToString() + "\n" + "Hava Kuvvetleri Bot (35 Numara): " + hava_35_bot.ToString() + "\n" + "Hava Kuvvetleri Bot (36 Numara): " + hava_36_bot.ToString() + "\n" + "Hava Kuvvetleri Bot (37 Numara): " + hava_37_bot.ToString() + "\n" + "Hava Kuvvetleri Bot (38 Numara): " + hava_38_bot.ToString() + "\n" + "Hava Kuvvetleri Bot (39 Numara): " + hava_39_bot.ToString() + "\n" + "Hava Kuvvetleri Bot (40 Numara): " + hava_40_bot.ToString() + "\n" + "Hava Kuvvetleri Bot (41 Numara): " + hava_41_bot.ToString() + "\n" + "Hava Kuvvetleri Bot (42 Numara): " + hava_42_bot.ToString() + "\n" + "Hava Kuvvetleri Bot (43 Numara): " + hava_43_bot.ToString() + "\n" + "Hava Kuvvetleri Bot (44 Numara): " + hava_44_bot.ToString() + "\n" + "Hava Kuvvetleri Bot (45 Numara): " + hava_45_bot.ToString() + "\n" + "Hava Kuvvetleri Bot (46 Numara): " + hava_46_bot.ToString() + "\n" + "Hava Kuvvetleri Bot (47 Numara): " + hava_47_bot.ToString() + "\n" + "Hava Kuvvetleri Bot (48 Numara): " + hava_48_bot.ToString() + "\n\n" + "Hava Kuvvetleri Toplam Pantolon : " + havatotalpant.ToString() + "\n" + "Hava Kuvvetleri Pantolon (XS) : " + hava_xs_pant.ToString() + "\n" + "Hava Kuvvetleri Pantolon (S) : " + hava_s_pant.ToString() + "\n" + "Hava Kuvvetleri Pantolon (M) : " + hava_m_pant.ToString() + "\n" + "Hava Kuvvetleri Pantolon (L) : " + hava_l_pant.ToString() + "\n" + "Hava Kuvvetleri Pantolon (XL) : " + hava_xl_pant.ToString() + "\n" + "Hava Kuvvetleri Pantolon (2XL) : " + hava_2xl_pant.ToString() + "\n" + "Hava Kuvvetleri Pantolon (3XL) : " + hava_3xl_pant.ToString() + "\n" + "Hava Kuvvetleri Pantolon (BXL) : " + hava_bxl_pant.ToString() + "\n\n" + "Hava Kuvvetleri Toplam Eldiven : " + havatotalhands.ToString() + "\n" + "Hava Kuvvetleri Eldiven (XS) : " + hava_xs_hands.ToString() + "\n" + "Hava Kuvvetleri Eldiven (S) : " + hava_s_hands.ToString() + "\n" + "Hava Kuvvetleri Eldiven (M) : " + hava_m_hands.ToString() + "\n" + "Hava Kuvvetleri Eldiven (L) : " + hava_l_hands.ToString() + "\n" + "Hava Kuvvetleri Eldiven (XL) : " + hava_xl_hands.ToString() + "\n" + "Hava Kuvvetleri Eldiven (2XL) : " + hava_2xl_hands.ToString() + "\n\n";

            //mesaj.Attachments.Add(new Attachment(@"C:\Users\sufuk\OneDrive\Masaüstü\DETECTEDS\" + DateTime.Now.ToString("yyyyMdd") + @"\" + "YAKALA(" + Convert.ToString(dcrptm * dcrpdd) + ").png")); // Burada Resmi Maile ekledik. 
            smtphava.Credentials = new System.Net.NetworkCredential("ilionsystem@gmail.com", "134679Renes");
            smtphava.Send(mesajhava);


            MailMessage mesajdeniz = new MailMessage();
            mesajdeniz.From = new MailAddress("ilionsystem@gmail.com");
            SmtpClient smtpdeniz = new SmtpClient();
            smtpdeniz.Host = "smtp.gmail.com";
            smtpdeniz.Port = 587;
            smtpdeniz.EnableSsl = true;
            mesajdeniz.To.Add("Denizkuvvetleri.demo@gmail.com");
            mesajdeniz.Subject = "GONDERILECEK URUN MIKTARLARI!";
            mesajdeniz.IsBodyHtml = false;
            mesajdeniz.BodyEncoding = System.Text.Encoding.UTF8;
            mesajdeniz.Body = "TOPLAM ASKER :" + totalsoldier.ToString() + "\n" + "Toplam Deniz Kuvvetleri :" + denizkuvvet.ToString()+ "}\n"+"Toplam Deniz Kuvvetleri UstGiyim :" + deniztotalchest.ToString()+"\n"+ "Deniz Kuvvetleri UstGiyim(XS) :" + deniz_xs_chest.ToString() + "\n" + "Deniz Kuvvetleri UstGiyim(S) :" + deniz_s_chest.ToString() + "\n" + "Deniz Kuvvetleri UstGiyim(M) :" + deniz_m_chest.ToString() + "\n" + "Deniz Kuvvetleri UstGiyim(L) :" + deniz_l_chest.ToString() + "\n" + "Deniz Kuvvetleri UstGiyim(XL) :" + deniz_xl_chest.ToString() + "\n" + "Deniz Kuvvetleri UstGiyim(2XL) :" + deniz_2xl_chest.ToString() + "\n\n"+ "Deniz Kuvvetleri Toplam Bot: " + deniztotalbot.ToString() + "\n\n" + "Deniz Kuvvetleri Bot (34 Numara): " + deniz_34_bot.ToString() + "\n" + "Deniz Kuvvetleri Bot (35 Numara): " + deniz_35_bot.ToString() + "\n" + "Deniz Kuvvetleri Bot (36 Numara): " + deniz_36_bot.ToString() + "\n" + "Deniz Kuvvetleri Bot (37 Numara): " + deniz_37_bot.ToString() + "\n" + "Deniz Kuvvetleri Bot (38 Numara): " + deniz_38_bot.ToString() + "\n" + "Deniz Kuvvetleri Bot (39 Numara): " + deniz_39_bot.ToString() + "\n" + "Deniz Kuvvetleri Bot (40 Numara): " + deniz_40_bot.ToString() + "\n" + "Deniz Kuvvetleri Bot (41 Numara): " + deniz_41_bot.ToString() + "\n" + "Deniz Kuvvetleri Bot (42 Numara): " + deniz_42_bot.ToString() + "\n" + "Deniz Kuvvetleri Bot (43 Numara): " + deniz_43_bot.ToString() + "\n" + "Deniz Kuvvetleri Bot (44 Numara): " + deniz_44_bot.ToString() + "\n" + "Deniz Kuvvetleri Bot (45 Numara): " + deniz_45_bot.ToString() + "\n" + "Deniz Kuvvetleri Bot (46 Numara): " + deniz_46_bot.ToString() + "\n" + "Deniz Kuvvetleri Bot (47 Numara): " + deniz_47_bot.ToString() + "\n" + "Deniz Kuvvetleri Bot (48 Numara): " + deniz_48_bot.ToString() + "\n\n" + "Deniz Kuvvetleri Toplam Pantolon : " + deniztotalpant.ToString() + "\n\n"+ "Deniz Kuvvetleri Pantolon (XS) : " + deniz_xs_pant.ToString() + "\n" + "Deniz Kuvvetleri Pantolon (S) : " + deniz_s_pant.ToString() + "\n" + "Deniz Kuvvetleri Pantolon (M) : " + deniz_m_pant.ToString() + "\n" + "Deniz Kuvvetleri Pantolon (L) : " + deniz_l_pant.ToString() + "\n" + "Deniz Kuvvetleri Pantolon (XL) : " + deniz_xl_pant.ToString() + "\n" + "Deniz Kuvvetleri Pantolon (2XL) : " + deniz_2xl_pant.ToString() + "\n" + "Deniz Kuvvetleri Pantolon (3XL) : " + deniz_3xl_pant.ToString() + "\n" + "Deniz Kuvvetleri Pantolon (BXL) : " + deniz_bxl_pant.ToString() + "\n\n" + "Deniz Kuvvetleri Toplam Eldiven : " + deniztotalhands.ToString() + "\n\n" + "Deniz Kuvvetleri Eldiven (XS) : " + deniz_xs_hands.ToString() + "\n" + "Deniz Kuvvetleri Eldiven (S) : " + deniz_s_hands.ToString() + "\n" + "Deniz Kuvvetleri Eldiven (M) : " + deniz_m_hands.ToString() + "\n" + "Deniz Kuvvetleri Eldiven (L) : " + deniz_l_hands.ToString() + "\n" + "Deniz Kuvvetleri Eldiven (XL) : " + deniz_xl_hands.ToString() + "\n" + "Deniz Kuvvetleri Eldiven (2XL) : " + deniz_2xl_hands.ToString() + "\n\n";



            //mesaj.Attachments.Add(new Attachment(@"C:\Users\sufuk\OneDrive\Masaüstü\DETECTEDS\" + DateTime.Now.ToString("yyyyMdd") + @"\" + "YAKALA(" + Convert.ToString(dcrptm * dcrpdd) + ").png")); // Burada Resmi Maile ekledik. 
            smtpdeniz.Credentials = new System.Net.NetworkCredential("ilionsystem@gmail.com", "134679Renes");
            smtpdeniz.Send(mesajdeniz);






        }




    }
}
