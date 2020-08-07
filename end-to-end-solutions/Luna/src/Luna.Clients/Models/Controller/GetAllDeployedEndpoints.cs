// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Luna.Clients.Models.Controller
{
    public class GetAllDeployedEndpoints
    {
        public string deploymentId { get; set; }
        public string scoringUrl { get; set; }
        public string key { get; set; }
        public String description { get; set; }
    }
}
