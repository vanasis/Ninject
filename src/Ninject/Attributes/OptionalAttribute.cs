// -------------------------------------------------------------------------------------------------
// <copyright file="OptionalAttribute.cs" company="Ninject Project Contributors">
//   Copyright (c) 2007-2010, Enkari, Ltd.
//   Copyright (c) 2010-2017, Ninject Project Contributors
//   Dual-licensed under the Apache License, Version 2.0, and the Microsoft Public License (Ms-PL).
// </copyright>
// -------------------------------------------------------------------------------------------------

namespace Ninject
{
    using System;

    /// <summary>
    /// Indicates that the decorated member represents an optional dependency.
    /// </summary>
    [AttributeUsage(
        AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Parameter,
        AllowMultiple = false,
        Inherited = true)]
    public class OptionalAttribute : Attribute
    {
    }
}