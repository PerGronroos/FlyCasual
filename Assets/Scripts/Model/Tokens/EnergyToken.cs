﻿using Ship;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tokens
{

    public class EnergyToken : GenericToken
    {
        public EnergyToken(GenericShip host) : base(host)
        {
            Name = ImageName = "Energy Token";
            Temporary = false;
            PriorityUI = 10;
        }
    }

}
