using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Moldir_prof
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e) {}
        private void groupBox6_Enter(object sender, EventArgs e){ }


        private void Form1_Load(object sender, EventArgs e)
        {

            comboBox1.Items.AddRange(new string[] {
    "Не участвовал", "Школьный", "Городской",
    "Региональный", "Республиканский", "Международный"});
            comboBox1.SelectedIndex = 0;

            comboBox9.Items.AddRange(new string[] {
    "Участие", "Призёр", "Победитель"});
            comboBox9.SelectedIndex = 0;

            comboBox2.Items.AddRange(new string[] {
    "Не было", "Местная компания",
    "Национальная компания", "Международная компания"});
            comboBox2.SelectedIndex = 0;

            comboBox10.Items.AddRange(new string[] {
    "Прошёл", "Прошёл с отличием"});
            comboBox10.SelectedIndex = 0;

            comboBox3.Items.AddRange(new string[] {
    "Не участвовал", "Школьный", "Городской",
    "Национальный", "Международный"});
            comboBox3.SelectedIndex = 0;

            comboBox11.Items.AddRange(new string[] {
    "Участие", "Призёр", "Победитель"});
            comboBox11.SelectedIndex = 0;

            comboBox4.Items.AddRange(new string[] {
    "Не участвовал", "Школьный", "Городской",
    "Республиканский", "Международный"});
            comboBox4.SelectedIndex = 0;

            comboBox12.Items.AddRange(new string[] {
    "Участие", "Призёр", "Победитель"});
            comboBox12.SelectedIndex = 0;

            comboBox5.Items.AddRange(new string[] {
    "Не участвовал", "Школьный", "Городской",
    "Региональный", "Республиканский", "Международный"});
            comboBox5.SelectedIndex = 0;
            comboBox13.Items.AddRange(new string[] {
    "Участие", "Призёр", "Победитель"});
            comboBox13.SelectedIndex = 0; comboBox6.Items.AddRange(new string[] {
    "Нет", "Школьная газета", "Местное издание",
    "Национальное издание", "Международное издание"});
            comboBox6.SelectedIndex = 0;
            comboBox14.Items.AddRange(new string[] {
    "Опубликовано", "Опубликовано с наградой"});
            comboBox14.SelectedIndex = 0;
            comboBox7.Items.AddRange(new string[] {
    "Нет", "Актив класса", "Ученический совет",
    "Президент школы", "Городской лидер"});
            comboBox7.SelectedIndex = 0;

            comboBox15.Items.AddRange(new string[] {
    "Назначен", "Избран"});
            comboBox15.SelectedIndex = 0;
            comboBox8.Items.AddRange(new string[] {
    "Нет", "Разовое", "Регулярное", "Организатор проекта"});
            comboBox8.SelectedIndex = 0;

            comboBox16.Items.AddRange(new string[] {
    "Участвовал", "Получил благодарность", "Получил награду"});
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int entSan;
            bool entYaxshi = int.TryParse(textBox2.Text, out entSan);
            if (!entYaxshi || entSan < 0 || entSan > 140)
            {MessageBox.Show("Вводите правильные данные!Проверьте еще раз!!!");return;}
            int satSan;
            bool satYaxshi = int.TryParse(textBox3.Text, out satSan);
            if (!satYaxshi || satSan < 400 || satSan > 1600)
            {MessageBox.Show("Вводите правильные данные!Проверьте еще раз!!!");return;}
            double ieltsSan;
            bool ieltsYaxshi = double.TryParse(textBox4.Text.Replace(".", ","), out ieltsSan);
            if (!ieltsYaxshi || ieltsSan < 0 || ieltsSan >9)
            { MessageBox.Show("Вводите правильные данные!Проверьте еще раз!!!");return;}
            double gpaSan;
            bool gpaYaxshi = double.TryParse(textBox5.Text.Replace(".", ","), out gpaSan);
            if (!gpaYaxshi || gpaSan < 0 || gpaSan > 5)
            {MessageBox.Show("Вводите правильные данные!Проверьте еще раз!!!");return;}

            int olimpBall = 0;
            if (comboBox1.SelectedIndex == 1) olimpBall = 100;
            if (comboBox1.SelectedIndex == 2) olimpBall = 200;
            if (comboBox1.SelectedIndex == 3) olimpBall = 300;
            if (comboBox1.SelectedIndex == 4) olimpBall = 400;
            if (comboBox1.SelectedIndex == 5) olimpBall = 500;
            if (comboBox9.SelectedIndex == 1) olimpBall = olimpBall * 2;
            if (comboBox9.SelectedIndex == 2) olimpBall = olimpBall * 3;

            int stajBall = 0;
            if (comboBox2.SelectedIndex == 1) stajBall = 100;
            if (comboBox2.SelectedIndex == 2) stajBall = 200;
            if (comboBox2.SelectedIndex == 3) stajBall = 300;
            if (comboBox10.SelectedIndex == 1) stajBall = stajBall * 2;

            int hakatBall = 0;
            if (comboBox3.SelectedIndex == 1) hakatBall = 100;
            if (comboBox3.SelectedIndex == 2) hakatBall = 200;
            if (comboBox3.SelectedIndex == 3) hakatBall = 300;
            if (comboBox3.SelectedIndex == 4) hakatBall = 400;
            if (comboBox11.SelectedIndex == 1) hakatBall = hakatBall * 2;
            if (comboBox11.SelectedIndex == 2) hakatBall = hakatBall * 3;

            int debatBall = 0;
            if (comboBox4.SelectedIndex == 1) debatBall = 100;
            if (comboBox4.SelectedIndex == 2) debatBall = 200;
            if (comboBox4.SelectedIndex == 3) debatBall = 300;
            if (comboBox4.SelectedIndex == 4) debatBall = 400;
            if (comboBox12.SelectedIndex == 1) debatBall = debatBall * 2;
            if (comboBox12.SelectedIndex == 2) debatBall = debatBall * 3;

            int sportBall = 0;
            if (comboBox5.SelectedIndex == 1) sportBall = 100;
            if (comboBox5.SelectedIndex == 2) sportBall = 200;
            if (comboBox5.SelectedIndex == 3) sportBall = 300;
            if (comboBox5.SelectedIndex == 4) sportBall = 400;
            if (comboBox5.SelectedIndex == 5) sportBall = 500;
            if (comboBox13.SelectedIndex == 1) sportBall = sportBall * 2;
            if (comboBox13.SelectedIndex == 2) sportBall = sportBall * 3;

            int statyaBall = 0;
            if (comboBox6.SelectedIndex == 1) statyaBall = 100;
            if (comboBox6.SelectedIndex == 2) statyaBall = 200;
            if (comboBox6.SelectedIndex == 3) statyaBall = 300;
            if (comboBox6.SelectedIndex == 4) statyaBall = 400;
            if (comboBox14.SelectedIndex == 1) statyaBall = statyaBall * 2;

            int liderBall = 0;
            if (comboBox7.SelectedIndex == 1) liderBall = 100;
            if (comboBox7.SelectedIndex == 2) liderBall = 200;
            if (comboBox7.SelectedIndex == 3) liderBall = 300;
            if (comboBox7.SelectedIndex == 4) liderBall = 400;
            if (comboBox15.SelectedIndex == 1) liderBall = liderBall * 2;

            int volontBall = 0;
            if (comboBox8.SelectedIndex == 1) volontBall = 100;
            if (comboBox8.SelectedIndex == 2) volontBall = 200;
            if (comboBox8.SelectedIndex == 3) volontBall = 300;
            if (comboBox16.SelectedIndex == 1) volontBall = volontBall * 2;
            if (comboBox16.SelectedIndex == 2) volontBall = volontBall * 3;
            int gpaBall = (int)(gpaSan * 50);
            int entBall = entSan * 5;
            int satBall = entSan * 5;
            double ieltsball = ieltsSan * 20;
            double total = olimpBall + stajBall + hakatBall + debatBall
                      + sportBall + statyaBall + liderBall + volontBall + entBall + gpaBall+ ieltsball;

            textBox1.Text = total.ToString();
            listBox1.Items.Clear();
            listBox1.Items.Add("Олимпиада: " + olimpBall);
            listBox1.Items.Add("Стажировка: " + stajBall);
            listBox1.Items.Add("Хакатон: " + hakatBall);
            listBox1.Items.Add("Дебаты: " + debatBall);
            listBox1.Items.Add("Спорт: " + sportBall);
            listBox1.Items.Add("Статья: " + statyaBall);
            listBox1.Items.Add("Лидерство: " + liderBall);
            listBox1.Items.Add("Волонтёрство: " + volontBall);

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox1.Items[i] = "✔ " + listBox1.Items[i];
            }

            if (total < 500) MessageBox.Show("Ваш рейтинг: " + total + "\nУровень: Базовый", "Результат");
            else if (total < 1200) MessageBox.Show("Ваш рейтинг: " + total + "\nУровень: Средний", "Результат");
            else if (total < 2500) MessageBox.Show("Ваш рейтинг: " + total + "\nУровень: Высокий", "Результат");
            else MessageBox.Show("Ваш рейтинг: " + total + "\nУровень: Топ!", "Результат");}}}
