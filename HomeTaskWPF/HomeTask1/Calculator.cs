using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;


namespace HomeTask5
{
    class Calculator
    {
        //Метод подсчета сщгласно нажатой кнопки
        public static string calculator(Button button, string val1, string val2 )
        {


            var v1 = Convert.ToDouble(val1.Trim());
            var v2 = Convert.ToDouble(val2.Trim());
            
            switch (button.Content.ToString())
            {

                case "/":
                {
                    if (v2 != 0)
                    {
                        return Convert.ToString(v1 / v2);
                    }
                    else
                    {
                        MessageBox.Show("Деление на ноль запрещено.");
                    }
                    break;
                }
                case "*":
                {
                    
                        return Convert.ToString(v1 * v2);

                   break;
                }
                case "-":
                {
                    return Convert.ToString(v1 - v2);
                        break;
                }
                case "+":
                {
                    return Convert.ToString(v1 + v2);
                    break;
                }
                    

            }

            return Convert.ToString(v1);
        }

    }
}
