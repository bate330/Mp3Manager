using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace mp3_player
{
    public partial class Form1 : Form
    {
 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Copy_button_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text == "2005")
            {
                string[] tt = new string[] {
                "D:\\Sounds\\Fiera Inquieta.mp3",
                "D:\\Sounds\\DAM - Min Imhabi.mp3",
                "D:\\Sounds\\Rammstein - Ohne Dich.mp3",
                "D:\\Sounds\\Amalia Rodrigues - Coimbra.mp3",
                "D:\\Sounds\\CD's\\The Songs of the World\\Songs from Brazil\\13 A Maluco Do Mangue.wma",
                "D:\\Sounds\\Ska-P - Intifada.mp3",
                "D:\\Sounds\\Enrico Macias - Hatikva.mp3",
                "D:\\Sounds\\Marcel Khalife - Unadikom.mp3",
                "D:\\Sounds\\Zharick León - Cumbia.mp3",
                "D:\\Sounds\\Big Boy & Vico C - Sin Tu amor.mp3",
                "D:\\Sounds\\Global DJ's - San Francisco.mp3",
                "D:\\Sounds\\Shiri Maimon - Ad Shetavin Oti.mp3",
                "D:\\Sounds\\Michel Sardou - Le France.mp3",
                "D:\\Sounds\\Regev Hod - Hatinasi Li (רגב הוד - התינשאי לי DJ).mp3",
                "D:\\Sounds\\Hany Shaker - Hatikhsari.mp3",
                "D:\\Sounds\\Hany Shaker - Almafroud.mp3",
                "D:\\Sounds\\Hany Shaker - Bahebak Ana.mp3",
                "D:\\Sounds\\Hany Shaker - Kelmten.mp3" };
                FolderBrowserDialog sfd = new FolderBrowserDialog();
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string[] values = new string[] { "\\1.mp3", "\\2.mp3", "\\3.mp3", "\\4.mp3", "\\5.wma", "\\6.mp3", "\\7.mp3", "\\8.mp3", "\\9.mp3", "\\10.mp3", "\\11.mp3", "\\12.mp3", "\\13.mp3", "\\14.mp3", "\\15.mp3", "\\16.mp3", "\\17.mp3", "\\18.mp3" };
                    string[] ss = new string[18];
                    for (int i = 0; i <= 17; i++)
                    {
                        ss[i] = sfd.SelectedPath + values[i];
                        File.Copy(tt[i], ss[i]);
                    }
                    MessageBox.Show("File is Copied!");
                }
                else
                    MessageBox.Show("File isn't Copied!");
            }
            if (comboBox1.Text == "2006")
            {
                string[] tt = new string[] {
                "D:\\Sounds\\Hany Shaker - Layoon Al-Quds.mp3",
                "D:\\Sounds\\Fado do Estoril.mp3",
                "D:\\Sounds\\Inimigos da HP - E Saudade.mp3",
                "D:\\Sounds\\Carlos Vives - Carito.mp3",
                "D:\\Sounds\\Iran Costa - Xenhenhem.mp3",
                "D:\\Sounds\\Chelo - Cha Cha.mp3",
                "D:\\Sounds\\Herbert Grönemeyer - Celebrate the Day.mp3",
                "D:\\Sounds\\DJ Tiesto - Touch Me.mp3",
                "D:\\Sounds\\Marcel Khalife - Oummi.mp3",
                "D:\\Sounds\\Faudel - Tellement Je t'Aime (French).mp3",
                "D:\\Sounds\\Hamada Helal - Dayman Domou3.mp3",
                "D:\\Sounds\\Tamer Hosny - Kol-Marra.mp3",
                "D:\\Sounds\\Rabbani - Intifada.mp3",
                "D:\\Sounds\\Rachid Taha - Ya Rayah.mp3",
                "D:\\Sounds\\Cheb Khaled, Faudel & Rachid Taha - Comme d'Habitude.mp3",
                "D:\\Sounds\\Raihan, Hijjaz, Saujana, Nowseeheart, Rabbani, Mirwana - Cahaya Selawat.mp3",
                "D:\\Sounds\\Güler Duman - Türkülerle Gömün Beni.mp3",
                "D:\\Sounds\\Chants de Noel - François Pérusse - Chansons De Noel.mp3",
                "D:\\Sounds\\Yavuz Bingöl - Yemen Türküsü.mp3"};
                FolderBrowserDialog sfd = new FolderBrowserDialog();
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string[] values = new string[] { "\\1.mp3", "\\2.mp3", "\\3.mp3", "\\4.mp3", "\\5.mp3", "\\6.mp3", "\\7.mp3", "\\8.mp3", "\\9.mp3", "\\10.mp3", "\\11.mp3", "\\12.mp3", "\\13.mp3", "\\14.mp3", "\\15.mp3", "\\16.mp3", "\\17.mp3", "\\18.mp3", "\\19.mp3" };
                    string[] ss = new string[19];
                    for (int i = 0; i <= 18; i++)
                    {
                        ss[i] = sfd.SelectedPath + values[i];
                        File.Copy(tt[i], ss[i]);
                    }
                    MessageBox.Show("File is Copied!");
                }
                else
                    MessageBox.Show("File isn't Copied!");
            }
            if (comboBox1.Text == "2007")
            {
                string[] tt = new string[] {
                "D:\\Sounds\\Cheb Khaled - Bakhta.mp3",
                "D:\\Sounds\\Faudel - Baïda (French).mp3",
                "D:\\Sounds\\Daniel - Quebradeira.mp3",
                "D:\\Sounds\\Grupo Revelação - Velocidade da Luz.mp3",
                "D:\\Sounds\\Mr Catra , Mc Rafa e Mc Galo - Rap Classe A.mp3",
                "D:\\Sounds\\Regev Hod - Choref 73.mp3",
                "D:\\Sounds\\Mohamed Mounir - Lola Sahar.mp3",
                "D:\\Sounds\\Bana Bana Söyle.mp3",
                "D:\\Sounds\\Hakim - Salam Aleikoum.mp3",
                "D:\\Sounds\\Carlos Santana & Rob Thomas - Smooth.mp3",
                "D:\\Sounds\\Rio Negro e Solimoes - Vida de Cao.mp3",
                "D:\\Sounds\\Ibrahim Tatlises - Agri Dagi (Cano Cano Remix).mp3",
                "D:\\Sounds\\Sarit Hadad - Shema Yisrael.mp3",
                "D:\\Sounds\\Jerry Reed - Amos Moses.mp3",
                "D:\\Sounds\\Jihad Nasheed - Fadjiroehom.mp3",
                "D:\\Sounds\\Marcel Khalife & Fairouz - Ya Oud.mp3"};
                FolderBrowserDialog sfd = new FolderBrowserDialog();
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string[] values = new string[] { "\\1.mp3", "\\2.mp3", "\\3.mp3", "\\4.mp3", "\\5.mp3", "\\6.mp3", "\\7.mp3", "\\8.mp3", "\\9.mp3", "\\10.mp3", "\\11.mp3", "\\12.mp3", "\\13.mp3", "\\14.mp3", "\\15.mp3", "\\16.mp3", "\\17.mp3", "\\18.mp3", "\\19.mp3" };
                    string[] ss = new string[16];
                    for (int i = 0; i <= 15; i++)
                    {
                        ss[i] = sfd.SelectedPath + values[i];
                        File.Copy(tt[i], ss[i]);
                    }
                    MessageBox.Show("File is Copied!");
                }
                else
                    MessageBox.Show("File isn't Copied!");
            }
            if (comboBox1.Text == "2008")
            {
                string[] tt = new string[] {
                "D:\\Sounds\\Mohamed Lamine, Rim'K & Sheryne - Clandestino.mp3",
                "D:\\Sounds\\Cheb Khaled & Melissa - Benthi.mp3",
                "D:\\Sounds\\Ofir Kohen - Ani Shar Bishvilekh.mp3",
                "D:\\Sounds\\Emilio el Moro - El Toro y La Luna.mp3",
                "D:\\Sounds\\Rio Negro e Solimoes - Garagem da Vizinha.mp3",
                "D:\\Sounds\\Rio Negro e Solimoes, Edson E Udson - O Chao Vai Tremer.mp3",
                "D:\\Sounds\\Ismail Yk - Allah Belanı Versin.mp3",
                "D:\\Sounds\\Marcel Khalife - Ajmal Al-Omahat.mp3",
                "D:\\Sounds\\Morano, Miguel Saez y Sergio Contreras - El Loco Flamenco.mp3",
                "D:\\Sounds\\Regev Hod - Ve Hayom (רגב הוד - והיום).mp3",
                "D:\\Sounds\\Dani Mata - Lamento Boliviano.mp3",
                "D:\\Sounds\\Murat Boz - Puf.mp3",
                "D:\\Sounds\\Gülay - Sen Gelmez Oldun.mp3",
                "D:\\Sounds\\Cheb Redouane ft N-Jay - Ahi3e.mp3",
                "D:\\Sounds\\Mohamed Lamine, Mokobe & Mory Kante - African Tonik.mp3",
                "D:\\Sounds\\Cheb Khaled, Mohamed Lamine & K-Mel - Retour Aux Sources.mp3",
                "D:\\Sounds\\Yusuf Islam - 99 Names of Allah.mp3"};
                FolderBrowserDialog sfd = new FolderBrowserDialog();
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string[] values = new string[] { "\\1.mp3", "\\2.mp3", "\\3.mp3", "\\4.mp3", "\\5.mp3", "\\6.mp3", "\\7.mp3", "\\8.mp3", "\\9.mp3", "\\10.mp3", "\\11.mp3", "\\12.mp3", "\\13.mp3", "\\14.mp3", "\\15.mp3", "\\16.mp3", "\\17.mp3", "\\18.mp3", "\\19.mp3" };
                    string[] ss = new string[17];
                    for (int i = 0; i <= 16; i++)
                    {
                        ss[i] = sfd.SelectedPath + values[i];
                        File.Copy(tt[i], ss[i]);
                    }
                    MessageBox.Show("File is Copied!");
                }
                else
                    MessageBox.Show("File isn't Copied!");
            }
            if (comboBox1.Text == "2009")
            {
                string[] tt = new string[] {
                "D:\\Sounds\\Baaziz, Mohamed Lamine, Cheb Khaled, Jimmy Oihid, Rim'k & Le Bled Band - Algérie Mon Amour.mp3",
                "D:\\Sounds\\Ugur Isilak - Adım Mehmet.mp3",
                "D:\\Sounds\\Emilio el Moro - El Relicario.mp3",
                "D:\\Sounds\\Victor e Leo - Borboletas.mp3",
                "D:\\Sounds\\Mc Claudinho e Buchecha e Dj Marlboro - Rap do Salgueiro.mp3",
                "D:\\Sounds\\Jammil e Uma Noites - Tchau I Have to go Now.mp3",
                "D:\\Sounds\\Sibel Can - Sen Gelmez Oldun.mp3",
                "D:\\Sounds\\Mostafa Amar - Taal El Leel.mp3",
                "D:\\Sounds\\Code Red - 18 (Dan Winter Radio Edit).mp3",
                "D:\\Sounds\\Alex C & Yass - Liebe zu Dritt.mp3",
                "D:\\Sounds\\Mostafa Amar - Benazret Ain.mp3",
                "D:\\Sounds\\Chitaozinho e Xororo e Fresno - Evidencias.mp3",
                "D:\\Sounds\\Orishas, Andres Cabas & Enrique Bunbury - He Pecado.mp3",
                "D:\\Sounds\\CD's\\DJ Nassim\\DJ Nassim - Reveillon 2009\\DJ Nassim - Reveillon 2009 - CD 2 - 10 - Dj Nassim Feat Meryam - Look at Me.mp3",
                "D:\\Sounds\\Uğur Işılak - Istanbulu Ozledim.mp3",
                "D:\\Sounds\\Mohamed Lamine, Kamelancien, Sana & OGB - Maghreb United.mp3"};
                FolderBrowserDialog sfd = new FolderBrowserDialog();
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string[] values = new string[] { "\\1.mp3", "\\2.mp3", "\\3.mp3", "\\4.mp3", "\\5.mp3", "\\6.mp3", "\\7.mp3", "\\8.mp3", "\\9.mp3", "\\10.mp3", "\\11.mp3", "\\12.mp3", "\\13.mp3", "\\14.mp3", "\\15.mp3", "\\16.mp3", "\\17.mp3", "\\18.mp3", "\\19.mp3" };
                    string[] ss = new string[16];
                    for (int i = 0; i <= 15; i++)
                    {
                        ss[i] = sfd.SelectedPath + values[i];
                        File.Copy(tt[i], ss[i]);
                    }
                    MessageBox.Show("File is Copied!");
                }
                else
                    MessageBox.Show("File isn't Copied!");
            }
            if (comboBox1.Text == "2010")
            {
                string[] tt = new string[] {
                "D:\\Sounds\\Mohamed Lamine - Malgré.wma",
                "D:\\Sounds\\CD's\\The Songs of the World\\Songs from Russia\\02 Popular Russian Melody.wma",
                "D:\\Sounds\\Raphael - Le Vent de l'Hiver.mp3",
                "D:\\Sounds\\Rachid Kasmi - Moul El Majmar (DJ Kayz Remix).mp3",
                "D:\\Sounds\\Grupo Sensacao - Sabor Do Teu Beijo (Ao Vivo).mp3",
                "D:\\Sounds\\Bruno e Marrone - Seu Amor Ainda é Tudo.mp3",
                "D:\\Sounds\\Mariza - Ó Gente da Minha Terra.mp3",
                "D:\\Sounds\\DJ Kayz, Nocif & Cheb Akil - Les Gladiateurs.mp3",
                "D:\\Sounds\\Najwa Karam & George Wassouf - Mawal.mp3",
                "D:\\Sounds\\Mourad Salam - Ay Yayai.mp3",
                "D:\\Sounds\\CD's\\DJ Nassim\\DJ Nassim - Reveillon 2010\\DJ Nassim - Reveillon 2010 - CD 3 - 01 - DJ Nassim - Alive In The Sun.mp3",
                "D:\\Sounds\\CD's\\DJ Nassim\\DJ Nassim - Reveillon 2010\\DJ Nassim - Reveillon 2010 - CD 2 - 12 - Edward Maya - Stereo Love.wma",
                "D:\\Sounds\\Shakira - Loca (English).mp3",
                "D:\\Sounds\\Ugur Isilak - Agladi Istanbul.mp3",
                "D:\\Sounds\\Leslie et Amine - Sobri.wma",
                "D:\\Sounds\\Russian Neizvestniy khor Исполнение - Proshaniye Slavyanki.mp3"};
                FolderBrowserDialog sfd = new FolderBrowserDialog();
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string[] values = new string[] { "\\1.wma", "\\2.wma", "\\3.mp3", "\\4.mp3", "\\5.mp3", "\\6.mp3", "\\7.mp3", "\\8.mp3", "\\9.mp3", "\\10.mp3", "\\11.mp3", "\\12.wma", "\\13.mp3", "\\14.mp3", "\\15.wma", "\\16.mp3", "\\17.mp3", "\\18.mp3", "\\19.mp3" };
                    string[] ss = new string[16];
                    for (int i = 0; i <= 15; i++)
                    {
                        ss[i] = sfd.SelectedPath + values[i];
                        File.Copy(tt[i], ss[i]);
                    }
                    MessageBox.Show("File is Copied!");
                }
                else
                    MessageBox.Show("File isn't Copied!");
            }
            if (comboBox1.Text == "2011")
            {
                string[] tt = new string[] {
                "D:\\Sounds\\Noir Desir - Le Vent Nous Portera.mp3",
                "D:\\Sounds\\Tim Berg - Seek Bromance.mp3",
                "D:\\Sounds\\CD's\\The Songs of the World\\Songs from the Andes\\01 El Condor Pasa.wma",
                "D:\\Sounds\\Emilio el Moro - Estudiantina de Madrid.mp3",
                "D:\\Sounds\\Barrio Jazz Gang - Amor Para Sonhar.mp3",
                "D:\\Sounds\\DJ Gregory & Gregor Salto Feat. The Serafim Crew - Paris Luanda (Main Mix).mp3",
                "D:\\Sounds\\Offer Nissim Ft Epiphony & Elisete - Million Stars (Original Full Mix 2010).mp3",
                "D:\\Sounds\\Wael Jassar - Ansak.mp3",
                "D:\\Sounds\\Şebnem Ferah & Polad Bülbüloğlu - Gəl ey səhər.mp3",
                "D:\\Sounds\\Şebnem Ferah - Can Kırıkları.mp3",
                "D:\\Sounds\\Şebnem Ferah, Hayko Cepkin, Aylin Aslım, TNK & Badem - Özgürce Yaşa.mp3",
                "D:\\Sounds\\Teoman - Istanbulda Sonbahar.mp3",
                "D:\\Sounds\\Teoman & Atiye Deniz -  Kal (Kucuk sirlar dm).mp3",
                "D:\\Sounds\\Emre Aydın & Göksel - Gülümse.mp3",
                "D:\\Sounds\\CD's\\DJ Nassim\\DJ Nassim - Rai Mix 3\\DJ Nassim - Rai Mix 3 - 28 - DJ Nassim & Meryem - Nkoune.mp3",
                "D:\\Sounds\\Hayko Çepkin - Yalniz Kalsin.mp3",
                "D:\\Sounds\\Ugur Işılak - Imam Hüseyin.mp3",};
                FolderBrowserDialog sfd = new FolderBrowserDialog();
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string[] values = new string[] { "\\1.mp3", "\\2.mp3", "\\3.wma", "\\4.mp3", "\\5.mp3", "\\6.mp3", "\\7.mp3", "\\8.mp3", "\\9.mp3", "\\10.mp3", "\\11.mp3", "\\12.mp3", "\\13.mp3", "\\14.mp3", "\\15.mp3", "\\16.mp3", "\\17.mp3", "\\18.mp3", "\\19.mp3" };
                    string[] ss = new string[17];
                    for (int i = 0; i <= 16; i++)
                    {
                        ss[i] = sfd.SelectedPath + values[i];
                        File.Copy(tt[i], ss[i]);
                    }
                    MessageBox.Show("File is Copied!");
                }
                else
                    MessageBox.Show("File isn't Copied!");
            }
            if (comboBox1.Text == "2012")
            {
                string[] tt = new string[] {
                "D:\\Sounds\\Emir Kusturica - Bubamara.mp3",
                "D:\\Sounds\\Cheb Khaled & Saul Hernandez - Ki Kounti.mp3",
                "D:\\Sounds\\Cheb Khaled & Compay Segundo - Saludo A Chango.mp3",
                "D:\\Sounds\\Carlos do Carmo - Um Homem Na Cidade.mp3",
                "D:\\Sounds\\Fernando e Sorocaba & Luan Santana - A Louca.mp3",
                "D:\\Sounds\\Rammstein - Sonne.mp3",
                "D:\\Sounds\\Epiphony & Mr Black - Drip Drop (Original Mix).mp3",
                "D:\\Sounds\\Fares Karam - Glli Fei Ya Samra.mp3",
                "D:\\Sounds\\Rabih El Asmar - Alamet Estefham.mp3",
                "D:\\Sounds\\Sean Paul & Alexis Jordan - Got 2 Luv U.mp3",
                "D:\\Sounds\\Faudel - Woulli.mp3",
                "D:\\Sounds\\Rabbani - Setanggi Kasih.mp3",
                "D:\\Sounds\\Oleg Qazmanov - Gospoda Oficery.mp3",
                "D:\\Sounds\\Alim Qasımov & Fərqanə Qasımova - Aman Ovçu (Izzy Gold Remix).mp3",
                "D:\\Sounds\\CD's\\DJ Nassim\\DJ Nassim - Rai Mix 5\\DJ Nassim - Rai Mix 5 - 04 - Kheira Feat DJ Nassim - Men Ayni Chehal Bkit.mp3",
                "D:\\Sounds\\Uğur Işılak - Sakarya Türküsü.mp3",
                "D:\\Sounds\\Ali Dimaev - Noxchijchö.mp3",
                "D:\\Sounds\\Mohamed Lamine & OGB - Lala Fatima.mp3",};
                FolderBrowserDialog sfd = new FolderBrowserDialog();
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string[] values = new string[] { "\\1.mp3", "\\2.mp3", "\\3.mp3", "\\4.mp3", "\\5.mp3", "\\6.mp3", "\\7.mp3", "\\8.mp3", "\\9.mp3", "\\10.mp3", "\\11.mp3", "\\12.mp3", "\\13.mp3", "\\14.mp3", "\\15.mp3", "\\16.mp3", "\\17.mp3", "\\18.mp3", "\\19.mp3" };
                    string[] ss = new string[18];
                    for (int i = 0; i <= 17; i++)
                    {
                        ss[i] = sfd.SelectedPath + values[i];
                        File.Copy(tt[i], ss[i]);
                    }
                    MessageBox.Show("File is Copied!");
                }
                else
                    MessageBox.Show("File isn't Copied!");
            }
            if (comboBox1.Text == "2013")
            {
                string[] tt = new string[] {
                "D:\\Sounds\\Yanni - Prelude & Nostalgia.mp3",
                "D:\\Sounds\\Emilio el Moro - Los Campanilleros.mp3",
                "D:\\Sounds\\Goran Bregovic - Gypsy Reggae.mp3",
                "D:\\Sounds\\Idir & Karen Matheson - A Vava Inouva.mp3",
                "D:\\Sounds\\Delyno & Looloo - Private Love.mp3",
                "D:\\Sounds\\Richard Durand - Sunhump.mp3",
                "D:\\Sounds\\Gad Elbaz & Itay Kalderon - Jerusalem.mp3",
                "D:\\Sounds\\Avraham Fried - Mnoroh.mp3",
                "D:\\Sounds\\Nassif Zeytoun - El Ard Li Btimchi Aaleha.mp3",
                "D:\\Sounds\\Enej - Symetryczno-Liryczna.mp3",
                "D:\\Sounds\\Avraham Fried - Elohai Neshama.mp3",
                "D:\\Sounds\\Avraham Fried - Sholom Aleichem.mp3",
                "D:\\Sounds\\Rabbani - Kaca Permata.mp3",
                "D:\\Sounds\\CD's\\DJ Nassim\\DJ Nassim - Reveillon 2013\\DJ Nassim - Reveillon 2013 - CD 2 - 18 - Dj Antoine - Ma Chérie.mp3",
                "D:\\Sounds\\Rammstein - Mein Herz Brennt.mp3",
                "D:\\Sounds\\Uğur Işılak - El Yanar.mp3",
                "D:\\Sounds\\Can Bonomo - Iyi ki doğdun.mp3",
                "D:\\Sounds\\Stromae - Formidable.mp3"};
                FolderBrowserDialog sfd = new FolderBrowserDialog();
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string[] values = new string[] { "\\1.mp3", "\\2.mp3", "\\3.mp3", "\\4.mp3", "\\5.mp3", "\\6.mp3", "\\7.mp3", "\\8.mp3", "\\9.mp3", "\\10.mp3", "\\11.mp3", "\\12.mp3", "\\13.mp3", "\\14.mp3", "\\15.mp3", "\\16.mp3", "\\17.mp3", "\\18.mp3", "\\19.mp3" };
                    string[] ss = new string[18];
                    for (int i = 0; i <= 17; i++)
                    {
                        ss[i] = sfd.SelectedPath + values[i];
                        File.Copy(tt[i], ss[i]);
                    }
                    MessageBox.Show("File is Copied!");
                }
                else
                    MessageBox.Show("File isn't Copied!");
            }
            if (comboBox1.Text == "2014")
            {
                string[] tt = new string[] {
                "D:\\Sounds\\Theodore Bikel - Reyzl.mp3",
                "D:\\Sounds\\Strachy Na Lachy - Ostatki.mp3",
                "D:\\Sounds\\Idir - Ssendou.mp3",
                "D:\\Sounds\\Carlos do Carmo - Não se Morre de Saudade.mp3",
                "D:\\Sounds\\Bonga - Marimbondo.mp3",
                "D:\\Sounds\\Bonga - Luanda Nbola.mp3",
                "D:\\Sounds\\Bonga - Dendém de açucar.mp3",
                "D:\\Sounds\\Ronen Maadi - Al Hevel Dak.mp3",
                "D:\\Sounds\\Rabih El Asmar - Om Ahmed.mp3",
                "D:\\Sounds\\Cheb Khaled & Nancy Ajram - Shaga Helmak.mp3",
                "D:\\Sounds\\Michel Sardou - Les Lacs Du Connemara.mp3",
                "D:\\Sounds\\Inna - Summer Lover.mp3",
                "D:\\Sounds\\Coldplay - A Sky Full Of Stars.mp3",
                "D:\\Sounds\\Imagine Dragons - Demons.mp3",
                "D:\\Sounds\\Patrizio Buanne - l`Italiano.mp3",
                "D:\\Sounds\\Reinhard Mey - Sei Wachsam.mp3",
                "D:\\Sounds\\CD's\\DJ Nassim\\DJ Nassim - Just My Music 2014 vol2\\DJ Nassim - Just My Music 2014 vol2 - 15 - Meriem Benallal - Harramt Ahebbak.mp3",
                "D:\\Sounds\\Uğur Işılak - Bana Sor Sevgili Kâri.mp3",
                "D:\\Sounds\\Al Bay - Hayranıyım.mp3"};
                FolderBrowserDialog sfd = new FolderBrowserDialog();
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string[] values = new string[] { "\\1.mp3", "\\2.mp3", "\\3.mp3", "\\4.mp3", "\\5.mp3", "\\6.mp3", "\\7.mp3", "\\8.mp3", "\\9.mp3", "\\10.mp3", "\\11.mp3", "\\12.mp3", "\\13.mp3", "\\14.mp3", "\\15.mp3", "\\16.mp3", "\\17.mp3", "\\18.mp3", "\\19.mp3" };
                    string[] ss = new string[19];
                    for (int i = 0; i <= 18; i++)
                    {
                        ss[i] = sfd.SelectedPath + values[i];
                        File.Copy(tt[i], ss[i]);
                    }
                    MessageBox.Show("File is Copied!");
                }
                else
                    MessageBox.Show("File isn't Copied!");
            }
            if (comboBox1.Text == "2015")
            {
                string[] tt = new string[] {
                "D:\\Sounds\\Cheb Khaled & Carlos Santana - Love To The People.mp3",
                "D:\\Sounds\\Theodore Bikel - Margaritkelech.mp3",
                "D:\\Sounds\\Cheb Khaled - El Barah.mp3",
                "D:\\Sounds\\Luan Santana - Tanto Faz.mp3",
                "D:\\Sounds\\Gnawa Diffusion - Ouvrez les stores.mp3",
                "D:\\Sounds\\Kobi Peretz & Ishtar Alabina - Zahiti.mp3",
                "D:\\Sounds\\Ishtar Alabina, Bouba & Dida - C'est la vie.mp3",
                "D:\\Sounds\\Ishtar Alabina & Gypsy King - Salam La Paz Al Final.mp3",
                "D:\\Sounds\\Fares Karam - Al Hamdella.mp3",
                "D:\\Sounds\\Fares Karam - Weslo Al3ersan.mp3",
                "D:\\Sounds\\George Wassouf - El Ayam De Sa3bah.mp3",
                "D:\\Sounds\\Ishtar Alabina - Comme Toi.mp3",
                "D:\\Sounds\\Rafet El Roman - Bir Damla Sevgi.mp3",
                "D:\\Sounds\\Hans Zimmer & Djivan Gasparyan - Duduk of The North.mp3",
                "D:\\Sounds\\Julia Boutros - Qawem.mp3",
                "D:\\Sounds\\Reinhard Mey - Sei Wachsam.mp3",
                "D:\\Sounds\\CD's\\DJ Nassim\\DJ Nassim - Reveillon 2015\\DJ Nassim - Reveillon 2015 - CD 3 - 17 - Cut Copy - Meet Me In A House Of Love.mp3",
                "D:\\Sounds\\Hayko Cepkin - Sıkı Tutun.mp3",
                "D:\\Sounds\\Abdul Razaq & Khdair Hadi - La Tezlmoha.mp3"};
                FolderBrowserDialog sfd = new FolderBrowserDialog();
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string[] values = new string[] { "\\1.mp3", "\\2.mp3", "\\3.mp3", "\\4.mp3", "\\5.mp3", "\\6.mp3", "\\7.mp3", "\\8.mp3", "\\9.mp3", "\\10.mp3", "\\11.mp3", "\\12.mp3", "\\13.mp3", "\\14.mp3", "\\15.mp3", "\\16.mp3", "\\17.mp3", "\\18.mp3", "\\19.mp3" };
                    string[] ss = new string[19];
                    for (int i = 0; i <= 18; i++)
                    {
                        ss[i] = sfd.SelectedPath + values[i];
                        File.Copy(tt[i], ss[i]);
                    }
                    MessageBox.Show("File is Copied!");
                }
                else
                    MessageBox.Show("File isn't Copied!");
            }
            if (comboBox1.Text == "2016")
            {
                string[] tt = new string[] {
                "D:\\Sounds\\Theodore Bikel - Polso Bylo Lyublyatse.mp3",
                "D:\\Sounds\\Cheb Khaled - Gnaoui.mp3",
                "D:\\Sounds\\Emilio El Moro - La Cadena De Oro.mp3",
                "D:\\Sounds\\Jeito Moleque - Nas Nuvens.mp3",
                "D:\\Sounds\\Henrique e Diego & Mc Guimê - Suíte 14.mp3",
                "D:\\Sounds\\Luan Santana ft Double You - Chuva De Arroz (New Life).mp3",
                "D:\\Sounds\\Héroes del Silencio - La Chispa Adecuada.mp3",
                "D:\\Sounds\\Ishtar Alabina - Adios Barcelona.mp3",
                "D:\\Sounds\\Anas Kareem - Alta2a Alijabeyh.mp3",
                "D:\\Sounds\\Rabih El Asmar - Dae3tina.mp3",
                "D:\\Sounds\\Deorro ft. Elvis Crespo - Bailar.mp3",
                "D:\\Sounds\\Mike Posner - I Took a Pill In Ibiza.mp3",
                "D:\\Sounds\\Los Rebujitos & José el Francés - Sangre de mi Corazón.mp3",
                "D:\\Sounds\\Rafet El Roman - Beni Affedermisi.mp3",
                "D:\\Sounds\\CD's\\DJ Nassim\\DJ Nassim - Reveillon 2016\\DJ Nassim - Reveillon 2016 - CD 2 - 27 - The italoborothers - Welecom To The Daneefloor.mp3",
                "D:\\Sounds\\Murat Göğebakan - Ay Yüzlüm.mp3",
                "D:\\Sounds\\Ahmet Kaya - İçimde Ölen Biri Var.mp3",
                "D:\\Sounds\\Burak Yeter & Danelle Sandoval - Tuesday.mp3",};
                FolderBrowserDialog sfd = new FolderBrowserDialog();
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string[] values = new string[] { "\\1.mp3", "\\2.mp3", "\\3.mp3", "\\4.mp3", "\\5.mp3", "\\6.mp3", "\\7.mp3", "\\8.mp3", "\\9.mp3", "\\10.mp3", "\\11.mp3", "\\12.mp3", "\\13.mp3", "\\14.mp3", "\\15.mp3", "\\16.mp3", "\\17.mp3", "\\18.mp3", "\\19.mp3" };
                    string[] ss = new string[18];
                    for (int i = 0; i <= 17; i++)
                    {
                        ss[i] = sfd.SelectedPath + values[i];
                        File.Copy(tt[i], ss[i]);
                    }
                    MessageBox.Show("File is Copied!");
                }
                else
                    MessageBox.Show("File isn't Copied!");
            }
            if (comboBox1.Text == "2017")
            {
                string[] tt = new string[] {
                "D:\\Sounds\\Yul Brynner - Shalyonochka.mp3",
                "D:\\Sounds\\Cheb Khaled - Yema Yema.mp3",
                "D:\\Sounds\\Rachid Kasmi - Rani Berani.mp3",
                "D:\\Sounds\\Emilio El Moro - Mujeres Feas.mp3",
                "D:\\Sounds\\Simone & Simaria e Anitta - Loka.mp3",
                "D:\\Sounds\\Rachid Kasmi - Habibi I Love Jou.mp3",
                "D:\\Sounds\\Amazigh Kateb & Idir - Tagrawla.mp3",
                "D:\\Sounds\\Salvador Sobral - Amar Pelos Dois.mp3",
                "D:\\Sounds\\Joe Ashkar - Qalou El Qamar.mp3",
                "D:\\Sounds\\Gripin - Yalnızlığın çaresini bulmuşlar.mp3",
                "D:\\Sounds\\Hamada Helal - Mastoul.mp3",
                "D:\\Sounds\\Joe Ashkar - Kenti Bel Sahra.mp3",
                "D:\\Sounds\\Rafet El Roman - En Güzel Şey Yaşamak.mp3",
                "D:\\Sounds\\Gripin - Boyle Kahpedir Dunya.mp3",
                "D:\\Sounds\\Bebe Rexha & Louis Tomlinson - Back To You.mp3",
                "D:\\Sounds\\CD's\\DJ Nassim\\DJ Nassim - Radio JTN 5 2017\\NewZik.Org_2. 02. Imany ft Filatov & Karas - Don't Be A Shy ( Meryem BEnallal Cover Mix).mp3",
                "D:\\Sounds\\Emre Aydın - Belki bir gün özlersin.mp3",
                "D:\\Sounds\\Marilyn Manson - Eat Me, Drink Me [Hannibal].mp3",
                "D:\\Sounds\\Karmate - Nayino.mp3"};
                FolderBrowserDialog sfd = new FolderBrowserDialog();
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string[] values = new string[] { "\\1.mp3", "\\2.mp3", "\\3.mp3", "\\4.mp3", "\\5.mp3", "\\6.mp3", "\\7.mp3", "\\8.mp3", "\\9.mp3", "\\10.mp3", "\\11.mp3", "\\12.mp3", "\\13.mp3", "\\14.mp3", "\\15.mp3", "\\16.mp3", "\\17.mp3", "\\18.mp3", "\\19.mp3" };
                    string[] ss = new string[19];
                    for (int i = 0; i <= 18; i++)
                    {
                        ss[i] = sfd.SelectedPath + values[i];
                        File.Copy(tt[i], ss[i]);
                    }
                    MessageBox.Show("File is Copied!");
                }
                else
                    MessageBox.Show("File isn't Copied!");
            }
            if (comboBox1.Text == "2018")
            {
                string[] tt = new string[] {
                "D:\\Sounds\\L'Algérino & Florin Salam - Marakech St Tropez.mp3",
                "D:\\Sounds\\Cheb Khaled, Cheb Hasni & Cheb Nasro - Ta Terre a Tremble.mp3",
                "D:\\Sounds\\Theodore Bikel - El Burro.mp3",
                "D:\\Sounds\\Carlos Cano - La Murga De Los Currelantes.mp3",
                "D:\\Sounds\\Cheb Khaled, Enzo Avitabile & Bottari - Abball' cu me.mp3",
                "D:\\Sounds\\Mc Kevinho & Simone e Simaria - Ta Tum Tum.mp3",
                "D:\\Sounds\\Fernando e Sorocaba & Jorge e Mateus - Bom Rapaz.mp3",
                "D:\\Sounds\\MC Fioti & Yuri Lorenzo Bootleg - Bum Bum Tam Tam.mp3",
                "D:\\Sounds\\Grupo Pixote - Ele e Ela.mp3",
                "D:\\Sounds\\La Casa de Papel - Bella Ciao.mp3",
                "D:\\Sounds\\Karika High Dam - El Shantah.mp3",
                "D:\\Sounds\\Rabih El Asmar - Akhod Karar.mp3",
                "D:\\Sounds\\Oleg Gazmanov - Esaul.mp3",
                "D:\\Sounds\\Gökhan Özen - Tövbeliyim.mp3",
                "D:\\Sounds\\Taconafide & Bedoes - 8 Kobiet.mp3",
                "D:\\Sounds\\CD's\\DJ Nassim\\DJ Nassim - Rai Mix 6\\DJ Nassim - Rai Mix 6 - 05 - Cheb Nassim feat Merieme Benallal - Aime.mp3",
                "D:\\Sounds\\Ahmet Kaya - Beni Vur.mp3",
                "D:\\Sounds\\Hassak - Аманат.mp3"};
                FolderBrowserDialog sfd = new FolderBrowserDialog();
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string[] values = new string[] { "\\1.mp3", "\\2.mp3", "\\3.mp3", "\\4.mp3", "\\5.mp3", "\\6.mp3", "\\7.mp3", "\\8.mp3", "\\9.mp3", "\\10.mp3", "\\11.mp3", "\\12.mp3", "\\13.mp3", "\\14.mp3", "\\15.mp3", "\\16.mp3", "\\17.mp3", "\\18.mp3", "\\19.mp3" };
                    string[] ss = new string[18];
                    for (int i = 0; i <= 17; i++)
                    {
                        ss[i] = sfd.SelectedPath + values[i];
                        File.Copy(tt[i], ss[i]);
                    }
                    MessageBox.Show("File is Copied!");
                }
                else
                    MessageBox.Show("File isn't Copied!");
            }
            if (comboBox1.Text == "2019")
            {
                string[] tt = new string[] {
                "D:\\Sounds\\Theodore Bikel - Snilsys mnye sad.mp3",
                "D:\\Sounds\\Theodore Bikel - Coplas.mp3",
                "D:\\Sounds\\Idir & Charles Aznavour - La Bohème.mp3",
                "D:\\Sounds\\Chopin - Spring Waltz (Mariage d'Amour).mp3",
                "D:\\Sounds\\Mc Zaac e Jerry Smith - Bumbum Granada.mp3",
                "D:\\Sounds\\Andrea Bocelli - Brucia La Terra.mp3",
                "D:\\Sounds\\Gad Elbaz & Alon DeLoco - True Love.mp3",
                "D:\\Sounds\\Ed Sheeran & Andrea Bocelli - Perfect Symphony.mp3",
                "D:\\Sounds\\Gogol Bordello - Wonderlust King.mp3",
                "D:\\Sounds\\Ehab Tawfik - Allah 3aleik Ya Sidi.mp3",
                "D:\\Sounds\\Avraham Fried - Retzonenu.mp3",
                "D:\\Sounds\\Daniel Saadon - The Hope.mp3",
                "D:\\Sounds\\Nebezao & Rafal - Tchernaya Pantera.mp3",
                "D:\\Sounds\\Tan Taşçı - Elbet.mp3",
                "D:\\Sounds\\Mohamed Benchenet - Fi Bladi Dalmoni.mp3",
                "D:\\Sounds\\Rammstein - Spring.mp3",
                "D:\\Sounds\\Uğur Işılak - Erenlerın Sofrasinda.mp3",
                "D:\\Sounds\\Mustafa Sandal & Zeynep Bastık - Mod.mp3"};
                FolderBrowserDialog sfd = new FolderBrowserDialog();
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string[] values = new string[] { "\\1.mp3", "\\2.mp3", "\\3.mp3", "\\4.mp3", "\\5.mp3", "\\6.mp3", "\\7.mp3", "\\8.mp3", "\\9.mp3", "\\10.mp3", "\\11.mp3", "\\12.mp3", "\\13.mp3", "\\14.mp3", "\\15.mp3", "\\16.mp3", "\\17.mp3", "\\18.mp3", "\\19.mp3" };
                    string[] ss = new string[18];
                    for (int i = 0; i <= 17; i++)
                    {
                        ss[i] = sfd.SelectedPath + values[i];
                        File.Copy(tt[i], ss[i]);
                    }
                    MessageBox.Show("File is Copied!");
                }
                else
                    MessageBox.Show("File isn't Copied!");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "2005")
            {
                System.Diagnostics.Process.Start("D:\\Sounds\\CD's\\The Songs of the World\\Songs from Brazil\\13 A Maluco Do Mangue.wma");
            }
            if (comboBox1.Text == "2006")
            {
                System.Diagnostics.Process.Start("D:\\Sounds\\Rabbani - Intifada.mp3");
            }
            if (comboBox1.Text == "2007")
            {
                System.Diagnostics.Process.Start("D:\\Sounds\\Regev Hod - Choref 73.mp3");
            }
            if (comboBox1.Text == "2008")
            {
                System.Diagnostics.Process.Start("D:\\Sounds\\Ismail Yk - Allah Belanı Versin.mp3");
            }
            if (comboBox1.Text == "2009")
            {
                System.Diagnostics.Process.Start("D:\\Sounds\\CD's\\DJ Nassim\\DJ Nassim - Reveillon 2009\\DJ Nassim - Reveillon 2009 - CD 2 - 10 - Dj Nassim Feat Meryam - Look at Me.mp3");
            }
            if (comboBox1.Text == "2010")
            {
                System.Diagnostics.Process.Start("D:\\Sounds\\Russian Neizvestniy khor Исполнение - Proshaniye Slavyanki.mp3");
            }
            if (comboBox1.Text == "2011")
            {
                System.Diagnostics.Process.Start("D:\\Sounds\\Şebnem Ferah, Hayko Cepkin, Aylin Aslım, TNK & Badem - Özgürce Yaşa.mp3");
            }
            if (comboBox1.Text == "2012")
            {
                System.Diagnostics.Process.Start("D:\\Sounds\\Rammstein - Sonne.mp3");
            }
            if (comboBox1.Text == "2013")
            {
                System.Diagnostics.Process.Start("D:\\Sounds\\Avraham Fried - Elohai Neshama.mp3");
            }
            if (comboBox1.Text == "2014")
            {
                System.Diagnostics.Process.Start("D:\\Sounds\\Michel Sardou - Les Lacs Du Connemara.mp3");
            }
            if (comboBox1.Text == "2015")
            {
                System.Diagnostics.Process.Start("D:\\Sounds\\Theodore Bikel - Margaritkelech.mp3");
            }
            if (comboBox1.Text == "2016")
            {
                System.Diagnostics.Process.Start("D:\\Sounds\\Héroes del Silencio - La Chispa Adecuada.mp3");
            }
            if (comboBox1.Text == "2017")
            {
                System.Diagnostics.Process.Start("D:\\Sounds\\Gripin - Yalnızlığın çaresini bulmuşlar.mp3");
            }
            if (comboBox1.Text == "2018")
            {
                System.Diagnostics.Process.Start("D:\\Sounds\\La Casa de Papel - Bella Ciao.mp3");
            }
            if (comboBox1.Text == "2019")
            {
                System.Diagnostics.Process.Start("D:\\Sounds\\Gogol Bordello - Wonderlust King.mp3");
            }


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);
            f2.ShowDialog();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
