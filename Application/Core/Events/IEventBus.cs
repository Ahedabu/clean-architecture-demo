﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Core.Events
{
    public interface IEventBus
    {
        void Raise(IEvent @event);
    }
}
