using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Filosofi
{
    public partial class Form1 : Form
    {
        Fil Aristotel = new Fil(),
            Pifagor = new Fil(),
            Platon = new Fil(),
            Sokrat = new Fil();
        //Создаём объекты класса Fil

        //Определяем массив, для выяснения выбранных полей вывода
        bool[] chek=new bool[6];

        String chekedFil;

        public Form1()
        {
            InitializeComponent();
            String[] names = { "Аристотель", "Пифагор", "Платон", "Сократ" };
            //Подгружаем данны из ресурсов, что бы не захломлять код
            String[] bio = { Filosofi.Properties.Resources.Arist_bio,
                            Filosofi.Properties.Resources.Pifagor_bio,
                            Filosofi.Properties.Resources.Platon_bio,
                            Filosofi.Properties.Resources.Sokrat_bio};

            String[] vis = { Filosofi.Properties.Resources.Arist_vis,
                            Filosofi.Properties.Resources.Pifagor_vis,
                            Filosofi.Properties.Resources.Platon_vis,
                            Filosofi.Properties.Resources.Sokrat_vis};

            String[] etik = { Filosofi.Properties.Resources.Arist_etik,
                            Filosofi.Properties.Resources.Pifagor_etik,
                            Filosofi.Properties.Resources.Platon_etik,
                            Filosofi.Properties.Resources.Sokrat_etik};

            String[] log = { Filosofi.Properties.Resources.Arist_log,
                            Filosofi.Properties.Resources.Pifagor_log,
                            Filosofi.Properties.Resources.Platon_log,
                            Filosofi.Properties.Resources.Sokrat_log};

            String[] poet = { Filosofi.Properties.Resources.Arist_poet,
                            Filosofi.Properties.Resources.Pifagor_poet,
                            Filosofi.Properties.Resources.Platon_poet,
                            Filosofi.Properties.Resources.Sokrat_poet};

            String[] prav = { Filosofi.Properties.Resources.Arist_prav,
                            Filosofi.Properties.Resources.Pifagor_prav,
                            Filosofi.Properties.Resources.Platon_prav,
                            Filosofi.Properties.Resources.Sokrat_prav};

            //Заполняем объекты
            Aristotel.name = names[0];  Pifagor.name = names[1];    Platon.name = names[2]; Sokrat.name = names[3];
            Aristotel.bio = bio[0];     Pifagor.bio = bio[1];       Platon.bio = bio[2];    Sokrat.bio = bio[3];
            Aristotel.vis = vis[0];     Pifagor.vis = vis[1];       Platon.vis = vis[2];    Sokrat.vis = vis[3];
            Aristotel.etik = etik[0];   Pifagor.etik = etik[1];     Platon.etik = etik[2];  Sokrat.etik = etik[3];
            Aristotel.log = log[0];     Pifagor.log = log[1];       Platon.log = log[2];    Sokrat.log = log[3];
            Aristotel.poet = poet[0];   Pifagor.poet = poet[1];     Platon.poet = poet[2];  Sokrat.poet = poet[3];
            Aristotel.prav = prav[0];   Pifagor.prav = prav[1];     Platon.prav = prav[2];  Sokrat.prav = prav[3];
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            bool flag = false;
            //Узнаём, какую информацию нужно вывести пользователю
            foreach (int id in checkedListBox1.CheckedIndices)
            {
                chek[id] = true;
                flag = true;
            }

            //Проверям выбрана ли информация для вывода
            if (flag==false)
            {
                //Если информация не выбрана, выводим сообщение об этом
                MessageBox.Show("Вы не выбрали информацию для вывода!");
            }
            else
            {
                chekedFil = label1.Text;
                //Узнаём какой Философ выбран и выбран ли вообще
                switch (chekedFil)
                {
                    case "Аристотель":
                        Arist();
                        break;
                    case "Пифагор":
                        Pif();
                        break;
                    case "Платон":
                        Plat();
                        break;
                    case "Сократ":
                        Sokr();
                        break;
                    default:
                        //Если философ не выбран, выводим сообщение об этом
                        MessageBox.Show("Вы не выбрали философа!");
                        break;
                }
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Далее выводим выбранную информацию
        void Arist()
        {
            textBox1.Text =Aristotel.name+Environment.NewLine;
            if (chek[0] == true) textBox1.Text += Aristotel.bio + Environment.NewLine;
            if (chek[1] == true) textBox1.Text += Aristotel.vis + Environment.NewLine;
            if (chek[2] == true) textBox1.Text += Aristotel.etik + Environment.NewLine;
            if (chek[3] == true) textBox1.Text += Aristotel.log + Environment.NewLine;
            if (chek[4] == true) textBox1.Text += Aristotel.poet + Environment.NewLine;
            if (chek[5] == true) textBox1.Text += Aristotel.prav + Environment.NewLine;
        }

        void Pif()
        {
            textBox1.Text = Pifagor.name + Environment.NewLine;
            if (chek[0] == true) textBox1.Text += Pifagor.bio + Environment.NewLine;
            if (chek[1] == true) textBox1.Text += Pifagor.vis + Environment.NewLine;
            if (chek[2] == true) textBox1.Text += Pifagor.etik + Environment.NewLine;
            if (chek[3] == true) textBox1.Text += Pifagor.log + Environment.NewLine;
            if (chek[4] == true) textBox1.Text += Pifagor.poet + Environment.NewLine;
            if (chek[5] == true) textBox1.Text += Pifagor.prav + Environment.NewLine;
        }

        void Plat()
        {
            textBox1.Text = Platon.name + Environment.NewLine;
            if (chek[0] == true) textBox1.Text += Platon.bio + Environment.NewLine;
            if (chek[1] == true) textBox1.Text += Platon.vis + Environment.NewLine;
            if (chek[2] == true) textBox1.Text += Platon.etik + Environment.NewLine;
            if (chek[3] == true) textBox1.Text += Platon.log + Environment.NewLine;
            if (chek[4] == true) textBox1.Text += Platon.poet + Environment.NewLine;
            if (chek[5] == true) textBox1.Text += Platon.prav + Environment.NewLine;
        }

        void Sokr()
        {
            textBox1.Text = Sokrat.name + Environment.NewLine;
            if (chek[0] == true) textBox1.Text += Sokrat.bio + Environment.NewLine;
            if (chek[1] == true) textBox1.Text += Sokrat.vis + Environment.NewLine;
            if (chek[2] == true) textBox1.Text += Sokrat.etik + Environment.NewLine;
            if (chek[3] == true) textBox1.Text += Sokrat.log + Environment.NewLine;
            if (chek[4] == true) textBox1.Text += Sokrat.poet + Environment.NewLine;
            if (chek[5] == true) textBox1.Text += Sokrat.prav + Environment.NewLine;
        }

        


        void un_ch()
        {
            /*
            Приходится использовать вариант с перебором всех элементов, ибо
            функция clearSelected работает некорректно            
              */

            for (int i=0;i<checkedListBox1.Items.Count;i++)
            { 
                chek[i]= false;
                checkedListBox1.SetItemChecked(i,false);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Visible = true;//По дэфолту я его выключил, что бы не мазолил глаза юзеру
            un_ch();//убираем выделение, при смене философа
            switch (comboBox1.SelectedItem.ToString()) //Переводом в строку сейчас удобнее. В большом проекте ориентировался бы по id
            {
                case "Аристотель":
                    label1.Text = "Аристотель";
                    pictureBox1.Image = Filosofi.Properties.Resources.Аристотель;
                    break;
                case "Пифагор":
                    label1.Text = "Пифагор";
                    pictureBox1.Image = Filosofi.Properties.Resources.Пифагор;
                    break;
                case "Платон":
                    label1.Text = "Платон";
                    pictureBox1.Image = Filosofi.Properties.Resources.Платон;
                    break;
                case "Сократ":
                    label1.Text = "Сократ";
                    pictureBox1.Image = Filosofi.Properties.Resources.Сократ;
                    break;
            }
        }
    }
}
