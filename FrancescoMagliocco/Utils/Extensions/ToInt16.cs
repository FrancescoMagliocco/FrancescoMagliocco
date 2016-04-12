// ----------------------------------------------------------------------------
// <Copyright File="ToInt16.cs" Company="FrancescoMagliocco"
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
//     <Time>17:36</Time>
// </Coded>
// ----------------------------------------------------------------------------

namespace FrancescoMagliocco.Utils.Extensions
{
    using System;
    using System.Diagnostics;
    using System.Globalization;

    /// <summary> Class handling all extensionsn involving parsing to <see cref="short"/>. </summary>
    public static class ToInt16
    {
        #region Members
        /// <summary>
        ///     Parses the given <paramref name="source"/> from a <see cref="byte"/> to a <see cref="short"/>
        ///     successfully as the <see cref="byte.MaxValue"/> and <see cref="byte.MinValue"/> are lower than that of an
        ///     <see cref="sbyte"/>.
        /// </summary>
        /// <param name="source"> The source <see cref="byte"/> to be parsed to a <see cref="short"/>. </param>
        /// <param name="numberStyles">
        ///     <para>
        ///         Determines the styles permitted in numeric string arguments that are passed to the <c> Parse </c>
        ///         and <c> TryParse </c> methods of the integral and floating-point numeric types.
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
        ///     If successful, returns the given <paramref name="source"/> <see cref="byte"/> parsed to a
        ///     <see cref="short"/>; otherwise returns if specified <paramref name="defaultValue"/> or if not 0.
        /// </returns>
        public static short ToShort(this byte source,
                                    NumberStyles numberStyles = NumberStyles.None,
                                    IFormatProvider provider = null,
                                    short defaultValue = 0)
            => _ToShort(source, numberStyles, provider, defaultValue);

        /// <summary>
        ///     Parses the given <paramref name="source"/> from a <see cref="char"/> to a <see cref="short"/>
        ///     successfully as the <see cref="char.MaxValue"/> is lower than that of an <see cref="char"/>.
        /// </summary>
        /// <param name="source"> The source <see cref="char"/> to be parsed to a <see cref="short"/>. </param>
        /// <param name="numberStyles">
        ///     <para>
        ///         Determines the styles permitted in numeric string arguments that are passed to the <c> Parse </c>
        ///         and <c> TryParse </c> methods of the integral and floating-point numeric types.
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
        ///     If successful, returns the given <paramref name="source"/> <see cref="char"/> parsed to a
        ///     <see cref="short"/>; otherwise returns if specified <paramref name="defaultValue"/> or if not 0.
        /// </returns>
        public static short ToShort(this char source,
                                    NumberStyles numberStyles = NumberStyles.None,
                                    IFormatProvider provider = null,
                                    short defaultValue = 0)
            => _ToShort(source, numberStyles, provider, defaultValue);

        /// <summary>
        ///     Parses the given <paramref name="source"/> from a <see cref="short"/> to a <see cref="short"/> with
        ///     a posibility of failing as the <see cref="short.MinValue"/> is lower than that of a <see cref="short"/>.
        /// </summary>
        /// <param name="source"> The source <see cref="short"/> to be parsed to a <see cref="short"/>. </param>
        /// <param name="numberStyles">
        ///     <para>
        ///         Determines the styles permitted in numeric string arguments that are passed to the <c> Parse </c>
        ///         and <c> TryParse </c> methods of the integral and floating-point numeric types.
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
        ///     If successful, returns the given <paramref name="source"/> <see cref="short"/> parsed to a
        ///     <see cref="short"/>; otherwise returns if specified <paramref name="defaultValue"/> of if not 0.
        /// </returns>
        public static short ToShortUnsafe(this sbyte source,
                                          NumberStyles numberStyles = NumberStyles.None,
                                          IFormatProvider provider = null,
                                          short defaultValue = 0)
            => _ToShort(source, numberStyles, provider, defaultValue);

        /// <summary>
        ///     Parses the given <paramref name="source"/> from a <see cref="decimal"/> to a <see cref="short"/>
        ///     with a posibility of failing as the <see cref="decimal.MaxValue"/> and <see cref="decimal.MinValue"/> are
        ///     higher than that of a <see cref="short"/>.
        /// </summary>
        /// <param name="source"> The source <see cref="decimal"/> to be parsed to a <see cref="short"/>. </param>
        /// <param name="numberStyles">
        ///     <para>
        ///         Determines the styles permitted in numeric string arguments that are passed to the <c> Parse </c>
        ///         and <c> TryParse </c> methods of the integral and floating-point numeric types.
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
        ///     If successful, returns the given <paramref name="source"/> <see cref="decimal"/> parsed to a
        ///     <see cref="short"/>; otherwise returns if specified <paramref name="defaultValue"/> of if not 0.
        /// </returns>
        public static short ToShortUnsafe(this decimal source,
                                          NumberStyles numberStyles = NumberStyles.None,
                                          IFormatProvider provider = null,
                                          short defaultValue = 0)
            => _ToShort(source, numberStyles, provider, defaultValue);

        /// <summary>
        ///     Parses the given <paramref name="source"/> from a <see cref="double"/> to a <see cref="short"/>
        ///     with a posibility of failing as the <see cref="double.MaxValue"/> and <see cref="double.MinValue"/> are
        ///     higher and lower than that of a <see cref="short"/>.
        /// </summary>
        /// <param name="source"> The source <see cref="double"/> to be parsed to a <see cref="short"/>. </param>
        /// <param name="numberStyles">
        ///     <para>
        ///         Determines the styles permitted in numeric string arguments that are passed to the <c> Parse </c>
        ///         and <c> TryParse </c> methods of the integral and floating-point numeric types.
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
        ///     If successful, returns the given <paramref name="source"/> <see cref="double"/> parsed to a
        ///     <see cref="short"/>; otherwise returns if specified <paramref name="defaultValue"/> of if not 0.
        /// </returns>
        public static short ToShortUnsafe(this double source,
                                          NumberStyles numberStyles = NumberStyles.None,
                                          IFormatProvider provider = null,
                                          short defaultValue = 0)
            => _ToShort(source, numberStyles, provider, defaultValue);

        /// <summary>
        ///     Parses the given <paramref name="source"/> from a <see cref="float"/> to a <see cref="short"/> with
        ///     a posibility of failing as the <see cref="float.MaxValue"/> and <see cref="float.MinValue"/> are higher
        ///     and lower than that of a <see cref="short"/>.
        /// </summary>
        /// <param name="source"> The source <see cref="float"/> to be parsed to a <see cref="short"/>. </param>
        /// <param name="numberStyles">
        ///     <para>
        ///         Determines the styles permitted in numeric string arguments that are passed to the <c> Parse </c>
        ///         and <c> TryParse </c> methods of the integral and floating-point numeric types.
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
        ///     If successful, returns the given <paramref name="source"/> <see cref="float"/> parsed to a
        ///     <see cref="short"/>; otherwise returns if specified <paramref name="defaultValue"/> of if not 0.
        /// </returns>
        public static short ToShortUnsafe(this float source,
                                          NumberStyles numberStyles = NumberStyles.None,
                                          IFormatProvider provider = null,
                                          short defaultValue = 0)
            => _ToShort(source, numberStyles, provider, defaultValue);

        /// <summary>
        ///     Parses the given <paramref name="source"/> from an <see cref="int"/> to a <see cref="short"/> with
        ///     a posibility of failing as the <see cref="int.MaxValue"/> and <see cref="int.MinValue"/> are higher and
        ///     lower than that of a <see cref="short"/>.
        /// </summary>
        /// <param name="source"> The source <see cref="int"/> to be parsed to a <see cref="short"/>. </param>
        /// <param name="numberStyles">
        ///     <para>
        ///         Determines the styles permitted in numeric string arguments that are passed to the <c> Parse </c>
        ///         and <c> TryParse </c> methods of the integral and floating-point numeric types.
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
        ///     If successful, returns the given <paramref name="source"/> <see cref="int"/> parsed to a
        ///     <see cref="short"/>; otherwise returns if specified <paramref name="defaultValue"/> of if not 0.
        /// </returns>
        public static short ToShortUnsafe(this int source,
                                          NumberStyles numberStyles = NumberStyles.None,
                                          IFormatProvider provider = null,
                                          short defaultValue = 0)
            => _ToShort(source, numberStyles, provider, defaultValue);

        /// <summary>
        ///     Parses the given <paramref name="source"/> from a <see cref="long"/> to a <see cref="short"/> with
        ///     a posibility of failing as the <see cref="long.MaxValue"/> and <see cref="long.MinValue"/> are higher and
        ///     lower than that of a <see cref="short"/>.
        /// </summary>
        /// <param name="source"> The source <see cref="long"/> to be parsed to a <see cref="short"/>. </param>
        /// <param name="numberStyles">
        ///     <para>
        ///         Determines the styles permitted in numeric string arguments that are passed to the <c> Parse </c>
        ///         and <c> TryParse </c> methods of the integral and floating-point numeric types.
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
        ///     If successful, returns the given <paramref name="source"/> <see cref="long"/> parsed to a
        ///     <see cref="short"/>; otherwise returns if specified <paramref name="defaultValue"/> of if not 0.
        /// </returns>
        public static short ToShortUnsafe(this long source,
                                          NumberStyles numberStyles = NumberStyles.None,
                                          IFormatProvider provider = null,
                                          short defaultValue = 0)
            => _ToShort(source, numberStyles, provider, defaultValue);

        /// <summary>
        ///     Parses the given <paramref name="source"/> from a <see cref="object"/> to a <see cref="short"/>
        ///     with a posibility of failing as <see cref="object"/> has no <c> MaxValue </c> or <c> MinValue </c>.
        /// </summary>
        /// <param name="source"> The source <see cref="object"/> to be parsed to a <see cref="short"/>. </param>
        /// <param name="numberStyles">
        ///     <para>
        ///         Determines the styles permitted in numeric string arguments that are passed to the <c> Parse </c>
        ///         and <c> TryParse </c> methods of the integral and floating-point numeric types.
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
        ///     If successful, returns the given <paramref name="source"/> <see cref="object"/> parsed to a
        ///     <see cref="short"/>; otherwise returns if specified <paramref name="defaultValue"/> of if not 0.
        /// </returns>
        public static short ToShortUnsafe(this object source,
                                          NumberStyles numberStyles = NumberStyles.None,
                                          IFormatProvider provider = null,
                                          short defaultValue = 0)
            => _ToShort(source.ToString(), numberStyles, provider, defaultValue);

        /// <summary>
        ///     Parses the given <paramref name="source"/> from a <see cref="string"/> to a <see cref="short"/>
        ///     with a posibility of failing as <see cref="string"/> has no <c> MaxValue </c> or <c> MinValue </c>.
        /// </summary>
        /// <param name="source"> The source <see cref="string"/> to be parsed to a <see cref="short"/>. </param>
        /// <param name="numberStyles">
        ///     <para>
        ///         Determines the styles permitted in numeric string arguments that are passed to the <c> Parse </c>
        ///         and <c> TryParse </c> methods of the integral and floating-point numeric types.
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
        ///     If successful, returns the given <paramref name="source"/> <see cref="string"/> parsed to a
        ///     <see cref="short"/>; otherwise returns if specified <paramref name="defaultValue"/> of if not 0.
        /// </returns>
        public static short ToShortUnsafe(this string source,
                                          NumberStyles numberStyles = NumberStyles.None,
                                          IFormatProvider provider = null,
                                          short defaultValue = 0)
            => _ToShort(source, numberStyles, provider, defaultValue);

        /// <summary>
        ///     Parses the given <paramref name="source"/> from an <see cref="uint"/> to a <see cref="short"/> with
        ///     a posibility of failing as the <see cref="uint.MaxValue"/> is higher than that of a <see cref="short"/>.
        /// </summary>
        /// <param name="source"> The source <see cref="uint"/> to be parsed to a <see cref="short"/>. </param>
        /// <param name="numberStyles">
        ///     <para>
        ///         Determines the styles permitted in numeric string arguments that are passed to the <c> Parse </c>
        ///         and <c> TryParse </c> methods of the integral and floating-point numeric types.
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
        ///     If successful, returns the given <paramref name="source"/> <see cref="uint"/> parsed to a
        ///     <see cref="short"/>; otherwise returns if specified <paramref name="defaultValue"/> of if not 0.
        /// </returns>
        public static short ToShortUnsafe(this uint source,
                                          NumberStyles numberStyles = NumberStyles.None,
                                          IFormatProvider provider = null,
                                          short defaultValue = 0)
            => _ToShort(source, numberStyles, provider, defaultValue);

        /// <summary>
        ///     Parses the given <paramref name="source"/> from a <see cref="ulong"/> to a <see cref="short"/>
        ///     successfully as the <see cref="ulong.MaxValue"/> and <see cref="ulong.MinValue"/> are higher and lower
        ///     than that of a <see cref="short"/>.
        /// </summary>
        /// <param name="source"> The source <see cref="ulong"/> to be parsed to a <see cref="short"/>. </param>
        /// <param name="numberStyles">
        ///     <para>
        ///         Determines the styles permitted in numeric string arguments that are passed to the <c> Parse </c>
        ///         and <c> TryParse </c> methods of the integral and floating-point numeric types.
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
        ///     If successful, returns the given <paramref name="source"/> <see cref="ulong"/> parsed to a
        ///     <see cref="short"/>; otherwise returns if specified <paramref name="defaultValue"/> of if not 0.
        /// </returns>
        public static short ToShortUnsafe(this ulong source,
                                          NumberStyles numberStyles = NumberStyles.None,
                                          IFormatProvider provider = null,
                                          short defaultValue = 0)
            => _ToShort(source, numberStyles, provider, defaultValue);

        /// <summary>
        ///     Parses the given <paramref name="source"/> from a <see cref="ushort"/> to a <see cref="short"/>
        ///     with a posibility of failing as the <see cref="ushort.MaxValue"/> is higher than that of a
        ///     <see cref="short"/>.
        /// </summary>
        /// <param name="source"> The source <see cref="ushort"/> to be parsed to a <see cref="short"/>. </param>
        /// <param name="numberStyles">
        ///     <para>
        ///         Determines the styles permitted in numeric string arguments that are passed to the <c> Parse </c>
        ///         and <c> TryParse </c> methods of the integral and floating-point numeric types.
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
        ///     If successful, returns the given <paramref name="source"/> <see cref="ushort"/> parsed to a
        ///     <see cref="short"/>; otherwise returns if specified <paramref name="defaultValue"/> of if not 0.
        /// </returns>
        public static short ToShortUnsafe(this ushort source,
                                          NumberStyles numberStyles = NumberStyles.None,
                                          IFormatProvider provider = null,
                                          short defaultValue = 0)
            => _ToShort(source, numberStyles, provider, defaultValue);

        private static short _ToShort(this IConvertible source,
                                      NumberStyles numberStyles = NumberStyles.None,
                                      IFormatProvider provider = null,
                                      short defaultValue = 0)
        {
            try {
                return short.Parse(source.ToString(provider), numberStyles, provider);
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