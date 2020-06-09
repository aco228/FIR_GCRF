using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;

namespace FIR_GCRF
{

  class Program
  {

    // Lokacija za kreiranje fajla
    const string FOLDER_LOCATION = @"C:\Users\aleks\Desktop\GCRF_GUI_TOOL-master\GCRFsTOOL\domaci\";
    const int BROJ_CVOROVA = 50;
    static Dictionary<string, string> FILES = new Dictionary<string, string>();

    static void Main(string[] args)
    {
      string file_location = FOLDER_LOCATION + "AleksandarKonatar_Assigment4";

      FILES.Add("xTrain", ""); FILES.Add("xTest", "");
      FILES.Add("yTrain", ""); FILES.Add("yTest", "");
      FILES.Add("sTrain", ""); FILES.Add("sTest", "");
      var rnd = new Random();
      
      for(int i = 0; i < BROJ_CVOROVA; i++)
      {
        FILES["sTrain"] += string.Format("{0},{1},{2}", rnd.Next(1, BROJ_CVOROVA), rnd.Next(1, BROJ_CVOROVA), rnd.Next(0, 10)) + Environment.NewLine;
        FILES["sTest"] += string.Format("{0},{1},{2}", rnd.Next(1, BROJ_CVOROVA), rnd.Next(1, BROJ_CVOROVA), rnd.Next(0, 10)) + Environment.NewLine;

        FILES["xTrain"] += string.Format("{0}", rnd.Next(0, BROJ_CVOROVA)) + Environment.NewLine;
        FILES["xTest"] += string.Format("{0}", rnd.Next(0, BROJ_CVOROVA)) + Environment.NewLine;

        FILES["yTrain"] += string.Format("{0}", rnd.Next(0, BROJ_CVOROVA)) + Environment.NewLine;
        FILES["yTest"] += string.Format("{0}", rnd.Next(0, BROJ_CVOROVA)) + Environment.NewLine;
      }


      // pisanje fajlova
      foreach(var f in FILES)
        File.WriteAllText(file_location + $"_{f.Key}.txt", f.Value);

      Console.WriteLine("Zavrseno!");
    }
  }
}
