﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPCMMS.Application.Contracts.Service
{
    public interface ILoggedInUserService
    {
        public string UserId { get; }
    }
}
