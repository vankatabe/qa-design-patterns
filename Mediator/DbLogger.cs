﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class DbLogger : ILogger
    {
        private string _name = "MS SQL DB";

        public void SendMessage(ILogMediator mediator, string message)
        {
            mediator.DistributeMessage(this, message);
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine(this._name + " received " + message);
        }
    }
}
