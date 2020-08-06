// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.
﻿using System;
using System.Threading.Tasks;
using Luna.Data.Entities;

namespace Luna.Services.Data
{
    public interface IIpAddressService
    {
        Task<IpAddress> TryAssignIpAddress(Guid subscriptionId, string offerName, string ipConfigName);
        Task UnassignIpAddresses(Guid subscriptionId);
    }
}
