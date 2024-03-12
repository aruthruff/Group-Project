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
        public int numberOfLanes = 2;  //Set number of lanes to 2 because default value is 0    
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

        public Motorway(string street, string direct, string surf, string maint) //Additions method for flexibility to test remaining data members
        { 
            streetType = street;
            direction = direct;
            surface = surf;
            tollMaintain = maint;
        }

        public Motorway(string highway, string Toll, int lanes, string street, string direct, string surf, string maint) //Additional method for flexibility to test all data members
        {
            highwayName = highway;
            toll = Toll;
            numberOfLanes = lanes;
            streetType = street;
            direction = direct;
            surface = surf;
            tollMaintain = maint;
        }
        public override string ToString() //ToString method to return data members and labels
        {
            return "\nName of Motorway: " + highwayName  + "\nToll: " + toll + "\nNumber of Lanes: " + numberOfLanes + "\nStreet Type: " +streetType + "\nDirection: " 
                + direction + "\nSurface Type: " + surface + "\nMaintained by: " + tollMaintain;
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Motorway motorway = new Motorway("US Highway 80"); //Call Instance method for highway name
            WriteLine(motorway);
            
            Motorway toll = new Motorway("International Highway 10", "Yes"); //Call Instance method for highway name and toll
            WriteLine(toll);
            
            Motorway lanes = new Motorway("State Highway 99", 5); //Call Instance method for highway name and number of lanes
            WriteLine(lanes);

            Motorway test = new Motorway("Boulevard", "North", "Blacktop", "State"); //Call Instance method to test remaining data members
            WriteLine(test);

            Motorway test2 = new Motorway("Hiawatha Forest Highway", "No", 3, "Highway", "South", "Concrete", "Federal"); //Call Instance method to test all data members
            WriteLine(test2);

            ReadKey();
        }
    }
}
            

            
        



       
        
        

       






