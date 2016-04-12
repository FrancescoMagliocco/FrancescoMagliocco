// ----------------------------------------------------------------------------
// <Copyright File="ToCharacter.cs" Company="FrancescoMagliocco"
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
//     <Month>04</Month>
//     <Day>12</Day>
//     <Time>18:49</Time>
// </Coded>
// ----------------------------------------------------------------------------

namespace FrancescoMagliocco.Utils.Extensions
{
    using System;
    using System.Diagnostics;

    /// <summary> Class handling all extensionsn involving parsing to <see cref="char"/>. </summary>
    public static class ToCharacter
    {
        #region Members
        /// <summary>
        ///     Parses the given <paramref name="source"/> from a <see cref="byte"/> to a <see cref="char"/>
        ///     successfully as the <see cref="byte.MaxValue"/> is lower than that of a <see cref="char"/>.
        /// </summary>
        /// <param name="source"> The source <see cref="byte"/> to be parsed to a <see cref="char"/>. </param>
        /// <param name="provider">
        ///     <para> Provides a mechanism for retrieving an object to control formatting. </para>
        ///     <remarks>
        ///         <para> If a value is not specified, <see langword="null"/> will be passed by default. </para>
        ///     </remarks>
        /// </param>
        /// <param name="defaultValue"> The default value to be returned if parse failes. </param>
        /// <returns>
        ///     If successful, returns the given <paramref name="source"/> <see cref="byte"/> parsed to a
        ///     <see cref="char"/>; otherwise returns (if specified) <paramref name="defaultValue"/> or if not, (char)0.
        /// </returns>
        public static char ToChar(this byte source,
                                  IFormatProvider provider = null,
                                  char defaultValue = (char)0) => _ToChar(source, provider, defaultValue);

        /// <summary>
        ///     Parses the given <paramref name="source"/> from a <see cref="ushort"/> to a <see cref="char"/>
        ///     successfully as the <see cref="ushort.MaxValue"/> is lower than that of a <see cref="char"/>.
        /// </summary>
        /// <param name="source"> The source <see cref="ushort"/> to be parsed to a <see cref="char"/>. </param>
        /// <param name="provider">
        ///     <para> Provides a mechanism for retrieving an object to control formatting. </para>
        ///     <remarks>
        ///         <para> If a value is not specified, <see langword="null"/> will be passed by default. </para>
        ///     </remarks>
        /// </param>
        /// <param name="defaultValue"> The default value to be returned if parse failes. </param>
        /// <returns>
        ///     If successful, returns the given <paramref name="source"/> <see cref="ushort"/> parsed to a
        ///     <see cref="char"/>; otherwise returns (if specified) <paramref name="defaultValue"/> or if not, (char)0.
        /// </returns>
        public static char ToChar(this ushort source,
                                  IFormatProvider provider = null,
                                  char defaultValue = (char)0) => _ToChar(source, provider, defaultValue);

        /// <summary>
        ///     Parses the given <paramref name="source"/> from a <see cref="decimal"/> to a <see cref="char"/>
        ///     with a posibility of failing as the <see cref="decimal.MaxValue"/> and <see cref="decimal.MinValue"/> are
        ///     higher than that of a <see cref="char"/>.
        /// </summary>
        /// <param name="source"> The source <see cref="decimal"/> to be parsed to a <see cref="char"/>. </param>
        /// <param name="provider">
        ///     <para> Provides a mechanism for retrieving an object to control formatting. </para>
        ///     <remarks>
        ///         <para> If a value is not specified, <see langword="null"/> will be passed by default. </para>
        ///     </remarks>
        /// </param>
        /// <param name="defaultValue"> The default value to be returned if parse failes. </param>
        /// <returns>
        ///     If successful, returns the given <paramref name="source"/> <see cref="decimal"/> parsed to a
        ///     <see cref="char"/>; otherwise returns (if specified) <paramref name="defaultValue"/> or if not, (char)0.
        /// </returns>
        public static char ToCharUnsafe(this decimal source,
                                        IFormatProvider provider = null,
                                        char defaultValue = (char)0)
            => _ToChar(source, provider, defaultValue);

        /// <summary>
        ///     Parses the given <paramref name="source"/> from a <see cref="double"/> to a <see cref="char"/> with
        ///     a posibility of failing as the <see cref="double.MinValue"/> is lower than that of a <see cref="char"/>.
        /// </summary>
        /// <param name="source"> The source <see cref="double"/> to be parsed to a <see cref="char"/>. </param>
        /// <param name="provider">
        ///     <para> Provides a mechanism for retrieving an object to control formatting. </para>
        ///     <remarks>
        ///         <para> If a value is not specified, <see langword="null"/> will be passed by default. </para>
        ///     </remarks>
        /// </param>
        /// <param name="defaultValue"> The default value to be returned if parse failes. </param>
        /// <returns>
        ///     If successful, returns the given <paramref name="source"/> <see cref="double"/> parsed to a
        ///     <see cref="char"/>; otherwise returns (if specified) <paramref name="defaultValue"/> or if not, (char)0.
        /// </returns>
        public static char ToCharUnsafe(this double source,
                                        IFormatProvider provider = null,
                                        char defaultValue = (char)0)
            => _ToChar(source, provider, defaultValue);

        /// <summary>
        ///     Parses the given <paramref name="source"/> from a <see cref="float"/> to a <see cref="char"/> with
        ///     a posibility of failing as the <see cref="float.MaxValue"/> and <see cref="float.MinValue"/> are higher
        ///     and lower than that of a <see cref="char"/>.
        /// </summary>
        /// <param name="source"> The source <see cref="float"/> to be parsed to a <see cref="char"/>. </param>
        /// <param name="provider">
        ///     <para> Provides a mechanism for retrieving an object to control formatting. </para>
        ///     <remarks>
        ///         <para> If a value is not specified, <see langword="null"/> will be passed by default. </para>
        ///     </remarks>
        /// </param>
        /// <param name="defaultValue"> The default value to be returned if parse failes. </param>
        /// <returns>
        ///     If successful, returns the given <paramref name="source"/> <see cref="float"/> parsed to a
        ///     <see cref="char"/>; otherwise returns (if specified) <paramref name="defaultValue"/> or if not, (char)0.
        /// </returns>
        public static char ToCharUnsafe(this float source,
                                        IFormatProvider provider = null,
                                        char defaultValue = (char)0)
            => _ToChar(source, provider, defaultValue);

        /// <summary>
        ///     Parses the given <paramref name="source"/> from an <see cref="int"/> to a <see cref="char"/> with a
        ///     posibility of failing as the <see cref="int.MinValue"/> is lower than that of a <see cref="char"/>.
        /// </summary>
        /// <param name="source"> The source <see cref="int"/> to be parsed to a <see cref="char"/>. </param>
        /// <param name="provider">
        ///     <para> Provides a mechanism for retrieving an object to control formatting. </para>
        ///     <remarks>
        ///         <para> If a value is not specified, <see langword="null"/> will be passed by default. </para>
        ///     </remarks>
        /// </param>
        /// <param name="defaultValue"> The default value to be returned if parse failes. </param>
        /// <returns>
        ///     If successful, returns the given <paramref name="source"/> <see cref="int"/> parsed to a
        ///     <see cref="char"/>; otherwise returns (if specified) <paramref name="defaultValue"/> or if not, (char)0.
        /// </returns>
        public static char ToCharUnsafe(this int source,
                                        IFormatProvider provider = null,
                                        char defaultValue = (char)0)
            => _ToChar(source, provider, defaultValue);

        /// <summary>
        ///     Parses the given <paramref name="source"/> from a <see cref="long"/> to a <see cref="char"/> with a
        ///     posibility of failing as the <see cref="long.MinValue"/> is lower than that of a <see cref="char"/>.
        /// </summary>
        /// <param name="source"> The source <see cref="long"/> to be parsed to a <see cref="char"/>. </param>
        /// <param name="provider">
        ///     <para> Provides a mechanism for retrieving an object to control formatting. </para>
        ///     <remarks>
        ///         <para> If a value is not specified, <see langword="null"/> will be passed by default. </para>
        ///     </remarks>
        /// </param>
        /// <param name="defaultValue"> The default value to be returned if parse failes. </param>
        /// <returns>
        ///     If successful, returns the given <paramref name="source"/> <see cref="long"/> parsed to a
        ///     <see cref="char"/>; otherwise returns (if specified) <paramref name="defaultValue"/> or if not, (char)0.
        /// </returns>
        public static char ToCharUnsafe(this long source,
                                        IFormatProvider provider = null,
                                        char defaultValue = (char)0)
            => _ToChar(source, provider, defaultValue);

        /// <summary>
        ///     Parses the given <paramref name="source"/> from a <see cref="object"/> to a <see cref="char"/> with
        ///     a posibility of failing as <see cref="object"/> has no <c> MaxValue </c> or <c> MinValue </c>.
        /// </summary>
        /// <param name="source"> The source <see cref="object"/> to be parsed to a <see cref="char"/>. </param>
        /// <param name="provider">
        ///     <para> Provides a mechanism for retrieving an object to control formatting. </para>
        ///     <remarks>
        ///         <para> If a value is not specified, <see langword="null"/> will be passed by default. </para>
        ///     </remarks>
        /// </param>
        /// <param name="defaultValue"> The default value to be returned if parse failes. </param>
        /// <returns>
        ///     If successful, returns the given <paramref name="source"/> <see cref="object"/> parsed to a
        ///     <see cref="char"/>; otherwise returns (if specified) <paramref name="defaultValue"/> or if not, (char)0.
        /// </returns>
        public static char ToCharUnsafe(this object source,
                                        IFormatProvider provider = null,
                                        char defaultValue = (char)0)
            => _ToChar(source.ToString(), provider, defaultValue);

        /// <summary>
        ///     Parses the given <paramref name="source"/> from a <see cref="sbyte"/> to a <see cref="char"/> with
        ///     a posibility of failing as the <see cref="sbyte.MinValue"/> is lower than that of a <see cref="char"/>.
        /// </summary>
        /// <param name="source"> The source <see cref="sbyte"/> to be parsed to a <see cref="char"/>. </param>
        /// <param name="provider">
        ///     <para> Provides a mechanism for retrieving an object to control formatting. </para>
        ///     <remarks>
        ///         <para> If a value is not specified, <see langword="null"/> will be passed by default. </para>
        ///     </remarks>
        /// </param>
        /// <param name="defaultValue"> The default value to be returned if parse failes. </param>
        /// <returns>
        ///     If successful, returns the given <paramref name="source"/> <see cref="sbyte"/> parsed to a
        ///     <see cref="char"/>; otherwise returns (if specified) <paramref name="defaultValue"/> or if not, (char)0.
        /// </returns>
        public static char ToCharUnsafe(this sbyte source,
                                        IFormatProvider provider = null,
                                        char defaultValue = (char)0)
            => _ToChar(source, provider, defaultValue);

        /// <summary>
        ///     Parses the given <paramref name="source"/> from a <see cref="short"/> to a <see cref="char"/> with
        ///     a posibility of failing as the <see cref="short.MinValue"/> is lower than that of a <see cref="char"/>.
        /// </summary>
        /// <param name="source"> The source <see cref="short"/> to be parsed to a <see cref="char"/>. </param>
        /// <param name="provider">
        ///     <para> Provides a mechanism for retrieving an object to control formatting. </para>
        ///     <remarks>
        ///         <para> If a value is not specified, <see langword="null"/> will be passed by default. </para>
        ///     </remarks>
        /// </param>
        /// <param name="defaultValue"> The default value to be returned if parse failes. </param>
        /// <returns>
        ///     If successful, returns the given <paramref name="source"/> <see cref="short"/> parsed to a
        ///     <see cref="char"/>; otherwise returns (if specified) <paramref name="defaultValue"/> or if not, (char)0.
        /// </returns>
        public static char ToCharUnsafe(this short source,
                                        IFormatProvider provider = null,
                                        char defaultValue = (char)0)
            => _ToChar(source, provider, defaultValue);

        /// <summary>
        ///     Parses the given <paramref name="source"/> from a <see cref="string"/> to a <see cref="char"/> with
        ///     a posibility of failing as <see cref="string"/> has no <c> MaxValue </c> or <c> MinValue </c>.
        /// </summary>
        /// <param name="source"> The source <see cref="string"/> to be parsed to a <see cref="char"/>. </param>
        /// <param name="provider">
        ///     <para> Provides a mechanism for retrieving an object to control formatting. </para>
        ///     <remarks>
        ///         <para> If a value is not specified, <see langword="null"/> will be passed by default. </para>
        ///     </remarks>
        /// </param>
        /// <param name="defaultValue"> The default value to be returned if parse failes. </param>
        /// <returns>
        ///     If successful, returns the given <paramref name="source"/> <see cref="string"/> parsed to a
        ///     <see cref="char"/>; otherwise returns (if specified) <paramref name="defaultValue"/> or if not, (char)0.
        /// </returns>
        public static char ToCharUnsafe(this string source,
                                        IFormatProvider provider = null,
                                        char defaultValue = (char)0)
            => _ToChar(source, provider, defaultValue);

        /// <summary>
        ///     Parses the given <paramref name="source"/> from an <see cref="uint"/> to a <see cref="char"/> with
        ///     a posibility of failing as the <see cref="uint.MaxValue"/> is higher than that of a <see cref="char"/>.
        /// </summary>
        /// <param name="source"> The source <see cref="uint"/> to be parsed to a <see cref="char"/>. </param>
        /// <param name="provider">
        ///     <para> Provides a mechanism for retrieving an object to control formatting. </para>
        ///     <remarks>
        ///         <para> If a value is not specified, <see langword="null"/> will be passed by default. </para>
        ///     </remarks>
        /// </param>
        /// <param name="defaultValue"> The default value to be returned if parse failes. </param>
        /// <returns>
        ///     If successful, returns the given <paramref name="source"/> <see cref="uint"/> parsed to a
        ///     <see cref="char"/>; otherwise returns (if specified) <paramref name="defaultValue"/> or if not, (char)0.
        /// </returns>
        public static char ToCharUnsafe(this uint source,
                                        IFormatProvider provider = null,
                                        char defaultValue = (char)0)
            => _ToChar(source, provider, defaultValue);

        /// <summary>
        ///     Parses the given <paramref name="source"/> from a <see cref="ulong"/> to a <see cref="char"/>
        ///     successfully as the <see cref="ulong.MaxValue"/> and <see cref="ulong.MinValue"/> are higher and lower
        ///     than that of a <see cref="char"/>.
        /// </summary>
        /// <param name="source"> The source <see cref="ulong"/> to be parsed to a <see cref="char"/>. </param>
        /// <param name="provider">
        ///     <para> Provides a mechanism for retrieving an object to control formatting. </para>
        ///     <remarks>
        ///         <para> If a value is not specified, <see langword="null"/> will be passed by default. </para>
        ///     </remarks>
        /// </param>
        /// <param name="defaultValue"> The default value to be returned if parse failes. </param>
        /// <returns>
        ///     If successful, returns the given <paramref name="source"/> <see cref="ulong"/> parsed to a
        ///     <see cref="char"/>; otherwise returns (if specified) <paramref name="defaultValue"/> or if not, (char)0.
        /// </returns>
        public static char ToCharUnsafe(this ulong source,
                                        IFormatProvider provider = null,
                                        char defaultValue = (char)0)
            => _ToChar(source, provider, defaultValue);

        private static char _ToChar(this IConvertible source,
                                    IFormatProvider provider = null,
                                    char defaultValue = (char)0)
        {
            try {
                return char.Parse(source.ToString(provider));
            }
            catch (ArgumentNullException e) {
                Debug.WriteLine(e.Message, e.InnerException);
            }
            catch (ArgumentException e) {
                Debug.WriteLine(e.Message, e.InnerException);
            }
            catch (FormatException e) {
                Debug.WriteLine(e.Message, e.InnerException);
            }
            catch (OverflowException e) {
                Debug.WriteLine(e.Message, e.InnerException);
            }

            return defaultValue;
        }
        #endregion
    }
}