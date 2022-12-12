﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public delegate void FakeEventHandler(string reason);
    public class FakeEventRaiser
    {
        private FakeEventHandler currentHandler = null;

        public void AddHandler(FakeEventHandler handler)
        {
            currentHandler = currentHandler + handler;
        }

        public void RemoveHandler(FakeEventHandler handler)
        {
            currentHandler = currentHandler - handler;
        }

        public void DoSomething(string text)
        {
            FakeEventHandler tmp = currentHandler;
            if(currentHandler != null)
            {
                tmp.Invoke(text);
            }
        }
    }
}
