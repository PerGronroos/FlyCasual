﻿using Editions;
using Ship;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Editions;

namespace Tokens
{

    public class JamToken : GenericToken
    {
        public JamToken(GenericShip host) : base(host)
        {
            Name = "Jam Token";
            ImageName = (Edition.Current is SecondEdition) ? "Jam Token SE" : "Jam Token FE";
            Temporary = Edition.Current is SecondEdition;
            TokenColor = TokenColors.Orange;
            PriorityUI = 40;
            Tooltip = "https://raw.githubusercontent.com/guidokessels/xwing-data/master/images/reference-cards/ReloadActionAndJamTokens.png";
        }
    }

}
