using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SurvivalSimulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int resourcesDistance=0;
        int count=0; 
        int indis = 0; // positionsort indisi
        string[] outputsentences; //Output Dosyasına yazılacak cümleler
        string[] sentences; // dosyanın içindeki cümleler
        string[] words; // dosyanın içindeki cümlelerin kelimeleri
        int[] positionsort; // enemy'lerin positionlarının küçükten büyüğe sıralanmış halleri bulunur.
        string filePath;
        int i = 0; 
        bool lastLocationState = false; //son position enemy gelmesi ve ölmesi
        struct EnemyType // Enemy'nin türü
        {
            public string name;
            public int hp,atack;
        }
        struct Enemy  // belirli position'lardaki enemy'ler
        {
            public string name;
            public int position;
        }
        Enemy[] enemies; // enemy sayısı
        EnemyType[] enemyTypes; //enemy türleri
        Hero hero = new Hero();

        public void initialize() 
        {
            hero.position = 0;
            hero.hp = 0;
            hero.attack = 0;
            lastLocationState = false;
            indis = 0;
            i = 0;
            resourcesDistance = 0;
            outputsentences = null;
            sentences = null;
            words = null;
            positionsort = null;
            timer1.Enabled = true;
            btnOpenFile.Enabled = false;
            btnSimulate.Enabled = false;
        }
        public void stopSimulation() 
        {
            timer1.Enabled = false;
            btnOpenFile.Enabled = true;
            btnSimulate.Enabled = true;
        }
        public void initializeHero() // Hero'nun propertileri giriliyor
        {
            try
            {

                sentences = rtxtSimulationDisplay.Text.Split('\n');
                words = sentences[i].Split(' ');
                resourcesDistance = Convert.ToInt32(words[2]);
                i++;
                words = sentences[i].Split(' ');
                hero.hp = Convert.ToInt32(words[2]);
                i++;
                words = sentences[i].Split(' ');
                hero.attack = Convert.ToInt32(words[3]);
            }
            catch (Exception error) 
            {
                stopSimulation();
                MessageBox.Show("Dosya formatı yanlış" + error.ToString());
            }
        }

        //Aşağıdaki fonksiyon kaç tür enemy ve kaç tane enemy old sayıyor.
        public int number(string[] words, string searchingword, string[] sentences, int sentenceIndex, int cnt, int wordIndex) 
        {
            try
            {
                words = sentences[sentenceIndex].Split(' ');
                cnt = 0;
                while (words[wordIndex] == searchingword)
                {
                    sentenceIndex++;
                    cnt++;
                    words = sentences[sentenceIndex].Split(' ');
                    if (sentences[sentenceIndex] == "") break;
                }
            }
            catch (Exception error)
            {
                stopSimulation();
                MessageBox.Show("Atama Hatası" + error.ToString());
            }
            return cnt;
        }

        public void sorting(int[] sort,int counter) //Enemylerin positionları sıralanıyor.
        {
            try
            {
                int temp;
                for (int m = 0; m < counter; m++)
                {
                    for (int t = m + 1; t < counter; t++)
                    {
                        if (sort[t] < sort[m])
                        {

                            temp = sort[m];

                            sort[m] = sort[t];

                            sort[t] = temp;

                        }
                    }

                }
            }
            catch (Exception error)
            {
                stopSimulation();
                MessageBox.Show("Sıralama Hatası" + error.ToString());
            }
        }


        public int attacking(int enemyHp , int heroAttack , int heroHp , int enemyAttack) // Hero atak yapıyor.
        {
            try
            {
                double temp;
                temp = (double)enemyHp / heroAttack;
                temp = Math.Ceiling(temp);
                heroHp = heroHp - (Convert.ToInt32(temp) * enemyAttack);
            }
            catch (Exception error)
            {
                stopSimulation();
                MessageBox.Show("Saldırı Hatası" + error.ToString());
            }
            return heroHp;
        }
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            //Dosya açılıyor. filePath değişkenine dosyanın yolu dosya ismi olmadan atanıyor
            OpenFileDialog simFile = new OpenFileDialog();
            try
            {
                if (simFile.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fi = new FileInfo(simFile.FileName);
                    if (fi.Exists)
                    {
                        StreamReader readSimFile = File.OpenText(simFile.FileName);
                        string text;
                        text = readSimFile.ReadLine();
                        rtxtSimulationDisplay.Text = "";
                        while (text != null)
                        {
                            rtxtSimulationDisplay.Text += text + "\n";
                            text = readSimFile.ReadLine();
                        }
                        readSimFile.Close();
                        filePath = "";
                        string[] temp = simFile.FileName.Split('\\');
                        int arraylength = temp.Length;
                        int k = 0;
                        while (k != arraylength-1 ) 
                        {
                            filePath += temp[k] + "\\";
                            k++;
                        }

                    }

                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Dosya Açılamadı!\n" + error);
            }
        }


        private void btnSimulate_Click(object sender, EventArgs e)
        {
            try
            {
            initialize(); //veriler sıfırlanıyor.
            initializeHero();
            i++;
            count = number(words,"Enemy",sentences,i,count,2); // enemy türü sayısı count değişkenine atanıyor.
            enemyTypes=new EnemyType[count];
            for (int j = 0; j < count; j++)//enemy türlerinin isimleri atanıyor.
            {
                words = sentences[i].Split(' ');
                enemyTypes[j].name = words[0].ToString().Trim();
                i++;
            }
            int q=i;
            int tempCnt = (count*2)+q;
            for (; i < tempCnt; i=i+2) // enemy türlerinin değişkenleri atanıyor.
            {
                int j=0;
                words = sentences[i].Split(' ');
                while (words[0] != enemyTypes[j].name)
                    j++;
                enemyTypes[j].hp = Convert.ToInt32(words[2]);
                words = sentences[i+1].Split(' ');
                enemyTypes[j].atack = Convert.ToInt32(words[3]);

            }

            count = number(words, "position", sentences, i, count, 5); // enemy sayısı count değişkenine atanıyor.
            enemies = new Enemy[count];  // enemy'ler oluşturuluyor.
            i = tempCnt;
            for (int j = 0; j < count; j++) //enemy'lerin isimleri ve positionları atanıyor.
            {
                words = sentences[i].Split(' ');
                enemies[j].name = words[3].ToString().Trim();
                enemies[j].position = Convert.ToInt32(words[6]);
                i++;
            }
            rtxtSimulationDisplay.Text = "Hero started journey with " + hero.hp + " HP!";
            positionsort = new int[count];
            for(int n=0; n<count; n++) // enemy'lerin positionları positionsort değişkenine atanıyor.
                positionsort[n]=enemies[n].position;
            sorting(positionsort, count); //
            }
            catch (Exception x)
            {
             stopSimulation();
             MessageBox.Show(x.ToString());
            }

        }


        
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                hero.position++;
                lblHeroStatus.Text = "Hero is running " + hero.position.ToString();        

                if (indis != count) //positionsort dizisindeki değerler geziliyor.Hero positiona eşit olan enemy position ile işlem yapılıyor
                {
                    if (hero.position == positionsort[indis]) //Hero enemy ile karşılaşıyor.
                    {

                        int k = 0;
                        while (enemies[k].position != positionsort[indis]) // enemy'nin position'ı positionsort'taki yeri saptanıyor.
                            k++;
                        int j = 0;
                        while (enemies[k].name != enemyTypes[j].name) //Enemy'nin türü belirleniyor.
                            j++;

                        hero.hp = attacking(enemyTypes[j].hp, hero.attack, hero.hp, enemyTypes[j].atack); //Hero enemy e saldırıyor.
                        if (hero.hp <= 0 ) //Hero öldüyse
                        {
                            if (hero.position == resourcesDistance) lastLocationState = true; //son position da öldüyse aşağıdaki son position if bloğuna girmiyor
                            rtxtSimulationDisplay.Text += "\nHero is dead!! Last seen at position " + enemies[k].position;
                            lblHeroStatus.Text = "Hero is dead!";
                            int x = 0;
                            StreamWriter dosya = File.CreateText(filePath + "SampleOutput.txt");
                            outputsentences = rtxtSimulationDisplay.Text.Split('\n');
                            while (outputsentences[x] != "Hero is dead!! Last seen at position " + enemies[k].position) //Output Dosyası yazılıyor.
                            {
                                dosya.WriteLine(outputsentences[x]);
                                x++;
                            }
                            dosya.WriteLine(outputsentences[x]);
                            dosya.Close();
                            stopSimulation();
                        }
                        else //Hero ölmediyse
                        {
                            rtxtSimulationDisplay.Text += "\nHero defeated " + enemyTypes[j].name + " with " + hero.hp + " HP remaining";
                            timer1.Enabled = true;
                        }
                        indis++;
                    }

                }

                if (hero.position == resourcesDistance && lastLocationState != true) //son position durumu
                {
                    rtxtSimulationDisplay.Text += "\nHero is survived!";
                    lblHeroStatus.Text = "Hero is survived";
                    StreamWriter dosya = File.CreateText(filePath + "SampleOutput.txt");
                    outputsentences = rtxtSimulationDisplay.Text.Split('\n');
                    int x = 0;
                    while (outputsentences[x] != "Hero is survived!") //Output dosyası yazılıyor
                    {
                        dosya.WriteLine(outputsentences[x]);
                        x++;
                    }
                    dosya.WriteLine(outputsentences[x]);
                    dosya.Close();

                    stopSimulation();
                }

            }
            catch (Exception error) 
            {
                stopSimulation();
                MessageBox.Show(error.ToString());
            }
        }

    }
}
