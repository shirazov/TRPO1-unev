// Данная программа предназначена для нахождения наименьшего и наибольшего кратного чисел.
// Имеется заданный натуральный диапазон, из двух чисел. Определить, наименьшее и наибольшее число, кратное двум числам.

// Входные данные: 
// del_1 - это первый делитель,   int
// del_2 - это второй делитель.   int
// niD - нижняя граница,          int
// vrD - верхняя граница          int

// Выходные данные:  
// БОК - большее общее кратное  int 
// МОК - меньшее общие кратное  int

// Авторы: Ширазов Хуршид Эралиевич и Козлов Артём 
// Версия 1.01 
// Дата последней корректировки: 01.02.2021

using System;                                                     
using System.Collections.Generic;                                 
using System.ComponentModel;                                      
using System.Data;                                                
using System.Drawing;                                             
using System.Linq;                                                
using System.Security.Cryptography.X509Certificates;              
using System.Text;                                                
using System.Threading.Tasks;                                     
using System.Windows.Forms;                                       

namespace ТРПО._1 // вход в главный метод                                           
{
    public partial class mainForm : Form // mainForm - это главная форма программы
    {
        public mainForm()
        {
            InitializeComponent();
        }

        
            public int x = 0;
            public int y = 0;
        

        private void button1_Click(object sender, EventArgs e)  // Обрабочик кнопки расчёт
        {
            if ((niD.Text != String.Empty) && (vrD.Text != String.Empty) && (del_1.Text != String.Empty) && (del_2.Text != String.Empty)) // проверка условия заполнены ли все поля 
            {
                if ((Int32.Parse(niD.Text) < Int32.Parse(vrD.Text))) // Условие что нижняя граница меньше верхней границы 
                {
                    if ((Int32.Parse(del_1.Text) <= Int32.Parse(vrD.Text)) && (Int32.Parse(del_2.Text) <= Int32.Parse(vrD.Text))) // Условие что делители находятся внутри диапазона
                    {
                        for (int i = Int32.Parse(niD.Text); i <= Int32.Parse(vrD.Text); i++)  // цикл для подсчёта БОК
                        {
                            if ((i % Int32.Parse(del_1.Text) == 0) && (i % Int32.Parse(del_2.Text) == 0))
                            {
                                int otvet = 0;
                                if (otvet < i)
                                    otvet = i;
                                label1.Text = Convert.ToString(otvet);  // Вывод ответа в лейбле 
                                x = otvet;
                            }
                           
                        }

                        for (int i = Int32.Parse(vrD.Text); i >= Int32.Parse(niD.Text); i--)   // цикл для подсчёта МОК
                        {
                            if ((i % Int32.Parse(del_1.Text) == 0) && (i % Int32.Parse(del_2.Text) == 0))
                            {
                                label2.Text = Convert.ToString(i); 
                                y = i;
                            }
                           
                        }

                        if (y != 0 && x != 0) // условие для понятия если кратные вообще 
                        
                            history.Nodes.Add(niD.Text + "--" + vrD.Text + "   " + ":(" + Int32.Parse(del_1.Text) + " & " +
                                Int32.Parse(del_2.Text) + ")  " + "МОК=" + " " + Convert.ToString(y) + "  " + "БОК=" +
                                Convert.ToString(x)); // Вывод хистори 
                       
                        else 
                            MessageBox.Show("Нет, общих кратных", "ОТВЕТ"); // Вывод сообщения ответ
                        x = 0;
                        y = 0;
                    }
                    else
                        MessageBox.Show("Делитель не должен выходить из диапазона!", "Ошибка"); 
                    
                }

                else
                    MessageBox.Show("Верний диапазон должен быть больше нижнего", "Ошибка"); 
                
            }

            else
                MessageBox.Show("Заполните все поля!", "Ошибка"); 
            
        }

        public void proverka(object sender, KeyPressEventArgs e)  // функиция проверки на дурака 
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) 
                e.Handled = true;
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) // проверка на ошибки поля ввода нижней границы диапазона поиска
        {
            proverka(sender, e);
        }

        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e) // проверка на ошибки поля ввода нижней границы диапазона поиска
        {
            proverka(sender, e);
        }

        private void info_Click(object sender, EventArgs e) // вывод информации о работе программы
        {
            MessageBox.Show("Программа создана студентами 9ПКС-1.18: \n Ширазов Хуршид и Козлов Артём \n \n  Данная программа предназначена для подсчёта минимального \n  и максимального общих кратных для введёного диапазона,\n  по введёным двум делителям", "Информация о программе");
        }

        private void button1_Click_1(object sender, EventArgs e) // очистка всех полей 
        {
            niD.Clear(); vrD.Clear(); del_1.Clear(); del_2.Clear(); history.Nodes.Clear(); label1.Text = null; label2.Text = null;
        }

        private void del_1_KeyPress(object sender, KeyPressEventArgs e)  // проверка на ошибки поля ввода 1 делителя
        {
            proverka(sender, e);
        }

        private void del_2_KeyPress(object sender, KeyPressEventArgs e)  // проверка на ошибки поля ввода 2 делителя
        {
            proverka(sender, e);
        }
    }
}
