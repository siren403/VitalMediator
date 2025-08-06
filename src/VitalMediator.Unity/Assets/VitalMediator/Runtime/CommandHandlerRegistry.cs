// Licensed to the.NET Foundation under one or more agreements.
// The.NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Concurrent;

namespace VitalMediator
{
    public class CommandHandlerRegistry : ConcurrentDictionary<Type, object>
    {
    }
}
