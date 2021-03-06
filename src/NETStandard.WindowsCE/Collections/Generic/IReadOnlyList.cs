﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

/*============================================================
**
** Interface:  IReadOnlyList<T>
** 
** 
**
** Purpose: Base interface for read-only generic lists.
** 
===========================================================*/

#if NET35_CF
namespace System.Collections.Generic
#else
namespace Mock.System.Collections.Generic
#endif
{
    /// <summary>
    /// Provides a read-only, view of a generic list.
    /// </summary>
    public interface IReadOnlyList<T> : IReadOnlyCollection<T>
    {
        T this[int index] { get; }
    }
}