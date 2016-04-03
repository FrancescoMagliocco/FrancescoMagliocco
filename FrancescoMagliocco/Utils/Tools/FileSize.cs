// ----------------------------------------------------------------------------
// <Copyright File="FileSize.cs" Company="FrancescoMagliocco"
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
//     <Time>22:31</Time>
// </Coded>
// ----------------------------------------------------------------------------

namespace FrancescoMagliocco.Utils.Tools
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;

    /// <summary>
    ///     Used to differenetiate between the two base messurment values.
    /// </summary>
    public enum BaseValue
    {
        /// <summary>
        ///     Base2 (Byte, 2 ^ 10)
        /// </summary>
        Binary,

        /// <summary>
        ///     Base10 (Bit, 10 ^ 3)
        /// </summary>
        Decimal
    }

    /// <summary>
    ///     Contains each unit meassure for both base values.
    /// </summary>
    public enum Units : ulong
    {
        /// <summary>
        ///     KiloBit, Kb, 10 ^ 3
        /// </summary>
        Kb = 1000UL,

        /// <summary>
        ///     MegaBit, Mb, 10 ^ 6
        /// </summary>
        Mb = 1000000UL,

        /// <summary>
        ///     GigaBit, Gb, 10 ^ 9
        /// </summary>
        Gb = 1000000000UL,

        /// <summary>
        ///     TeraBit, Tb, 10 ^ 12
        /// </summary>
        Tb = 1000000000000UL,

        /// <summary>
        ///     PetaBit, Pb, 10 ^ 15
        /// </summary>
        Pb = 1000000000000000UL,

        /// <summary>
        ///     ExaBit, Eb, 10 ^ 18
        /// </summary>
        Eb = 1000000000000000000UL,

        /// <summary>
        ///     KiloByte, KB, 2 ^ 10
        /// </summary>
        KB = 1024UL,

        /// <summary>
        ///     MegaByte, MB, 2 ^ 20
        /// </summary>
        MB = 1048576UL,

        /// <summary>
        ///     GigaByte, GB, 2 ^ 30
        /// </summary>
        GB = 1073741824UL,

        /// <summary>
        ///     TeraByte, TB, 2 ^ 40
        /// </summary>
        TB = 1099511627776UL,

        /// <summary>
        ///     PetaByte, PB, 2 ^ 50
        /// </summary>
        PB = 1125899906842624UL,

        /// <summary>
        ///     ExaByte, EB, 2 ^ 60
        /// </summary>
        EB = 1152921504606846978UL
    }

    /// <summary>
    ///     Class for handling File Size more adequetely.
    /// </summary>
    public sealed class FileSize
    {
        #region Fields
        /// <summary>
        ///     KiloBit, Kb, 10 ^ 3
        /// </summary>
        public const decimal KiloBit = 1000M;

        /// <summary>
        ///     MegaBit, Mb, 10 ^ 6
        /// </summary>
        public const decimal MegaBit = 1000000M;

        /// <summary>
        ///     GigaBit, Gb, 10 ^ 9
        /// </summary>
        public const decimal GigaBit = 1000000000M;

        /// <summary>
        ///     TeraBit, Tb, 10 ^ 12
        /// </summary>
        public const decimal TeraBit = 1000000000000M;

        /// <summary>
        ///     PetaBit, Pb, 10 ^ 15
        /// </summary>
        public const decimal PetaBit = 1000000000000000M;

        /// <summary>
        ///     ExaBit, Eb, 10 ^ 18
        /// </summary>
        public const decimal ExaBit = 1000000000000000000M;

        /// <summary>
        ///     ZettaBit, Zb, 10 ^ 21
        /// </summary>
        public const decimal ZettaBit = 1000000000000000000000M;

        /// <summary>
        ///     YottaBit, Yb, 10 ^ 24
        /// </summary>
        public const decimal YottaBit = 1000000000000000000000000M;

        /// <summary>
        ///     KiloByte, KB, 2 ^ 10
        /// </summary>
        public const decimal KiloByte = 1024M;

        /// <summary>
        ///     MegaByte, MB, 2 ^ 20
        /// </summary>
        public const decimal MegaByte = 1048576M;

        /// <summary>
        ///     GigaByte, GB, 2 ^ 30
        /// </summary>
        public const decimal GigaByte = 1073741824M;

        /// <summary>
        ///     TeraByte, TB, 2 ^ 40
        /// </summary>
        public const decimal TeraByte = 1099511627776M;

        /// <summary>
        ///     PetaByte, PB, 2 ^ 50
        /// </summary>
        public const decimal PetaByte = 1125899906842624M;

        /// <summary>
        ///     ExaByte, EB, 2 ^ 60
        /// </summary>
        public const decimal ExaByte = 1152921504606846978M;

        /// <summary>
        ///     ZettaByte, ZB, 2 ^ 70
        /// </summary>
        public const decimal ZettaByte = 1180591620717411303424M;

        /// <summary>
        ///     YottaByte, YB, 2 ^ 80
        /// </summary>
        public const decimal YottaByte = 1208925819614629174706176M;

        private readonly BaseValue _baseValue;
        #endregion

        #region Properties and Indexers
        /// <summary>
        ///     Gets or Sets the File Size in Bits or Bytes.
        /// </summary>
        public decimal Size { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        ///     Creates a new instance for class FileSize
        /// </summary>
        /// <param name="baseValue">
        ///     Base used for meassurment.
        /// </param>
        /// <param name="size">
        ///     The size in Bits or Bytes.
        /// </param>
        public FileSize(BaseValue baseValue = BaseValue.Binary, decimal size = 0M)
        {
            this._baseValue = baseValue;
            this.Size = size;
        }
        #endregion

        #region Members
        /// <summary>
        ///     Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <returns>
        ///     true if the specified object  is equal to the current object; otherwise, false.
        /// </returns>
        /// <param name="obj">
        ///     The object to compare with the current object.
        /// </param>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) { return false; }
            if (ReferenceEquals(this, obj)) { return true; }
            return obj is FileSize && this.Equals((FileSize)obj);
        }

        /// <summary>
        ///     Serves as the default hash function.
        /// </summary>
        /// <returns>
        ///     A hash code for the current object.
        /// </returns>
        public override int GetHashCode()
        {
            unchecked { return ((int)this._baseValue * 397) ^ this.Size.GetHashCode(); }
        }

        /// <summary>
        ///     Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        ///     A string that represents the current object.
        /// </returns>
        public override string ToString() => this.Size + (this._baseValue == BaseValue.Binary ? "b" : "B");

        /// <summary>
        ///     Checks if the two specified <see cref="FileSize"/> are equal.  <seealso cref="Size"/>.
        /// </summary>
        /// <param name="fileSizeA">
        ///     The <see cref="FileSize"/> to check if equal to <paramref name="fileSizeB"/>.  <seealso cref="Size"/>.
        /// </param>
        /// <param name="fileSizeB">
        ///     The <see cref="FileSize"/> to check if equal to <paramref name="fileSizeA"/>.  <seealso cref="Size"/>.
        /// </param>
        /// <returns>
        ///     If <paramref name="fileSizeA"/> is equal to <paramref name="fileSizeB"/>, return true.  Otherwise returns false.
        ///     <seealso cref="FileSize"/>.  <seealso cref="Size"/>.
        /// </returns>
        public static bool operator ==(FileSize fileSizeA, FileSize fileSizeB)
        {
            if (ReferenceEquals(fileSizeA, fileSizeB)) { return true; }
            if (((object)fileSizeA == null) ||
                ((object)fileSizeB == null)) {
                    return false;
                }

            return fileSizeA.Size == fileSizeB.Size;
        }

        /// <summary>
        ///     Checks if the two specified <see cref="FileSize"/> are not equal.  <seealso cref="Size"/>.
        /// </summary>
        /// <param name="fileSizeA">
        ///     The <see cref="FileSize"/> to check if not equal to <paramref name="fileSizeB"/>.  <seealso cref="Size"/>.
        /// </param>
        /// <param name="fileSizeB">
        ///     The <see cref="FileSize"/> to check if not equal to <paramref name="fileSizeA"/>.  <seealso cref="Size"/>.
        /// </param>
        /// <returns>
        ///     If <paramref name="fileSizeA"/> is not equal to <paramref name="fileSizeB"/>, returns true.  Otherwise returns
        ///     false.  <seealso cref="FileSize"/>.  <seealso cref="Size"/>.
        /// </returns>
        public static bool operator !=(FileSize fileSizeA, FileSize fileSizeB) => !(fileSizeA == fileSizeB);

        /// <summary>
        ///     Compares and checks if <paramref name="fileSizeA"/> is greater than <paramref name="fileSizeB"/>.
        ///     <seealso cref="FileSize"/>.  <seealso cref="Size"/>.
        /// </summary>
        /// <param name="fileSizeA">
        ///     The <see cref="FileSize"/> to compare and check to see if greater than <paramref name="fileSizeB"/>.
        ///     <seealso cref="Size"/>.
        /// </param>
        /// <param name="fileSizeB">
        ///     The <see cref="FileSize"/> that is compared and checked to see if less than <paramref name="fileSizeA"/>.
        ///     <seealso cref="Size"/>.
        /// </param>
        /// <returns>
        ///     If <paramref name="fileSizeA"/> is greater than <paramref name="fileSizeB"/>, returns true.  Otherwise returns
        ///     false.  <seealso cref="FileSize"/>.  <seealso cref="Size"/>.
        /// </returns>
        public static bool operator >(FileSize fileSizeA, FileSize fileSizeB)
        {
            if (((object)fileSizeA == null) ||
                ((object)fileSizeB == null)) {
                    return false;
                }

            return fileSizeA.Size > fileSizeB.Size;
        }

        /// <summary>
        ///     Compares and checks if <paramref name="fileSizeA"/> is less than <paramref name="fileSizeB"/>.
        ///     <seealso cref="FileSize"/>.  <seealso cref="Size"/>.
        /// </summary>
        /// <param name="fileSizeA">
        ///     The <see cref="FileSize"/> to compare and check to see if less than <paramref name="fileSizeB"/>.
        ///     <seealso cref="Size"/>.
        /// </param>
        /// <param name="fileSizeB">
        ///     The <see cref="FileSize"/> that is compared and checked to see if greater than <paramref name="fileSizeA"/>.
        ///     <seealso cref="Size"/>.
        /// </param>
        /// <returns>
        ///     If <paramref name="fileSizeA"/> is less than <paramref name="fileSizeB"/>, returns true.  Otherwise returns false.
        ///     <seealso cref="FileSize"/>.  <seealso cref="Size"/>.
        /// </returns>
        public static bool operator <(FileSize fileSizeA, FileSize fileSizeB)
        {
            if (((object)fileSizeA == null) ||
                ((object)fileSizeB == null)) {
                    return false;
                }

            return fileSizeA.Size < fileSizeB.Size;
        }

        /// <summary>
        ///     Compares and checks if <paramref name="fileSizeA"/> is greater than or equal to <paramref name="fileSizeB"/>.
        ///     <seealso cref="FileSize"/>.  <seealso cref="Size"/>.
        /// </summary>
        /// <param name="fileSizeA">
        ///     The <see cref="FileSize"/> to compare and check to see if greater than or equal to <paramref name="fileSizeB"/>.
        ///     <seealso cref="Size"/>.
        /// </param>
        /// <param name="fileSizeB">
        ///     The <see cref="FileSize"/> that is compared and checked to see if less than or equal to
        ///     <paramref name="fileSizeA"/>.  <seealso cref="Size"/>.
        /// </param>
        /// <returns>
        ///     If <paramref name="fileSizeA"/> is greater than or equal to <paramref name="fileSizeB"/>, returns true.  Otherwise
        ///     returns false.  <seealso cref="FileSize"/>.  <seealso cref="Size"/>.
        /// </returns>
        public static bool operator >=(FileSize fileSizeA, FileSize fileSizeB)
        {
            if (((object)fileSizeA == null) ||
                ((object)fileSizeB == null)) {
                    return false;
                }

            return fileSizeA.Size >= fileSizeB.Size;
        }

        /// <summary>
        ///     Compares and checks if <paramref name="fileSizeA"/> is less than or equal to <paramref name="fileSizeB"/>.
        ///     <seealso cref="FileSize"/>.  <seealso cref="Size"/>.
        /// </summary>
        /// <param name="fileSizeA">
        ///     The <see cref="FileSize"/> to compare and check to see if less than or equal to <paramref name="fileSizeB"/>.
        ///     <seealso cref="Size"/>.
        /// </param>
        /// <param name="fileSizeB">
        ///     The <see cref="FileSize"/> that is compared and checked to see if greater than or equal to
        ///     <paramref name="fileSizeA"/>.  <seealso cref="Size"/>.
        /// </param>
        /// <returns>
        ///     If <paramref name="fileSizeA"/> is less than or equal to <paramref name="fileSizeB"/>, returns true.  Otherwise
        ///     returns false.  <seealso cref="FileSize"/>.  <seealso cref="Size"/>.
        /// </returns>
        public static bool operator <=(FileSize fileSizeA, FileSize fileSizeB)
        {
            if (((object)fileSizeA == null) ||
                ((object)fileSizeB == null)) {
                    return false;
                }

            return fileSizeA.Size <= fileSizeB.Size;
        }

        /// <summary>
        ///     Converts the current <see cref="Size"/> to the specified <see cref="Units"/>.  <seealso cref="FileSize"/>.
        /// </summary>
        /// <param name="unit">
        ///     The specified <see cref="Units"/> used to convert the current <see cref="Size"/> to.  <seealso cref="FileSize"/>.
        /// </param>
        /// <param name="cultureInfo">
        ///     If <see cref="CultureInfo"/> is not provded, 'null' will be used.
        /// </param>
        /// <param name="numberStyles">
        ///     If a number style is not specified, <see cref="NumberStyles.None"/> will be used as default.
        ///     <seealso cref="NumberStyles"/>.
        /// </param>
        /// <param name="provider">
        ///     If a provider is not specified, 'null' will be used as default.  <see cref="IFormatProvider"/>.
        ///     <seealso cref="CultureInfo"/>.
        /// </param>
        /// <returns>
        ///     If parse is successful, returns the current <see cref="Size"/>, converted to the specified <paramref name="unit"/>,
        ///     others returns the current <see cref="Size"/> converted to the new <see cref="BaseValue"/> (If specified) with the
        ///     correct value.  <seealso cref="Units"/>.  <seealso cref="FileSize"/>.  <seealso cref="decimal"/>.
        /// </returns>
        public decimal ToUnit(Units unit,
                              CultureInfo cultureInfo = null,
                              NumberStyles numberStyles = NumberStyles.None,
                              IFormatProvider provider = null)
        {
            decimal result;
            var tempSize = this._baseValue == BaseValue.Binary
                               ? nameof(unit).EndsWith("B", false, cultureInfo) ? this.Size : this.Size * 8M
                               : nameof(unit).EndsWith("b", false, cultureInfo) ? this.Size : this.Size / 8M;
            /*
             * So I'm hoping that if suceeded it will return the correct value, and if it doesn't succeed that it will
             * atleast return it convertetd into the new base (If specified) with the correct value.
             */
            return decimal.TryParse((tempSize / (ulong)unit).ToString(provider), numberStyles, provider, out result)
                       ? result
                       : tempSize;
        }

        /// <summary>
        ///     Converts the current <see cref="Size"/> to the specified <see cref="Units"/>, then into a <see cref="string"/>.
        ///     <seealso cref="FileSize"/>.
        /// </summary>
        /// <param name="unit">
        ///     The specified <see cref="Units"/> used to convert the current <see cref="Size"/> to.  <seealso cref="FileSize"/>.
        /// </param>
        /// <param name="cultureInfo">
        ///     If <see cref="CultureInfo"/> is not provded, 'null' will be used.
        /// </param>
        /// <param name="numberStyles">
        ///     If a number style is not specified, <see cref="NumberStyles.None"/> will be used as default.
        ///     <seealso cref="NumberStyles"/>.
        /// </param>
        /// <param name="provider">
        ///     If a provider is not specified, 'null' will be used as default.  <see cref="IFormatProvider"/>.
        ///     <seealso cref="CultureInfo"/>.
        /// </param>
        /// <returns>
        ///     If parse is successful, returns the current <see cref="Size"/>, converted to the specified <paramref name="unit"/>,
        ///     then to a <see cref="string"/>, otherwise returns the current <see cref="Size"/> converted to the new
        ///     <see cref="BaseValue"/> (If specified) with the correct value, then to a <see cref="string"/>.
        ///     <seealso cref="Units"/>.  <seealso cref="FileSize"/>.  <seealso cref="decimal"/>
        /// </returns>
        public string ToUnitString(Units unit,
                                   CultureInfo cultureInfo = null,
                                   NumberStyles numberStyles = NumberStyles.None,
                                   IFormatProvider provider = null)
            => this.ToUnit(unit, cultureInfo, numberStyles, provider) + nameof(unit);

        // TODO Static FromUnitToUnit (Maybe try to use generics)
        // TODO Static FromUnitToUnitString (Maybe try to use generics)

        /// <summary>
        ///     Converts the current <see cref="Size"/> to a <see cref="ZettaBit"/>.  <seealso cref="FileSize"/>.
        /// </summary>
        /// <param name="numberStyles">
        ///     If a number style is not specified, <see cref="NumberStyles.None"/> will be used as default.
        ///     <seealso cref="NumberStyles"/>.
        /// </param>
        /// <param name="provider">
        ///     If a provider is not specified, 'null' will be used as default.  <see cref="IFormatProvider"/>.
        ///     <seealso cref="CultureInfo"/>.
        /// </param>
        /// <returns>
        ///     If parse is successful, returns the current <see cref="Size"/>, converted to a <see cref="ZettaBit"/>,
        ///     otherwise returns the current <see cref="Size"/> converted to the new <see cref="BaseValue"/> (If specified) with
        ///     the correct value.  <seealso cref="Units"/>.  <seealso cref="FileSize"/>.  <seealso cref="decimal"/>.
        /// </returns>
        public decimal ToZettaBit(NumberStyles numberStyles = NumberStyles.None, IFormatProvider provider = null)
        {
            decimal result;
            var tempSize = this._baseValue == BaseValue.Binary ? this.Size * 8M : this.Size;
            /*
             * So I'm hoping that if suceeded it will return the correct value, and if it doesn't succeed that it will
             * atleast return it convertetd into the new base (If specified) with the correct value.
             */
            return decimal.TryParse((tempSize / ZettaBit).ToString(provider), numberStyles, provider, out result)
                       ? result
                       : tempSize;
        }

        /// <summary>
        ///     Converts the current <see cref="Size"/> to a <see cref="ZettaBit"/>, then into a <see cref="string"/>.
        ///     <seealso cref="FileSize"/>.
        /// </summary>
        /// <param name="numberStyles">
        ///     If a number style is not specified, <see cref="NumberStyles.None"/> will be used as default.
        ///     <seealso cref="NumberStyles"/>.
        /// </param>
        /// <param name="provider">
        ///     If a provider is not specified, 'null' will be used as default.  <see cref="IFormatProvider"/>.
        ///     <seealso cref="CultureInfo"/>.
        /// </param>
        /// <returns>
        ///     If parse is successful, returns the current <see cref="Size"/>, converted to a <see cref="ZettaBit"/>,
        ///     otherwise returns the current <see cref="Size"/> converted to the new <see cref="BaseValue"/> (If specified) with
        ///     the correct value, then to a <see cref="string"/>.  <seealso cref="Units"/>.  <seealso cref="FileSize"/>.
        ///     <seealso cref="decimal"/>.
        /// </returns>
        public string ToZettaBitString(NumberStyles numberStyles = NumberStyles.None, IFormatProvider provider = null)
            => this.ToZettaBit(numberStyles, provider) + "Zb";

        /// <summary>
        ///     Converts the current <see cref="Size"/> to a <see cref="ZettaByte"/>.  <seealso cref="FileSize"/>.
        /// </summary>
        /// <param name="numberStyles">
        ///     If a number style is not specified, <see cref="NumberStyles.None"/> will be used as default.
        ///     <seealso cref="NumberStyles"/>.
        /// </param>
        /// <param name="provider">
        ///     If a provider is not specified, 'null' will be used as default.  <see cref="IFormatProvider"/>.
        ///     <seealso cref="CultureInfo"/>.
        /// </param>
        /// <returns>
        ///     If parse is successful, returns the current <see cref="Size"/>, converted to a <see cref="ZettaByte"/>,
        ///     otherwise returns the current <see cref="Size"/> converted to the new <see cref="BaseValue"/> (If specified) with
        ///     the correct value.  <seealso cref="Units"/>.  <seealso cref="FileSize"/>.  <seealso cref="decimal"/>.
        /// </returns>
        public decimal ToZettaByte(NumberStyles numberStyles = NumberStyles.None, IFormatProvider provider = null)
        {
            decimal result;
            var tempSize = this._baseValue == BaseValue.Binary ? this.Size : this.Size / 8M;
            /*
             * So I'm hoping that if suceeded it will return the correct value, and if it doesn't succeed that it will
             * atleast return it convertetd into the new base (If specified) with the correct value.
             */
            return decimal.TryParse((tempSize / ZettaByte).ToString(provider), numberStyles, provider, out result)
                       ? result
                       : tempSize;
        }

        /// <summary>
        ///     Converts the current <see cref="Size"/> to a <see cref="ZettaByte"/>, then into a <see cref="string"/>.
        ///     <seealso cref="FileSize"/>.
        /// </summary>
        /// <param name="numberStyles">
        ///     If a number style is not specified, <see cref="NumberStyles.None"/> will be used as default.
        ///     <seealso cref="NumberStyles"/>.
        /// </param>
        /// <param name="provider">
        ///     If a provider is not specified, 'null' will be used as default.  <see cref="IFormatProvider"/>.
        ///     <seealso cref="CultureInfo"/>.
        /// </param>
        /// <returns>
        ///     If parse is successful, returns the current <see cref="Size"/>, converted to a <see cref="ZettaByte"/>,
        ///     otherwise returns the current <see cref="Size"/> converted to the new <see cref="BaseValue"/> (If specified) with
        ///     the correct value, then to a <see cref="string"/>.  <seealso cref="Units"/>.  <seealso cref="FileSize"/>.
        ///     <seealso cref="decimal"/>.
        /// </returns>
        public string ToZettaByteString(NumberStyles numberStyles = NumberStyles.None, IFormatProvider provider = null)
            => this.ToZettaByte(numberStyles, provider) + "ZB";

        /// <summary>
        ///     Converts the current <see cref="Size"/> to a <see cref="YottaBit"/>.  <seealso cref="FileSize"/>.
        /// </summary>
        /// <param name="numberStyles">
        ///     If a number style is not specified, <see cref="NumberStyles.None"/> will be used as default.
        ///     <seealso cref="NumberStyles"/>.
        /// </param>
        /// <param name="provider">
        ///     If a provider is not specified, 'null' will be used as default.  <see cref="IFormatProvider"/>.
        ///     <seealso cref="CultureInfo"/>.
        /// </param>
        /// <returns>
        ///     If parse is successful, returns the current <see cref="Size"/>, converted to a <see cref="YottaBit"/>,
        ///     otherwise returns the current <see cref="Size"/> converted to the new <see cref="BaseValue"/> (If specified) with
        ///     the correct value.  <seealso cref="Units"/>.  <seealso cref="FileSize"/>.  <seealso cref="decimal"/>.
        /// </returns>
        public decimal ToYottaBit(NumberStyles numberStyles = NumberStyles.None, IFormatProvider provider = null)
        {
            decimal result;
            var tempSize = this._baseValue == BaseValue.Binary ? this.Size * 8M : this.Size;
            /*
             * So I'm hoping that if suceeded it will return the correct value, and if it doesn't succeed that it will
             * atleast return it convertetd into the new base (If specified) with the correct value.
             */
            return decimal.TryParse((tempSize / YottaBit).ToString(provider), numberStyles, provider, out result)
                       ? result
                       : tempSize;
        }

        /// <summary>
        ///     Converts the current <see cref="Size"/> to a <see cref="YottaBit"/>, then into a <see cref="string"/>.
        ///     <seealso cref="FileSize"/>.
        /// </summary>
        /// <param name="numberStyles">
        ///     If a number style is not specified, <see cref="NumberStyles.None"/> will be used as default.
        ///     <seealso cref="NumberStyles"/>.
        /// </param>
        /// <param name="provider">
        ///     If a provider is not specified, 'null' will be used as default.  <see cref="IFormatProvider"/>.
        ///     <seealso cref="CultureInfo"/>.
        /// </param>
        /// <returns>
        ///     If parse is successful, returns the current <see cref="Size"/>, converted to a <see cref="YottaBit"/>,
        ///     otherwise returns the current <see cref="Size"/> converted to the new <see cref="BaseValue"/> (If specified) with
        ///     the correct value, then to a <see cref="string"/>.  <seealso cref="Units"/>.  <seealso cref="FileSize"/>.
        ///     <seealso cref="decimal"/>.
        /// </returns>
        public string ToYottaBitString(NumberStyles numberStyles = NumberStyles.None, IFormatProvider provider = null)
            => this.ToYottaBit(numberStyles, provider) + "Yb";

        /// <summary>
        ///     Converts the current <see cref="Size"/> to a <see cref="YottaByte"/>.  <seealso cref="FileSize"/>.
        /// </summary>
        /// <param name="numberStyles">
        ///     If a number style is not specified, <see cref="NumberStyles.None"/> will be used as default.
        ///     <seealso cref="NumberStyles"/>.
        /// </param>
        /// <param name="provider">
        ///     If a provider is not specified, 'null' will be used as default.  <see cref="IFormatProvider"/>.
        ///     <seealso cref="CultureInfo"/>.
        /// </param>
        /// <returns>
        ///     If parse is successful, returns the current <see cref="Size"/>, converted to a <see cref="YottaByte"/>,
        ///     otherwise returns the current <see cref="Size"/> converted to the new <see cref="BaseValue"/> (If specified) with
        ///     the correct value.  <seealso cref="Units"/>.  <seealso cref="FileSize"/>.  <seealso cref="decimal"/>.
        /// </returns>
        public decimal ToYottaByte(NumberStyles numberStyles = NumberStyles.None, IFormatProvider provider = null)
        {
            decimal result;
            var tempSize = this._baseValue == BaseValue.Binary ? this.Size : this.Size / 8M;
            /*
             * So I'm hoping that if suceeded it will return the correct value, and if it doesn't succeed that it will
             * atleast return it convertetd into the new base (If specified) with the correct value.
             */
            return decimal.TryParse((tempSize / YottaByte).ToString(provider), numberStyles, provider, out result)
                       ? result
                       : tempSize;
        }

        /// <summary>
        ///     Converts the current <see cref="Size"/> to a <see cref="YottaByte"/>, then into a <see cref="string"/>.
        ///     <seealso cref="FileSize"/>.
        /// </summary>
        /// <param name="numberStyles">
        ///     If a number style is not specified, <see cref="NumberStyles.None"/> will be used as default.
        ///     <seealso cref="NumberStyles"/>.
        /// </param>
        /// <param name="provider">
        ///     If a provider is not specified, 'null' will be used as default.  <see cref="IFormatProvider"/>.
        ///     <seealso cref="CultureInfo"/>.
        /// </param>
        /// <returns>
        ///     If parse is successful, returns the current <see cref="Size"/>, converted to a <see cref="YottaByte"/>,
        ///     otherwise returns the current <see cref="Size"/> converted to the new <see cref="BaseValue"/> (If specified) with
        ///     the correct value, then to a <see cref="string"/>.  <seealso cref="Units"/>.  <seealso cref="FileSize"/>.
        ///     <seealso cref="decimal"/>.
        /// </returns>
        public string ToYottaByteString(NumberStyles numberStyles = NumberStyles.None, IFormatProvider provider = null)
            => this.ToYottaByte(numberStyles, provider) + "YB";

        private bool Equals(FileSize other) => (this._baseValue == other._baseValue) && (this.Size == other.Size);
        #endregion
    }
}