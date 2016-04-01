// ----------------------------------------------------------------------------
// <Copyright File="Contents.cs" Company="FrancescoMagliocco"
//     Copyright (C) 2016 FrancescoMagliocco
// 
//     This program is free software: you can redistribute it and/or modify
//     it under the terms of the GNU General Public License as published by
//     the Free Software Foundation, either version 3 of the License, or
//     (at your option) any later version.
// 
//     This program is distributed in the hope that it will be useful,
//     but WITHOUT ANY WARRANTY; without even the implied warranty of
//     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//     GNU General Public License for more details.
// 
//     You should have received a copy of the GNU General Public License
//     along with this program.  If not, see <http://www.gnu.org/licenses/>.
// </copyright>
// <Contact Email="Magliocco.W.Francesco@Gmail.com"/>
// <Coded Year="2016">
//     <Month>03</Month>
//     <Day>31</Day>
//     <Time>15:46</Time>
// </Coded>
// ----------------------------------------------------------------------------

namespace FrancescoMagliocco.Utils.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    /// <summary>
    ///     Extensions invovling 'Contents'.
    /// </summary>
    public static class Contents
    {
        #region Members
        /// <summary>
        ///     Checks the given <paramref name="source"/> for the specified <paramref name="values"/>.  <see cref="string"/>
        /// </summary>
        /// <param name="source">
        ///     The given <see cref="string"/> to be examined for the existence of the specified <paramref name="values"/>.
        /// </param>
        /// <param name="values">
        ///     The specified contents to examine the given <paramref name="source"/> for.  <see cref="char"/>.
        /// </param>
        /// <returns>
        ///     If <paramref name="source"/> contains at least one of the specified <paramref name="values"/>, returns true.
        ///     Otherwise returns false.  <see cref="bool"/>.
        /// </returns>
        public static bool ContainsAny(this string source, params char[] values) => values.Any(source.Contains);

        /// <summary>
        ///     Checks the given <paramref name="source"/> for the specified <paramref name="values"/>.  <see cref="string"/>
        /// </summary>
        /// <param name="source">
        ///     The given <see cref="string"/> to be examined for the existence of the specified <paramref name="values"/>.
        /// </param>
        /// <param name="values">
        ///     The specified contents to examine the given <paramref name="source"/> for.  <see cref="string"/>.
        /// </param>
        /// <returns>
        ///     If <paramref name="source"/> contains at least one of the specified <paramref name="values"/>, returns true.
        ///     Otherwise returns false.  <see cref="bool"/>.
        /// </returns>
        public static bool ContainsAny(this string source, params string[] values) => values.Any(source.Contains);

        /// <summary>
        ///     Checks the given <paramref name="source"/> of <typeparamref name="TSource"/> for the specified
        ///     <paramref name="values"/>.
        /// </summary>
        /// <param name="source">
        ///     The given <typeparamref name="TSource"/> to be examined for the existence of the specified
        ///     <paramref name="values"/>.
        /// </param>
        /// <param name="values">
        ///     The specified contents to examine the given <paramref name="source"/> for.  <typeparamref name="TSource"/>.
        /// </param>
        /// <typeparam name="TSource">
        ///     The <see cref="Type"/> of the given <paramref name="source"/>.
        /// </typeparam>
        /// <returns>
        ///     If <paramref name="source"/> contains at least one of the specified <paramref name="values"/>, returns true.
        ///     Otherwise returns false.  <see cref="bool"/>.
        /// </returns>
        [SuppressMessage("ReSharper", "ConvertMethodToExpressionBody")]
        public static bool ContainsAny<TSource>(this IEnumerable<TSource> source, params TSource[] values)
        {
            return values.Any(source.Contains);
        }

        /// <summary>
        ///     Checks the given <paramref name="source"/> for all the specified <paramref name="values"/>.  <see cref="string"/>
        /// </summary>
        /// <param name="source">
        ///     The given <see cref="string"/> to be examined for the existence of the specified <paramref name="values"/>.
        /// </param>
        /// <param name="values">
        ///     The specified contents to examine the given <paramref name="source"/> for.  <see cref="char"/>.
        /// </param>
        /// <returns>
        ///     If <paramref name="source"/> contains all of the specified <paramref name="values"/>, returns true.  Otherwise
        ///     returns false.  <see cref="bool"/>.
        /// </returns>
        public static bool ContainsAll(this string source, params char[] values) => values.All(source.Contains);

        /// <summary>
        ///     Checks the given <paramref name="source"/> for all the specified <paramref name="values"/>.  <see cref="string"/>
        /// </summary>
        /// <param name="source">
        ///     The given <see cref="string"/> to be examined for the existence of the specified <paramref name="values"/>.
        /// </param>
        /// <param name="values">
        ///     The specified contents to examine the given <paramref name="source"/> for.  <see cref="string"/>.
        /// </param>
        /// <returns>
        ///     If <paramref name="source"/> contains all of the specified <paramref name="values"/>, returns true.  Otherwise
        ///     returns false.  <see cref="bool"/>.
        /// </returns>
        public static bool ContainsAll(this string source, params string[] values) => values.All(source.Contains);

        /// <summary>
        ///     Checks the given <paramref name="source"/> of <typeparamref name="TSource"/> for all the specified
        ///     <paramref name="values"/>.
        /// </summary>
        /// <param name="source">
        ///     The given <typeparamref name="TSource"/> to be examined for the existence of the specified
        ///     <paramref name="values"/>.
        /// </param>
        /// <param name="values">
        ///     The specified contents to examine the given <paramref name="source"/> for.  <typeparamref name="TSource"/>.
        /// </param>
        /// <typeparam name="TSource">
        ///     The <see cref="Type"/> of the given <paramref name="source"/>.
        /// </typeparam>
        /// <returns>
        ///     If <paramref name="source"/> contains all of the specified <paramref name="values"/>, returns true.  Otherwise
        ///     returns false.  <see cref="bool"/>.
        /// </returns>
        [SuppressMessage("ReSharper", "ConvertToExpressionBodyWhenPossible")]
        public static bool ContainsAll<TSource>(this IEnumerable<TSource> source, params TSource[] values)
        {
            // TODO May not work as expected.
            return !values.Any(value => !source.Contains(value));
        }
        #endregion
    }
}