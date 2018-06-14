﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;


namespace Microsoft.Azure.SignalR.Samples.ChatRoom
{
    public class PolicyBasedAuthHandler : AuthorizationHandler<PolicyBasedAuthRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context,
            PolicyBasedAuthRequirement requirement)
        {
            if (context.User.IsInRole("Admin"))
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}
