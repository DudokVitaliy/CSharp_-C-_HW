using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace OOP_intro_HW
{
    partial class Freezer
    {
        public void Print()
        {
            WriteLine("\tFreezer");
            WriteLine($"brand = {brand}");
            WriteLine($"model = {model}");
            WriteLine($"color = {color}");
            WriteLine($"power = {power}V");
            WriteLine($"volume = {volume}L");
        }
        public override string ToString()
        {
            return $"brand = {brand}\nmodel = {model}\ncolor = {color}\npower = {power}V\nvolume = {volume}L\n";
        }
        public static int GetCount()
        {
            return count;
        }
    }
}
