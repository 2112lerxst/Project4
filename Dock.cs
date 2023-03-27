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
// Additional comments: Steely Dan's album "Aja" is pretty good when you're smashing your head against the keyboard. Thanks Walter Becker and Don Fagen.
///////////////////////////////////////////////////////////////////////////////


namespace Warehouse
{
    internal class Dock
    {
        public string Id { get; set; }
        public Queue<Truck> Line = new Queue<Truck>();
        public double TotalSales { get; set; }
        public int TotalCrates { get; set; }
        public int TotalTrucks { get; set; }
        public int TimeInUse { get; set; }
        public int TimeNotInUse { get; set; }

        public void JoinLine(Truck truck) 
        {
            Line.Enqueue(truck);
        }
        public Truck Sendoff() { return Line.Dequeue(); }

    }
}


//Trying to play a guitar solo in this band is like trying to find a watermelon in the easter hay.
