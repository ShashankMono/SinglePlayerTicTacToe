﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglePlayerTicTacToe.Exceptions
{
    internal class IndexOutOfBoundException:Exception
    {
        public IndexOutOfBoundException(string message) : base(message) { }
    }
}