/* 
 * Programmer: Anthony Ruthruff
 *             Richard Carson
 *             Nathan Wenson
 * Date: 03/11/2024
 * Class: CITP 180
 * Purpose: Program with Motorway Class, data members, instance methods, and ToString method to return data members
 * Assignment: Chapter 4 - Programming Excercise 3
 */

using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Week6_Group
{
    class Motorway
    {
        public string highwayName;  //List of data members
        public string streetType;
        public string direction;
        public string surface;
        public int numberOfLanes;
        public string toll;
        public string tollMaintain;

        public Motorway(string highway)  //Instance method for highway name
        {
            highwayName = highway;
            
        }

        public Motorway(string highway, string Toll) //Instance method for highway name and toll
        { 
            highwayName= highway;
            toll = Toll;
        }

        public Motorway(string highway, int lanes) //Instance method for highway name and number of lanes
        {
            highwayName = highway;
            numberOfLanes = lanes;
            
        }

        public override string ToString() //ToString method to return data members and labels
        {
            return "Name of Motorway: " + highwayName  + "\nToll: " + toll + "\nNumber of Lanes: " + numberOfLanes + "\nStreet Type: " +streetType + "\nDirection: " 
                + direction + "\nSurface Type: " + surface + "Maintained by: " + tollMaintain;
        }


    }
  
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Motorway motorway = new Motorway("I-96");
            WriteLine(motorway);
            WriteLine("");
            
            Motorway toll1 = new Motorway("I-96", "Yes");
            WriteLine(toll1);
            WriteLine("");
            
            Motorway lanes1 = new Motorway("I-96", 5);
            WriteLine(lanes1);


            ReadKey();

        }

    }

}
            

            
        



       
        
        

       






