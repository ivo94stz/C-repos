using System;
using System.Collections.Generic;
using System.Text;


public class Smartphone
{
    public string Web(string url)
    {
        if (this.IsValidWeb(url))
        {
            return $"Browsing: {url}!";
        }
        else return "Invalid URL!";
    }

    public string Call(string number)
    {
        if (this.IsValidNumber(number))
        {
            return $"Calling... {number}";
        }
        else return "Invalid number!";
    }


    private bool IsValidWeb(string url)
    {
        for (int i = 0; i < url.Length; i++)
        {
            if (char.IsDigit(url[i])) return false;
        }
        return true;
    }
    private bool IsValidNumber(string number)
    {
        for (int i = 0; i < number.Length; i++)
        {
            if (!char.IsDigit(number[i])) return false;
        }
        return true;
    }
}
