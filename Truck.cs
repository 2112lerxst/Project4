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
// Additional comments: I gotta go, but my friend's can stick around.
///////////////////////////////////////////////////////////////////////////////


namespace Warehouse
{
    internal class Truck
    {
        public string driver { get; set; }
        public string deliveryCompany { get; set; }
        public Stack<Crate> Trailer = new Stack<Crate>();

        public Crate Unload()
        { return Trailer.Pop(); }

        public void Load(Crate crate)
        {
            Trailer.Push(crate);
        }
    }
}
