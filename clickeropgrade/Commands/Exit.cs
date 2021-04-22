using System;
using System.Collections.Generic;
using System.Text;

namespace clickeropgrade
{
    class Exit : ICommand
    {
        public void Run()
        {
            Environment.Exit(0);
        }
    }
}
