using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CerealProblems.csv;
{ 
    List<CerealProblem> allCereals = new List<CerealProblem>();
            string[] linesOfFile = linesOfFile.ReadAllLines("cereal.csv");
            for (int i = 1; i < linesOfFile.Length; i++)
            {
                string line = linesOfFile[i];
                string[] parts = line.Split('!');
                Cereal c = new Cereal();
                c.Name = parts[0];
                c.Manufacturer = parts[1];
                c.Calories = double.Parse(parts[2]);
                c.Cups = double.Parse(parts[3]);

                allCereals.Add(c);
            }
    foreach (int creal in allCereals)
    {
        Console.WriteLine(cereal);
    }
