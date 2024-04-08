using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator;
public partial class MainWindow : Window
{

    private double num1 = 0;
    private double num2 = 0;
    private string operation = "";
    private bool pushed = false;


    public MainWindow()
    {
        InitializeComponent();
    }

    private void bero_Click(object sender, RoutedEventArgs e)
    {
        results.Content += ("^");
    }

    private void zero_Click(object sender, RoutedEventArgs e)
    {
        results.Content += ("0");
        num1 = 0;
        num2 = 0;

    }

    private void one_Click(object sender, RoutedEventArgs e)
    {
        results.Content += ("1");
        if (pushed)
        {
            num2 = 1;

        }
        else
        {
            num1 = 1;
        }
    }

    private void two_Click(object sender, RoutedEventArgs e)
    {
        results.Content += ("2");
        if (pushed)
        {
            num2 = 2;
            
        }
        else
        {
            num1 = 2;
        }
    }

    private void three_Click(object sender, RoutedEventArgs e)
    {
        results.Content += ("3");
        if (pushed)
        {
            num2 = 3;

        }
        else
        {
            num1 = 3;
        }
    }

    private void four_Click(object sender, RoutedEventArgs e)
    {
        results.Content += ("4");
        if (pushed)
        {
            num2 = 4;

        }
        else
        {
            num1 = 4;
        }
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        results.Content += ("5");
        if (pushed)
        {
            num2 = 5;

        }
        else
        {
            num1 = 5;
        }
    }

    private void six_Click(object sender, RoutedEventArgs e)
    {
        results.Content += ("6");
        if (pushed)
        {
            num2 = 6;

        }
        else
        {
            num1 = 6;
        }
    }

    private void seven_Click(object sender, RoutedEventArgs e)
    {
        results.Content += ("7");
        if (pushed)
        {
            num2 = 7;

        }
        else
        {
            num1 = 7;
        }
    }

    private void eight_Click(object sender, RoutedEventArgs e)
    {
        results.Content += ("8");
        if (pushed)
        {
            num2 = 8;

        }
        else
        {
            num1 = 8;
        }
    }

    private void nine_Click(object sender, RoutedEventArgs e)
    {
        results.Content += ("9");
        if (pushed)
        {
            num2 = 9;

        }
        else
        {
            num1 = 9;
        }
    }

    private void plus_Click(object sender, RoutedEventArgs e)
    {
        results.Content += ("+");
        operation = "+";
        pushed = true;
    }

    private void times_Click(object sender, RoutedEventArgs e)
    {
        results.Content += ("*");
        operation = "*";
        pushed = true;
    }

    private void minus_Click(object sender, RoutedEventArgs e)
    {
        results.Content += ("-");
        operation = "-";
        pushed = true;
    }

    private void division_Click(object sender, RoutedEventArgs e)
    {
        results.Content += ("/");
        operation = "/";
        pushed = true;
    }

    private void a_Click(object sender, RoutedEventArgs e)
    {
        results.Content = ("√");
    }

    private void delete_Click(object sender, RoutedEventArgs e)
    {
        results.Content = delete.DataContext as string;
    }
    private void equel_Click(object sender, RoutedEventArgs e)
    {

        double result = 0;

        switch (operation)
        {
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":

                if (num2 != 0)
                    result = num1 / num2;
                else
                    results.Content = "Nullával nem osztható";
                break;
        }
        results.Content = result;

    }
}


