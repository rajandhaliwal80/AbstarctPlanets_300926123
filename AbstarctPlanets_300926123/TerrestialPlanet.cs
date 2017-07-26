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
/// Version 0.1 Created TerrestialPlanet Class
/// /// </summary>

namespace AbstarctPlanets_300926123
{
    class TerrestialPlanet:Planet
    {
        //PRIVATE INSTANCE VARIABLES
        private bool _oxygen;

        //Constructor---------------------------------------------
        /// <summary>
        /// This is the terrestial planet constructor. it takes 5 arguments 3 of them are derived from planet class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="oxygen"></param>
        /// <param name="moonCount"></param>
        public TerrestialPlanet(string name, double diameter, double mass, bool oxygen, int moonCount) : base(name, diameter, mass)
        {
            _oxygen = oxygen;
           
        }
        //Implemented Interface Method
    }
}
