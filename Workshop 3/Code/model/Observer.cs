﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model
{
    interface Observer
    {
        void CardWasDealt (model.Player player);
    }
}
