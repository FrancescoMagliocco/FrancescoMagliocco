// ----------------------------------------------------------------------------
// <Copyright File="ToUInt32.cs" Company="FrancescoMagliocco"
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
//     <Time>0:20</Time>
// </Coded>
// ----------------------------------------------------------------------------

namespace FrancescoMagliocco.Utils.Extensions
{
    using System;
    using System.Diagnostics;
    using System.Globalization;

    /// <summary>
    ///     Class handling all extensionsn involving parsing to <see cref="uint"/>.
    /// </summary>
    public static class ToUInt32
    {
        #region Members
        /// <summary>
        ///     Parses the given <paramref name="source"/> from a <see cref="byte"/> to an <see cref="uint"/> successfully as the
        ///     <see cref="byte.MaxValue"/> is lower than that of an <see cref="uint"/>.
        /// </summary>
        /// <param name="source"> The source <see cref="byte"/> to be parsed to an <see cref="uint"/>. </param>
        /// <param name="numberStyles">
        ///     <para>
        ///         Determines the styles permitted in numeric string arguments that are passed to the <c> Parse </c> and
        ///         <c> TryParse </c> methods of the integral and floating-point numeric types.
        ///     </para>
        ///     <remarks>
        ///         <para> If a value is not specified, <see cref="NumberStyles.None"/> will be passed by default. </para>
        ///     </remarks>
        /// </param>
        /// <param name="provider">
        ///     <para> Provides a mechanism for retrieving an object to control formatting. </para>
        ///     <remarks>
        ///         <para> If a value is not specified, <see langword="null"/> will be passed by default. </para>
        ///     </remarks>
        /// </param>
        /// <param name="defaultValue"> The default value to be returned if parse failes. </param>
        /// <returns>
        ///     If successful, returns the given <paramref name="source"/> <see cref="byte"/> parsed to an <see cref="uint"/>;
        ///     otherwise returns if specified <paramref name="defaultValue"/> or if not 0.
        /// </returns>
        public static uint ToUInt(this byte source,
                                  NumberStyles numberStyles = NumberStyles.None,
                                  IFormatProvider provider = null,
                                  uint defaultValue = 0) => _ToUInt(source, numberStyles, provider, defaultValue);

        /// <summary>
        ///     Parses the given <paramref name="source"/> from a <see cref="ushort"/> to an <see cref="uint"/> successfully as the
        ///     <see cref="ushort.MaxValue"/> is lower than that of an <see cref="uint"/>.
        /// </summary>
        /// <param name="source"> The source <see cref="ushort"/> to be parsed to an <see cref="uint"/>. </param>
        /// <param name="numberStyles">
        ///     <para>
        ///         Determines the styles permitted in numeric string arguments that are passed to the <c> Parse </c> and
        ///         <c> TryParse </c> methods of the integral and floating-point numeric types.
        ///     </para>
        ///     <remarks>
        ///         <para> If a value is not specified, <see cref="NumberStyles.None"/> will be passed by default. </para>
        ///     </remarks>
        /// </param>
        /// <param name="provider">
        ///     <para> Provides a mechanism for retrieving an object to control formatting. </para>
        ///     <remarks>
        ///         <para> If a value is not specified, <see langword="null"/> will be passed by default. </para>
        ///     </remarks>
        /// </param>
        /// <param name="defaultValue"> The default value to be returned if parse failes. </param>
        /// <returns>
        ///     If successful, returns the given <paramref name="source"/> <see cref="ushort"/> parsed to an
        ///     <see cref="uint"/>; otherwise returns if specified <paramref name="defaultValue"/> or if not 0.
        /// </returns>
        public static uint ToUInt(this ushort source,
                                  NumberStyles numberStyles = NumberStyles.None,
                                  IFormatProvider provider = null,
                                  uint defaultValue = 0) => _ToUInt(source, numberStyles, provider, defaultValue);

        /// <summary>
        ///     Parses the given <paramref name="source"/> from a <see cref="char"/> to an <see cref="uint"/> with a posibility
        ///     of failing as the <see cref="char.MinValue"/> is lower than that of an <see cref="uint"/>.
        /// </summary>
        /// <param name="source"> The source <see cref="char"/> to be parsed to an <see cref="uint"/>. </param>
        /// <param name="numberStyles">
        ///     <para>
        ///         Determines the styles permitted in numeric string arguments that are passed to the <c> Parse </c> and
        ///         <c> TryParse </c> methods of the integral and floating-point numeric types.
        ///     </para>
        ///     <remarks>
        ///         <para> If a value is not specified, <see cref="NumberStyles.None"/> will be passed by default. </para>
        ///     </remarks>
        /// </param>
        /// <param name="provider">
        ///     <para> Provides a mechanism for retrieving an object to control formatting. </para>
        ///     <remarks>
        ///         <para> If a value is not specified, <see langword="null"/> will be passed by default. </para>
        ///     </remarks>
        /// </param>
        /// <param name="defaultValue"> The default value to be returned if parse failes. </param>
        /// <returns>
        ///     If successful, returns the given <paramref name="source"/> <see cref="char"/> parsed to an
        ///     <see cref="uint"/>; otherwise returns if specified <paramref name="defaultValue"/> or if not 0.
        /// </returns>
        public static uint ToUIntUnsafe(this char source,
                                        NumberStyles numberStyles = NumberStyles.None,
                                        IFormatProvider provider = null,
                                        uint defaultValue = 0) => _ToUInt(source, numberStyles, provider, defaultValue);

        /// <summary>
        ///     Parses the given <paramref name="source"/> from a <see cref="decimal"/> to an <see cref="uint"/> with a posibility
        ///     of failing as the <see cref="decimal.MaxValue"/> and <see cref="decimal.MinValue"/> are higher and lower than that
        ///     of an <see cref="uint"/>.
        /// </summary>
        /// <param name="source"> The source <see cref="decimal"/> to be parsed to an <see cref="uint"/>. </param>
        /// <param name="numberStyles">
        ///     <para>
        ///         Determines the styles permitted in numeric string arguments that are passed to the <c> Parse </c> and
        ///         <c> TryParse </c> methods of the integral and floating-point numeric types.
        ///     </para>
        ///     <remarks>
        ///         <para> If a value is not specified, <see cref="NumberStyles.None"/> will be passed by default. </para>
        ///     </remarks>
        /// </param>
        /// <param name="provider">
        ///     <para> Provides a mechanism for retrieving an object to control formatting. </para>
        ///     <remarks>
        ///         <para> If a value is not specified, <see langword="null"/> will be passed by default. </para>
        ///     </remarks>
        /// </param>
        /// <param name="defaultValue"> The default value to be returned if parse failes. </param>
        /// <returns>
        ///     If successful, returns the given <paramref name="source"/> <see cref="decimal"/> parsed to an
        ///     <see cref="uint"/>; otherwise returns if specified <paramref name="defaultValue"/> or if not 0.
        /// </returns>
        public static uint ToUIntUnsafe(this decimal source,
                                        NumberStyles numberStyles = NumberStyles.None,
                                        IFormatProvider provider = null,
                                        uint defaultValue = 0) => _ToUInt(source, numberStyles, provider, defaultValue);

        /// <summary>
        ///     Parses the given <paramref name="source"/> from a <see cref="double"/> to an <see cref="uint"/> with a posibility
        ///     of failing as the <see cref="double.MaxValue"/> and <see cref="double.MinValue"/> are higher and lower than that of
        ///     an <see cref="uint"/>.
        /// </summary>
        /// <param name="source"> The source <see cref="double"/> to be parsed to an <see cref="uint"/>. </param>
        /// <param name="numberStyles">
        ///     <para>
        ///         Determines the styles permitted in numeric string arguments that are passed to the <c> Parse </c> and
        ///         <c> TryParse </c> methods of the integral and floating-point numeric types.
        ///     </para>
        ///     <remarks>
        ///         <para> If a value is not specified, <see cref="NumberStyles.None"/> will be passed by default. </para>
        ///     </remarks>
        /// </param>
        /// <param name="provider">
        ///     <para> Provides a mechanism for retrieving an object to control formatting. </para>
        ///     <remarks>
        ///         <para> If a value is not specified, <see langword="null"/> will be passed by default. </para>
        ///     </remarks>
        /// </param>
        /// <param name="defaultValue"> The default value to be returned if parse failes. </param>
        /// <returns>
        ///     If successful, returns the given <paramref name="source"/> <see cref="double"/> parsed to an
        ///     <see cref="uint"/>; otherwise returns if specified <paramref name="defaultValue"/> or if not 0.
        /// </returns>
        public static uint ToUIntUnsafe(this double source,
                                        NumberStyles numberStyles = NumberStyles.None,
                                        IFormatProvider provider = null,
                                        uint defaultValue = 0) => _ToUInt(source, numberStyles, provider, defaultValue);

        /// <summary>
        ///     Parses the given <paramref name="source"/> from a <see cref="float"/> to an <see cref="uint"/> with a posibility of
        ///     failing as the <see cref="float.MaxValue"/> and <see cref="float.MinValue"/> are higher and lower than that of an
        ///     <see cref="uint"/>.
        /// </summary>
        /// <param name="source"> The source <see cref="float"/> to be parsed to an <see cref="uint"/>. </param>
        /// <param name="numberStyles">
        ///     <para>
        ///         Determines the styles permitted in numeric string arguments that are passed to the <c> Parse </c> and
        ///         <c> TryParse </c> methods of the integral and floating-point numeric types.
        ///     </para>
        ///     <remarks>
        ///         <para> If a value is not specified, <see cref="NumberStyles.None"/> will be passed by default. </para>
        ///     </remarks>
        /// </param>
        /// <param name="provider">
        ///     <para> Provides a mechanism for retrieving an object to control formatting. </para>
        ///     <remarks>
        ///         <para> If a value is not specified, <see langword="null"/> will be passed by default. </para>
        ///     </remarks>
        /// </param>
        /// <param name="defaultValue"> The default value to be returned if parse failes. </param>
        /// <returns>
        ///     If successful, returns the given <paramref name="source"/> <see cref="float"/> parsed to an <see cref="uint"/>
        ///     ; otherwise returns if specified <paramref name="defaultValue"/> or if not 0.
        /// </returns>
        public static uint ToUIntUnsafe(this float source,
                                        NumberStyles numberStyles = NumberStyles.None,
                                        IFormatProvider provider = null,
                                        uint defaultValue = 0) => _ToUInt(source, numberStyles, provider, defaultValue);

        /// <summary>
        ///     Parses the given <paramref name="source"/> from an <see cref="int"/> to an <see cref="uint"/> with a posibility of
        ///     failing as the <see cref="int.MinValue"/> is lower than that of an <see cref="uint"/>.
        /// </summary>
        /// <param name="source"> The source <see cref="int"/> to be parsed to an <see cref="uint"/>. </param>
        /// <param name="numberStyles">
        ///     <para>
        ///         Determines the styles permitted in numeric string arguments that are passed to the <c> Parse </c> and
        ///         <c> TryParse </c> methods of the integral and floating-point numeric types.
        ///     </para>
        ///     <remarks>
        ///         <para> If a value is not specified, <see cref="NumberStyles.None"/> will be passed by default. </para>
        ///     </remarks>
        /// </param>
        /// <param name="provider">
        ///     <para> Provides a mechanism for retrieving an object to control formatting. </para>
        ///     <remarks>
        ///         <para> If a value is not specified, <see langword="null"/> will be passed by default. </para>
        ///     </remarks>
        /// </param>
        /// <param name="defaultValue"> The default value to be returned if parse failes. </param>
        /// <returns>
        ///     If successful, returns the given <paramref name="source"/> <see cref="int"/> parsed to an <see cref="uint"/>;
        ///     otherwise returns if specified <paramref name="defaultValue"/> or if not 0.
        /// </returns>
        public static uint ToUIntUnsafe(this int source,
                                        NumberStyles numberStyles = NumberStyles.None,
                                        IFormatProvider provider = null,
                                        uint defaultValue = 0) => _ToUInt(source, numberStyles, provider, defaultValue);

        /// <summary>
        ///     Parses the given <paramref name="source"/> from a <see cref="long"/> to an <see cref="uint"/> with a posibility of
        ///     failing as the <see cref="long.MaxValue"/> and <see cref="long.MinValue"/> are higher and than that of an
        ///     <see cref="uint"/>.
        /// </summary>
        /// <param name="source"> The source <see cref="long"/> to be parsed to an <see cref="uint"/>. </param>
        /// <param name="numberStyles">
        ///     <para>
        ///         Determines the styles permitted in numeric string arguments that are passed to the <c> Parse </c> and
        ///         <c> TryParse </c> methods of the integral and floating-point numeric types.
        ///     </para>
        ///     <remarks>
        ///         <para> If a value is not specified, <see cref="NumberStyles.None"/> will be passed by default. </para>
        ///     </remarks>
        /// </param>
        /// <param name="provider">
        ///     <para> Provides a mechanism for retrieving an object to control formatting. </para>
        ///     <remarks>
        ///         <para> If a value is not specified, <see langword="null"/> will be passed by default. </para>
        ///     </remarks>
        /// </param>
        /// <param name="defaultValue"> The default value to be returned if parse failes. </param>
        /// <returns>
        ///     If successful, returns the given <paramref name="source"/> <see cref="long"/> parsed to an <see cref="uint"/>;
        ///     otherwise returns if specified <paramref name="defaultValue"/> or if not 0.
        /// </returns>
        public static uint ToUIntUnsafe(this long source,
                                        NumberStyles numberStyles = NumberStyles.None,
                                        IFormatProvider provider = null,
                                        uint defaultValue = 0) => _ToUInt(source, numberStyles, provider, defaultValue);

        /// <summary>
        ///     Parses the given <paramref name="source"/> from a <see cref="object"/> to an <see cref="uint"/> with a posibility
        ///     of
        ///     failing as <see cref="object"/> has no <c> MaxValue </c> or <c> MinValue </c>.
        /// </summary>
        /// <param name="source"> The source <see cref="object"/> to be parsed to an <see cref="uint"/>. </param>
        /// <param name="numberStyles">
        ///     <para>
        ///         Determines the styles permitted in numeric string arguments that are passed to the <c> Parse </c> and
        ///         <c> TryParse </c> methods of the integral and floating-point numeric types.
        ///     </para>
        ///     <remarks>
        ///         <para> If a value is not specified, <see cref="NumberStyles.None"/> will be passed by default. </para>
        ///     </remarks>
        /// </param>
        /// <param name="provider">
        ///     <para> Provides a mechanism for retrieving an object to control formatting. </para>
        ///     <remarks>
        ///         <para> If a value is not specified, <see langword="null"/> will be passed by default. </para>
        ///     </remarks>
        /// </param>
        /// <param name="defaultValue"> The default value to be returned if parse failes. </param>
        /// <returns>
        ///     If successful, returns the given <paramref name="source"/> <see cref="object"/> parsed to an
        ///     <see cref="uint"/>; otherwise returns if specified <paramref name="defaultValue"/> or if not 0.
        /// </returns>
        public static uint ToUIntUnsafe(this object source,
                                        NumberStyles numberStyles = NumberStyles.None,
                                        IFormatProvider provider = null,
                                        uint defaultValue = 0)
            => _ToUInt(source.ToString(), numberStyles, provider, defaultValue);

        /// <summary>
        ///     Parses the given <paramref name="source"/> from a <see cref="sbyte"/> to an <see cref="uint"/> with a posibility of
        ///     failing as the <see cref="sbyte.MinValue"/> is lower than that of an <see cref="uint"/>.
        /// </summary>
        /// <param name="source"> The source <see cref="sbyte"/> to be parsed to an <see cref="uint"/>. </param>
        /// <param name="numberStyles">
        ///     <para>
        ///         Determines the styles permitted in numeric string arguments that are passed to the <c> Parse </c> and
        ///         <c> TryParse </c> methods of the integral and floating-point numeric types.
        ///     </para>
        ///     <remarks>
        ///         <para> If a value is not specified, <see cref="NumberStyles.None"/> will be passed by default. </para>
        ///     </remarks>
        /// </param>
        /// <param name="provider">
        ///     <para> Provides a mechanism for retrieving an object to control formatting. </para>
        ///     <remarks>
        ///         <para> If a value is not specified, <see langword="null"/> will be passed by default. </para>
        ///     </remarks>
        /// </param>
        /// <param name="defaultValue"> The default value to be returned if parse failes. </param>
        /// <returns>
        ///     If successful, returns the given <paramref name="source"/> <see cref="sbyte"/> parsed to an <see cref="uint"/>;
        ///     otherwise returns if specified <paramref name="defaultValue"/> or if not 0.
        /// </returns>
        public static uint ToUIntUnsafe(this sbyte source,
                                        NumberStyles numberStyles = NumberStyles.None,
                                        IFormatProvider provider = null,
                                        uint defaultValue = 0) => _ToUInt(source, numberStyles, provider, defaultValue);

        /// <summary>
        ///     Parses the given <paramref name="source"/> from a <see cref="short"/> to an <see cref="uint"/> with a posibility of
        ///     failing as the <see cref="short.MinValue"/> is lower than that of an <see cref="uint"/>.
        /// </summary>
        /// <param name="source"> The source <see cref="short"/> to be parsed to an <see cref="uint"/>. </param>
        /// <param name="numberStyles">
        ///     <para>
        ///         Determines the styles permitted in numeric string arguments that are passed to the <c> Parse </c> and
        ///         <c> TryParse </c> methods of the integral and floating-point numeric types.
        ///     </para>
        ///     <remarks>
        ///         <para> If a value is not specified, <see cref="NumberStyles.None"/> will be passed by default. </para>
        ///     </remarks>
        /// </param>
        /// <param name="provider">
        ///     <para> Provides a mechanism for retrieving an object to control formatting. </para>
        ///     <remarks>
        ///         <para> If a value is not specified, <see langword="null"/> will be passed by default. </para>
        ///     </remarks>
        /// </param>
        /// <param name="defaultValue"> The default value to be returned if parse failes. </param>
        /// <returns>
        ///     If successful, returns the given <paramref name="source"/> <see cref="short"/> parsed to an <see cref="uint"/>;
        ///     otherwise returns if specified <paramref name="defaultValue"/> or if not 0.
        /// </returns>
        public static uint ToUIntUnsafe(this short source,
                                        NumberStyles numberStyles = NumberStyles.None,
                                        IFormatProvider provider = null,
                                        uint defaultValue = 0) => _ToUInt(source, numberStyles, provider, defaultValue);

        /// <summary>
        ///     Parses the given <paramref name="source"/> from a <see cref="string"/> to an <see cref="uint"/> with a posibility
        ///     of failing as <see cref="string"/> has no <c> MaxValue </c> or <c> MinValue </c>.
        /// </summary>
        /// <param name="source"> The source <see cref="string"/> to be parsed to an <see cref="uint"/>. </param>
        /// <param name="numberStyles">
        ///     <para>
        ///         Determines the styles permitted in numeric string arguments that are passed to the <c> Parse </c> and
        ///         <c> TryParse </c> methods of the integral and floating-point numeric types.
        ///     </para>
        ///     <remarks>
        ///         <para> If a value is not specified, <see cref="NumberStyles.None"/> will be passed by default. </para>
        ///     </remarks>
        /// </param>
        /// <param name="provider">
        ///     <para> Provides a mechanism for retrieving an object to control formatting. </para>
        ///     <remarks>
        ///         <para> If a value is not specified, <see langword="null"/> will be passed by default. </para>
        ///     </remarks>
        /// </param>
        /// <param name="defaultValue"> The default value to be returned if parse failes. </param>
        /// <returns>
        ///     If successful, returns the given <paramref name="source"/> <see cref="string"/> parsed to an
        ///     <see cref="uint"/>; otherwise returns if specified <paramref name="defaultValue"/> or if not 0.
        /// </returns>
        public static uint ToUIntUnsafe(this string source,
                                        NumberStyles numberStyles = NumberStyles.None,
                                        IFormatProvider provider = null,
                                        uint defaultValue = 0) => _ToUInt(source, numberStyles, provider, defaultValue);

        /// <summary>
        ///     Parses the given <paramref name="source"/> from a <see cref="ulong"/> to an <see cref="uint"/> with a posibility of
        ///     failing as the <see cref="ulong.MaxValue"/> is higher than that of an <see cref="uint"/>.
        /// </summary>
        /// <param name="source"> The source <see cref="ulong"/> to be parsed to an <see cref="uint"/>. </param>
        /// <param name="numberStyles">
        ///     <para>
        ///         Determines the styles permitted in numeric string arguments that are passed to the <c> Parse </c> and
        ///         <c> TryParse </c> methods of the integral and floating-point numeric types.
        ///     </para>
        ///     <remarks>
        ///         <para> If a value is not specified, <see cref="NumberStyles.None"/> will be passed by default. </para>
        ///     </remarks>
        /// </param>
        /// <param name="provider">
        ///     <para> Provides a mechanism for retrieving an object to control formatting. </para>
        ///     <remarks>
        ///         <para> If a value is not specified, <see langword="null"/> will be passed by default. </para>
        ///     </remarks>
        /// </param>
        /// <param name="defaultValue"> The default value to be returned if parse failes. </param>
        /// <returns>
        ///     If successful, returns the given <paramref name="source"/> <see cref="ulong"/> parsed to an <see cref="uint"/>
        ///     ; otherwise returns if specified <paramref name="defaultValue"/> or if not 0.
        /// </returns>
        public static uint ToUIntUnsafe(this ulong source,
                                        NumberStyles numberStyles = NumberStyles.None,
                                        IFormatProvider provider = null,
                                        uint defaultValue = 0) => _ToUInt(source, numberStyles, provider, defaultValue);

        private static uint _ToUInt(this IConvertible source,
                                    NumberStyles numberStyles = NumberStyles.None,
                                    IFormatProvider provider = null,
                                    uint defaultValue = 0)
        {
            try {
                return uint.Parse(source.ToString(provider), numberStyles, provider);
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