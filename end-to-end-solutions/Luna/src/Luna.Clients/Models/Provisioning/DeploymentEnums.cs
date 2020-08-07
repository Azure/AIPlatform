// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

namespace Luna.Clients.Models.Provisioning
{
    public enum DeploymentMode
    {
        Complete,
        Incremental
    }

    public enum DeploymentRollback
    {
        LastSuccessful,
        SpecificDeployment
    }
}