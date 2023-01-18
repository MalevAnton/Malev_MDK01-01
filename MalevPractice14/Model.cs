using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MalevPractice14
{
    public static class Model
    {
        static int a;
        static int b;
        static int result;
        public static List<string> datalist = new List<string> { "Сложение", "Вычитание", "Умножение", "Деление" };

        public static TextBlock tbResult;
        public static TextBlock tbArif;
        public static TextBox a1;
        public static TextBox a2;

        public static int Combo
        {
            set
            {
                if (datalist[value] == "Сложение")
                {
                    tbArif.Text = "+";
                }

                else if (datalist[value] == "Вычитание")
                {
                    tbArif.Text = "-";
                }

                else if (datalist[value] == "Умножение")
                {
                    tbArif.Text = "*";
                }

                else if (datalist[value] == "Деление")
                {
                    tbArif.Text = ":";
                }
            }
        }

        public static int Result
        {
            get
            {
                if (tbArif.Text == "Сложение")
                {
                    a = Convert.ToInt32(a1.Text);
                    b = Convert.ToInt32(a2.Text);
                    result = a + b;
                    return result;
                }

                else if (tbArif.Text == "Вычитание")
                {
                    a = Convert.ToInt32(a1.Text);
                    b = Convert.ToInt32(a2.Text);
                    result = a - b;
                    return result;
                }

                else if (tbArif.Text == "Умножение")
                {
                    a = Convert.ToInt32(a1.Text);
                    b = Convert.ToInt32(a2.Text);
                    result = a * b;
                    return result;
                }

                else if (tbArif.Text == "Деление")
                {
                    a = Convert.ToInt32(a1.Text);
                    b = Convert.ToInt32(a2.Text);
                    result = a / b;
                    return result;
                }

                return result;
            }

            set
            {
                result = value;
                tbResult.Text = result.ToString();
            }
        }
    }
}
