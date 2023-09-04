// -----------------------------------------------------------------------
// <copyright file="CommonExtensions.cs" company="Exiled Team">
// Copyright (c) Exiled Team. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace Exiled.API.Extensions
{
    using System.Collections.Generic;
    using System.Linq;

    using UnityEngine;

    /// <summary>
    /// A set of extensions for common things.
    /// </summary>
    public static class CommonExtensions
    {
        /// <summary>
        /// Gets a random value from an <see cref="IEnumerable{T}"/>.
        /// </summary>
        /// <param name="enumerable"><see cref="IEnumerable{T}"/> to be used to get a random value.</param>
        /// <typeparam name="T">Type of <see cref="IEnumerable{T}"/> elements.</typeparam>
        /// <returns>Returns a random value from <see cref="IEnumerable{T}"/>.</returns>
        public static T GetRandomValue<T>(this IEnumerable<T> enumerable) => enumerable is null || enumerable.Count() == 0 ? default : enumerable.ElementAt(Random.Range(0, enumerable.Count()));

        /// <summary>
        /// Gets a random value from an <see cref="IEnumerable{T}"/> that matches the provided condition.
        /// </summary>
        /// <param name="enumerable"><see cref="IEnumerable{T}"/> to be used to get a random value.</param>
        /// <typeparam name="T">Type of <see cref="IEnumerable{T}"/> elements.</typeparam>
        /// <param name="condition">The condition to require.</param>
        /// <returns>Returns a random value from <see cref="IEnumerable{T}"/>.</returns>
        public static T GetRandomValue<T>(this IEnumerable<T> enumerable, System.Func<T, bool> condition) => enumerable is null || enumerable.Count() == 0 ? default : enumerable.Where(condition).GetRandomValue();
    }
}