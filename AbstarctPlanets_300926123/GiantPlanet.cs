using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Rajandeep Kaur Dhaliwal
/// 300926123
/// 7/25/2017
/// Comp123 Assignment04 Abstract Classes
/// This is a Giant Planet Class
/// Version 0.3 Added Constructor
/// /// </summary>
/// 

namespace AbstarctPlanets_300926123
{
    class GiantPlanet : Planet
    {
        //PRIVATE INSTANCE VARIABLES
        private string _type;
        private int _moonCount;
        private int _ringCount;

        //CONSTRUCTOR----------------------------------------------------
        /// <summary>
        /// this is a giantplanet constructor its takes 6 arguments. 3 of them are derived from planet class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="type"></param>
        /// <param name="moonCount"></param>
        /// <param name="ringCount"></param>
        public GiantPlanet(string name, double diameter, double mass, string type, int moonCount, int ringCount) : base(name, diameter, mass)
        {
            _type = type;
            _moonCount = moonCount;
            _ringCount = ringCount;
        }
        //defining derived Interface Methods
        public bool HasMoons()
        {
            if (MoonCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool HasRings()
        {
            if (RingCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
