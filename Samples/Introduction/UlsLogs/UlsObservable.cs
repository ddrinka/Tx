﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;

namespace UlsLogs
{
    public class UlsObservable
    {
        public static IObservable<UlsRecord> FromFiles(params string[] files)
        {
            return UlsEnumerable.FromFiles(files).ToObservable();
        }
    }
}
