using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TezAPPV2;
using TezAPPV2.Model;
using FuzzyLogicController;
using FuzzyLogicController.FLC;
using FuzzyLogicController.RuleEngine;
using StringTok;
using TezAPPV2.SqlOperations;



namespace TezAPPV2.Forms
{
    public partial class FormAnalyzeData : Form
    {
       


        Random rndisim = new Random();
        Random rndisim2 = new Random();
        Random rndsoyisim = new Random();
        Random rndsoyisim2= new Random();
        Random tcsallayici = new Random();

        
        GetProjectLabData _getProjectLabData = new GetProjectLabData();
        AddNewPerson _addNewPerson = new AddNewPerson();
        ClearTheDataBase _clearTheDataBase = new ClearTheDataBase();
        private LingVariable _current;
        private LingVariable _currentBMI;
        
        int _donem;
       
        public FormAnalyzeData()
        {


            InitializeComponent();
        }

        double solution2;
        double solution2BMI;
        string AnalyzeUstGiyimEbat;
        string AnalyzeBMIndex;
        private void LabYukle()
        {
            dtgLab.DataSource = _getProjectLabData.ProjectLabGet();
            

        }
        private void ColumnVisibleLab()
        {
            foreach (DataGridViewColumn i in
         dtgLab.Columns)
            {
                string detailcolumnfilter = dtgLab.Columns[i.DisplayIndex].HeaderText.ToString();
                switch (detailcolumnfilter)
                {
                    case "subjectid":
                        {
                            i.Visible = true;
                            break;
                        }
                    case "A77Lab":
                        {
                            i.Visible = true;
                            break;
                        }
                    case "A87Lab":
                        {
                            i.Visible = true;
                            break;
                        }
                    case "A8Lab":
                        {
                            i.Visible = true;
                            break;
                        }


                    default:
                        {
                            i.Visible = false;
                            break;
                        }

                }

            }
        }




      


        private void LabCalculator(double a77labs, double a87labs, double a8labs, double e101labs, double e102labs, double e103labs)
        {

            string[] namecreator = { "Atnan", "Attila", "Attilla", "Avşin", "Avvat", "Ayatin", "Ayatullah", "Aybaba", "Aydin", "Atıl", "Aydiner", "Aykutcan", "Aynullah", "Atılgan", "Atız", "Ayton", "Aytümen", "Ayvas", "Azad", "Atik", "Azdin", "Azem", "Azettin", "Atila", "Azrail", "Baattin", "Baba", "Babek", "Badet", "Badiru", "Atilla", "Bahaddin", "Bahadir", "Bahaettin", "Bahaittin", "Bahatdin", "Bahittin", "Bahman", "Bahrettin", "Bahşi", "Bahtinur", "Bakir", "Bakiş", "Bali", "Balkir", "Babür", "Banihan", "Barboros", "Bariş", "Atlan", "Barişcan", "Attilâ", "Benna", "Beran", "Berati", "Beray", "Atuf", "Bergün", "Berhan", "Berho", "Babürşah", "Avar", "Berkcan", "Berkehan", "Berkem", "Berkkalp", "Berktuğ", "Avcı", "Bersan", "Bertal", "Besdemin", "Avhan", "Besin", "Beslan", "Avkan", "Bestami", "Beyazit", "Beyhani", "Beykut", "Beyler", "Beynur", "Avni", "Beysim", "Beytüllah", "Bezgin", "Bhekumusa", "Bilal", "Bilcan", "Avşar", "Binyami", "Binyamin", "Birand", "Birkay", "Birön", "Birtekin", "Bişar", "Bonci", "Boracan", "Bubo", "Buhari", "Bukan", "Bülend", "Bulent", "Bünyami", "Bünyamil", "Bünyamün", "Burakbey", "Burakhan", "Buray", "Burçay", "Balaban", "Bürhan", "Burhaneddin", "Burtay", "Cafet", "Çagatay", "Çağda", "Çağdan", "Çağil", "Çağin", "Çağri", "Ayalp", "Çağtay", "Cahid", "Cahti", "Cait", "Çakir", "Çaliş", "Camal", "Canali", "Candeniz", "Candirem", "Cangir", "Mucahit", "Mücait", "Mücayit", "Mücdet", "Mücellib", "Mucib", "Mücteba", "Müdavim", "Müddesir", "Müfid", "Müftah", "Muhamet", "Muhammad", "Muhammedali", "Muhammer", "Muhammetali", "Muharem", "Muhazim", "Muhbet", "Muhib", "Muhiddin", "Mühreli", "Muhutdin", "Muhuttin", "Muhyedin", "Muhyettin", "Muhyiddin", "Muhyittin", "Mükail", "Mükayil", "Karabörü", "Mükramin", "Mukrayil", "Mülayim", "Mülcem", "Mülkü", "Mulla", "Mumtas", "Mümün", "Münacettin", "Münib", "Münik", "Munip", "Munir", "Münircan", "Müntez", "Münüp", "Münür", "Murad", "Muratcan", "Murathanabdu", "Mursel", "Mürselin", "Mürşid", "Mürşüt", "Mürteza", "Musab", "Musaburak", "Musafet", "Musamettin", "Müseddin", "Seyifali", "Seyir", "Seyitahmet", "Seyitali", "Şeyva", "Seyyar", "Seyyat", "Seyyid", "Seyyidullah", "Nabi", "Baldemir", "Sezair", "Sezar", "Sezayi", "Shahram", "Baler", "Sidar", "Siddik", "Sidik", "Sidika", "Balhan", "Sidki", "Şih", "Siham", "Şihmehmet", "Şihmus", "Balı", "Silay", "Şimet", "Balıbaş", "Simon", "Sino", "Balıbey", "Sirri", "Sitdik", "Sitem", "Sitki", "Sittik", "Siyahi", "Siyami", "Şiyar", "Siyasi", "Şöhrat", "Balibey", "Sšheyla", "Stefan", "Balk", "Şuap", "Şuayb", "Şuayben", "Şuayip", "Şüayp", "Şuayüp", "Balkan", "Subhani", "Sücaattin", "Sücaettin", "Sugat", "Şüheda", "Suheyl", "Şükret", "Şükri", "Şükür", "Suleyman", "Sulhattin", "Sullhattin", "Balkış", "Sümeyye", "Summani", "Suphan", "Balkoç", "Suray", "Sürecettin", "Sürhap", "Balsan", "Süyer", "Şüyüp", "Tabip", "Tacdin", "Cangiray", "Yabgu", "Cangür", "Canip", "Cankan", "Cankaya", "Cankılıç", "Yabız", "Cankoç", "Cankorur", "Cankurt", "Cankut", "Canol", "Canören", "Yalabuk", "Canpolat", "Cansal", "Cansay", "Yalazabay", "Cansunay", "Cansuner", "Zabit", "Cantaş", "Cantekin", "Cantez", "Cantürk", "Canyurt", "Caran", "Carim", "Carullah", "Zeynelabidin", "Cavit", "Cavlı", "Cavuldur", "Caymaz", "Cazim", "Cazip", "Cebbar", "Cebealp", "Cebrail", "Aca", "Cefa", "Celilay", "Cemal", "Cemaleddin", "Cemalettin", "Cemalullah", "Cemşah", "Cenan", "Cenani", "Cenap", "Acahan", "Cengizhan", "Cerullah", "Cevat", "Cezayir", "Cihandar", "Cihandide", "Cihanefruz", "Cihaner", "Cihangir", "Cihani", "Acaralp", "Cihanmert", "Cihanşah", "Cihat", "Civan", "Civanbaht", "Civanmert", "Civanşir", "Coşan", "Coşar", "Coşkunay", "Cuma", "Cumali", "Cura", "Cündullah", "Çadır", "Çağ", "Çağa", "Acarbey", "Çağaçan", "Çağaçar", "Çağakan", "Çağan", "Çağanak", "Çağatay", "Çağay", "Çağbay", "Çağıltı", "Çağır", "Çağkan", "Çağlam", "Çağlan", "Çağlayangil", "Çağlayantürk", "Çağlı", "Çağman", "Çağrıbey", "Çağveren", "Acarer", "Çakan", "Çakar", "Çakıl", "Çakım", "Çakın", "Çakırbey", "Çakırca", "Çakırer", "Çakmak", "Çakman", "Çakmur", "Çalapkulu", "Çalapöver", "Çalapverdi", "Çalgan", "Çalıkbey", "Çalın", "Çalış", "Çalkan", "Çalkara", "Çalkın", "Çaltı", "Çam", "Çamak", "Çambel", "Çamer", "Çamok", "Çandar", "Çandarlı", "Çanga", "Çangal", "Çankara", "Çankaya", "Çapan", "Çapaner", "Çapar", "Acarman", "Çapın", "Çapkan", "Çarlan", "Çarman", "Çav", "Çavaş", "Çavdar", "Çavdur", "Çavlan", "Çavlı", "Acaröz", "Çavuldur", "Çavuş", "Çaydam", "Çaydamar", "Çayhan", "Çaykara", "Çaylak", "Çaynak", "Çelikbaş", "Acarsoy", "Çelikhan", "Çelikkan", "Çelikkanat", "Çelikkaya", "Çeliktan", "Çeliktaş", "Çelikyay", "Çetinalp", "Çetinay", "Acartürk", "Çetinkaya", "Çetintaş", "Çevikcan", "Çıda", "Çıdal", "Çıdam", "Çıdamlı", "Çığa", "Çığal", "Çınak", "Acatay", "Çınay", "Çıray", "Çıtak", "Çıtanak", "Çiltay", "Çintan", "Acıdaş", "Çintay", "Çiray", "Çoban", "Çoğa", "Çoğahan", "Çoğan", "Çoğaş", "Çoğay", "Erşan", "Erşat", "Ertaç", "Ertan", "Ertaş", "Ertay", "Ertaylan", "Ertepınar", "Adamış", "Ertugay", "Ertuna", "Ertunca", "Ertuncay", "Ertunga", "Erturan", "Erünal", "Eryalçın", "Eryaman", "Eryavuz", "Adanan", "Eryılmaz", "Erzade", "Esat", "Esedullah", "Esenbay", "Esenboğa", "Esendağ", "Esenkal", "Esertaş", "Eskinalp", "Eşfak", "Eşraf", "Evhat", "Evliya", "Evran", "Evrenata", "Eyyam", "Ezelhan", "Fadıl", "Adarkan", "Fahim", "Fahir", "Fahrettin", "Fahri", "Adasal", "Faik", "Faiz", "Fakih", "Fakir", "Fakirullah", "Falih", "Adaş", "Fani", "Farik", "Faris", "Faruk", "Fasih", "Fatih", "Fatin", "Aday", "Faysal", "Fazıl", "Fazlı", "Fazlullah", "Fedai", "Fehamettin", "Fehimdar", "Feragat", "Ferahi", "Feramuş", "Feramuz", "Adıgün", "Fercan", "Ferdal", "Ferdar", "Ferhat", "Ferhattin", "Feritkan", "Ferkan", "Ferman", "Fermani", "Fersan", "Feruzat", "Adın", "Ferzan", "Fettah", "Fevzullah", "Feyyaz", "Adısanlı", "Feyzullah", "Fezahan", "Fezai", "Fırat", "Adısönmez", "Keleşbay", "Keleşhan", "Kemal", "Kemalettin", "Kemandar", "Kenan", "Keramettin", "Kerami", "Keremşah", "Kerimhan", "Ajlan", "Kerman", "Kervan", "Keskinay", "Keyhan", "Kılavuz", "Kılıçal", "Kılıçalp", "Kılıçaslan", "Kılıçbay", "Kılıçhan", "Kınalp", "Kınay", "Kınayman", "Kınaytürk", "Kınıkaslan", "Kıpçak", "Kıraç", "Kıralp", "Aka", "Kıran", "Kıranalp", "Kıraner", "Kırat", "Kıratlı", "Kıray", "Kırbay", "Kırboğa", "Kırca", "Kırdar", "Akad", "Kırdarlı", "Kırhan", "Kırman", "Kırtay", "Kıvançer", "Kıvançlı", "Kıyam", "Kıyan", "Kıyas", "Akadlı", "Kızan", "Kızılaslan", "Kızılateş", "Kızılbars", "Kızılboğa", "Kızılelma", "Kızılpars", "Kızılyalım", "Akağan", "Kiçialp", "Kiçihan", "Kinaş", "Akal", "Kinyas", "Kipcan", "Kiram", "Akcebe", "Nisani", "Nişan", "Nişanbay", "Niyazi", "Nizam", "Akcivan", "Nizamettin", "Nizami", "Nizar", "Nogay", "Noyan", "Nuhcan", "Nuhkan", "Numan", "Nuralp", "Nurani", "Nuratay", "Nuraydın", "Nurbaki", "Nurbay", "Akçael", "Nurihak", "Akçakan", "Nurşah", "Nurullah", "Nurzat", "Akçakaya", "Nuyan", "Oba", "Ocak", "Ocan", "Odhan", "Odkan", "Odkanlı", "Odman", "Odyak", "Odyakar", "Akçakıl", "Odyakmaz", "Oflas", "Oflazer", "Ogan", "Oganalp", "Oganer", "Ogansoy", "Ogeday", "Oğan", "Akçakoca", "Oğanalp", "Oğaner", "Oğansoy", "Oğanverdi", "Oğulbalı", "Oğulbaş", "Oğulbay", "Oğulcan", "Oğulçak", "Oğultan", "Akçal", "Oğuralp", "Oğurata", "Oğuzalp", "Oğuzata", "Oğuzbala", "Oğuzbay", "Oğuzcan", "Oğuzhan", "Oğuzkan", "Oğuzman", "Akçalı", "Oğuztan", "Okakın", "Okal", "Okan", "Öztaş", "Öztay", "Öztaylan", "Öztoygar", "Özüak", "Özyay", "Özyuva", "Padişah", "Pakalın", "Pakân", "Pakbaz", "Pakel", "Paker", "Paki", "Akdora", "Pakkan", "Pakman", "Paksan", "Akdoru", "Akdoruk", "Akdöl", "Polat", "Poyraz", "Raci", "Racih", "Akduman", "Radi", "Rafet", "Rafettin", "Rafi", "Rafih", "Ragıp", "Akdur", "Rahi", "Rahim", "Rahman", "Rahmani", "Rahmeti", "Akdurmuş", "Rahmetullah", "Rahmi", "Raif", "Sıralp", "Sırat", "Akkaya", "Sıylıhan", "Simavi", "Sina", "Akkaynak", "Sinan", "Sipahi", "Siracettin", "Siraç", "Siyavuş", "Akkemik", "Sonad", "Sonalp", "Sonbay", "Sondal", "Songurhan", "Songurkan", "Akkerman", "Soral", "Soyak", "Soyalp", "Soydan", "Soydaner", "Soydaş", "Soykal", "Akkılıç", "Soylubay", "Soysal", "Soysaldı", "Soysaltürk", "Soysan", "Soyupak", "Soyurgal", "Sönmezalp", "Sözal", "Akkın", "Sualp", "Suavi", "Subaşı", "Subay", "Subutay", "Suca", "Suhan", "Suka", "Sukat", "Sunal", "Sunalp", "Sunguralp", "Sungurbay", "Tatarhan", "Tatarkan", "Tav", "Tavgaç", "Tavlan", "Tavlı", "Tavuş", "Aksunar", "Tay", "Uzbay", "Uzcan", "Uzhan", "Uzkan", "Uzman", "Uzsan", "Uztan", "Uztaş", "Uztav", "Uztay", "Übeydullah", "Ükkaşe", "Alâaddin", "Ülgenalp", "Ülkütan", "Ünalan", "Ünaldı", "Ünalmış", "Ünalp", "Alaca", "Ünkan", "Ünkaya", "Ünsan", "Ünüvar", "Ünyay", "Alacan", "Üründübay", "Üstat", "Üstay", "Üstünbay", "Vacip", "Vacit", "Vafi", "Vafir", "Alaçam", "Vafit", "Vaha", "Vahap", "Vahdet", "Vahdettin", "Vahip", "Vahit", "Vahittin", "Alaçuk", "Vaiz", "Vakkas", "Vakur", "Vâlâşan", "Vamık", "Varal", "Varaş", "Vardar", "Aladoğan", "Vargın", "Varol", "Vasfi", "Vasıf", "Vasıl", "Vassaf", "Vatan", "Vataner", "Vecahettin", "Vedat", "Vefai", "Velican", "Veliyullah", "Veral", "Verşan", "Vicdani", "Visali", "Visam", "Volkan", "Vural", "Yadacı", "Alahan", "Yafes", "Yağın", "Yağınalp", "Yağısıyan", "Yağız", "Yağızalp", "Yağızbay", "Yağızboğa", "Yağızer", "Yağızhan", "Yağızkan", "Yağızkurt", "Yağıztekin", "Yağmurca", "Yahşibay", "Alakoç", "Yahşiboğa", "Yahşihan", "Yahşikan", "Yahşitay", "Yahya", "Yakup", "Yalap", "Yalavaç", "Alakurt", "Yalaz", "Yalazahan", "Yalazakan", "Yalazalp", "Yalçın", "Yalçıner", "Yalçınkaya", "Yaldırak", "Yaldırım", "Yalgı", "Yalgın", "Yalgınay", "Yalım", "Yalınalp", "Alâmet", "Yalkı", "Yalkın", "Yalmaç", "Yalman", "Yalt", "Yaltır", "Yalvaç", "Alan", "Yamaç", "Yaman", "Yamaner", "Yamanöz", "Yamansoy", "Yamantürk", "Yamanyiğit", "Yamçı", "Yanaç", "Yanal", "Alanalp", "Yanar", "Yanbek", "Yanbey", "Yandil", "Yangâr", "Yanık", "Yanıker", "Yapalak", "Alanay", "Yararer", "Yardak", "Yargan", "Yargı", "Yarkan", "Yarkaya", "Alanbay", "Yarlık", "Yarluk", "Yaruk", "Yasa", "Yasan", "Yasavul", "Yaser", "Yasin", "Alaner", "Yasun", "Yaşa", "Yaşartürk", "Yaşdaş", "Yaşlak", "Yatman", "Yatuk", "Yavaş", "Yaver", "Yavuz", "Yavuzalp", "Yavuzay", "Yavuzbay", "Alangu", "Yavuzboğa", "Yavuzcan", "Yavuzer", "Yavuzhan", "Yavuzsoy", "Yay", "Yayak", "Yayalp", "Yaybörü", "Yaybüke", "Yaygır", "Yaylak", "Yazan", "Yazar", "Yazgan", "Yazganalp", "Yazgı", "Yazık", "Yazır", "Yelal", "Yelbay", "Yelboğa", "Yeldan", "Yenal", "Alat", "Yenay", "Yeneral", "Yertan", "Yesari", "Yetişal", "Vecdi", "Vechi", "Vecih", "Vecihi", "Vecit", "Yüceer", "Alpak", "Yücelt", "Yücelten", "Yücesoy", "Yücetekin", "Yücetürk", "Çeçen", "Çekik", "Çekim", "Alpar", "Çekin", "Çelem", "Çelen", "Çelenk", "Çelik", "Çelikel", "Çeliker", "Çelikiz", "Çelikkol", "Çeliköz", "Alparslan", "Çeliksu", "Çelikten", "Çeliktürk", "Çelikyürek", "Çelim", "Çeltik", "Çender", "Çengiz", "Çepni", "Çerçi", "Alpartun", "Çeri", "Çerkez", "Çerme", "Çetik", "Çetin", "Çetinel", "Çetiner", "Çetinok", "Çetinöz", "Çetinsoy", "Alpaslan", "Çetinsu", "Çetintürk", "Çetinyiğit", "Çevik", "Çevikel", "Çeviker", "Çeviköz", "Çevrim", "Çığ", "Alpat", "Çığıl", "Çıngı", "Çıvgın", "Çiftçi", "Çiğil", "Çiğlez", "Alpata", "Çin", "Çiner", "Çinerk", "Çingiz", "Çinkılıç", "Alpay", "Çinuçin", "Çoker", "Çoku", "Çopur", "Çotuk", "Çotur", "Çökermiş", "Çöyür", "Alpaydın", "Demirgüç", "Demirkoç", "Demirpençe", "Dikeç", "Dinç", "Dinçer", "Dinçerk", "Dinçkol", "Dinçkök", "Abidin", "Alpayer", "Dinçmen", "Dinçok", "Dinçol", "Dinçöz", "Dinçsel", "Dinçsoy", "Dinçsü", "Dinçtürk", "Direnç", "Elçi", "Alpbilge", "Emeç", "Enç", "Eneç", "Erçelik", "Erçetin", "Erçevik", "Erdinç", "Alpçetin", "Erdin", "Erdiner", "Erdoğ", "Erdoğdu", "Erdoğmuş", "Erdöl", "Erdölek", "Erdönmez", "Erdur", "Erdurdu", "Erdurmuş", "Erdursun", "Erduru", "Erendemir", "Ergüden", "Ergüder", "Eryıldız", "Esendemir", "Ferdi", "Altınbaran", "Feridun", "Ferzend", "Firdevsi", "Gedik", "Gökdemir", "Altınbaş", "Gökdeniz", "Göndem", "Gönder", "Gönüldeş", "Güdek", "Güder", "Altınbay", "Gündemir", "Gündeniz", "Günder", "Gündeş", "Gündoğdu", "Gündoğmuş", "Gündöndü", "Güngördü", "Hemdem", "Hıdır", "Idık", "Idıkut", "İdi", "İdikurt", "İdikut", "İdris", "İğdemir", "İldem", "İldemer", "İldemir", "İskender", "İşgüden", "İşgüder", "Kızıldemir", "Ablak", "Altınel", "Kuddus", "Kuddusi", "Ledün", "Medeni", "Medet", "Medih", "Altıner", "Medit", "Mehdi", "Memduh", "Menderes", "Merdi", "Mevdut", "Muktedir", "Muslihiddin", "Müderris", "Müdrik", "Altınhan", "Müldür", "Nedim", "Od", "Oder", "Okdemir", "Okverdi", "Önderol", "Öndeş", "Öründü", "Özdeğer", "Özdek", "Özdel", "Özdemir", "Özdil", "Özdoğdu", "Özdoğmuş", "Özdoğru", "Özdoru", "Özdoruk", "Özdurdu", "Özduru", "Özdurul", "Özdurum", "Özender", "Özerdem", "Özerdim", "Özönder", "Özüdoğru", "Özverdi", "Reşididdin", "Altınkaya", "Sedit", "Semender", "Sevgideğer", "Sevindik", "Seydi", "Sıddık", "Abraş", "Altınkılıç", "Sıdkı", "Sudi", "Suudi", "Süerdem", "Süerden", "Şemdin", "Şendur", "Şide", "Tedü", "Tendürek", "Tepedelen", "Tevhiddin", "Tokdemir", "Topdemir", "Toydemir", "Altınok", "Toydeniz", "Tümerdem", "Türkdoğdu", "Ufukdeniz", "Uldız", "Umdu", "Neşit", "Nevfel", "Nevit", "Nevrettin", "Nevri", "Argın", "Neyyiri", "Neyzen", "Nezih", "Nezihi", "Nezir", "Argu", "Nurer", "Nurersin", "Nurettin", "Arguç", "Akabay", "Argüden", "Nurtekin", "Argüder", "Nusrettin", "Oğultekin", "Argün", "Oğuzer", "Oker", "Okergin", "Oksev", "Okseven", "Oksever", "Oktüre", "Oktüremiş", "Okver", "Olguner", "Arhan", "Onel", "Oner", "Onerim", "Onguner", "Ongüner", "Ongüneş", "Onuker", "Onuktekin", "Onursev", "Onurseven", "Öger", "Ögetürk", "Öğe", "Öğet", "Öğmen", "Ökeer", "Ökelik", "Arıbal", "Öker", "Ökkeş", "Ökmen", "Ökmener", "Ökte", "Öktem", "Öktemer", "Ökten", "Öktener", "Ölen", "Arıbaş", "Ömer", "Önel", "Önemli", "Önen", "Öneri", "Öneş", "Öngel", "Arıboğa", "Öngen", "Öngören", "Önsel", "Örenel", "Örgen", "Arıca", "Örsel", "Örüner", "Öryürek", "Ötüken", "Övet", "Öymen", "Özek", "Özengin", "Özerek", "Özerk", "Özerkin", "Özerkmen", "Akabey", "Özerol", "Özertem", "Özgeer", "Özgener", "Özger", "Özgüner", "Özgürel", "Özgüven", "Özilter", "Özke", "Özkent", "Özker", "Özlek", "Arıer", "Özlüer", "Özmert", "Özöğe", "Özpeker", "Arığ", "Özsüer", "Özşen", "Öztek", "Öztekin", "Öztinel", "Öztiner", "Arıhan", "Özüpek", "Özver", "Özveren", "Özvermiş", "Arık", "Pertev", "Arıkal", "Arıkan", "Refettin", "Refi", "Refiğ", "Refih", "Refii", "Refik", "Arıkboğa", "Reis", "Rekin", "Remzi", "Reset", "Resmî", "Arıker", "Resul", "Reşik", "Reşit", "Akçabay", "Arıkhan", "Rüknettin", "Rüstem", "Seferî", "Seğmen", "Arıkiz", "Sehi", "Selâh", "Selâhi", "Selâm", "Selâmettin", "Arıkol", "Selâmi", "Selâtin", "Selek", "Selekmen", "Seler", "Selim", "Arıkut", "Selmi", "Selok", "Semih", "Arıl", "Semir", "Semuh", "Sener", "Senger", "Arıman", "Senî", "Senih", "Senol", "Serener", "Sergen", "Sergin", "Serhenk", "Serhun", "Serim", "Serimer", "Serkut", "Serol", "Sertel", "Serter", "Sertuğ", "Arınık", "Server", "Sevener", "Sevgün", "Seviğ", "Sevik", "Alabaş", "Arısal", "Sevük", "Arısan", "Sevüktekin", "Seyfettin", "Seyfi", "Seyhun", "Seyit", "Seymen", "Arısoy", "Sezi", "Sezim", "Seziş", "Sezmen", "Siper", "Arış", "Sirer", "Sirmen", "Siyret", "Somel", "Somer", "Soner", "Arıtan", "Soyer", "Soygüven", "Soyluer", "Soytekin", "Törel", "Töreli", "Tören", "Tuğrultekin", "Tuğsel", "Tuğser", "Tuğtekin", "Arpad", "Tutel", "Tuter", "Tuzer", "Tükel", "Tülek", "Tümel", "Tümen", "Tümer", "Tümerk", "Arpağ", "Tümerkin", "Tüner", "Tüney", "Türe", "Türek", "Türel", "Türeli", "Türemen", "Türev", "Arpak", "Türkşen", "Tüzeer", "Tüzemen", "Arpınar", "Tüzmen", "Uğurel", "Uhuvvet", "Uluer", "Ulutekin", "User", "Usluer", "Uygunel", "Uyguner", "Uzel", "Uzer", "Uzgören", "Uzmen", "Uztekin", "Arsan", "Üke", "Üleş", "Ülez", "Ülfer", "Ülgener", "Arslan", "Ülken", "Ülkümen", "Ülküsel", "Ülmen", "Ümek", "Ümmet", "Arslaner", "Ünek", "Üner", "Üngören", "Ünlem", "Ünlen", "Ünlüer", "Arsoy", "Ünsevin", "Ünveren", "Ünvermiş", "Ürek", "Ürem", "Artaç", "Üren", "Üresin", "Ürkmez", "Üsgen", "Üstek", "Üstel", "Üster", "Artam", "Üstüner", "Ütügen", "Üveys", "Üye", "Üzek", "Üzer", "Üzeyir", "Vefi", "Vefik", "Vefki", "Artan", "Vehip", "Vekil", "Velet", "Veli", "Velit", "Vergi", "Vergili", "Vergin", "Artık", "Verim", "Vesik", "Vesim", "Veyis", "Veysel", "Veysi", "Yâren", "Yegân", "Artuç", "Yeğin", "Yeğiner", "Yeğrek", "Yel", "Yelen", "Yeler", "Yelesen", "Yeleser", "Yeltekin", "Artuk", "Yemen", "Yenel", "Yenen", "Yenerol", "Yengi", "Yenin", "Yenisu", "Yenisü", "Artun", "Yerel", "Yergin", "Yerik", "Yersel", "Yesügey", "Yeten", "Artunç", "Yetener", "Yetik", "Yetim", "Yetiş", "Yetişen", "Yetkiner", "Artut", "Yiğitel", "Yiğiter", "Yöner", "Yönet", "Yönetken", "Yönetmen", "Yöntem", "Yurter", "Yurtgüven", "Yürekli", "Yürüker", "Arukan", "Zekâi", "Zeki", "Zemin", "Zengin", "Zerin", "Zeynel", "Zeyni", "Aryüz", "Zeynur", "Zeyrek", "Züheyr", "Arzık", "Zürriyet", "Fikri", "Firuz", "Fuzuli", "Hıfzı", "Kâşif", "Lâtif", "Lütfi", "Müfit", "Müftü", "Abdal", "Münif", "Müşfik", "Örfi", "Rıfkı", "Vâkıf", "Yusuf", "Zülfi", "Zülfü", "Zülkif", "Zülküf", "Girgin", "Giz", "Göğüş", "Gökgöl", "Gökhun", "Göksoy", "Göktuğ", "Göktürk", "Görgü", "Görgün", "Görk", "Göyük", "Gözütok", "Asaf", "Asal", "Gümüşkurt", "Gümüşkut", "Güngörmüş", "Günışık", "Günizi", "Günizli", "Günkurt", "Günkutlu", "Günmutlu", "Günol", "Güntimur", "Güntürk", "Güntürkün", "Günyıl", "Günyol", "Günyüz", "Gür", "Gürgân", "Asan", "Hoşgör", "Hülâgü", "Ilgı", "İlig", "İyigün", "İzgü", "Kırgız", "Kızgın", "Kızgınok", "Kızgınyiğit", "Kongur", "Korgün", "Koygun", "Mutlugün", "Ası", "Ogün", "Olgunsoy", "Asıf", "Olgunsu", "Ongun", "Ongunsu", "Ongur", "Ongün", "Orgun", "Orgün", "Öngör", "Öngü", "Öngün", "Öngüt", "Özsungur", "Sılgın", "Sıngın", "Singin", "Songun", "Kip", "Kipkurt", "Kişi", "Kökşin", "Köni", "Lâmi", "Mikâil", "Muin", "Mukim", "Munis", "Muti", "Mükrim", "Mükrimin", "Mülâyim", "Asutay", "Mümin", "Münim", "Münip", "Münir", "Mürit", "Mürşit", "Müslim", "Müşir", "Atabek", "Nuri", "Örik", "Öztimur", "Öztin", "Rükni", "Suzi", "Sükûti", "Süruri", "Timur", "Timuröz", "Tin", "Tinkut", "Tipi", "Aşan", "Toktimur", "Tulûi", "Türkili", "Ulvi", "Ünsi", "Aşcır", "Yümni", "Zikir", "Zikri", "Zinnur", "Konuk", "Konur", "Konuröz", "Kopuz", "Kor", "Korkut", "Aşır", "Koşuk", "Kotuz", "Koytuk", "Köksoy", "Molu", "Oksu", "Oktürk", "Okumuş", "Okur", "Okuş", "Okuşlu", "Oluk", "Omur", "Onuk", "Onul", "Onurlu", "Aşir", "Onursoy", "Onursu", "Onursü", "Orkun", "Orkuş", "Orkut", "Ortun", "Oruk", "Orum", "Orun", "Aşkan", "Orus", "Oruz", "Otuk", "Oy", "Oykut", "Önol", "Önsoy", "Özok", "Özol", "Özsoy", "Öztoklu", "Özütok", "Som", "Sorkun", "Atabey", "Soykök", "Soykurt", "Soykut", "Soylu", "Soyöz", "Sürsoy", "Tok", "Toköz", "Toku", "Tokuş", "Aşkınay", "Tokuz", "Tokyüz", "Tolon", "Tolun", "Topuz", "Tor", "Toros", "Torun", "Tosun", "Totuk", "Aşkıner", "Toy", "Tozun", "Tümkor", "Türkol", "Ulusoy", "Uzsoy", "Ünlüol", "Ünlüsoy", "Ünsoy", "Üstol", "Ata", "Yomut", "Zorlu", "Kök", "Köklü", "Köksu", "Köksür", "Köktürk", "Körklü", "Köz", "Atâ", "Ök", "Öklü", "Öktürk", "Önür", "Örs", "Örük", "Ataan", "Ötnü", "Ötün", "Özkök", "Özkul", "Özkurt", "Atacan", "Özkutlu", "Özlütürk", "Özmut", "Özön", "Özsözlü", "Özsun", "Ataç", "Özsü", "Özsüt", "Öztürk", "Özü", "Özyörük", "Sözüsöz", "Tör", "Atadan", "Törü", "Törüm", "Töz", "Tözüm", "Türköz", "Uluöz", "Yön", "Yörük", "Ataergin", "Rüknü", "Rüştü", "Atabörü", "Şükrü", "Tur", "Tümkurt", "Türk", "Ulutürk", "Umur", "Atagün", "Ur", "Urluk", "Uruk", "Urun", "Uruş", "Uruz", "Uztürk", "Üntürk", "Ürkün", "Atahan", "Yurtkulu", "Yürük", "Müslüm", "Sâmân", "Sukuşu", "Atak", "Suut", "Sü", "Sülü", "Ulus", "Atakan", "Ulusu", "Us", "Usuk", "Usum", "Üs", "Üstün", "Yunus", "Muştu", "Ataker", "Tutuş", "Ukuş", "Yumuş", "Kutlu", "Kutluk", "Lut", "Mut", "Mutluk", "Atakul", "Tuluk", "Tulum", "Tulun", "Tun", "Tutku", "Tutu", "Tutuk", "Tutun", "Atakurt", "Tuyuk", "Tuz", "Tümkut", "Ulukut", "Atakut" };


          
            int counterisim = 1;
            List<int> sayilarisim = new List<int>();
           
            while (counterisim < 500)
            {
                sayilarisim.Add(rndisim.Next(1,1700));
                counterisim++;
            }
          
            int seciciisim = sayilarisim[rndisim2.Next(0,490)];

          
            



            _addNewPerson.Ad = namecreator[seciciisim];


            string[] surnamecreator = { "ŞEN", "KANDEMİR", "ÇEVİK", "ERKURAN", "TÜTEN", "ÖZTÜRK", "YÜZBAŞIOĞLU", "VURAL", "YÜCEL", "SÖNMEZ", "ERTEKİN", "DEDE", "UYANIK", "ASLAN", "AKBULUT", "ORHON", "UZ", "YAVUZ", "ERDEM", "KULAÇ", "KAYA", "SELVİ", "AKPINAR", "ABACIOĞLU", "ÇAY", "IŞIK", "ÖZER", "ÖZDEMİR", "ÖZTÜRK", "TAHTACI", "BÜYÜKCAM", "KULAKSIZ", "AKSEL", "EROĞLU", "KARAKUM", "DAL", "ÖCAL", "AYHAN", "YİĞİT", "YARBİL", "CANACANKATAN", "GÜMÜŞAY", "MURT", "HALHALLI", "ULUÖZ", "ŞEYHANLI", "ÇALIŞKANTÜRK", "YILMAZ", "SARAÇOĞLU", "SEZER", "DOĞAN", "DEMİR", "KAYAYURT", "SÜRÜM", "YAVAŞİ", "TURGUT", "ŞENTANRIKULU", "BARBAROS", "ALDİNÇ", "TEKİN", "GÜLŞAN", "KÜFECİLER", "ALMACIOĞLU", "ÇİLDİR", "TÜRKDOĞAN", "KAYA", "ÖNER", "ŞELİMAN", "YAMAN", "ATİK", "YİĞİT", "GİRAY", "YALÇINKAYA", "KILIÇ", "ŞENTÜRK", "KARABAĞ", "DEĞİRMENCİ", "BODUROĞLU", "YILDIZ", "GÜLER", "ERASLAN", "ÜZER", "PİŞİRGEN", "ADANIR", "KOÇ", "KORKMAZ", "YENİDOĞAN", "AYDOĞAN", "ACARBULUT", "ERGE", "ERDOĞAN", "ÖĞÜTAYDIN", "KUŞKU", "KUCURTÜLÜBAŞ", "PEKTAŞ", "KAYACAN", "GÜLEN", "DOĞAN", "AYDINBADILLIOĞLU", "GÜLENAKKÜÇÜK", "CANDAN", "TEMEL", "YENİGÜN", "YILDIRIM", "BEDER", "AKINCI", "ÖZDEMİR", "ONUK", "AYDOĞAN", "YILMAZ", "AKCANATASOY", "SARAÇOĞLUÇEKİÇ", "CÖMERT", "TOPAL", "KARAHAN", "ŞAHİN", "ÇETİN", "YILMAZİNAL", "AYTAÇ", "YILDIZALTUN", "KİŞİ", "GÜNDÜZ", "ÖZKURTPÜRCÜ", "AK", "URFALI", "KARAMAN", "MEMETOĞLU", "KAZBEK", "KİREÇÇİ", "AKIN", "YADİGAROĞLU", "YÜKSEL", "ÖZÇELİKORAL", "BABUŞ", "KAPLAN", "AKÖZ", "KARTAL", "BİLGİÇ", "ERDEN", "TUĞCUGİL", "KUMRAL", "ERBAŞ", "ORAL", "KILAÇ", "CENGİZ", "YILDIRIM", "KUTLUCANBAĞCI", "BALABAN", "KAYA", "BALCI", "TÜFEKÇİ", "ATAY", "YARAR", "SEVER", "YILDIRIM", "ARSLANKAŞDOĞAN", "ARKAN", "TUTAŞ", "ÖZTÜRK", "HAVAS", "SEÇİR", "YILDIZ", "SOYKAMER", "BEKTAŞ", "BERK", "GÜL", "GEDİKYILMAZ", "CENGİZ", "ÇOLAK", "BULUT", "SARI", "AKYOL", "BAĞCIK", "KUTLUYURDU", "DEMİRGAN", "YİĞİTKUPLAY", "GERİLMEZ", "DÜZKALIR", "KÖKSOY", "GÜLŞEN", "AKAR", "ÖZDOĞAN", "TÖNGE", "YASA", "ÖNVERMEZ", "YILDIRIM", "BİÇER", "KARADEMİR", "ALIMLI", "AKGÜL", "HANCIOĞLU", "BATÇIK", "OLPAK", "BOLAT", "ARSLAN", "SİĞA", "MERCAN", "BOZKURTER", "GÜLER", "ERGİNEL", "ŞAHİN", "KADAK", "GÜNEYKOCABAŞ", "GAYRETLİAYDIN", "HEPKAYA", "BAYRAM", "KANIKYÜKSEK", "KULAKGEDİK", "AKCANPAKSOY", "ESER", "KILIÇYILDIRIM", "GİDER", "KURT", "ELLİALTI", "DEMİRTAŞ", "ARGA", "BAŞKANVURALKAN", "ALUÇLU", "MUTLU", "ŞATIRERTEM", "ENGİZ", "ÇİPE", "UYSAL", "BAŞER", "ARSLAN", "GÖZKAYA", "ULUTAŞ", "PİRİM", "ÜSTÜN", "KIZMAZOĞLU", "ULUBA", "ARSLAN", "KARAOĞLU", "ÖZSOY", "YALÇIN", "SAF", "VURAL", "DEMİRTAŞ", "GENÇPINAR", "AKASLAN", "UYĞUN", "ATAY", "ÖNDERSİVİŞ", "BAYMAK", "ATAY", "GÜVENÇ", "AKCAÇAĞLAR", "ÖZCAN", "ERDEMÖZCAN", "BAŞMAN", "YANNİ", "ÜNAL", "GÜNDOĞDU", "ÇELİK", "USTAGÜÇ", "TANRIVERDİYILMAZ", "TAŞKIN", "ÇETİN", "YILMAZÇİFTDOĞAN", "GAZETECİTEKİN", "SARİ", "KARAKOYUN", "KARAKUŞEPÇAÇAN", "EKİCİ", "AYDINER", "AKTAŞ", "BELGEMEN", "ÇETİN", "OFLAZ", "BUĞRUL", "BAYSOY", "BÜKÜLMEZ", "YILMAZ", "BIÇAKÇI", "KARA", "TİMURTAŞDAYAR", "ATEŞ", "BİNBOĞA", "KIZILTEPE", "KAYA", "ABSEYİ", "AMİROVAUÇAN", "ÖZTÜRK", "TAŞ", "CEYLAN", "KILIÇ", "EROL", "TAYFUN", "KAYA", "KARAKURT", "BUDUNOĞLU", "ÖZER", "SAYGIN", "ERYAVUZ", "POLATÇİÇEK", "YILMAZ", "ÇELİK", "ÜNSAL", "ALPINAR", "CİNDEMİR", "AKDUMAN", "UYAR", "TÜLPAR", "AZAK", "EREN", "GÖZCÜ", "BAYSAL", "TUNCEL", "ÇETEMEN", "YILMAZ", "GİNİŞ", "UZUN", "NASIROĞLU", "SEZGİN", "ÖZTÜRK", "YILDIRIM", "UZUN", "BULUR", "DUYSAK", "YENİN", "DEMİREL", "SAK", "KOCABAŞ", "SARAÇ", "ALKURTKAYIKÇI", "YURT", "İLKAY", "TAVŞAN", "ALAY", "ERTEM", "ÖZEL", "GENÇ", "UĞUZ", "EVİK", "GENÇTALAS", "EKER", "ÇİMEN", "ÇIRAKOĞLU", "DEMİRGÖÇMEN", "ALPAYCI", "AK", "ÇELİK", "ERCAN", "ALTUN", "KILIÇ", "SARP", "SÖKER", "KÖSE", "BARÇAK", "ÖZEKLİMISIRLIOĞLU", "BOLAÇ", "ASLANALP", "ÖRNEK", "AKDOĞAN", "ÖZÇELİK", "ERTÜRKLER", "SARAL", "ÖZKAN", "DEMİRHAN", "ASLANKARA", "EMLAKÇIOĞLU", "ÖZTÜRK", "ESER", "ÖDEN", "DEMİRAY", "AYHAN", "YAĞCI", "AVCI", "BAYGELDİ", "BÜKÜM", "DİNCER", "DOĞAN", "EKİZ", "ŞAHİNER", "ŞENGÜL", "İLGÜN", "AŞIK", "ÖZKAN", "ŞİRZAİ", "ÖCALAN", "KABA", "TÜLÜCE", "AYTEKİN", "KAYA", "DÜGER", "METİNEREN", "BULUT", "ŞAHİNDUYAR", "ÇETİN", "BÖLÜK", "GÖZAÇAN", "BOZKURT", "ÖNEYKURNAZ", "AYGÜNEY", "KÖYLÜ", "ÖZMENSÜNER", "TALAN", "DUMLU", "ZORLUKARAYİĞİT", "KÖYCÜ", "UYGUR", "KABACAOĞLU", "TOPALOĞLU", "AYIK", "DEMİR", "ERDEM", "KARAMANLI", "SADİAYKAN", "OKTAY", "YURTLU", "SALMANSEVER", "CİRİTKOÇER", "SORGUNEVCİLİ", "NURÇİN", "BAŞKAN", "KAZANCI", "KIYAKYILMAZ", "METE", "UZUN", "SAĞDIK", "ARIKANYORGUN", "EKİCİ", "KESİM", "GÜL", "YILDIRIM", "KARAGÖZ", "PEKEL", "YAKAR", "TARLAN", "ÇATAK", "ÇETİNKOR", "SAYIN", "KURT", "GÜMÜŞ", "KOCAKAYAALTUNDAL", "ÖZMEN", "GÜNAY", "DÜZ", "DİLEK", "DEMİRTAŞ", "KURTULUŞ", "KARPUZOĞLU", "ERGİNTÜRKACAR", "BEYOĞLU", "SULHAN", "ARSLAN", "NUHVEREN", "AVCIOĞLU", "AHISKALI", "ASENA", "KARACANERŞEKERCİ", "GÖLEMEZ", "YILDIRIM", "TOHUMOĞLU", "ÇELİK", "BOZARSLAN", "KÖŞKER", "ÇELİK", "SÜL", "KORKMAZ", "TARKAN", "DUMAN", "HODJAOGLU", "BALLI", "ŞATIROĞLU", "ÖNDE", "LAĞARLI", "ÖZÇAY", "ARSLAN", "AKDEMİR", "İÇBAY", "AKIN", "DEMİRÖZ", "KUYUCU", "SELÇUK", "İNCE", "ERGÜLÜEŞMEN", "GÖKALP", "BABACAN", "ÜLGER", "AYVAZ", "ELVERDİ", "AYDIN", "DEMİREL", "CİMBEK", "FIRAT", "BAHÇEBAŞI", "DAM", "KÖROĞLU", "ÖZÇELİK", "KARACA", "SEVEN", "ÖZKURT", "ALTUN", "BÜYÜKTAŞ", "SERTKAYA", "ÖVENUSTAALİOĞLU", "YALNIZ", "SAVAŞ", "YILMAZ", "YALÇIN", "BEREKET", "KAYA", "PEKGÖZ", "DEMİR", "OLMAZ", "SEVİNÇ", "MERHAMETSİZ", "ÇOBANOĞLU", "ŞİMŞEK", "BİNNETOĞLU", "ÖĞÜTMENKOÇ", "ÇINKIR", "CAMCI", "YAZAK", "NİZAM", "TÜRKOĞLU", "DEMİRKOL", "AKSAKAL", "AKIN", "BOZOĞLAN", "DEĞİRMENCİ", "AYMAN", "SAÇLI", "KARAKILIÇ", "BAKANAYÖZTÜRK", "KARAKÖSE", "GÜVENMEŞE", "YEŞİLOVA", "EŞKAZAN", "GERDAN", "MUMCUOĞLU", "VATANSEVER", "PAKÖZ", "ATMIŞ", "AKÇALI", "FAKIOĞLU", "YENİDÜNYA", "ANIK", "KÖSEOĞLU", "SONAY", "ÇELİKER", "ÖZDEMİRKIRAN", "ÇELİK", "KÖSE", "AKIN", "DURÇÖZTÜRK", "İNERKÖKSAL", "BEREKATOĞLU", "DİLLİ", "ELBÜKEN", "BAHÇECİ", "BÜLBÜL", "KADI", "IŞIK", "YÜCETÜRK", "BULUR", "ÖZİŞ", "ULUBAŞOĞLU", "AKŞAHİN", "KARPUZ", "YABUL", "GÖKSOY", "ÜNAL", "IŞIK", "KÖKSAL", "TEKİŞ", "AKSOY", "BAŞYURT", "YURDSEVEN", "ERDEM", "MERDEN", "KISAKARAKAYA", "SANHAL", "ŞAHİN", "VATANSEVER", "BİLGİ", "KAYABAŞ", "GÜRBOSTAN", "BOLAT", "KABİLKUCUR", "DEĞİRMENCİAKAR", "TAYYAR", "ŞAHBAZ", "YANCAR", "OLGAÇ", "EKİZ", "EREN", "MALÇOK", "KARASU", "KARADAĞ", "TOPRAK", "SAĞLAM", "ŞAHİN", "KEBAPCILAR", "TATAR", "ARSLAN", "YÜCE", "TOLA", "GÜNGÖR", "KARAGÖZ", "ALTINBOĞA", "YENİÇERİ", "IŞIKALAN", "ÖZDEMİR", "GÜRBÜZ", "KURU", "YURDAM", "KARA", "ÇETİN", "BAŞARAN", "ŞAHİN", "ÜREYEN", "IŞIK", "ÖZTÜRK", "DOĞAN", "MESCİHAFTACI", "ORHAN", "VURAL", "EROL", "BALSAK", "ÖZDEMİR", "ÇİFT", "ŞEN", "YAZICIEROL", "BAYRAMOĞLU", "GENÇDAL", "DESTEGÜL", "ÖZDEMİR", "KARÇİN", "ASLAN", "BAZ", "ALTUNTAŞ", "ÖZCAN", "KIRBAŞ", "YILMAZ", "KAYMANKÖSE", "ÇETİN", "YEŞİLDAĞER", "YÜKSEL", "KAYAOĞLU", "KILIÇ", "CELTEMEN", "GÜNDÜZ", "ŞANLIKAN", "ÇELİK", "ORHAN", "TANTEKİN", "KARAALP", "TUNCER", "ATASOY", "DOĞAN", "GÖK", "ÖZDEMİR", "ÖZKAN", "ONARŞEKERCİ", "ASOĞLU", "KHALİL", "YURDAKÖK", "YILMAZ", "KESKİN", "KOÇARSLAN", "GÖKALP", "TUNÇAY", "SÜRMENAKYOL", "AYDIN", "SEVİNGİL", "GENÇPINAR", "AKKAYA", "KUSERLİ", "BOZKURT", "ŞİMŞEK", "YILMAZ", "TALAS", "ÇEVİKER", "KAYNAK", "BAYRAKTAR", "ÇETİNTAŞ", "CANTÜRK", "KARADENİZ", "ALAN", "KOYUNCU", "KARTAL", "KAYA", "BAKIRCI", "NAR", "ULUSOY", "CELİLOĞLU", "YÜCEL", "DUMAN", "AKDENİZ", "YERAL", "GÜRDAL", "KÜTÜK", "KANYILMAZ", "ÖZBEK", "UYSAL", "AKIN", "AKDENİZ", "KAPLAN", "ALBAYRAK", "YILDIRIM", "MÜEZZİNOĞLU", "AYHAN", "UYGUR", "TÜFENK", "YÜCEL", "DEMİR", "ÖZDEMİR", "KIRIŞ", "KIRASLAN", "SALTÜRK", "AÇIKGÖZ", "YAĞCI", "SEVÜK", "KAYA", "DOĞAN", "YILDIZ", "BAYTAN", "DEMİRTAŞ", "MUTLU", "GENÇ", "AKTUĞ", "SERİN", "TUNCAY", "GÜNBEY", "KAYA", "TAŞAR", "AVSEREN", "BAL", "BATMAZ", "VEZİROĞLUBİRDANE", "ARAZSERVER", "GÜLER", "DALYANCİLO", "KARADAĞGEÇGEL", "BAŞTÜRKAYHAN", "ERSOY", "TAY", "ERYILMAZ", "DEMİR", "AYDIN", "OCAK", "BÖLÜK", "ÖZMEN", "ÖZTÜRKERİ", "EKEN", "AKGÜL", "SARICADAROL", "CANSEVER", "AKIN", "GÜZEL", "ÖZERÇELİK", "ÇAKIR", "AKSUN", "BALAL", "BAYAM", "ŞAİR", "ÜNLÜ", "YUMURTAŞ", "AKGÜL", "AYKAN", "ALPSANGÖKMEN", "CANATAN", "MUMCUOĞLU", "TAŞKIRAN", "HATİPOĞLU", "AKYOL", "SUCAK", "YILDIZ", "AKPINAR", "GÖKSEL", "KARSLI", "ÖZGÜROL", "ACAR", "KALEM", "ŞAHİN", "AYDIN", "DÖKMECİ", "GÖRMELİ", "ÖZATEŞ", "SERVET", "TOPRAK", "SÜNER", "SARIKAYA", "SULUOVA", "SERBEST", "EFE", "TOPAK", "ATBİNİCİ", "KIYAK", "ÇELİK", "ÖZ", "TEPE", "ÖZÜAK", "ÖNCEL", "CANBAZ", "AL", "DEMİR", "GÜRER", "GÜNGÖR", "GÜZEL", "GÖNCÜ", "ÖZDAMAR", "KARATOPRAK", "ÇAVDAR", "KARA", "ÖZ", "SÖZEN", "GÖKÇEK", "KARAKAYA", "GÜNGÖR", "ÇEPNİ", "KIR", "ERSOY", "ÇAĞLAR", "ÖZALP", "EVRENOS", "BAYRAKTAROĞLU", "USLUSOY", "SARI", "ATALAY", "TOPKARA", "BEKTAŞ", "TENEKECİ", "ÇAĞIL", "MERTOL", "TAŞ", "HIDIROĞLU", "ŞENGÖKÇEİMAM", "KARAHAN", "ÖNALMUSALAR", "DEMİREL", "YACI", "IŞIKLI", "KILIÇ", "ÜLGEN", "KÜÇÜKGÖNCÜ", "SUKURT", "KOÇAR", "BALOĞLU", "DUMAN", "ASLAN", "SARICANBAZ", "SERT", "ALTUN", "GÖRMELİ", "YILMAZGELEBEK", "AKYOL", "ÖZANSANHAL", "AKYILMAZ", "BAKAN", "KARAKAN", };


            int countersoyisim = 1;
            List<int> sayilarsoyisim = new List<int>();

            while (countersoyisim < 500)
            {
                sayilarsoyisim.Add(rndsoyisim.Next(1, 700));
                countersoyisim++;
            }

            int secicisoyisim = sayilarsoyisim[rndsoyisim2.Next(0, 490)];

            _addNewPerson.Soyad = surnamecreator[secicisoyisim];


            int ilk5 = tcsallayici.Next(12345, 98765);
            string ilkbes = ilk5.ToString();
            int son5 = tcsallayici.Next(12345, 98765);
            string sonbes = son5.ToString();
           

            _addNewPerson.Tc = "1" + ilkbes + sonbes;

            _addNewPerson.A77 = Convert.ToInt16(a77labs);
            _addNewPerson.A87 = Convert.ToInt16(a87labs);
            _addNewPerson.A8 = Convert.ToInt16(a8labs);
            _getProjectLabData.A77Lab = Convert.ToInt16(a77labs);
            _getProjectLabData.A87Lab = Convert.ToInt16(a87labs);
            _getProjectLabData.A8Lab = Convert.ToInt16(a8labs);
            _addNewPerson.E101 = Convert.ToInt16(e101labs);
            _addNewPerson.E102 = Convert.ToInt16(e102labs);
            _addNewPerson.E103 = Convert.ToInt16(e103labs);


            _addNewPerson.A3Classic = Convert.ToInt16(-106.738537 + 0.835045 * e101labs + 0.188357 * e103labs);
            _addNewPerson.A4Classic = Convert.ToInt16(-20.945256 + 0.202817 * e101labs);
            _addNewPerson.A6Classic = Convert.ToInt16(-105.326523 + 0.718177 * e101labs + 0.402824 * e103labs);
            _addNewPerson.A19Classic = Convert.ToInt16(-47.697705 + 0.256377 * e101labs + 1.129147 * e103labs);
            _addNewPerson.A20Classic = Convert.ToInt16(90.761735 + 0.340686 * e102labs + 0.350313 * e103labs);
            _addNewPerson.A21Classic = Convert.ToInt16(59.294483 + 0.188209 * e102labs + 0.548081 * e103labs);
            _addNewPerson.A23Classic = Convert.ToInt16(-57.294902 + 0.848933 * e101labs + 0.194706 * e103labs);
            _addNewPerson.A27Classic = Convert.ToInt16(-41.963861 + 0.644490 * e101labs + 0.468165 * e103labs);
            _addNewPerson.A28Classic = Convert.ToInt16(-47.381527 + 0.213635 * e101labs + 1.205485 * e103labs);
            _addNewPerson.A35Classic = Convert.ToInt16(44.117699 + 0.693511 * e101labs + -1.064576 * e103labs);
            _addNewPerson.A41Classic = Convert.ToInt16(63.810323 + 0.115326 * e101labs + 0.497590 * e103labs);
            _addNewPerson.A42Classic = Convert.ToInt16(152.424057 + 0.595924 * e102labs + 0.742059 * e103labs);
            _addNewPerson.A53Classic = Convert.ToInt16(-55.610308 + 0.419386 * e101labs + 0.885773 * e103labs);
            _addNewPerson.A57Classic = Convert.ToInt16(-28.035053 + 0.101631 * e101labs + 0.786261 * e103labs);
            _addNewPerson.A58Classic = Convert.ToInt16(-15.204029 + 0.167189 * e101labs + 0.641549 * e103labs);
            _addNewPerson.A59Classic = Convert.ToInt16(-12.079942 + 0.101352 * e101labs + 0.757886 * e103labs);
            _addNewPerson.A65Classic = Convert.ToInt16(52.447531 + 0.782496 * e101labs);


            _addNewPerson.A68Classic = Convert.ToInt16(26.169505 + 0.044728 * e101labs + 0.379618 * e103labs);
            _addNewPerson.A70Classic = Convert.ToInt16(82.093259 + 0.080794 * e102labs + 0.447412 * e103labs);
            _addNewPerson.A72Classic = Convert.ToInt16(85.312841 + 0.749979 * e101labs + -1.126437 * e103labs);
            _addNewPerson.A73Classic = Convert.ToInt16(141.415083 + 0.339238 * e101labs + 0.369140 * e103labs);
            _addNewPerson.A74Classic = Convert.ToInt16(26.354689 + 0.168318 * e101labs + 0.630909 * e103labs);
            _addNewPerson.A75Classic = Convert.ToInt16(163.697267 + 0.632588 * e101labs + 1.255216 * e103labs);
            _addNewPerson.A77Classic = Convert.ToInt16(-88.756973 + 0.840642 * e101labs + 0.118663 * e103labs);
            _addNewPerson.A78Classic = Convert.ToInt16(-65.865792 + 0.482697 * e101labs + 0.788300 * e103labs);
            _addNewPerson.A82Classic = Convert.ToInt16(-48.088630 + 0.131415 * e101labs + 0.6642650 * (e103labs));
            _addNewPerson.A84Classic = Convert.ToInt16(-59.083669 + 0.293004 * e101labs + 1.036371 * e103labs);
            _addNewPerson.A91Classic = Convert.ToInt16(-49.140921 + 0.381921 * e101labs + 1.011836 * e103labs);
            _addNewPerson.A94Classic = Convert.ToInt16(-15.679586 + 0.938747 * e102labs + -0.406201 * e103labs);


            _addNewPerson.A2Trium = Convert.ToInt16(-45.101775 + 0.918255 * a87labs);
            _addNewPerson.A3Trium = Convert.ToInt16(-16.792604 + 0.987023 * a77labs + 0.043370 * a87labs + 0.116696 * a8labs);
            _addNewPerson.A6Trium = Convert.ToInt16(-25.596371 + 0.961065 * a77labs + -0.143448 * a87labs + 0.094185 * a8labs);
            _addNewPerson.A23Trium = Convert.ToInt16(49.888267 + 0.994674 * a77labs + -0.022369 * a87labs + 0.217901 * a8labs);
            _addNewPerson.A27Trium = Convert.ToInt16(12.608033 + 0.881134 * a77labs + -0.147747 * a87labs + 0.294365 * a8labs);
            _addNewPerson.A53Trium = Convert.ToInt16(-64.100029 + 0.761457 * a77labs + -0.197303 * a87labs + 0.471347 * a8labs);
            _addNewPerson.A78Trium = Convert.ToInt16(-77.463677 + 0.754171 * a77labs + -0.072149 * a87labs + 0.680516 * a8labs);
            _addNewPerson.A76Trium = Convert.ToInt16(178.973024 + 1.100870 * a77labs + -0.110327 * a87labs + 0.147082 * a8labs);
            _addNewPerson.A58Trium = Convert.ToInt16(-61.520425 + 0.365502 * a77labs + 0.447251 * a8labs);
            _addNewPerson.A4Trium = Convert.ToInt16(-0.226398 + 0.211667 * a77labs + 0.154119 * a8labs);
            _addNewPerson.A19Trium = Convert.ToInt16(-104.563971 + 0.630994 * a77labs + -0.211202 * a87labs + 0.764583 * a8labs);
            _addNewPerson.A59Trium = Convert.ToInt16(-59.822252 + 0.340544 * a77labs + -0.082402 * a87labs + 0.440318 * a8labs);
            _addNewPerson.A70Trium = Convert.ToInt16(11.255298 + 0.233635 * a77labs + -0.036070 * a87labs + 0.139968 * a8labs);
            _addNewPerson.A74Trium = Convert.ToInt16(-12.349681 + 0.343589 * a77labs + 0.553360 * a8labs);
            _addNewPerson.A91Trium = Convert.ToInt16(-46.524266 + 0.776548 * a77labs + -0.352021 * a87labs + 0.501591 * a8labs);
            _addNewPerson.A35Trium = Convert.ToInt16(263.277758 + 0.436220 * a77labs + 0.064016 * a87labs + -0.533529 * a8labs);
            _addNewPerson.A28Trium = Convert.ToInt16(-102.280483 + 0.622898 * a77labs + -0.282288 * a87labs + 0.717959 * a8labs);
            _addNewPerson.A57Trium = Convert.ToInt16(-83.258033 + 0.346940 * a77labs + -0.072620 * a87labs + 0.478991 * a8labs);
            _addNewPerson.A67Trium = Convert.ToInt16(-59.441407 + 0.334051 * a77labs + -0.193591 * a87labs + 0.357713 * a8labs);
            _addNewPerson.A82Trium = Convert.ToInt16(-83.460238 + 0.370562 * a77labs + -0.065726 * a87labs + 0.199244 * a8labs);
            _addNewPerson.A84Trium = Convert.ToInt16(-95.121944 + 0.672353 * a77labs + -0.225910 * a87labs + 0.510395 * a8labs);
            _addNewPerson.A68Trium = Convert.ToInt16(-12.350114 + 0.137748 * a77labs + 0.408437 * a8labs);
            _addNewPerson.A72Trium = Convert.ToInt16(326.721718 + 0.460583 * a77labs + 0.065512 * a87labs + -0.459889 * a8labs);
            _addNewPerson.A51Trium = Convert.ToInt16(54.850425 + 0.047806 * a77labs + 0.550016 * a87labs + 0.211832 * a8labs);
            _addNewPerson.A44Trium = Convert.ToInt16(78.017335 + 0.031662 * a77labs + 0.079454 * a87labs + 0.312442 * a8labs);
            _addNewPerson.A52Trium = Convert.ToInt16(22.165516 + 0.051973 * a77labs + 0.700181 * a87labs + 0.267744 * a8labs);
            _addNewPerson.A9Trium = Convert.ToInt16(147.667082 + 0.096545 * a77labs + 0.142044 * a87labs + 0.411829 * a8labs);
            _addNewPerson.A79Trium = Convert.ToInt16(54.375209 + -0.031790 * a77labs + 1.335470 * a87labs + 0.898565 * a8labs);
            _addNewPerson.A71Trium = Convert.ToInt16(48.866557 + 0.061390 * a77labs + -0.023408 * a87labs + 0.100708 * a8labs);
            _addNewPerson.A85Trium = Convert.ToInt16(250.729955 + 0.598313 * a77labs + 1.695107 * a87labs);
            _addNewPerson.A30Trium = Convert.ToInt16(88.740184 + 0.224249 * a77labs + 0.139455 * a87labs + -0.502395 * a8labs);
            _addNewPerson.A88Trium = Convert.ToInt16(-64.607488 + 3.079259 * a87labs);
            _addNewPerson.A43Trium = Convert.ToInt16(31.700846 + 0.0136011 * a77labs + 0.0282693739 * a87labs + 0.1381835 * a8labs);
            _addNewPerson.A89Trium = Convert.ToInt16(-45.331941 + 0.867252 * a87labs);
            _addNewPerson.A12Trium = Convert.ToInt16(162.445118 + 0.023838 * a77labs + 0.687638 * a87labs + 0.444005 * a8labs);
            _addNewPerson.A17Trium = Convert.ToInt16(131.020548 + 0.064154 * a77labs + 1.830446 * a87labs + 0.988782 * a8labs);
            _addNewPerson.A29Trium = Convert.ToInt16(80.639868 + 0.213828 * a77labs + 0.717112 * a87labs);
            _addNewPerson.A61Trium = Convert.ToInt16(67.735245 + 0.655908 * a87labs + 0.634233 * a8labs);
            _addNewPerson.A22Trium = Convert.ToInt16(107.431549 + -0.029235 * a77labs + 0.569322 * a87labs + 0.701913 * a8labs);
            _addNewPerson.A5Trium = Convert.ToInt16(62.795146 + 0.212295 * a87labs + 0.483976 * a8labs);
            _addNewPerson.A80Trium = Convert.ToInt16(40.126905 + 0.303287 * a87labs + 0.205684 * a8labs);
            _addNewPerson.A93Trium = Convert.ToInt16(51.217317 + 0.032278 * a77labs + 0.108286 * a87labs + 0.213584 * a8labs);
            _addNewPerson.A56Trium = Convert.ToInt16(181.550507 + 0.045307 * a77labs + 0.423027 * a87labs + 0.325191 * a8labs);
            _addNewPerson.A18Trium = Convert.ToInt16(37.078778 + 0.639543 * a87labs);
            _addNewPerson.A55Trium = Convert.ToInt16(190.115800 + 0.576113 * a87labs + 0.262139 * a8labs);
            _addNewPerson.A26Trium = Convert.ToInt16(16.310536 + -0.014720 * a77labs + 0.604974 * a87labs + 0.304707 * a8labs);
            _addNewPerson.A25Trium = Convert.ToInt16(207.707653 + 2.118783 * a87labs + 0.793033 * a8labs);
            _addNewPerson.A66Trium = Convert.ToInt16(18.771480 + 0.033155 * a77labs + 0.248777 * a8labs);
            _addNewPerson.A49Trium = Convert.ToInt16(39.565337 + 0.061876 * a77labs + 0.139101 * a87labs + 0.843483 * a8labs);
            _addNewPerson.A45Trium = Convert.ToInt16(17.501254 + 0.064538 * a77labs + 0.412735 * a8labs);
            _addNewPerson.A42Trium = Convert.ToInt16(-9.620756 + 0.695622 * a77labs + 0.150238 * a87labs + 0.447978 * a8labs);
            _addNewPerson.A41Trium = Convert.ToInt16(14.972599 + 0.220410 * a77labs + -0.056588 * a87labs + 0.829288 * a8labs);
            _addNewPerson.A38Trium = Convert.ToInt16(4.391388 + 0.176800 * a77labs + 0.449280 * a8labs);
            _addNewPerson.A37Trium = Convert.ToInt16(11.473740 + 0.041407 * a77labs + 0.996029 * a8labs);
            _addNewPerson.A7Trium = Convert.ToInt16(77.747303 + 0.031166 * a77labs + 0.112017 * a87labs + 0.462176 * a8labs);
            _addNewPerson.A81Trium = Convert.ToInt16(35.565254 + 0.387964 * a77labs + 0.099732 * a87labs + 0.924087 * a8labs);
            _addNewPerson.A13Trium = Convert.ToInt16(18.997111 + 0.0102960491 * a77labs + 0.017322 * a87labs + 0.175786 * a8labs);
            _addNewPerson.A20Trium = Convert.ToInt16(-14.886230 + 0.322632 * a77labs + 0.157779 * a87labs + 0.583264 * a8labs);
            _addNewPerson.A21Trium = Convert.ToInt16(-23.080582 + 0.287796 * a77labs + 0.557314 * a8labs);
            _addNewPerson.A36Trium = Convert.ToInt16(34.169395 + 0.010948 * a77labs + 0.037431 * a87labs + 0.197679 * a8labs);
            _addNewPerson.A73Trium = Convert.ToInt16(103.564967 + 0.380240 * a77labs + 0.170729 * a87labs + 0.943287 * a8labs);
            _addNewPerson.A75Trium = Convert.ToInt16(93.518160 + 0.987451 * a77labs + -0.139712 * a87labs + 1.720476 * a8labs);


            _addNewPerson.A76Network = Convert.ToInt16(175.831436 + 1.098562 * a77labs);
            _addNewPerson.A53Network = Convert.ToInt16(-62.035009 + 0.781086 * a77labs);
            _addNewPerson.A3Network = Convert.ToInt16(-16.792604 + 0.043370 * a87labs + 0.987023 * a77labs + 0.116696 * a8labs);
            _addNewPerson.A6Network = Convert.ToInt16(-33.260574 + 0.946997 * a77labs);
            _addNewPerson.A27Network = Convert.ToInt16(-99.563702 + 0.753316 * (_addNewPerson.A76Network) + 0.336914 * a8labs);
            _addNewPerson.A78Network = Convert.ToInt16(-77.463677 + 0.680516 * a8labs + -0.072149 * a87labs + 0.754171 * a77labs);
            _addNewPerson.A58Network = Convert.ToInt16(-45.024640 + 0.416505 * a77labs);
            _addNewPerson.A84Network = Convert.ToInt16(-22.336053 + 0.262666 * a8labs + 0.819955 * (_addNewPerson.A53Network));
            _addNewPerson.A19Network = Convert.ToInt16(-13.132120 + 0.931878 * (_addNewPerson.A84Network) + 0.305777 * a8labs);
            _addNewPerson.A72Network = Convert.ToInt16(130.121514 + -0.323757 * a8labs + 0.716447 * (_addNewPerson.A76Network) + -0.469520 * (_addNewPerson.A19Network) + 0.036331 * a87labs);
            _addNewPerson.A91Network = Convert.ToInt16(-37.419551 + 0.438261 * a8labs + 0.756795 * (_addNewPerson.A6Network));
            _addNewPerson.A28Network = Convert.ToInt16(-56.254522 + 0.554312 * (_addNewPerson.A19Network) + 0.247319 * a77labs + 0.269928 * a8labs);
            _addNewPerson.A35Network = Convert.ToInt16(-21.708011 + 0.899739 * (_addNewPerson.A72Network));
            _addNewPerson.A57Network = Convert.ToInt16(-31.107584 + 0.937455 * (_addNewPerson.A58Network));
            _addNewPerson.A59Network = Convert.ToInt16(56.994708 + 0.889996 * (_addNewPerson.A57Network));
            _addNewPerson.A67Network = Convert.ToInt16(-18.582834 + 0.759377 * (_addNewPerson.A59Network) + 0.052079 * (_addNewPerson.A3Network));
            _addNewPerson.A74Network = Convert.ToInt16(30.332024 + 0.317954 * a8labs + 0.347931 * (_addNewPerson.A28Network) + 0.142208 * a77labs);
            _addNewPerson.A70Network = Convert.ToInt16(14.094766 + -0.109304 * a8labs + 0.440916 * (_addNewPerson.A74Network) + 0.076505 * a77labs);
            _addNewPerson.A4Network = Convert.ToInt16(-7.917209 + 0.034367 * a8labs + 0.889153 * (_addNewPerson.A70Network) + 0.008941 * a77labs);
            _addNewPerson.A68Network = Convert.ToInt16(-8.768365 + 0.195002 * a8labs + 0.014528 * (_addNewPerson.A6Network) + 0.367814 * (_addNewPerson.A74Network));
            _addNewPerson.A82Network = Convert.ToInt16(30.142910 + 0.896959 * (_addNewPerson.A57Network));
            _addNewPerson.A23Network = Convert.ToInt16(56.188164 + 1.015654 * a77labs);


            _addNewPerson.A88Network = Convert.ToInt16(-64.607488 + 3.079259 * a87labs);
            _addNewPerson.A89Network = Convert.ToInt16(-30.382353 + 0.298617 * (_addNewPerson.A88Network) + -0.063299 * a8labs);
            _addNewPerson.A2Network = Convert.ToInt16(-41.362187 + 0.314714 * (_addNewPerson.A88Network));
            _addNewPerson.A92Network = Convert.ToInt16(-1200.213054 + 1.018030 * (_addNewPerson.A88Network) + 2.123612 * a8labs + 0.466573 * a77labs);
            _addNewPerson.A17Network = Convert.ToInt16(805.425541 + -0.204985 * a8labs + 0.542749 * (_addNewPerson.A92Network) + -0.145211 * a77labs);
            _addNewPerson.A18Network = Convert.ToInt16(-14.190307 + 0.210480 * (_addNewPerson.A17Network) + 0.085129 * (_addNewPerson.A88Network) + -0.024064 * a77labs);
            _addNewPerson.A85Network = Convert.ToInt16(879.090985 + 0.436219 * a77labs + -1.330864 * a8labs + 0.497626 * (_addNewPerson.A92Network));
            _addNewPerson.A51Network = Convert.ToInt16(41.922760 + 0.246423 * (_addNewPerson.A17Network) + 0.108049 * a87labs + 0.086128 * a8labs);
            _addNewPerson.A52Network = Convert.ToInt16(9.475592 + 0.324613 * (_addNewPerson.A17Network) + 0.119083 * a87labs);
            _addNewPerson.A79Network = Convert.ToInt16(-90.180704 + 0.724535 * (_addNewPerson.A17Network) + -0.116226 * a8labs);
            _addNewPerson.A61Network = Convert.ToInt16(32.252850 + 0.361394 * (_addNewPerson.A79Network) + 0.073355 * (_addNewPerson.A2Network) + 0.116480 * (_addNewPerson.A51Network) + 0.023505 * (_addNewPerson.A85Network) + 0.263918 * a8labs);
            _addNewPerson.A80Network = Convert.ToInt16(22.863437 + 0.243427 * (_addNewPerson.A79Network) + -0.023422 * a87labs + 0.009082 * a77labs);
            _addNewPerson.A25Network = Convert.ToInt16(1142.709110 + -0.365562 * a77labs + -1.030207 * (_addNewPerson.A80Network) + 0.734066 * (_addNewPerson.A92Network));
            _addNewPerson.A26Network = Convert.ToInt16(-40.612259 + 0.235021 * (_addNewPerson.A25Network) + 0.061500 * a8labs + 0.035386 * (_addNewPerson.A88Network));
            _addNewPerson.A12Network = Convert.ToInt16(448.292036 + -0.073358 * a77labs - 0.084685 * (_addNewPerson.A51Network) + 0.230279 * (_addNewPerson.A92Network));
            _addNewPerson.A69Network = Convert.ToInt16(111.118526 + 0.417027 * a8labs + 1.740003 * (_addNewPerson.A12Network) + 0.074913 * a77labs + -0.051462 * (_addNewPerson.A89Network));
            _addNewPerson.A9Network = Convert.ToInt16(-59.820927 + 0.187514 * a8labs + -0.067350 * (_addNewPerson.A92Network) + 0.314832 * (_addNewPerson.A69Network) + 0.086447 * a77labs);
            _addNewPerson.A10Network = Convert.ToInt16(286.460314 + 0.191893 * (_addNewPerson.A92Network) + 0.124425 * (_addNewPerson.A9Network) + 0.297139 * (_addNewPerson.A80Network) + -0.137483 * a77labs);
            _addNewPerson.A39Network = Convert.ToInt16(28.617843 + 0.016631 * a77labs + 0.479472 * (_addNewPerson.A10Network) + 0.109615 * (_addNewPerson.A80Network) + 0.071278 * (_addNewPerson.A9Network) + 0.181101 * a8labs);



            _addNewPerson.A37Network = Convert.ToInt16(13.482970 + 0.990611 * a8labs + 0.039571 * a77labs + 0.002011 * (_addNewPerson.A92Network));
            _addNewPerson.A49Network = Convert.ToInt16(90.595603 + 0.048060 * (_addNewPerson.A92Network) + 0.013820 * a77labs + 0.707626 * (_addNewPerson.A37Network));
            _addNewPerson.A75Network = Convert.ToInt16(70.655228 + 0.577853 * (_addNewPerson.A49Network) + 1.233067 * a8labs + 0.951696 * a77labs + -0.220091 * a87labs);
            _addNewPerson.A41Network = Convert.ToInt16(11.890962 + 0.508491 * a8labs + 0.018879 * a77labs + 0.214251 * (_addNewPerson.A75Network) + -0.119549 * (_addNewPerson.A9Network));
            _addNewPerson.A45Network = Convert.ToInt16(11.202810 + 0.130049 * a8labs + -0.008431 * a77labs + 0.335489 * (_addNewPerson.A41Network) + 0.016759 * (_addNewPerson.A9Network));
            _addNewPerson.A38Network = Convert.ToInt16(-7.192767 + 0.019299 * a77labs + 0.683946 * (_addNewPerson.A41Network));
            _addNewPerson.A42Network = Convert.ToInt16(43.309529 + 0.564194 * a77labs + 0.049679 * (_addNewPerson.A92Network) + 0.484597 * (_addNewPerson.A41Network));
            _addNewPerson.A20Network = Convert.ToInt16(88.881541 + 0.232427 * (_addNewPerson.A41Network) + 0.324270 * (_addNewPerson.A78Network) + 0.063209 * (_addNewPerson.A92Network));
            _addNewPerson.A21Network = Convert.ToInt16(-34.049338 + -0.037546 * (_addNewPerson.A41Network) + 0.737022 * (_addNewPerson.A20Network) + 0.088839 * (_addNewPerson.A78Network));

            _addNewPerson.A73Network = Convert.ToInt16(157.939760 + 0.068549 * (_addNewPerson.A92Network) + 0.281376 * (_addNewPerson.A75Network) + 0.142154 * a8labs + 0.125155 * (_addNewPerson.A78Network));

            _addNewPerson.karakuvvet = 0;
            _addNewPerson.denizkuvvet = 0;
            _addNewPerson.havakuvvet = 0;
            _addNewPerson.karatotalchest = 0;
            _addNewPerson.havatotalchest = 0;
            _addNewPerson.deniztotalchest = 0;
            _addNewPerson.kara_xs_chest = 0;
            _addNewPerson.kara_s_chest = 0;
            _addNewPerson.kara_m_chest = 0;
            _addNewPerson.kara_l_chest = 0;
            _addNewPerson.kara_xl_chest = 0;
            _addNewPerson.kara_2xl_chest = 0;
            _addNewPerson.hava_xs_chest = 0;
            _addNewPerson.hava_s_chest = 0;
            _addNewPerson.hava_m_chest = 0;
            _addNewPerson.hava_l_chest = 0;
            _addNewPerson.hava_2l_chest = 0;
            _addNewPerson.hava_xxl_chest = 0;
            _addNewPerson.deniz_xs_chest = 0;
            _addNewPerson.deniz_s_chest = 0;
            _addNewPerson.deniz_m_chest = 0;
            _addNewPerson.deniz_l_chest = 0;
            _addNewPerson.deniz_xl_chest = 0;
            _addNewPerson.deniz_2xl_chest = 0;
            _addNewPerson.karatotalbot = 0;
            _addNewPerson.havatotalbot = 0;
            _addNewPerson.deniztotalbot = 0;
            _addNewPerson.kara_34_bot = 0;
            _addNewPerson.kara_35_bot = 0;
            _addNewPerson.kara_36_bot = 0;
            _addNewPerson.kara_37_bot = 0;
            _addNewPerson.kara_38_bot = 0;
            _addNewPerson.kara_39_bot = 0;
            _addNewPerson.kara_40_bot = 0;
            _addNewPerson.kara_41_bot = 0;
            _addNewPerson.kara_42_bot = 0;
            _addNewPerson.kara_43_bot = 0;
            _addNewPerson.kara_44_bot = 0;
            _addNewPerson.kara_45_bot = 0;
            _addNewPerson.kara_46_bot = 0;
            _addNewPerson.kara_47_bot = 0;
            _addNewPerson.kara_48_bot = 0;
            _addNewPerson.hava_34_bot = 0;
            _addNewPerson.hava_35_bot = 0;
            _addNewPerson.hava_36_bot = 0;
            _addNewPerson.hava_37_bot = 0;
            _addNewPerson.hava_38_bot = 0;
            _addNewPerson.hava_39_bot = 0;
            _addNewPerson.hava_40_bot = 0;
            _addNewPerson.hava_41_bot = 0;
            _addNewPerson.hava_42_bot = 0;
            _addNewPerson.hava_43_bot = 0;
            _addNewPerson.hava_44_bot = 0;
            _addNewPerson.hava_45_bot = 0;
            _addNewPerson.hava_46_bot = 0;
            _addNewPerson.hava_47_bot = 0;
            _addNewPerson.hava_48_bot = 0;
            _addNewPerson.deniz_34_bot = 0;
            _addNewPerson.deniz_35_bot = 0;
            _addNewPerson.deniz_36_bot = 0;
            _addNewPerson.deniz_37_bot = 0;
            _addNewPerson.deniz_38_bot = 0;
            _addNewPerson.deniz_39_bot = 0;
            _addNewPerson.deniz_40_bot = 0;
            _addNewPerson.deniz_41_bot = 0;
            _addNewPerson.deniz_42_bot = 0;
            _addNewPerson.deniz_43_bot = 0;
            _addNewPerson.deniz_44_bot = 0;
            _addNewPerson.deniz_45_bot = 0;
            _addNewPerson.deniz_46_bot = 0;
            _addNewPerson.deniz_47_bot = 0;
            _addNewPerson.deniz_48_bot = 0;
            _addNewPerson.karatotalpant = 0;
            _addNewPerson.havatotalpant = 0;
            _addNewPerson.deniztotalpant = 0;
            _addNewPerson.kara_xs_pant = 0;
            _addNewPerson.kara_s_pant = 0;
            _addNewPerson.kara_m_pant = 0;
            _addNewPerson.kara_l_pant = 0;
            _addNewPerson.kara_xl_pant = 0;
            _addNewPerson.kara_2xl_pant = 0;
            _addNewPerson.kara_3xl_pant = 0;
            _addNewPerson.kara_bxl_pant = 0;
            _addNewPerson.hava_xs_pant = 0;
            _addNewPerson.hava_s_pant = 0;
            _addNewPerson.hava_m_pant = 0;
            _addNewPerson.hava_l_pant = 0;
            _addNewPerson.hava_xl_pant = 0;
            _addNewPerson.hava_2xl_pant = 0;
            _addNewPerson.hava_3xl_pant = 0;
            _addNewPerson.hava_bxl_pant = 0;
            _addNewPerson.deniz_xs_pant = 0;
            _addNewPerson.deniz_s_pant = 0;
            _addNewPerson.deniz_m_pant = 0;
            _addNewPerson.deniz_l_pant = 0;
            _addNewPerson.deniz_xl_pant = 0;
            _addNewPerson.deniz_2xl_pant = 0;
            _addNewPerson.deniz_3xl_pant = 0;
            _addNewPerson.deniz_bxl_pant = 0;
            _addNewPerson.karatotalhands = 0;
            _addNewPerson.havatotalhands = 0;
            _addNewPerson.deniztotalhands = 0;
            _addNewPerson.kara_xs_hands = 0;
            _addNewPerson.kara_s_hands = 0;
            _addNewPerson.kara_m_hands = 0;
            _addNewPerson.kara_l_hands = 0;
            _addNewPerson.kara_xl_hands = 0;
            _addNewPerson.kara_2xl_hands = 0;
            _addNewPerson.hava_xs_hands = 0;
            _addNewPerson.hava_s_hands = 0;
            _addNewPerson.hava_m_hands = 0;
            _addNewPerson.hava_l_hands = 0;
            _addNewPerson.hava_xl_hands = 0;
            _addNewPerson.hava_2xl_hands = 0;
            _addNewPerson.deniz_xs_hands = 0;
            _addNewPerson.deniz_s_hands = 0;
            _addNewPerson.deniz_m_hands = 0;
            _addNewPerson.deniz_l_hands = 0;
            _addNewPerson.deniz_xl_hands = 0;
            _addNewPerson.deniz_2xl_hands = 0;
            _addNewPerson.kara_140_150_boy = 0;
            _addNewPerson.kara_150_160_boy = 0;
            _addNewPerson.kara_160_170_boy = 0;
            _addNewPerson.kara_170_180_boy = 0;
            _addNewPerson.kara_180_190_boy = 0;
            _addNewPerson.kara_190_200_boy = 0;
            _addNewPerson.kara_200_210_boy = 0;
            _addNewPerson.kara_210_220_boy = 0;
            _addNewPerson.kara_220_230_boy = 0;
            _addNewPerson.hava_140_150_boy = 0;
            _addNewPerson.hava_150_160_boy = 0;
            _addNewPerson.hava_160_170_boy = 0;
            _addNewPerson.hava_170_180_boy = 0;
            _addNewPerson.hava_180_190_boy = 0;
            _addNewPerson.hava_190_200_boy = 0;
            _addNewPerson.hava_200_210_boy = 0;
            _addNewPerson.hava_210_220_boy = 0;
            _addNewPerson.hava_220_230_boy = 0;
            _addNewPerson.deniz_140_150_boy = 0;
            _addNewPerson.deniz_150_160_boy = 0;
            _addNewPerson.deniz_160_170_boy = 0;
            _addNewPerson.deniz_170_180_boy = 0;
            _addNewPerson.deniz_180_190_boy = 0;
            _addNewPerson.deniz_190_200_boy = 0;
            _addNewPerson.deniz_200_210_boy = 0;
            _addNewPerson.deniz_210_220_boy = 0;
            _addNewPerson.deniz_220_230_boy = 0;
            _addNewPerson.kara_140alti_uyluk = 0;
            _addNewPerson.kara_140_180_uyluk = 0;
            _addNewPerson.kara_180_220_uyluk = 0;
            _addNewPerson.kara_220_260_uyluk = 0;
            _addNewPerson.kara_260ustu_uyluk = 0;
            _addNewPerson.hava_140alti_uyluk = 0;
            _addNewPerson.hava_140_180_uyluk = 0;
            _addNewPerson.hava_180_220_uyluk = 0;
            _addNewPerson.hava_220_260_uyluk = 0;
            _addNewPerson.hava_260ustu_uyluk = 0;
            _addNewPerson.deniz_140alti_uyluk = 0;
            _addNewPerson.deniz_140_180_uyluk = 0;
            _addNewPerson.deniz_180_220_uyluk = 0;
            _addNewPerson.deniz_220_260_uyluk = 0;
            _addNewPerson.deniz_260ustu_uyluk = 0;

            Random birlikkura = new Random();
            int birlikrollvalue = birlikkura.Next(1, 210);

            txtFuzzyOptionChest.Text = _addNewPerson.A25Trium + "," + _addNewPerson.A88Trium;
            ChestConfig();
            FuzzyCalculatorChest();

            _addNewPerson.UstGiyimEbat = AnalyzeUstGiyimEbat;

            if (birlikrollvalue > 0 && birlikrollvalue < 71)
            {
                if (AnalyzeUstGiyimEbat == "XSmall")
                {
                    _addNewPerson.kara_xs_chest = 1;

                }
                else if (AnalyzeUstGiyimEbat == "Small")
                {
                    _addNewPerson.kara_s_chest = 1;

                }
                else if (AnalyzeUstGiyimEbat == "Medium")
                {
                    _addNewPerson.kara_m_chest = 1;

                }
                else if (AnalyzeUstGiyimEbat == "Large")
                {
                    _addNewPerson.kara_l_chest = 1;

                }
                else if (AnalyzeUstGiyimEbat == "XLarge")
                {
                    _addNewPerson.kara_xl_chest = 1;

                }
                else if (AnalyzeUstGiyimEbat == "XXLarge")
                {
                    _addNewPerson.kara_2xl_chest = 1;
                }

            }
            else if (birlikrollvalue > 71 && birlikrollvalue < 141)
            {
                if (AnalyzeUstGiyimEbat == "XSmall")
                {
                    _addNewPerson.hava_xs_chest = 1;

                }
                else if (AnalyzeUstGiyimEbat == "Small")
                {
                    _addNewPerson.hava_s_chest = 1;

                }
                else if (AnalyzeUstGiyimEbat == "Medium")
                {
                    _addNewPerson.hava_m_chest = 1;

                }
                else if (AnalyzeUstGiyimEbat == "Large")
                {
                    _addNewPerson.hava_l_chest = 1;

                }
                else if (AnalyzeUstGiyimEbat == "XLarge")
                {
                    _addNewPerson.hava_2l_chest = 1;

                }
                else if (AnalyzeUstGiyimEbat == "XXLarge")
                {
                    _addNewPerson.hava_xxl_chest = 1;
                }

            }
            else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
            {
                if (AnalyzeUstGiyimEbat == "XSmall")
                {
                    _addNewPerson.deniz_xs_chest = 1;

                }
                else if (AnalyzeUstGiyimEbat == "Small")
                {
                    _addNewPerson.deniz_s_chest = 1;

                }
                else if (AnalyzeUstGiyimEbat == "Medium")
                {
                    _addNewPerson.deniz_m_chest = 1;

                }
                else if (AnalyzeUstGiyimEbat == "Large")
                {
                    _addNewPerson.deniz_l_chest = 1;

                }
                else if (AnalyzeUstGiyimEbat == "XLarge")
                {
                    _addNewPerson.deniz_xl_chest = 1;

                }
                else if (AnalyzeUstGiyimEbat == "XXLarge")
                {
                    _addNewPerson.deniz_2xl_chest = 1;
                }

            }














            txtFuzzyOptionBMI.Text = _addNewPerson.A92Network + "," + _addNewPerson.A76Trium;
            BMIConfig();
            FuzzyCalculatorBMI();
            _addNewPerson.BMIndex = AnalyzeBMIndex;

            if (_addNewPerson.A37Trium > 0)
            {
                if (_addNewPerson.A37Trium < 220)
                {
                    _addNewPerson.BotEbat = "34 Numara";

                    if (birlikrollvalue > 0 && birlikrollvalue < 71)
                    {
                        _addNewPerson.kara_34_bot = 1;
                    }
                    else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                    {
                        _addNewPerson.hava_34_bot = 1;

                    }
                    else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                    {
                        _addNewPerson.deniz_34_bot = 1;

                    }
                }
                else if (_addNewPerson.A37Trium >= 220 && _addNewPerson.A37Trium < 227)
                {
                    _addNewPerson.BotEbat = "35 Numara";

                    if (birlikrollvalue > 0 && birlikrollvalue < 71)
                    {
                        _addNewPerson.kara_35_bot = 1;
                    }
                    else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                    {
                        _addNewPerson.hava_35_bot = 1;

                    }
                    else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                    {
                        _addNewPerson.deniz_35_bot = 1;

                    }
                }
                else if (_addNewPerson.A37Trium >= 227 && _addNewPerson.A37Trium < 233)
                {
                    _addNewPerson.BotEbat = "36 Numara";

                    if (birlikrollvalue > 0 && birlikrollvalue < 71)
                    {
                        _addNewPerson.kara_36_bot = 1;
                    }
                    else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                    {
                        _addNewPerson.hava_36_bot = 1;

                    }
                    else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                    {
                        _addNewPerson.deniz_36_bot = 1;

                    }
                }
                else if (_addNewPerson.A37Trium >= 233 && _addNewPerson.A37Trium < 240)
                {
                    _addNewPerson.BotEbat = "37 Numara";

                    if (birlikrollvalue > 0 && birlikrollvalue < 71)
                    {
                        _addNewPerson.kara_37_bot = 1;
                    }
                    else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                    {
                        _addNewPerson.hava_37_bot = 1;

                    }
                    else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                    {
                        _addNewPerson.deniz_37_bot = 1;

                    }
                }
                else if (_addNewPerson.A37Trium >= 240 && _addNewPerson.A37Trium < 247)
                {
                    _addNewPerson.BotEbat = "38 Numara";

                    if (birlikrollvalue > 0 && birlikrollvalue < 71)
                    {
                        _addNewPerson.kara_38_bot = 1;
                    }
                    else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                    {
                        _addNewPerson.hava_38_bot = 1;

                    }
                    else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                    {
                        _addNewPerson.deniz_38_bot = 1;

                    }
                }
                else if (_addNewPerson.A37Trium >= 247 && _addNewPerson.A37Trium < 253)
                {
                    _addNewPerson.BotEbat = "39 Numara";

                    if (birlikrollvalue > 0 && birlikrollvalue < 71)
                    {
                        _addNewPerson.kara_39_bot = 1;

                    }
                    else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                    {
                        _addNewPerson.hava_39_bot = 1;


                    }
                    else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                    {
                        _addNewPerson.deniz_39_bot = 1;

                    }
                }
                else if (_addNewPerson.A37Trium >= 253 && _addNewPerson.A37Trium < 260)
                {
                    _addNewPerson.BotEbat = "40 Numara";

                    if (birlikrollvalue > 0 && birlikrollvalue < 71)
                    {
                        _addNewPerson.kara_40_bot = 1;

                    }
                    else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                    {
                        _addNewPerson.hava_40_bot = 1;

                    }
                    else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                    {
                        _addNewPerson.deniz_40_bot = 1;

                    }
                }
                else if (_addNewPerson.A37Trium >= 260 && _addNewPerson.A37Trium < 267)
                {
                    _addNewPerson.BotEbat = "41 Numara";

                    if (birlikrollvalue > 0 && birlikrollvalue < 71)
                    {
                        _addNewPerson.kara_41_bot = 1;

                    }
                    else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                    {
                        _addNewPerson.hava_41_bot = 1;

                    }
                    else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                    {
                        _addNewPerson.deniz_41_bot = 1;

                    }
                }
                else if (_addNewPerson.A37Trium >= 267 && _addNewPerson.A37Trium < 273)
                {
                    _addNewPerson.BotEbat = "42 Numara";

                    if (birlikrollvalue > 0 && birlikrollvalue < 71)
                    {
                        _addNewPerson.kara_42_bot = 1;

                    }
                    else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                    {
                        _addNewPerson.hava_42_bot = 1;

                    }
                    else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                    {
                        _addNewPerson.deniz_42_bot = 1;

                    }
                }
                else if (_addNewPerson.A37Trium >= 273 && _addNewPerson.A37Trium < 280)
                {
                    _addNewPerson.BotEbat = "43 Numara";

                    if (birlikrollvalue > 0 && birlikrollvalue < 71)
                    {
                        _addNewPerson.kara_43_bot = 1;

                    }
                    else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                    {
                        _addNewPerson.hava_43_bot = 1;

                    }
                    else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                    {
                        _addNewPerson.deniz_43_bot = 1;

                    }
                }
                else if (_addNewPerson.A37Trium >= 280 && _addNewPerson.A37Trium < 287)
                {
                    _addNewPerson.BotEbat = "44 Numara";

                    if (birlikrollvalue > 0 && birlikrollvalue < 71)
                    {
                        _addNewPerson.kara_44_bot = 1;

                    }
                    else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                    {
                        _addNewPerson.hava_44_bot = 1;

                    }
                    else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                    {
                        _addNewPerson.deniz_44_bot = 1;

                    }
                }
                else if (_addNewPerson.A37Trium >= 287 && _addNewPerson.A37Trium < 293)
                {
                    _addNewPerson.BotEbat = "45 Numara";

                    if (birlikrollvalue > 0 && birlikrollvalue < 71)
                    {
                        _addNewPerson.kara_45_bot = 1;

                    }
                    else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                    {
                        _addNewPerson.hava_45_bot = 1;

                    }
                    else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                    {
                        _addNewPerson.deniz_45_bot = 1;

                    }
                }
                else if (_addNewPerson.A37Trium >= 293 && _addNewPerson.A37Trium < 300)
                {
                    _addNewPerson.BotEbat = "46 Numara";

                    if (birlikrollvalue > 0 && birlikrollvalue < 71)
                    {
                        _addNewPerson.kara_46_bot = 1;

                    }
                    else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                    {
                        _addNewPerson.hava_46_bot = 1;

                    }
                    else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                    {
                        _addNewPerson.deniz_46_bot = 1;

                    }
                }
                else if (_addNewPerson.A37Trium >= 300 && _addNewPerson.A37Trium < 312)
                {
                    _addNewPerson.BotEbat = "47 Numara";

                    if (birlikrollvalue > 0 && birlikrollvalue < 71)
                    {
                        _addNewPerson.kara_47_bot = 1;

                    }
                    else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                    {
                        _addNewPerson.hava_47_bot = 1;

                    }
                    else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                    {
                        _addNewPerson.deniz_47_bot = 1;

                    }
                }
                else if (_addNewPerson.A37Trium >= 312)
                {
                    _addNewPerson.BotEbat = "48 Numara";

                    if (birlikrollvalue > 0 && birlikrollvalue < 71)
                    {
                        _addNewPerson.kara_48_bot = 1;
                    }
                    else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                    {
                        _addNewPerson.hava_48_bot = 1;
                    }
                    else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                    {
                        _addNewPerson.deniz_48_bot = 1;
                    }
                }

            }
            else
            {
                _addNewPerson.BotEbat = "BELIRSIZ";
            }


            if (Convert.ToDouble(_addNewPerson.A88Trium) / Convert.ToDouble(_addNewPerson.A17Trium) > 0)
            {
                if (Convert.ToDouble(_addNewPerson.A88Trium) / Convert.ToDouble(_addNewPerson.A17Trium) < 0.85)
                {
                    _addNewPerson.BKoran = "X<85";
                }
                else if (Convert.ToDouble(_addNewPerson.A88Trium) / Convert.ToDouble(_addNewPerson.A17Trium) < 0.90 && Convert.ToDouble(_addNewPerson.A88Trium) / Convert.ToDouble(_addNewPerson.A17Trium) > 0.85)
                {
                    _addNewPerson.BKoran = "85<X<90";
                }
                else if (Convert.ToDouble(_addNewPerson.A88Trium) / Convert.ToDouble(_addNewPerson.A17Trium) >= 0.90 && Convert.ToDouble(_addNewPerson.A88Trium) / Convert.ToDouble(_addNewPerson.A17Trium) < 0.95)
                {
                    _addNewPerson.BKoran = "90<X<95";
                }
                else if (Convert.ToDouble(_addNewPerson.A88Trium) / Convert.ToDouble(_addNewPerson.A17Trium) > 0.95 && Convert.ToDouble(_addNewPerson.A88Trium) / Convert.ToDouble(_addNewPerson.A17Trium) < 1)
                {
                    _addNewPerson.BKoran = "95<X<100";
                }
                else if (Convert.ToDouble(_addNewPerson.A88Trium) / Convert.ToDouble(_addNewPerson.A17Trium) >= 1)
                {
                    _addNewPerson.BKoran = "X>100";
                }
            }
            else
            {
                _addNewPerson.BKoran = "BELIRSIZZ";
            }


            if (_addNewPerson.A88Trium < 690)
            {
                _addNewPerson.PantolonEbat = "XSmall";

                if (birlikrollvalue > 0 && birlikrollvalue < 71)
                {
                    _addNewPerson.kara_xs_pant = 1;

                }
                else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                {
                    _addNewPerson.hava_xs_pant = 1;


                }
                else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                {
                    _addNewPerson.deniz_xs_pant = 1;


                }
            }
            else if (_addNewPerson.A88Trium >= 690 && _addNewPerson.A88Trium < 780)
            {
                _addNewPerson.PantolonEbat = "Small";
                if (birlikrollvalue > 0 && birlikrollvalue < 71)
                {
                    _addNewPerson.kara_s_pant = 1;

                }
                else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                {
                    _addNewPerson.hava_s_pant = 1;


                }
                else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                {
                    _addNewPerson.deniz_s_pant = 1;


                }
            }
            else if (_addNewPerson.A88Trium >= 780 && _addNewPerson.A88Trium < 870)
            {
                _addNewPerson.PantolonEbat = "Medium";
                if (birlikrollvalue > 0 && birlikrollvalue < 71)
                {
                    _addNewPerson.kara_m_pant = 1;

                }
                else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                {
                    _addNewPerson.hava_m_pant = 1;


                }
                else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                {
                    _addNewPerson.deniz_m_pant = 1;



                }
            }
            else if (_addNewPerson.A88Trium >= 870 && _addNewPerson.A88Trium < 1000)
            {
                _addNewPerson.PantolonEbat = "Large";

                if (birlikrollvalue > 0 && birlikrollvalue < 71)
                {
                    _addNewPerson.kara_l_pant = 1;


                }
                else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                {
                    _addNewPerson.hava_l_pant = 1;


                }
                else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                {
                    _addNewPerson.deniz_l_pant = 1;


                }
            }
            else if (_addNewPerson.A88Trium >= 1000 && _addNewPerson.A88Trium < 1050)
            {
                _addNewPerson.PantolonEbat = "XLarge";

                if (birlikrollvalue > 0 && birlikrollvalue < 71)
                {
                    _addNewPerson.kara_xl_pant = 1;


                }
                else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                {
                    _addNewPerson.hava_xl_pant = 1;


                }
                else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                {
                    _addNewPerson.deniz_xl_pant = 1;


                }
            }
            else if (_addNewPerson.A88Trium >= 1050 && _addNewPerson.A88Trium < 1150)
            {
                _addNewPerson.PantolonEbat = "2XLarge";

                if (birlikrollvalue > 0 && birlikrollvalue < 71)
                {
                    _addNewPerson.kara_2xl_pant = 1;
                }
                else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                {
                    _addNewPerson.hava_2xl_pant = 1;


                }
                else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                {
                    _addNewPerson.deniz_2xl_pant = 1;


                }
            }
            else if (_addNewPerson.A88Trium >= 1150 && _addNewPerson.A88Trium < 1300)
            {
                _addNewPerson.PantolonEbat = "3XLarge";

                if (birlikrollvalue > 0 && birlikrollvalue < 71)
                {
                    _addNewPerson.kara_3xl_pant = 1;
                }
                else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                {

                    _addNewPerson.hava_3xl_pant = 1;

                }
                else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                {
                    _addNewPerson.deniz_3xl_pant = 1;


                }
            }
            else if (_addNewPerson.A88Trium >= 1300)
            {
                _addNewPerson.PantolonEbat = "BXLarge";

                if (birlikrollvalue > 0 && birlikrollvalue < 71)
                {
                    _addNewPerson.kara_bxl_pant = 1;
                }
                else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                {
                    _addNewPerson.hava_bxl_pant = 1;

                }
                else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                {
                    _addNewPerson.deniz_bxl_pant = 1;

                }
            }


            if (_addNewPerson.A45Network <= 180)
            {
                _addNewPerson.EldivenEbat = "XSmall";

                if (birlikrollvalue > 0 && birlikrollvalue < 71)
                {
                    _addNewPerson.kara_xs_hands = 1;

                }
                else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                {
                    _addNewPerson.hava_xs_hands = 1;


                }
                else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                {

                    _addNewPerson.deniz_xs_hands = 1;

                }
            }
            else if (_addNewPerson.A45Network >= 180 && _addNewPerson.A45Network < 190)
            {
                _addNewPerson.EldivenEbat = "Small";

                if (birlikrollvalue > 0 && birlikrollvalue < 71)
                {
                    _addNewPerson.kara_s_hands = 1;

                }
                else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                {
                    _addNewPerson.hava_s_hands = 1;


                }
                else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                {
                    _addNewPerson.deniz_s_hands = 1;


                }
            }
            else if (_addNewPerson.A45Network >= 190 && _addNewPerson.A45Network < 230)
            {
                _addNewPerson.EldivenEbat = "Medium";

                if (birlikrollvalue > 0 && birlikrollvalue < 71)
                {
                    _addNewPerson.kara_m_hands = 1;

                }
                else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                {
                    _addNewPerson.hava_m_hands = 1;


                }
                else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                {
                    _addNewPerson.deniz_m_hands = 1;


                }
            }
            else if (_addNewPerson.A45Network >= 230 && _addNewPerson.A45Network < 250)
            {
                _addNewPerson.EldivenEbat = "Large";

                if (birlikrollvalue > 0 && birlikrollvalue < 71)
                {
                    _addNewPerson.kara_l_hands = 1;

                }
                else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                {
                    _addNewPerson.hava_l_hands = 1;


                }
                else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                {
                    _addNewPerson.deniz_l_hands = 1;


                }
            }
            else if (_addNewPerson.A45Network >= 250 && _addNewPerson.A45Network < 280)
            {
                _addNewPerson.EldivenEbat = "XLarge";

                if (birlikrollvalue > 0 && birlikrollvalue < 71)
                {
                    _addNewPerson.kara_xl_hands = 1;

                }
                else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                {
                    _addNewPerson.hava_xl_hands = 1;


                }
                else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                {
                    _addNewPerson.deniz_xl_hands = 1;


                }
            }
            else if (_addNewPerson.A45Network >= 280)
            {
                _addNewPerson.EldivenEbat = "XXLarge";

                if (birlikrollvalue > 0 && birlikrollvalue < 71)
                {
                    _addNewPerson.kara_2xl_hands = 1;
                }
                else if (birlikrollvalue > 71 && birlikrollvalue < 141)
                {
                    _addNewPerson.hava_2xl_hands = 1;

                }
                else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
                {
                    _addNewPerson.deniz_2xl_hands = 1;

                }
            }

            if (_donem < 1)
            {
                _donem++;
            }
            _addNewPerson.totalsoldier = 1;



            if (birlikrollvalue > 0 && birlikrollvalue < 71)
            {
                _addNewPerson.Birlik = "KaraKuvvetleri";
                _addNewPerson.karakuvvet = 1;
                _addNewPerson.karatotalchest = 1;
                _addNewPerson.karatotalbot = 1;
                _addNewPerson.karatotalhands = 1;
                _addNewPerson.karatotalpant = 1;

                if (_addNewPerson.A76Network <= 1500)
                {
                    _addNewPerson.kara_140_150_boy = 1;

                }
                else if (_addNewPerson.A76Network > 1500 && _addNewPerson.A76Network <= 1600)
                {
                    _addNewPerson.kara_150_160_boy = 1;

                }
                else if (_addNewPerson.A76Network > 1600 && _addNewPerson.A76Network <= 1700)
                {
                    _addNewPerson.kara_160_170_boy = 1;

                }
                else if (_addNewPerson.A76Network > 1700 && _addNewPerson.A76Network <= 1800)
                {
                    _addNewPerson.kara_170_180_boy = 1;

                }
                else if (_addNewPerson.A76Network > 1800 && _addNewPerson.A76Network <= 1900)
                {
                    _addNewPerson.kara_180_190_boy = 1;

                }
                else if (_addNewPerson.A76Network > 1900 && _addNewPerson.A76Network <= 2000)
                {
                    _addNewPerson.kara_190_200_boy = 1;

                }
                else if (_addNewPerson.A76Network > 2000 && _addNewPerson.A76Network <= 2100)
                {
                    _addNewPerson.kara_200_210_boy = 1;

                }
                else if (_addNewPerson.A76Network > 2100 && _addNewPerson.A76Network <= 2200)
                {
                    _addNewPerson.kara_210_220_boy = 1;

                }
                else if (_addNewPerson.A76Network >= 2200)
                {
                    _addNewPerson.kara_220_230_boy = 1;
                }

            }
            else if (birlikrollvalue > 71 && birlikrollvalue < 141)
            {
                _addNewPerson.Birlik = "HavaKuvvetleri";
                _addNewPerson.havakuvvet = 1;
                _addNewPerson.havatotalchest = 1;
                _addNewPerson.havatotalbot = 1;
                _addNewPerson.havatotalhands = 1;
                _addNewPerson.havatotalpant = 1;

                if (_addNewPerson.A76Network <= 1500)
                {
                    _addNewPerson.hava_140_150_boy = 1;

                }
                else if (_addNewPerson.A76Network > 1500 && _addNewPerson.A76Network <= 1600)
                {
                    _addNewPerson.hava_150_160_boy = 1;

                }
                else if (_addNewPerson.A76Network > 1600 && _addNewPerson.A76Network <= 1700)
                {
                    _addNewPerson.hava_160_170_boy = 1;

                }
                else if (_addNewPerson.A76Network > 1700 && _addNewPerson.A76Network <= 1800)
                {
                    _addNewPerson.hava_170_180_boy = 1;


                }
                else if (_addNewPerson.A76Network > 1800 && _addNewPerson.A76Network <= 1900)
                {
                    _addNewPerson.hava_180_190_boy = 1;

                }
                else if (_addNewPerson.A76Network > 1900 && _addNewPerson.A76Network <= 2000)
                {
                    _addNewPerson.hava_190_200_boy = 1;

                }
                else if (_addNewPerson.A76Network > 2000 && _addNewPerson.A76Network <= 2100)
                {
                    _addNewPerson.hava_200_210_boy = 1;

                }
                else if (_addNewPerson.A76Network > 2100 && _addNewPerson.A76Network <= 2200)
                {
                    _addNewPerson.hava_210_220_boy = 1;

                }
                else if (_addNewPerson.A76Network >= 2200)
                {
                    _addNewPerson.hava_220_230_boy = 1;
                }

            }
            else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
            {
                _addNewPerson.Birlik = "DenizKuvvetleri";
                _addNewPerson.denizkuvvet = 1;
                _addNewPerson.deniztotalchest = 1;
                _addNewPerson.deniztotalbot = 1;
                _addNewPerson.deniztotalhands = 1;
                _addNewPerson.deniztotalpant = 1;

                if (_addNewPerson.A76Network <= 1500)
                {
                    _addNewPerson.deniz_140_150_boy = 1;

                }
                else if (_addNewPerson.A76Network > 1500 && _addNewPerson.A76Network <= 1600)
                {
                    _addNewPerson.deniz_150_160_boy = 1;

                }
                else if (_addNewPerson.A76Network > 1600 && _addNewPerson.A76Network <= 1700)
                {
                    _addNewPerson.deniz_160_170_boy = 1;

                }
                else if (_addNewPerson.A76Network > 1700 && _addNewPerson.A76Network <= 1800)
                {
                    _addNewPerson.deniz_170_180_boy = 1;

                }
                else if (_addNewPerson.A76Network > 1800 && _addNewPerson.A76Network <= 1900)
                {
                    _addNewPerson.deniz_180_190_boy = 1;

                }
                else if (_addNewPerson.A76Network > 1900 && _addNewPerson.A76Network <= 2000)
                {
                    _addNewPerson.deniz_190_200_boy = 1;

                }
                else if (_addNewPerson.A76Network > 2000 && _addNewPerson.A76Network <= 2100)
                {
                    _addNewPerson.deniz_200_210_boy = 1;

                }
                else if (_addNewPerson.A76Network > 2100 && _addNewPerson.A76Network <= 2200)
                {
                    _addNewPerson.deniz_210_220_boy = 1;

                }
                else if (_addNewPerson.A76Network >= 2200)
                {
                    _addNewPerson.deniz_220_230_boy = 1;
                }
            }




            if (birlikrollvalue > 0 && birlikrollvalue < 71)
            {

                if (_addNewPerson.A80Trium <= 150)
                {
                    _addNewPerson.kara_140alti_uyluk = 1;


                }
                else if (_addNewPerson.A80Trium > 150 && _addNewPerson.A80Trium <= 178)
                {
                    _addNewPerson.kara_140_180_uyluk = 1;


                }
                else if (_addNewPerson.A80Trium > 178 && _addNewPerson.A80Trium <= 220)
                {
                    _addNewPerson.kara_180_220_uyluk = 1;


                }
                else if (_addNewPerson.A80Trium > 220 && _addNewPerson.A80Trium <= 250)
                {

                    _addNewPerson.kara_220_260_uyluk = 1;

                }

                else if (_addNewPerson.A80Trium > 250)
                {
                    _addNewPerson.kara_260ustu_uyluk = 1;
                }
            }
            else if (birlikrollvalue > 71 && birlikrollvalue < 141)
            {
                if (_addNewPerson.A80Trium <= 150)
                {

                    _addNewPerson.hava_140alti_uyluk = 1;

                }
                else if (_addNewPerson.A80Trium > 150 && _addNewPerson.A80Trium <= 178)
                {
                    _addNewPerson.hava_140_180_uyluk = 1;


                }
                else if (_addNewPerson.A80Trium > 178 && _addNewPerson.A80Trium <= 220)
                {
                    _addNewPerson.hava_180_220_uyluk = 1;


                }
                else if (_addNewPerson.A80Trium > 220 && _addNewPerson.A80Trium <= 250)
                {
                    _addNewPerson.hava_220_260_uyluk = 1;


                }

                else if (_addNewPerson.A80Trium > 250)
                {
                    _addNewPerson.hava_260ustu_uyluk = 1;
                }

            }
            else if (birlikrollvalue > 140 && birlikrollvalue <= 210)
            {
                if (_addNewPerson.A80Trium <= 150)
                {
                    _addNewPerson.deniz_140alti_uyluk = 1;


                }
                else if (_addNewPerson.A80Trium > 150 && _addNewPerson.A80Trium <= 178)
                {
                    _addNewPerson.deniz_140_180_uyluk = 1;


                }
                else if (_addNewPerson.A80Trium > 178 && _addNewPerson.A80Trium <= 220)
                {
                    _addNewPerson.deniz_180_220_uyluk = 1;


                }
                else if (_addNewPerson.A80Trium > 220 && _addNewPerson.A80Trium <= 250)
                {
                    _addNewPerson.deniz_220_260_uyluk = 1;

                }

                else if (_addNewPerson.A80Trium > 250)
                {
                    _addNewPerson.deniz_260ustu_uyluk = 1;
                }

            }


            










             _addNewPerson.AddPerson(_addNewPerson);
            //Yukle();







        }
        private void button1_Click(object sender, EventArgs e)


        {
           

            for (int i = 0; i < 4000; i++)
            {
               
                double A77CLON = Convert.ToDouble(dtgLab.Rows[i].Cells[1].Value.ToString());
                double A87CLON = Convert.ToDouble(dtgLab.Rows[i].Cells[2].Value.ToString());
                double A8CLON = Convert.ToDouble(dtgLab.Rows[i].Cells[3].Value.ToString());
                double E101CLON = Convert.ToDouble(dtgLab.Rows[i].Cells[4].Value.ToString());
                double E102CLON = Convert.ToDouble(dtgLab.Rows[i].Cells[5].Value.ToString());
                double E103CLON = Convert.ToDouble(dtgLab.Rows[i].Cells[6].Value.ToString());

                LabCalculator(A77CLON, A87CLON, A8CLON, E101CLON, E102CLON, E103CLON);
            }
            MessageBox.Show("İŞLEM TAMAMLANDI");


        }
        private Label TextLabel(String Text, TextType type, String ToolTip)
        {
            Label Temp = new Label();
            Temp.Dock = DockStyle.Fill;
            Temp.Text = Text;

            ToolTip tip = new ToolTip();
            tip.IsBalloon = true;
            tip.Active = true;
            tip.ToolTipIcon = ToolTipIcon.Info;
            tip.UseAnimation = true;
            tip.UseFading = true;
            tip.SetToolTip(Temp, ToolTip);

            if (type == TextType.Header)
            {
                Temp.Font = new Font("Century Gothic", 15, FontStyle.Italic);
            }
            else if (type == TextType.Normal)
            {
                Temp.Font = new Font("Century Gothic", 15, FontStyle.Regular);
            }
            return Temp;
        }
        private Label TextLabel(String Text, TextType type)
        {
            Label Temp = new Label();
            Temp.Dock = DockStyle.Fill;
            Temp.Text = Text;
            if (type == TextType.Header)
            {
                Temp.Font = new Font("Century Gothic", 15, FontStyle.Italic);
            }
            else if (type == TextType.Normal)
            {
                Temp.Font = new Font("Century Gothic", 15, FontStyle.Regular);
            }
            return Temp;
        }
        private void FormAnalyzeData_Load(object sender, EventArgs e)
        {

            LabYukle();
        }
        private enum TextType
        {
            Header = 0, Normal = 1
        }
        private void FormAnalyzeData_Click(object sender, EventArgs e)
        {
            FormMainMenu.ActiveForm.WindowState = FormWindowState.Maximized;
        }
        private bool checkNodeNotRoot(TreeNode node)
        {
            return !(node.Text == "Inputs" || node.Text == "Outputs");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FormMainMenu.ActiveForm.WindowState = FormWindowState.Maximized;
            Random roll = new Random();
            int rollvalue = roll.Next(10, 3500);



            double A77CLON = Convert.ToDouble(dtgLab.Rows[rollvalue].Cells[1].Value.ToString());
            double A87CLON = Convert.ToDouble(dtgLab.Rows[rollvalue].Cells[2].Value.ToString());
            double A8CLON = Convert.ToDouble(dtgLab.Rows[rollvalue].Cells[3].Value.ToString());
            double E101CLON = Convert.ToDouble(dtgLab.Rows[rollvalue].Cells[4].Value.ToString());
            double E102CLON = Convert.ToDouble(dtgLab.Rows[rollvalue].Cells[5].Value.ToString());
            double E103CLON = Convert.ToDouble(dtgLab.Rows[rollvalue].Cells[6].Value.ToString());

            LabCalculator(A77CLON, A87CLON, A8CLON, E101CLON, E102CLON, E103CLON);





            ClearVariableChest();
            ClearVariableBMI();
            InputViewChest.Clear();
            OutputViewChest.Clear();
            InputViewBMI.Clear();
            OutputViewBMI.Clear();
            FuzzyLogic.FuzzyChestOption();
            if (FuzzyLogic.InputVariables.Count > 0)
            {
                this.Current = FuzzyLogic.InputVariables[0];

                populateVariablesChest();

            }
            loadRulesChestView();
            FuzzyLogic.FuzzyBMIndexOption();
            if (FuzzyLogic.InputVariablesBMI.Count > 0)
            {
                this.CurrentBMI = FuzzyLogic.InputVariablesBMI[0];


                populateVariablesBMI();
            }

            loadRulesBMIView();








        }
        //CHEST
        public void loadVariablesChest()
        {
            if (FuzzyLogic.InputVariables.Count > 0)
            {
                VarLabelChest.Text = FuzzyLogic.InputVariables[0].Name;



                for (int i = 1; i < FuzzyLogic.InputVariables.Count; i++)
                {
                    VarLabelChest.Text = VarLabelChest.Text + "," + FuzzyLogic.InputVariables[i].Name;
                }
            }
        }
        public void loadRulesChest()
        {
            List<FuzzyLogicController.RuleEngine.Rule> rules = FuzzyLogic.Rules;

        }
        public void FuzzyCalculatorChest()
        {

            clearChest();
            List<double> inputs = FuzzyLogic.tokString(txtFuzzyOptionChest.Text);
            CrispPanChest.RowCount = FuzzyLogic.InputVariables.Count;

            for (int i = 0; i < FuzzyLogic.InputVariables.Count; i++)
            {
                CrispPanChest.Controls.Add(TextLabel(FuzzyLogic.InputVariables[i].Name + " : " + inputs[i], TextType.Normal));
            }





            //Fuzzification
            List<FuzzySet> InSets = new List<FuzzySet>();
            for (int i = 0; i < FuzzyLogic.InputVariables.Count; i++)
            {
                InSets.Add(new FuzzySet(FuzzyLogic.FuzzyControl.Fuzzification(inputs[i], FuzzyLogic.InputVariables[i]), FuzzyLogic.InputVariables[i].Name));
            }

            for (int i = 0; i < InSets.Count; i++)
            {

                FuzzPanChest.Controls.Add(TextLabel(InSets[i].Variable, TextType.Normal));

                for (int j = 0; j < InSets[i].Set.Count; j++)
                {
                    FuzzPanChest.Controls.Add(TextLabel(InSets[i].Set[j].MemberShipName + ":" + InSets[i].Set[j].FuzzyValue.ToString(), TextType.Normal));
                }
            }

            //Inference Engine
            InferEngine engine = new InferEngine(FuzzyLogic.Configuration, FuzzyLogic.Rules, InSets);
            List<FuzzySet> RuleResults = engine.evaluateRules();

            EnginePanChest.Controls.Add(TextLabel("Tetiklenen Kurallar", TextType.Header));

            for (int i = 0; i < engine.FiredRules.Count; i++)
            {
                EnginePanChest.Controls.Add(TextLabel("Kural :" + engine.FiredRules[i].ToString(), TextType.Normal, FuzzyLogic.Rules[engine.FiredRules[i] - 1].ToString()));
            }

            for (int i = 0; i < RuleResults.Count; i++)
            {
                DeFuzzPanChest.Controls.Add(TextLabel(RuleResults[i].Variable, TextType.Header));
                for (int j = 0; j < RuleResults[i].Set.Count; j++)
                {
                    DeFuzzPanChest.Controls.Add(TextLabel(RuleResults[i].Set[j].MemberShipName + " : " + RuleResults[i].Set[j].FuzzyValue.ToString(), TextType.Normal));
                }
            }


            //deFuzzification
            List<double> CrispValues = new List<double>();
            for (int i = 0; i < FuzzyLogic.OutputVariables.Count; i++)
            {
                CrispValues.Add(FuzzyLogic.FuzzyControl.DeFuzzification(RuleResults, FuzzyLogic.OutputVariables[i]));
            }

            for (int i = 0; i < CrispValues.Count; i++)
            {
                solution2 = CrispValues[i];

                //  String text = FuzzyLogic.OutputVariables[i].Name  + " : " + CrispValues[i].ToString();

                String text = RuleResults[i].Set[i].MemberShipName;


                AnalyzeUstGiyimEbat = RuleResults[i].Set[i].MemberShipName;
                CrispViewChest.Items.Add(text);


            }

        }
        private void clearChest()
        {
            CrispPanChest.Controls.Clear();
            FuzzPanChest.Controls.Clear();
            DeFuzzPanChest.Controls.Clear();
            EnginePanChest.Controls.Clear();
            CrispViewChest.Clear();

        }
        private void ChestConfig()
        {

            loadRulesChest();
            FuzzyLogic.Initalize();
            FuzzyLogic.FuzzyChestOption();
            loadVariablesChest();
            // buraya loadrules eklersek forma if li şekilde kuralları yazdırabilriiz:)
        }
        public void ClearVariableChest()
        {
            MFViewChest.Clear();
            VarTxTChest.Text = "";
            RangeTxTChest.Text = "";
            Current = null;
        }
        private void InputView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InputViewChest.SelectedIndices.Count > 0)
            {
                int index = InputViewChest.SelectedIndices[0];
                ClearVariableChest();
                Current = FuzzyLogic.InputVariables[index];
                PopulateChest();
            }
        }
        private void OutputView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OutputViewChest.SelectedIndices.Count > 0)
            {
                int index = OutputViewChest.SelectedIndices[0];
                ClearVariableChest();
                Current = FuzzyLogic.OutputVariables[index];
                PopulateChest();
            }
        }
        public void PopulateChest()
        {
            VarTxTChest.Text = Current.Name;
            RangeTxTChest.Text = Current.Range[0] + ", " + Current.Range[1];

            if (Current.Type == VarType.Input) { TypeComboChest.SelectedIndex = 0; }
            else { TypeComboChest.SelectedIndex = 1; }

            if (Current.MFs.Count > 0)
            {
                for (int i = 0; i < Current.MFs.Count; i++)
                {
                    if (!MFViewChest.Items.ContainsKey(Current.MFs[i].Name))
                    {
                        MFViewChest.Items.Add(Current.MFs[i].Name, Current.MFs[i].Name, 1);
                    }
                }

            }
        }
        public void loadRulesChestView()
        {

            List<FuzzyLogicController.RuleEngine.Rule> rules = FuzzyLogic.Rules;

            RulePanChest.Controls.Clear();
            RulePanChest.RowCount = rules.Count;

            for (int i = 0; i < rules.Count; i++)
            {
                String rule = "IF ";
                for (int j = 0; j < rules[i].InputRules.Count; j++)
                {
                    rule = rule + rules[i].InputRules[j].Variable + " is " + rules[i].InputRules[j].MemberShipValue;
                    if (j != rules[i].InputRules.Count - 1)
                    {
                        rule = rule + " And ";
                    }
                }
                rule = rule + " Then ";
                for (int j = 0; j < rules[i].OutputRules.Count; j++)
                {
                    rule = rule + rules[i].OutputRules[j].Variable + " is " + rules[i].OutputRules[j].MemberShipValue;
                    if (j != rules[i].OutputRules.Count - 1)
                    {
                        rule = rule + " And ";
                    }
                }

                Label Temp = new Label();
                Temp.Text = rule;
                Temp.Name = FuzzyLogic.Rules.IndexOf(rules[i]).ToString();

                Temp.Font = new Font("Century Gothic", 13, FontStyle.Bold);
                Temp.Dock = DockStyle.Fill;
                RulePanChest.Controls.Add(Temp, 0, i);
            }
        }
        private void populateVariablesChest()   // SON KEZ BAK
        {
            for (int i = 0; i < FuzzyLogic.InputVariables.Count; i++)
            {
                if (InputViewChest.Items.ContainsKey(FuzzyLogic.InputVariables[i].Name) == false)
                {
                    InputViewChest.Items.Add(FuzzyLogic.InputVariables[i].Name, FuzzyLogic.InputVariables[i].Name, 1);
                }
            }

            for (int i = 0; i < FuzzyLogic.OutputVariables.Count; i++)
            {
                if (OutputViewChest.Items.ContainsKey(FuzzyLogic.OutputVariables[i].Name) == false)
                {
                    OutputViewChest.Items.Add(FuzzyLogic.OutputVariables[i].Name, FuzzyLogic.OutputVariables[i].Name, 1);
                }
            }
        }
        private void popualteMF(FuzzyLogicController.MFs.MemberShipFunction mf)
        {
            VarTxTChest.Text = mf.Name;
            txtFuzzyOptionChest.Text = mf.Params[0].ToString();
            for (int i = 1; i < mf.Params.Count; i++)
            {
                VarTxTChest.Text = VarTxTChest.Text + ", " + mf.Params[i];
            }
            if (mf is FuzzyLogicController.MFs.Trimf)
            {
                TypeComboChest.SelectedIndex = 0;
            }
            else if (mf is FuzzyLogicController.MFs.Trapmf)
            {
                TypeComboChest.SelectedIndex = 1;
            }
        }
        private void drawSelectedMF(object sender, PaintEventArgs e)
        {
            if (Current != null)
            {
                for (int i = 0; i < Current.MFs.Count; i++)
                {
                    if (MFViewChest.SelectedIndices.Count > 0 && i == MFViewChest.SelectedIndices[0])
                    {
                        DrawChart(e.Graphics, Current.MFs[i], Current.Range, true);
                    }
                    else
                    {
                        DrawChart(e.Graphics, Current.MFs[i], Current.Range, false);
                    }
                }
                base.OnPaint(e);
            }
        }
        private void VarTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (checkNodeNotRoot(e.Node))
            {
                if (e.Node.Parent.Text.Equals("Inputs"))
                {
                    RuleItemUI item = new RuleItemUI(e.Node.Text, InOutType.In);
                    if (InRulePanChest.Controls.Find(item.Name, false).Length == 0)
                    {
                        InRulePanChest.Controls.Add(item);
                    }
                }
                else
                {
                    RuleItemUI item = new RuleItemUI(e.Node.Text, InOutType.Out);
                    if (OutRulePanChest.Controls.Find(item.Name, false).Length == 0)
                    {
                        OutRulePanChest.Controls.Add(item);
                    }
                }
            }



        }
        public void loadVariablesRulesChest()
        {
            VarTreeChest.Nodes.Clear();
            int InputCount = FuzzyLogic.InputVariables.Count;
            TreeNode[] INnodes = new TreeNode[InputCount];
            for (int i = 0; i < InputCount; i++)
            {
                INnodes[i] = new TreeNode(FuzzyLogic.InputVariables[i].Name);
            }
            TreeNode root = new TreeNode("Inputs", INnodes);
            VarTreeChest.Nodes.Add(root);

            int OutputCount = FuzzyLogic.OutputVariables.Count;
            TreeNode[] Outnodes = new TreeNode[OutputCount];
            for (int i = 0; i < OutputCount; i++)
            {
                Outnodes[i] = new TreeNode(FuzzyLogic.OutputVariables[i].Name);
            }
            TreeNode root2 = new TreeNode("Outputs", Outnodes);
            VarTreeChest.Nodes.Add(root2);

        }
        private void DrawChart(Graphics g, FuzzyLogicController.MFs.MemberShipFunction mf, List<double> Range, bool isSelected)
        {
            List<double> pts = mf.Params;

            Graphics gfx = g;
            #region Graphs
            Point[] points = new Point[pts.Count];
            for (int i = 0; i < pts.Count; i++)
            {
                double value = (pts[i] - Range[0]) / (Range[1] - Range[0]);
                int pos = Convert.ToInt32(value * (ChartPanelChest.Bounds.Width));
                if (i == 0 || i == pts.Count - 1)
                {
                    points[i] = new Point(pos, ChartPanelChest.Bounds.Height - 20);
                }
                else
                {
                    points[i] = new Point(pos, 40);
                }
            }
            if (!isSelected)
            {
                gfx.DrawLines(new Pen(Color.Red), points);
            }
            else
            {
                gfx.DrawLines(new Pen(new SolidBrush(Color.Blue), 3), points);
            }


            int diff = Convert.ToInt32((points[pts.Count - 1].X - points[0].X) / 2);
            int strvalue = points[0].X + diff;

            if (!isSelected)
            {
                Font font = new Font("SanSerif", 10, FontStyle.Italic);
                gfx.DrawString(mf.Name, font, new SolidBrush(Color.Red), new PointF(strvalue - 25, 20));
            }
            else
            {
                Font font = new Font("SanSerif", 12, FontStyle.Italic);
                gfx.DrawString(mf.Name, font, new SolidBrush(Color.Blue), new PointF(strvalue - 25, 20));
            }
            #endregion
            #region Axis
            gfx.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, ChartPanelChest.Height - 19), new Point(ChartPanelChest.Width, ChartPanelChest.Height - 19));
            double Step = (Range[1] - Range[0]) / (10 - 1);
            double Steps = Range[0];
            for (int i = 0; i < 10; i++)
            {
                Steps = Steps + Step;
                double value = (Steps - Range[0]) / (Range[1] - Range[0]);
                int pos = Convert.ToInt32(value * (ChartPanelChest.Bounds.Width));
                PointF point = new PointF(pos, ChartPanelChest.Bounds.Height - 15);
                gfx.DrawString(Convert.ToInt32(Steps).ToString(), new Font(FontFamily.GenericSansSerif, 10), new SolidBrush(Color.Black), point);
            }
            #endregion
        }
        private void MFViewChest_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MFViewChest.SelectedIndices.Count > 0)
            {
                VarTxTChest.Text = "";
                popualteMF(Current.MFs[MFViewChest.SelectedIndices[0]]);
                this.ChartPanelChest.Paint += new PaintEventHandler(drawSelectedMF);
                this.ChartPanelChest.Refresh();
            }
        }
        public LingVariable Current
        {
            get { return _current; }
            set
            {
                _current = value;
                this.ChartPanelChest.Paint += new PaintEventHandler(drawSelectedMF);
                this.ChartPanelChest.Refresh();
            }

        }
        //BMI
        public void loadVariablesBMI()
        {
            if (FuzzyLogic.InputVariablesBMI.Count > 0)
            {
                VarLabelBMI.Text = FuzzyLogic.InputVariablesBMI[0].Name;



                for (int i = 1; i < FuzzyLogic.InputVariablesBMI.Count; i++)
                {
                    VarLabelBMI.Text = VarLabelBMI.Text + "," + FuzzyLogic.InputVariablesBMI[i].Name;
                }
            }
        }
        public void loadRulesBMI()
        {
            List<FuzzyLogicController.RuleEngine.Rule> rulesBMI = FuzzyLogic.RulesBMI;

        }
        public void FuzzyCalculatorBMI()
        {

            clearBMI();
            List<double> inputs = FuzzyLogic.tokString(txtFuzzyOptionBMI.Text);
            CrispPanBMI.RowCount = FuzzyLogic.InputVariablesBMI.Count;

            for (int i = 0; i < FuzzyLogic.InputVariablesBMI.Count; i++)
            {
                CrispPanBMI.Controls.Add(TextLabel(FuzzyLogic.InputVariablesBMI[i].Name + " : " + inputs[i], TextType.Normal));
            }



            //Fuzzification
            List<FuzzySet> InSets = new List<FuzzySet>();
            for (int i = 0; i < FuzzyLogic.InputVariablesBMI.Count; i++)
            {
                InSets.Add(new FuzzySet(FuzzyLogic.FuzzyControl.Fuzzification(inputs[i], FuzzyLogic.InputVariablesBMI[i]), FuzzyLogic.InputVariablesBMI[i].Name));
            }

            for (int i = 0; i < InSets.Count; i++)
            {

                FuzzPanBMI.Controls.Add(TextLabel(InSets[i].Variable, TextType.Normal));

                for (int j = 0; j < InSets[i].Set.Count; j++)
                {
                    FuzzPanBMI.Controls.Add(TextLabel(InSets[i].Set[j].MemberShipName + ":" + InSets[i].Set[j].FuzzyValue.ToString(), TextType.Normal));
                }
            }

            //Inference Engine
            InferEngine engine = new InferEngine(FuzzyLogic.Configuration, FuzzyLogic.RulesBMI, InSets);
            List<FuzzySet> RuleResults = engine.evaluateRules();

            EnginePanBMI.Controls.Add(TextLabel("Tetiklenen Kurallar", TextType.Header));

            for (int i = 0; i < engine.FiredRules.Count; i++)
            {
                EnginePanBMI.Controls.Add(TextLabel("Kural :" + engine.FiredRules[i].ToString(), TextType.Normal, FuzzyLogic.RulesBMI[engine.FiredRules[i] - 1].ToString()));
            }

            for (int i = 0; i < RuleResults.Count; i++)
            {
                DeFuzzPanBMI.Controls.Add(TextLabel(RuleResults[i].Variable, TextType.Header));
                for (int j = 0; j < RuleResults[i].Set.Count; j++)
                {
                    DeFuzzPanBMI.Controls.Add(TextLabel(RuleResults[i].Set[j].MemberShipName + " : " + RuleResults[i].Set[j].FuzzyValue.ToString(), TextType.Normal));
                }
            }


            //deFuzzification
            List<double> CrispValues = new List<double>();
            for (int i = 0; i < FuzzyLogic.OutputVariablesBMI.Count; i++)
            {
                CrispValues.Add(FuzzyLogic.FuzzyControl.DeFuzzification(RuleResults, FuzzyLogic.OutputVariablesBMI[i]));
            }

            for (int i = 0; i < CrispValues.Count; i++)
            {
                solution2BMI = CrispValues[i];

                //String text = FuzzyLogic.OutputVariables[i].Name  + " : " + CrispValues[i].ToString();

                String text = RuleResults[i].Set[i].MemberShipName;



                AnalyzeBMIndex = RuleResults[i].Set[i].MemberShipName;
                CrispViewBMI.Items.Add(text);

            }

        }
        private void clearBMI()
        {
            CrispPanBMI.Controls.Clear();
            FuzzPanBMI.Controls.Clear();
            DeFuzzPanBMI.Controls.Clear();
            EnginePanBMI.Controls.Clear();
            CrispViewBMI.Clear();
        }
        public void BMIConfig()
        {

            loadRulesBMI();
            FuzzyLogic.InitalizeBMI();
            FuzzyLogic.FuzzyBMIndexOption();
            loadVariablesBMI();
            // buraya loadrules eklersek forma if li şekilde kuralları yazdırabilriiz:)
        }
        public void ClearVariableBMI()
        {
            MFViewBMI.Clear();
            VarTxTBMI.Text = "";
            RangeTxTBMI.Text = "";
            CurrentBMI = null;
        }
        private void InputViewBMI_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InputViewBMI.SelectedIndices.Count > 0)
            {
                int index = InputViewBMI.SelectedIndices[0];
                ClearVariableBMI();
                CurrentBMI = FuzzyLogic.InputVariablesBMI[index];
                PopulateBMI();
            }
        }
        private void OutputViewBMI_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OutputViewBMI.SelectedIndices.Count > 0)
            {
                int index = OutputViewBMI.SelectedIndices[0];
                ClearVariableBMI();
                CurrentBMI = FuzzyLogic.OutputVariablesBMI[index];
                PopulateBMI();
            }
        }
        public void PopulateBMI()
        {
            VarTxTBMI.Text = CurrentBMI.Name;
            RangeTxTBMI.Text = CurrentBMI.Range[0] + ", " + CurrentBMI.Range[1];

            if (CurrentBMI.Type == VarType.Input) { TypeComboBMI.SelectedIndex = 0; }
            else { TypeComboBMI.SelectedIndex = 1; }

            if (CurrentBMI.MFs.Count > 0)
            {
                for (int i = 0; i < CurrentBMI.MFs.Count; i++)
                {
                    if (!MFViewBMI.Items.ContainsKey(CurrentBMI.MFs[i].Name))
                    {
                        MFViewBMI.Items.Add(CurrentBMI.MFs[i].Name, CurrentBMI.MFs[i].Name, 1);
                    }
                }

            }
        }
        public void loadRulesBMIView()
        {

            List<FuzzyLogicController.RuleEngine.Rule> rules = FuzzyLogic.RulesBMI;

            RulePanBMI.Controls.Clear();
            RulePanBMI.RowCount = rules.Count;

            for (int i = 0; i < rules.Count; i++)
            {
                String rule = "IF ";
                for (int j = 0; j < rules[i].InputRules.Count; j++)
                {
                    rule = rule + rules[i].InputRules[j].Variable + " is " + rules[i].InputRules[j].MemberShipValue;
                    if (j != rules[i].InputRules.Count - 1)
                    {
                        rule = rule + " And ";
                    }
                }
                rule = rule + " Then ";
                for (int j = 0; j < rules[i].OutputRules.Count; j++)
                {
                    rule = rule + rules[i].OutputRules[j].Variable + " is " + rules[i].OutputRules[j].MemberShipValue;
                    if (j != rules[i].OutputRules.Count - 1)
                    {
                        rule = rule + " And ";
                    }
                }

                Label Temp = new Label();
                Temp.Text = rule;
                Temp.Name = FuzzyLogic.Rules.IndexOf(rules[i]).ToString();

                Temp.Font = new Font("Century Gothic", 13, FontStyle.Bold);
                Temp.Dock = DockStyle.Fill;
                RulePanBMI.Controls.Add(Temp, 0, i);
            }
        }
        private void populateVariablesBMI()   // SON KEZ BAK
        {
            for (int i = 0; i < FuzzyLogic.InputVariablesBMI.Count; i++)
            {
                if (InputViewBMI.Items.ContainsKey(FuzzyLogic.InputVariablesBMI[i].Name) == false)
                {
                    InputViewBMI.Items.Add(FuzzyLogic.InputVariablesBMI[i].Name, FuzzyLogic.InputVariablesBMI[i].Name, 1);
                }
            }

            for (int i = 0; i < FuzzyLogic.OutputVariablesBMI.Count; i++)
            {
                if (OutputViewBMI.Items.ContainsKey(FuzzyLogic.OutputVariablesBMI[i].Name) == false)
                {
                    OutputViewBMI.Items.Add(FuzzyLogic.OutputVariablesBMI[i].Name, FuzzyLogic.OutputVariablesBMI[i].Name, 1);
                }
            }
        }
        private void popualteMFBMI(FuzzyLogicController.MFs.MemberShipFunction mf)
        {
            VarTxTBMI.Text = mf.Name;
            txtFuzzyOptionBMI.Text = mf.Params[0].ToString();
            for (int i = 1; i < mf.Params.Count; i++)
            {
                VarTxTBMI.Text = VarTxTBMI.Text + ", " + mf.Params[i];
            }
            if (mf is FuzzyLogicController.MFs.Trimf)
            {
                TypeComboBMI.SelectedIndex = 0;
            }
            else if (mf is FuzzyLogicController.MFs.Trapmf)
            {
                TypeComboBMI.SelectedIndex = 1;
            }
        }
        private void drawSelectedMFBMI(object sender, PaintEventArgs e)
        {
            if (CurrentBMI != null)
            {
                for (int i = 0; i < CurrentBMI.MFs.Count; i++)
                {
                    if (MFViewBMI.SelectedIndices.Count > 0 && i == MFViewBMI.SelectedIndices[0])
                    {
                        DrawChartBMI(e.Graphics, CurrentBMI.MFs[i], CurrentBMI.Range, true);
                    }
                    else
                    {
                        DrawChartBMI(e.Graphics, CurrentBMI.MFs[i], CurrentBMI.Range, false);
                    }
                }
                base.OnPaint(e);
            }
        }
        private void VarTreeBMI_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (checkNodeNotRoot(e.Node))
            {
                if (e.Node.Parent.Text.Equals("Inputs"))
                {
                    RuleItemUI item = new RuleItemUI(e.Node.Text, InOutType.In);
                    if (InRulePanBMI.Controls.Find(item.Name, false).Length == 0)
                    {
                        InRulePanBMI.Controls.Add(item);
                    }
                }
                else
                {
                    RuleItemUI item = new RuleItemUI(e.Node.Text, InOutType.Out);
                    if (OutRulePanBMI.Controls.Find(item.Name, false).Length == 0)
                    {
                        OutRulePanBMI.Controls.Add(item);
                    }
                }
            }
        }
        public void loadVariablesRulesBMI()
        {
            VarTreeBMI.Nodes.Clear();
            int InputCount = FuzzyLogic.InputVariablesBMI.Count;
            TreeNode[] INnodes = new TreeNode[InputCount];
            for (int i = 0; i < InputCount; i++)
            {
                INnodes[i] = new TreeNode(FuzzyLogic.InputVariablesBMI[i].Name);
            }
            TreeNode root = new TreeNode("Inputs", INnodes);
            VarTreeBMI.Nodes.Add(root);

            int OutputCount = FuzzyLogic.OutputVariablesBMI.Count;
            TreeNode[] Outnodes = new TreeNode[OutputCount];
            for (int i = 0; i < OutputCount; i++)
            {
                Outnodes[i] = new TreeNode(FuzzyLogic.OutputVariablesBMI[i].Name);
            }
            TreeNode root2 = new TreeNode("Outputs", Outnodes);
            VarTreeBMI.Nodes.Add(root2);

        }
        private void DrawChartBMI(Graphics gBMI, FuzzyLogicController.MFs.MemberShipFunction mfBMI, List<double> Range, bool isSelected)
        {
            List<double> pts = mfBMI.Params;

            Graphics gfxBMI = gBMI;
            #region Graphs
            Point[] points = new Point[pts.Count];
            for (int i = 0; i < pts.Count; i++)
            {
                double value = (pts[i] - Range[0]) / (Range[1] - Range[0]);
                int pos = Convert.ToInt32(value * (ChartPanelBMI.Bounds.Width));
                if (i == 0 || i == pts.Count - 1)
                {
                    points[i] = new Point(pos, ChartPanelBMI.Bounds.Height - 20);
                }
                else
                {
                    points[i] = new Point(pos, 40);
                }
            }
            if (!isSelected)
            {
                gfxBMI.DrawLines(new Pen(Color.Red), points);
            }
            else
            {
                gfxBMI.DrawLines(new Pen(new SolidBrush(Color.Blue), 2), points);
            }


            int diff = Convert.ToInt32((points[pts.Count - 1].X - points[0].X) / 3);
            int strvalue = points[0].X + diff;

            if (!isSelected)
            {
                Font font = new Font("SanSerif", 10, FontStyle.Italic);
                gfxBMI.DrawString(mfBMI.Name, font, new SolidBrush(Color.Red), new PointF(strvalue - 25, 20));
            }
            else
            {
                Font font = new Font("SanSerif", 12, FontStyle.Italic);
                gfxBMI.DrawString(mfBMI.Name, font, new SolidBrush(Color.Blue), new PointF(strvalue - 25, 20));
            }
            #endregion
            #region Axis
            gfxBMI.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, ChartPanelBMI.Height - 19), new Point(ChartPanelBMI.Width, ChartPanelBMI.Height - 19));
            double Step = (Range[1] - Range[0]) / (10 - 1);
            double Steps = Range[0];
            for (int i = 0; i < 10; i++)
            {
                Steps = Steps + Step;
                double value = (Steps - Range[0]) / (Range[1] - Range[0]);
                int pos = Convert.ToInt32(value * (ChartPanelBMI.Bounds.Width));
                PointF point = new PointF(pos, ChartPanelBMI.Bounds.Height - 15);
                gfxBMI.DrawString(Convert.ToInt32(Steps).ToString(), new Font(FontFamily.GenericSansSerif, 10), new SolidBrush(Color.Black), point);
            }
            #endregion
        }

        public LingVariable CurrentBMI
        {
            get { return _currentBMI; }
            set
            {
                _currentBMI = value;
                this.ChartPanelBMI.Paint += new PaintEventHandler(drawSelectedMFBMI);
                this.ChartPanelBMI.Refresh();
            }

        }
        private void MFViewBMI_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MFViewBMI.SelectedIndices.Count > 0)
            {
                VarTxTBMI.Text = "";
                popualteMFBMI(CurrentBMI.MFs[MFViewBMI.SelectedIndices[0]]);
                this.ChartPanelBMI.Paint += new PaintEventHandler(drawSelectedMFBMI);
                this.ChartPanelBMI.Refresh();
            }
        }

        private void btnTriumEqu_Click(object sender, EventArgs e)
        {
            TRIUMPIC1.Enabled = true;
            TRIUMPIC1.Visible = true;
            TRIUMPIC2.Enabled = true;
            TRIUMPIC2.Visible = true;
            TRIUMPIC3.Enabled = true;
            TRIUMPIC3.Visible = true;

            NETWORKPIC1.Enabled = false;
            NETWORKPIC2.Enabled = false;
            NETWORKPIC3.Enabled = false;
            NETWORKPIC1.Visible = false;
            NETWORKPIC2.Visible = false;
            NETWORKPIC3.Visible = false;

            CLASSICPIC1.Enabled = false;
            CLASSICPIC2.Enabled = false;
            CLASSICPIC1.Visible = false;
            CLASSICPIC2.Visible = false;
            CLASSICLABELCLCK.Enabled = false;
            CLASSICLABELCLCK.Visible = false;
            TRIUMLABELCLCK.Enabled = true;
            TRIUMLABELCLCK.Visible = true;
            NETWORKLABELCLCK.Enabled = false;
            NETWORKLABELCLCK.Visible = false;


        }

        private void btnNetworkEqu_Click(object sender, EventArgs e)
        {
            TRIUMPIC1.Enabled = false;
            TRIUMPIC1.Visible = false;
            TRIUMPIC2.Enabled = false;
            TRIUMPIC2.Visible = false;
            TRIUMPIC3.Enabled = false;
            TRIUMPIC3.Visible = false;
            NETWORKPIC1.Enabled = true;
            NETWORKPIC2.Enabled = true;
            NETWORKPIC3.Enabled = true;
            NETWORKPIC1.Visible = true;
            NETWORKPIC2.Visible = true;
            NETWORKPIC3.Visible = true;
            CLASSICPIC1.Enabled = false;
            CLASSICPIC2.Enabled = false;
            CLASSICPIC1.Visible = false;
            CLASSICPIC2.Visible = false;
            CLASSICLABELCLCK.Enabled = false;
            CLASSICLABELCLCK.Visible = false;
            TRIUMLABELCLCK.Enabled = false;
            TRIUMLABELCLCK.Visible = false;
            NETWORKLABELCLCK.Enabled = true;
            NETWORKLABELCLCK.Visible = true;

        }

        private void btnClassicEqu_Click(object sender, EventArgs e)
        {
            TRIUMPIC1.Enabled = false;
            TRIUMPIC1.Visible = false;
            TRIUMPIC2.Enabled = false;
            TRIUMPIC2.Visible = false;
            TRIUMPIC3.Enabled = false;
            TRIUMPIC3.Visible = false;

            NETWORKPIC1.Enabled = false;
            NETWORKPIC2.Enabled = false;
            NETWORKPIC3.Enabled = false;
            NETWORKPIC1.Visible = false;
            NETWORKPIC2.Visible = false;
            NETWORKPIC3.Visible = false;
            CLASSICPIC1.Enabled = true;
            CLASSICPIC2.Enabled = true;

            CLASSICPIC1.Enabled = true;
            CLASSICPIC2.Enabled = true;
            CLASSICPIC1.Visible = true;
            CLASSICPIC2.Visible = true;

            CLASSICLABELCLCK.Enabled = true;
            CLASSICLABELCLCK.Visible = true;
            TRIUMLABELCLCK.Enabled = false;
            TRIUMLABELCLCK.Visible = false;
            NETWORKLABELCLCK.Enabled = false;
            NETWORKLABELCLCK.Visible = false;


        }

        private void btnmillion_Click(object sender, EventArgs e)
        {
            Random testerc = new Random();

            for (int i = 0; i < 1000000; i++)
            {
                int ak = testerc.Next(1, 3999);
                double A77CLON = Convert.ToDouble(dtgLab.Rows[ak].Cells[11].Value.ToString());
                double A87CLON = Convert.ToDouble(dtgLab.Rows[ak].Cells[12].Value.ToString());
                double A8CLON = Convert.ToDouble(dtgLab.Rows[ak].Cells[13].Value.ToString());
                double E101CLON = Convert.ToDouble(dtgLab.Rows[ak].Cells[14].Value.ToString());
                double E102CLON = Convert.ToDouble(dtgLab.Rows[ak].Cells[15].Value.ToString());
                double E103CLON = Convert.ToDouble(dtgLab.Rows[ak].Cells[16].Value.ToString());

                LabCalculator(A77CLON, A87CLON, A8CLON, E101CLON, E102CLON, E103CLON);
            }
            MessageBox.Show("İŞLEM TAMAMLANDI");
        }

        private void btnDataAllClear_Click(object sender, EventArgs e)
        {
            _clearTheDataBase.ClearAllDataBase();
        }
    }
}
