﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglePlayerTicTacToe.Exceptions
{
    internal class AlreadyUsedPlaceException:Exception
    {
        public AlreadyUsedPlaceException(string message) : base(message) { }
    }
}