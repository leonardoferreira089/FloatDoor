﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatDoor.Core.Entities
{
    public abstract class BaseEntity
    {
        public BaseEntity() { }

        public int Id { get; private set; }
    }
}
