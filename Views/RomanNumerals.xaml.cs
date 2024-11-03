using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roman.Custom;

namespace Roman.Views;

public partial class RomanNumerals : ContentPage
{
    public RomanNumerals()
    {
        InitializeComponent();
        Title = "Numbers To Roman Numerals";
    }

    private void ConvertRomanNumeral(object sender, EventArgs e)
    {
        int num = 0;
        Converter n2r = new Converter();

        num = int.Parse(txtRoman.Text); // Parse the input text as an integer

        txtNumbers.Text = n2r.NumberToRoman(num).ToString(); //Convert integer to string display in label
    }
}