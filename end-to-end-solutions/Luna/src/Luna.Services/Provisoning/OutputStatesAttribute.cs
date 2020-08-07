// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

﻿using System;
using Luna.Data.Enums;

namespace Luna.Services.Provisoning
{
    [AttributeUsage(AttributeTargets.Method)]
    public class OutputStatesAttribute: ValidStatesAttribute
    {
        public OutputStatesAttribute(params ProvisioningState[] states) : base(states)
        {

        }
    }
}
