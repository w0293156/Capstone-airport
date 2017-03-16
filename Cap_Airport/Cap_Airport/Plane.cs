using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap_Airport
{
    public class Plane : MovingObj
    {
        public string planeID;
        private string destination;
        private string departureTime;
        private string arrivalTime;
        private bool isInService = false;
        private bool isWaiting = false;
        private bool isTakeoff = true;

        public Plane (Position p, Direction d, int altitude, int speed, string planeID)
        {
            this.planeID = planeID;
            if (altitude == 0)
            {
                isTakeoff = false;
            }
        }

        public string GetPlaneID()
        {
            return planeID;
        }
    }
}
