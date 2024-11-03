using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roman.Custom;

namespace Roman.Views;

public partial class Numbers : ContentPage
{
    public Numbers()
    {
        InitializeComponent();
        Title = "Roman Numerals To Numbers";
    }

    private void ConvertNumber(object sender, EventArgs e)
    {
        string roman = txtRomanNumeral.Text; //roman numeral variable user input
        Converter n2r = new Converter(); //instantiate object n2r from Converter class
        
        int num = n2r.RomanToNumber(roman); //int num variable to hold object n2r variable that is converted from string to integer.
        txtNumberDisplay.Text = num.ToString();
        
    }
}