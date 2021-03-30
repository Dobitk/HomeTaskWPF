using System;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using HomeTask5;

namespace HomeTask1
{



    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public string val1 = "";//Первое число ввода
        public string val2 = "";//Второе число ввода;
        Button button;//Для ввода в метод подсчета
        private bool clear = false;
        public void InCalc(Button button, TextBox textBox)
        {
            //Присваевам переменной длину строки
            var n = textBox.Text.Length;
            //Вводить не больше 18 символов
            if (n < 18)
            {
                //Вводим в TextBox числа согласно наименования клавиши
                textBox.Text = textBox.Text.Insert(n, button.Content.ToString());
                //ActiveControl = textBox;
            }


            //return richTextBox.Text;
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            //this.Content = "Калькулятор";
            this.TextBox1.Focusable = true;
            Keyboard.Focus(this.TextBox1);

            double screenHeight = SystemParameters.FullPrimaryScreenHeight;
            double screenWidth = SystemParameters.FullPrimaryScreenWidth;
            this.Top = (screenHeight - this.ActualHeight) / 2;
            this.Left = (screenWidth - this.ActualWidth) / 2;

            this.TextBox1.Text = "";
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            if (clear)
            {
                this.TextBox1.Clear();
                clear = false;
            }

            InCalc(One, this.TextBox1);
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            if (clear)
            {
                this.TextBox1.Clear();
                clear = false;
            }

            InCalc(Two, this.TextBox1);
        }

        private void Tree_Click(object sender, RoutedEventArgs e)
        {
            if (clear)
            {
                this.TextBox1.Clear();
                clear = false;
            }
            InCalc(Tree, this.TextBox1);
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            if (clear)
            {
                this.TextBox1.Clear();
                clear = false;
            }
            InCalc(Four, this.TextBox1);
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            if (clear)
            {
                this.TextBox1.Clear();
                clear = false;
            }
            InCalc(Five, this.TextBox1);
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            if (clear)
            {
                this.TextBox1.Clear();
                clear = false;
            }
            InCalc(Six, this.TextBox1);
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            if (clear)
            {
                this.TextBox1.Clear();
                clear = false;
            }
            InCalc(Seven, this.TextBox1);
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            if (clear)
            {
                this.TextBox1.Clear();
                clear = false;
            }
            InCalc(Eight, this.TextBox1);
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            if (clear)
            {
                this.TextBox1.Clear();
                clear = false;
            }
            InCalc(Nine, this.TextBox1);
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            if (clear) 
            {
                this.TextBox1.Clear();
                clear = false;
            }
            InCalc(Zero, this.TextBox1);
        }

        private void Point_Click(object sender, RoutedEventArgs e)
        {
            InCalc(Point, this.TextBox1);
        }

        private void Eraser_Click(object sender, RoutedEventArgs e)
        {
            this.TextBox1.Clear();
            val1 = "";
            val2 = "";
            
        }

        private void division_Click(object sender, RoutedEventArgs e)
        {
            val1 = this.TextBox1.Text.Trim();//Присваеваем первое значение
            button = this.division;            //Присваеваем для метода calculator
            this.TextBox1.Clear();//Очищаем TexBox
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
                val1 = this.TextBox1.Text.Trim();//Присваеваем первое значение
                button = this.Multiply;            //Присваеваем для метода calculator
                this.TextBox1.Clear();//Очищаем TexBox

        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            val1 = this.TextBox1.Text.Trim();//Присваеваем первое значение
            button = this.Minus;            //Присваеваем для метода calculator
            this.TextBox1.Clear();//Очищаем TexBox
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            val1 = this.TextBox1.Text.Trim();//Присваеваем первое значение
            button = this.Plus;            //Присваеваем для метода calculator
            this.TextBox1.Clear();//Очищаем TexBox
        }

        private void Equally_Click(object sender, RoutedEventArgs e)
        {
            if (val1 != "")
            {
                val2 = this.TextBox1.Text.Trim();
                this.TextBox1.Clear();//Очищаем TexBox

                this.TextBox1.Text = Calculator.calculator(button, val1, val2);
                val1 = "";
                val2 = "";
                clear = true;
                

            }
        }



        private void TextBox1_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Return)
            {
                 Equally.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
            }
            if (e.Key == Key.Escape)
            {
                Eraser.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
            }

        }

       

        private void TextBox1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

            int val;
            if (!Int32.TryParse(e.Text, out val) && e.Text != ".")
            {
                e.Handled = true; // отклоняем ввод


            }
            
            if (string.Compare(e.Text, "*") == 0)//Сравнение строки
            {
                Multiply.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));//Запускаем метод нажатия на кнопку
            }

            //Нажатие деления
            if (string.Compare(e.Text, "/") == 0)//Сравнение строки
            {
                division.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
            }

            //Нажатие вычитания
            if (string.Compare(e.Text, "-") == 0)//Сравнение строки
            {
                Minus.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
            }

            //Нажатие сложения
            if (string.Compare(e.Text, "+") == 0)//Сравнение строки
            {
                Plus.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
            }

        }
    }
}
