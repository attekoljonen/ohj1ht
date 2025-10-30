using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

/// @author Atte Koljonen
/// @version 29.10.2025
/// <summary>
/// 
/// </summary>
public class Harjoitustyö_50
{
    /// <summary>
    /// Lottokone joka tulostaa arpanumerot väliltä 1-50 ja 1-12
    /// Ohjelmasta puuttuu vielä lisänumeroiden tulostaminen sekä logiikka, jossa käytetään vain uniikkeja numeroita
    /// </summary>
    public static void Main()
    {
        Console.WriteLine("Monta riviä tehdään?");
        Console.WriteLine(" ");
        int rivit = int.Parse(Console.ReadLine()); 
        Console.Write(rivit);

        List<int> primary = new List<int>();

        for (int i = 1; i <= 50; i++)
        {
            primary.Add(i);
        }

        List<int> secondary = new List<int>();

        for (int i = 1; i <= 12; i++)
        {
            secondary.Add(i);
        } 
        ///Console.WriteLine(String.Join(",", primary));
        // Console.WriteLine(String.Join(",", secondary));

        arpaKone(rivit);
        
    }
    

    public static void arpaKone(int rivit)
    {
        Random arvontaRivit = new Random();
        
        
        if (rivit <= 10)
        {
            for (int i = 1; i <= rivit; i++)
                // Console.WriteLine($"Arvontarivi: {i}");
            for (int j = 1; j <= 5; j++)
                
          // tarvitaan satunnaisuutta
            
            for (int y = 1; y <= 2; y++)
                
                
                // tämä pitäisi saada tulostettua paremmin "Arvotut luvut" +" " + i + + y + " " +
                Console.WriteLine( arvontaRivit.Next(51) + " ");
            
        }
        else
        {
            Console.WriteLine (" Eipäs tehdä yli 10 riviä, niin ei mene uhkapeliksi");
        }
    }
}