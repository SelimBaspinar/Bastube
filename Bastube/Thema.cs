using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bastube
{
    class Thema
    {
        public void LigthThema(Bastube bastube)
        {
            bastube.BackColor = Color.White;
            bastube.panel2.BackColor = Color.White;
            bastube.hakkında.ForeColor = Color.Black;
            bastube.ayarlar.ForeColor = Color.Black;
            bastube.thema.ForeColor = Color.Black;
            bastube.exit.ForeColor = Color.Black;
            bastube.mods.ForeColor = Color.Black;
            bastube.guncellemeKontorl.ForeColor = Color.Black;
            bastube.lblprgname.ForeColor = Color.Black;
            bastube.lblyoutubetag.ForeColor = Color.Black;
            bastube.lblinstatag.ForeColor = Color.Black;
            bastube.lblinsta.ForeColor = Color.Black;
            bastube.lblfacebook.ForeColor = Color.Black;
            bastube.lblyoutube.ForeColor = Color.Black;
            bastube.lblwelcome.ForeColor = Color.Black;
            bastube.lblbastube.ForeColor = Color.Black;


        }
        public void DarkThema(Bastube bastube) {
            bastube.BackColor = Color.FromArgb(61, 56, 57);
            bastube.panel2.BackColor = Color.FromArgb(61, 56, 57);
            bastube.hakkında.ForeColor = Color.White;
            bastube.ayarlar.ForeColor = Color.White;
            bastube.lblprgname.ForeColor = Color.White;
            bastube.lblyoutubetag.ForeColor = Color.White;
            bastube.lblinstatag.ForeColor = Color.White;
            bastube.lblinsta.ForeColor = Color.White;
            bastube.lblfacebook.ForeColor = Color.White;
            bastube.lblyoutube.ForeColor = Color.White;
            bastube.lblwelcome.ForeColor = Color.White;
            bastube.lblbastube.ForeColor = Color.White;

        }
        public void LigthThema(Facebook facebook)
        {
            facebook.BackColor = Color.White;
            facebook.panel1.BackColor = Color.White;
            facebook.hakkında.ForeColor = Color.Black;
            facebook.ayarlar.ForeColor = Color.Black;
            facebook.lblbastube.ForeColor = Color.Black;
            facebook.lbldurum.ForeColor = Color.Black;
            facebook.lblstat.ForeColor = Color.Black;
            facebook.lblurl.ForeColor = Color.Black;
            facebook.lblyuzde.ForeColor = Color.Black;
            facebook.urltxt.ForeColor = Color.Black;
            facebook.urltxt.BackColor = Color.White;
            facebook.urltxt.ForeColor = Color.Black;
        }
        public void DarkThema(Facebook facebook)
        {
            facebook.BackColor = Color.FromArgb(61, 56, 57);
            facebook.panel1.BackColor = Color.FromArgb(61, 56, 57);
            facebook.hakkında.ForeColor = Color.White;
            facebook.ayarlar.ForeColor = Color.White;
            facebook.lblbastube.ForeColor = Color.White;
            facebook.urltxt.ForeColor = Color.White;
            facebook.lblstat.ForeColor = Color.White;
            facebook.lbldurum.ForeColor = Color.White;
            facebook.lblyuzde.ForeColor = Color.White;
            facebook.lblurl.ForeColor = Color.White;
            facebook.urltxt.BackColor = Color.FromArgb(61, 56, 57);
            facebook.urltxt.ForeColor = Color.White;
        }
        public void LigthThema(İnstagram instagram)
        {
            instagram.BackColor = Color.White;
            instagram.panel1.BackColor = Color.White;
            instagram.hakkında.ForeColor = Color.Black;
            instagram.ayarlar.ForeColor = Color.Black;
            instagram.lblbastube.ForeColor = Color.Black;
            instagram.lbldurum.ForeColor = Color.Black;
            instagram.lblstat.ForeColor = Color.Black;
            instagram.lblurl.ForeColor = Color.Black;
            instagram.lblyuzde.ForeColor = Color.Black;
            instagram.lblpicturekind.ForeColor = Color.Black;
            instagram.urltxt.BackColor = Color.White;
            instagram.urltxt.ForeColor = Color.Black;
            instagram.listBox1.ForeColor = Color.Black;
            instagram.listBox2.ForeColor = Color.Black;
            instagram.listBox1.BackColor = Color.White;
            instagram.listBox2.BackColor = Color.White;
            instagram.indır.BackColor = Color.Black;
            instagram.indır.ForeColor = Color.White;
            instagram.urltxt.BackColor = Color.White;
            instagram.urltxt.ForeColor = Color.Black;
            instagram.comboBox1.BackColor = Color.FromArgb(235, 72, 67); ;
            instagram.comboBox1.ForeColor = Color.White;
        }
        public void DarkThema(İnstagram instagram)
        {
            instagram.BackColor = Color.FromArgb(61, 56, 57);
            instagram.panel1.BackColor = Color.FromArgb(61, 56, 57);
            instagram.hakkında.ForeColor = Color.White;
            instagram.ayarlar.ForeColor = Color.White;
            instagram.lblbastube.ForeColor = Color.White;
            instagram.urltxt.BackColor = Color.FromArgb(61, 56, 57);
            instagram.urltxt.ForeColor = Color.White;
            instagram.lblstat.ForeColor = Color.White;
            instagram.lbldurum.ForeColor = Color.White;
            instagram.lblyuzde.ForeColor = Color.White;
            instagram.lblurl.ForeColor = Color.White;
            instagram.lblpicturekind.ForeColor = Color.White;
            instagram.listBox1.ForeColor = Color.White;
            instagram.listBox2.ForeColor = Color.White;
            instagram.listBox1.BackColor = Color.FromArgb(61, 56, 57);
            instagram.listBox2.BackColor = Color.FromArgb(61, 56, 57);
            instagram.indır.BackColor = Color.White;
            instagram.indır.ForeColor = Color.FromArgb(235, 72, 67);
            instagram.urltxt.BackColor = Color.FromArgb(61, 56, 57);
            instagram.urltxt.ForeColor = Color.White;
            instagram.comboBox1.BackColor = Color.FromArgb(61, 56, 57);
            instagram.comboBox1.ForeColor = Color.White;


        }
        public void LigthThema(Youtube youtube)
        {
            youtube.BackColor = Color.White;
            youtube.panel1.BackColor = Color.White;
            youtube.hakkında.ForeColor = Color.Black;
            youtube.ayarlar.ForeColor = Color.Black;
            youtube.lblbastube.ForeColor = Color.Black;
            youtube.lblurl.ForeColor = Color.Black;
            youtube.urltxt.ForeColor = Color.Black;
            youtube.lblstat.ForeColor = Color.Black;
            youtube.lbldurum.ForeColor = Color.Black;
            youtube.lblyuzde.ForeColor = Color.Black;
            youtube.lblformat.ForeColor = Color.Black;
            youtube.rbmp3.ForeColor = Color.Black;
            youtube.rbmp31.ForeColor = Color.Black;
            youtube.rbmp4.ForeColor = Color.Black;
            youtube.rbmp41.ForeColor = Color.Black;
            youtube.urltxt.BackColor = Color.White;


        }
        public void DarkThema(Youtube youtube)
        {
            youtube.BackColor = Color.FromArgb(61, 56, 57);
            youtube.panel1.BackColor = Color.FromArgb(61, 56, 57);
            youtube.hakkında.ForeColor = Color.White;
            youtube.ayarlar.ForeColor = Color.White;
            youtube.lblbastube.ForeColor = Color.White;
            youtube.lblurl.ForeColor = Color.White;
            youtube.urltxt.ForeColor = Color.White;
            youtube.lblstat.ForeColor = Color.White;
            youtube.lbldurum.ForeColor = Color.White;
            youtube.lblyuzde.ForeColor = Color.White;
            youtube.lblformat.ForeColor = Color.White;
            youtube.rbmp3.ForeColor = Color.White;
            youtube.rbmp31.ForeColor = Color.White;
            youtube.rbmp4.ForeColor = Color.White;
            youtube.rbmp41.ForeColor = Color.White;
            youtube.urltxt.BackColor= Color.FromArgb(61, 56, 57);
        }
    }
}
