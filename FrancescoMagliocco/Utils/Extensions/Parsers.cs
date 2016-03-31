// ----------------------------------------------------------------------------
// <Copyright File="Parsers.cs" Company="FrancescoMagliocco"
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
//     <Time>15:13</Time>
// </Coded>
// ----------------------------------------------------------------------------

namespace FrancescoMagliocco.Utils.Extensions
{
    using System;
    using System.Globalization;

    /// <summary>
    ///     Extensions involving 'Parsing'.
    /// </summary>
    public static class Parsers
    {
        #region Members
        /// <summary>
        ///     Converts the give value to a <see cref="decimal"/>.
        /// </summary>
        /// <param name="value"> The given value to be converted.  <see cref="IConvertible"/>. </param>
        /// <param name="numberStyles">
        ///     If a number style is not specified, <see cref="NumberStyles.None"/> will be used as default.
        ///     <seealso cref="NumberStyles"/>.
        /// </param>
        /// <param name="provider">
        ///     If a provider is not specified, 'null' will be used as default.  <see cref="IFormatProvider"/>.
        ///     <seealso cref="CultureInfo"/>.
        /// </param>
        /// <returns>
        ///     If conversion is successful, returns the given value converted into a <see cref="decimal"/>, otherwise returns
        ///     0M.
        /// </returns>
        public static decimal ToDecimal(this IConvertible value,
                                        NumberStyles numberStyles = NumberStyles.None,
                                        IFormatProvider provider = null)
        {
            // TODO Make sure nothing is thrown when 'null' is being used as the provider.
            decimal result;
            return decimal.TryParse(value.ToString(provider), numberStyles, provider, out result) ? result : result;
        }

        /// <summary>
        ///     Converts the give value to a <see cref="double"/>.
        /// </summary>
        /// <param name="value"> The given value to be converted.  <see cref="IConvertible"/>. </param>
        /// <param name="numberStyles">
        ///     If a number style is not specified, <see cref="NumberStyles.None"/> will be used as default.
        ///     <seealso cref="NumberStyles"/>.
        /// </param>
        /// <param name="provider">
        ///     If a provider is not specified, 'null' will be used as default.  <see cref="IFormatProvider"/>.
        ///     <seealso cref="CultureInfo"/>.
        /// </param>
        /// <returns>
        ///     If conversion is successful, returns the given value converted into a <see cref="double"/>, otherwise returns
        ///     0D.
        /// </returns>
        public static double ToDouble(this IConvertible value,
                                      NumberStyles numberStyles = NumberStyles.None,
                                      IFormatProvider provider = null)
        {
            // TODO Make sure nothing is thrown when 'null' is being used as the provider.
            double result;
            return double.TryParse(value.ToString(provider), numberStyles, provider, out result) ? result : result;
        }

        /// <summary>
        ///     Converts the give value to a <see cref="float"/>.
        /// </summary>
        /// <param name="value"> The given value to be converted.  <see cref="IConvertible"/>. </param>
        /// <param name="numberStyles">
        ///     If a number style is not specified, <see cref="NumberStyles.None"/> will be used as default.
        ///     <seealso cref="NumberStyles"/>.
        /// </param>
        /// <param name="provider">
        ///     If a provider is not specified, 'null' will be used as default.  <see cref="IFormatProvider"/>.
        ///     <seealso cref="CultureInfo"/>.
        /// </param>
        /// <returns>
        ///     If conversion is successful, returns the given value converted into a <see cref="float"/>, otherwise returns
        ///     0F.
        /// </returns>
        public static float ToFloat(this IConvertible value,
                                    NumberStyles numberStyles = NumberStyles.None,
                                    IFormatProvider provider = null)
        {
            // TODO Make sure nothing is thrown when 'null' is being used as the provider.
            float result;
            return float.TryParse(value.ToString(provider), numberStyles, provider, out result) ? result : result;
        }

        /// <summary>
        ///     Converts the give value to an <see cref="int"/>.
        /// </summary>
        /// <param name="value"> The given value to be converted.  <see cref="IConvertible"/>. </param>
        /// <param name="numberStyles">
        ///     If a number style is not specified, <see cref="NumberStyles.None"/> will be used as default.
        ///     <seealso cref="NumberStyles"/>.
        /// </param>
        /// <param name="provider">
        ///     If a provider is not specified, 'null' will be used as default.  <see cref="IFormatProvider"/>.
        ///     <seealso cref="CultureInfo"/>.
        /// </param>
        /// <returns>
        ///     If conversion is successful, returns the given value converted into an <see cref="int"/>, otherwise returns
        ///     0.
        /// </returns>
        public static int ToInt(this IConvertible value,
                                NumberStyles numberStyles = NumberStyles.None,
                                IFormatProvider provider = null)
        {
            // TODO Make sure nothing is thrown when 'null' is being used as the provider.
            int result;
            return int.TryParse(value.ToString(provider), numberStyles, provider, out result) ? result : result;
        }

        /// <summary>
        ///     Converts the give value to a <see cref="long"/>.
        /// </summary>
        /// <param name="value"> The given value to be converted.  <see cref="IConvertible"/>. </param>
        /// <param name="numberStyles">
        ///     If a number style is not specified, <see cref="NumberStyles.None"/> will be used as default.
        ///     <seealso cref="NumberStyles"/>.
        /// </param>
        /// <param name="provider">
        ///     If a provider is not specified, 'null' will be used as default.  <see cref="IFormatProvider"/>.
        ///     <seealso cref="CultureInfo"/>.
        /// </param>
        /// <returns>
        ///     If conversion is successful, returns the given value converted into a <see cref="long"/>, otherwise returns
        ///     0L.
        /// </returns>
        public static long ToLong(this IConvertible value,
                                  NumberStyles numberStyles = NumberStyles.None,
                                  IFormatProvider provider = null)
        {
            // TODO Make sure nothing is thrown when 'null' is being used as the provider.
            long result;
            return long.TryParse(value.ToString(provider), numberStyles, provider, out result) ? result : result;
        }
        #endregion
    }
}