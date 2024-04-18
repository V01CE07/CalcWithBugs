using Avalonia.Controls;
using Avalonia.Interactivity;
using System;
using System.Numerics;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EngineCalcDrozdov
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            inputCalc.Text = "0";

            
        }

        public void clickNegativeDegree(object? sender, RoutedEventArgs args)
        {

        }
        public void clickSkobkaRight(object? sender, RoutedEventArgs args)
        {
            inputCalc.Text += ")";
        }
        public void clickSkobkaLeft(object? sender, RoutedEventArgs args)
        {
            inputCalc.Text += "(";
        }
        public void clickDecimal(object? sender, RoutedEventArgs args)
        {
            inputCalc.Text += ",";
           

        }

        public void clickEqual(object? sender, RoutedEventArgs args)
        {
            string strEqual = inputCalc.Text!;
            string[] equalParts = strEqual.Split(' ');
            double firstOperand = double.Parse(equalParts[0]);
            double secondOperand = double.Parse(equalParts[2]);
            char operation = char.Parse(equalParts[1]);

            double equalResult = 0;
           
            switch(operation)
            {
                case '+':
                    {
                        equalResult = firstOperand + secondOperand;
                        
                    }
                    break;
                case '-':
                    {
                        equalResult = firstOperand - secondOperand;
                    }
                    break;
                case '×':
                    {
                        equalResult = firstOperand * secondOperand;
                    }
                    break;
                case '÷':
                    {
                        if (secondOperand != 0)
                        {
                            equalResult = firstOperand / secondOperand;
                        }
                        else
                        {
                            inputCalc.Text = "Error";
                        }
                        
                    }
                    break;
                case '^':
                    {
                        equalResult = Math.Pow(firstOperand, secondOperand);
                    }
                    break;
               



            }
            inputCalc.Text = equalResult.ToString();

        }
        private void clickNumber (object? sender, RoutedEventArgs args)
        {
            var button = sender as Button;

            if (inputCalc.Text == "0")
            {
                inputCalc.Text = null;
            }

            switch (button.Name)
            {
                case "zero":
                    {
                        inputCalc.Text += "0";
                        
                    }
                    break;
                case "one":
                    {   
                        inputCalc.Text += "1";
                        
                    }
                    break;
                case "two":
                    {
                        inputCalc.Text += "2";
                    }
                    break;
                case "three":
                    {
                        inputCalc.Text += "3";
                    }
                    break;
                case "four":
                    {
                        inputCalc.Text += "4";
                    }
                    break;
                case "five":
                    {
                        inputCalc.Text += "5";

                    }
                    break;
                case "six":
                    {
                        inputCalc.Text += "6";
                    }
                    break;
                case "seven":
                    {
                        inputCalc.Text += "7";
                    }
                    break;
                case "eight":
                    {
                        inputCalc.Text += "8";
                    }
                    break;
                case "nine":
                    {
                        inputCalc.Text += "9";
                    }
                    break;


            }
           
        }
        private async void clickOperations (object? sender, RoutedEventArgs args)
        {
            var button = sender as Button;

            if (inputCalc.Text == "0")
            {
                inputCalc.Text = null;
            }

            switch (button.Name)
            {
                            
                case "factorial":
                    {
                        double ParseFactorial = double.Parse(inputCalc.Text!);
                        long factorial = 1;
                        for (int i = 1; i <= ParseFactorial; i++)
                        {                          
                            factorial *= i;
                        }
                        inputCalc.Text = factorial.ToString();
                        outputCalc.Text = "Факториал от числа " + ParseFactorial;

                    }
                    break;
                case "deleteAll":
                    {
                        inputCalc.Text = null;
                        outputCalc.Text = null;
                    }
                    break;
                case "plus":
                    {
                        inputCalc.Text += " + ";
                    }
                    break;
                case "minus":
                    {
                        inputCalc.Text += " - ";
                    }
                    break;

                case "multiply":
                    {
                        inputCalc.Text += " × ";
                    }
                    break;
                case "div":
                    {
                        inputCalc.Text += " ÷ ";
                    }
                    break;
                case "positiveDegree":
                    {
                        inputCalc.Text += " ^ ";
                    }
                    break;
                case "mathRoot":
                    {
                        double sqrtNumber = double.Parse(inputCalc.Text);
                        double sqrt = Math.Sqrt(sqrtNumber);
                        inputCalc.Text = sqrt.ToString();   
                    }
                    break;
                case "pi":
                    {
                        double piNumber = double.Parse(inputCalc.Text);
                        double pi = Math.PI * piNumber;
                        pi = Math.Round(pi, 5);
                        inputCalc.Text = pi.ToString();
                        outputCalc.Text = "Примерный результат числа π от " + piNumber;
                        outputCalc.FontSize = 14;

                    }
                    break;
                case "lg":
                    {
                        double LgNumber = double.Parse(inputCalc.Text);
                        double lg = Math.Log10(LgNumber);
                        inputCalc.Text = lg.ToString();
                        outputCalc.Text = "Десятичный логарифм от числа " + LgNumber;
                    }
                    break;
                case "Ln":
                    {
                        double LnNumber = double.Parse(inputCalc.Text);
                        double ln = Math.Log(LnNumber);
                        inputCalc.Text = ln.ToString();
                        outputCalc.Text = "Натуральный логарифм от числа " + LnNumber;
                    }
                    break;
                case "delOneChar":
                    {
                        string delOne = inputCalc.Text!;
                        int lastChar = delOne.Length - 1;
                        delOne = delOne.Remove(lastChar);
                        inputCalc.Text = delOne;
                        
                    }
                    break;
                case "percent":
                    {
                        double percentNumber = double.Parse(inputCalc.Text!);
                        double percentNumberDel = percentNumber / 100;
                        inputCalc.Text = percentNumberDel.ToString();
                        outputCalc.Text = "Процент от числа " + percentNumber.ToString();
                    }
                    break;
                case "sin":
                    {
                        double sin = double.Parse(inputCalc.Text!);
                        
                        double sinRadian = sin * Math.PI / 180;
                        double sinNumber = Math.Round(Math.Sin(sinRadian), 4);    
                        inputCalc.Text = sinNumber.ToString();
                        outputCalc.Text = "Синус угла " + sin.ToString();
                    }
                    break;
                case "cos":
                    {
                        double cos = double.Parse(inputCalc.Text!);
                        double cosNumber = Math.Cos(cos);
                        inputCalc.Text = cosNumber.ToString();
                        outputCalc.Text = "Косинус угла " + cos.ToString();
                    }
                    break;
                case "tg":
                    {
                        double tg = double.Parse(inputCalc.Text!);
                        double tgNumber = Math.Tan(tg);
                        inputCalc.Text = tgNumber.ToString();
                        outputCalc.Text = "Тангенс угла " + tg.ToString();
                    }
                    break;
                case "ctg":
                    {
                        double ctg = double.Parse(inputCalc.Text!);
                        double ctgNumber = ctg / Math.Tan(ctg);
                        inputCalc.Text = ctgNumber.ToString();
                        outputCalc.Text = "Котангенс угла " + ctg.ToString();
                    }
                    break;
                default:
                    {
                        inputCalc.Text = "Error";
                    }
                    return;

            }

        }

    }
}