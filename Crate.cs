using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///////////////////////////////////////////////////////////////////////////////
//
// Author: Jerry Galloway
// Course: CSCI-2210-001 - Data Structures
// Assignment: Project 4
// Description: Building a warehouse
// Additional comments: Gonna fail, dawg
///////////////////////////////////////////////////////////////////////////////



namespace Warehouse
{
    internal class Crate
    {
        
      public string Id;
         public double Price 
        {
            get {
                Random rnd = new Random();
                int  Range = 500;
                double RPrice = rnd.NextDouble()* Range;
                return Price;
       } }
    }
}
