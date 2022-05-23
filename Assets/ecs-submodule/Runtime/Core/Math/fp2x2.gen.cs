//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;
using static Unity.Mathematics.math;
using Unity.Mathematics;

#pragma warning disable 0660, 0661

namespace ME.ECS
{
    [System.Serializable]
    public partial struct fp2x2 : System.IEquatable<fp2x2>, IFormattable
    {
        public fp2 c0;
        public fp2 c1;

        /// <summary>fp2x2 identity transform.</summary>
        public static readonly fp2x2 identity = new fp2x2((fp)1, (fp)0,   (fp)0, (fp)1);

        /// <summary>fp2x2 zero value.</summary>
        public static readonly fp2x2 zero;

        /// <summary>Constructs a fp2x2 matrix from two fp2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public fp2x2(fp2 c0, fp2 c1)
        { 
            this.c0 = c0;
            this.c1 = c1;
        }

        /// <summary>Constructs a fp2x2 matrix from 4 fp values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public fp2x2(fp m00, fp m01,
                     fp m10, fp m11)
        { 
            this.c0 = new fp2(m00, m10);
            this.c1 = new fp2(m01, m11);
        }

        /// <summary>Constructs a fp2x2 matrix from a single fp value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public fp2x2(fp v)
        {
            this.c0 = v;
            this.c1 = v;
        }

        /// <summary>Constructs a fp2x2 matrix from a single int value by converting it to fp and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public fp2x2(int v)
        {
            this.c0 = (fp2)v;
            this.c1 = (fp2)v;
        }

        /// <summary>Constructs a fp2x2 matrix from a int2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public fp2x2(int2x2 v)
        {
            this.c0 = (fp2)v.c0;
            this.c1 = (fp2)v.c1;
        }

        /// <summary>Constructs a fp2x2 matrix from a single uint value by converting it to fp and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public fp2x2(uint v)
        {
            this.c0 = (fp2)v;
            this.c1 = (fp2)v;
        }

        /// <summary>Constructs a fp2x2 matrix from a uint2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public fp2x2(uint2x2 v)
        {
            this.c0 = (fp2)v.c0;
            this.c1 = (fp2)v.c1;
        }


        /// <summary>Implicitly converts a single fp value to a fp2x2 matrix by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator fp2x2(fp v) { return new fp2x2(v); }

        /// <summary>Explicitly converts a single int value to a fp2x2 matrix by converting it to fp and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator fp2x2(int v) { return new fp2x2(v); }

        /// <summary>Explicitly converts a int2x2 matrix to a fp2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator fp2x2(int2x2 v) { return new fp2x2(v); }

        /// <summary>Explicitly converts a single uint value to a fp2x2 matrix by converting it to fp and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator fp2x2(uint v) { return new fp2x2(v); }

        /// <summary>Explicitly converts a uint2x2 matrix to a fp2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator fp2x2(uint2x2 v) { return new fp2x2(v); }


        /// <summary>Returns the result of a componentwise multiplication operation on two fp2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x2 operator * (fp2x2 lhs, fp2x2 rhs) { return new fp2x2 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1); }

        /// <summary>Returns the result of a componentwise multiplication operation on a fp2x2 matrix and a fp value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x2 operator * (fp2x2 lhs, fp rhs) { return new fp2x2 (lhs.c0 * rhs, lhs.c1 * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on a fp value and a fp2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x2 operator * (fp lhs, fp2x2 rhs) { return new fp2x2 (lhs * rhs.c0, lhs * rhs.c1); }


        /// <summary>Returns the result of a componentwise addition operation on two fp2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x2 operator + (fp2x2 lhs, fp2x2 rhs) { return new fp2x2 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1); }

        /// <summary>Returns the result of a componentwise addition operation on a fp2x2 matrix and a fp value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x2 operator + (fp2x2 lhs, fp rhs) { return new fp2x2 (lhs.c0 + rhs, lhs.c1 + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on a fp value and a fp2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x2 operator + (fp lhs, fp2x2 rhs) { return new fp2x2 (lhs + rhs.c0, lhs + rhs.c1); }


        /// <summary>Returns the result of a componentwise subtraction operation on two fp2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x2 operator - (fp2x2 lhs, fp2x2 rhs) { return new fp2x2 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1); }

        /// <summary>Returns the result of a componentwise subtraction operation on a fp2x2 matrix and a fp value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x2 operator - (fp2x2 lhs, fp rhs) { return new fp2x2 (lhs.c0 - rhs, lhs.c1 - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on a fp value and a fp2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x2 operator - (fp lhs, fp2x2 rhs) { return new fp2x2 (lhs - rhs.c0, lhs - rhs.c1); }


        /// <summary>Returns the result of a componentwise division operation on two fp2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x2 operator / (fp2x2 lhs, fp2x2 rhs) { return new fp2x2 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1); }

        /// <summary>Returns the result of a componentwise division operation on a fp2x2 matrix and a fp value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x2 operator / (fp2x2 lhs, fp rhs) { return new fp2x2 (lhs.c0 / rhs, lhs.c1 / rhs); }

        /// <summary>Returns the result of a componentwise division operation on a fp value and a fp2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x2 operator / (fp lhs, fp2x2 rhs) { return new fp2x2 (lhs / rhs.c0, lhs / rhs.c1); }


        /// <summary>Returns the result of a componentwise modulus operation on two fp2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x2 operator % (fp2x2 lhs, fp2x2 rhs) { return new fp2x2 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1); }

        /// <summary>Returns the result of a componentwise modulus operation on a fp2x2 matrix and a fp value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x2 operator % (fp2x2 lhs, fp rhs) { return new fp2x2 (lhs.c0 % rhs, lhs.c1 % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on a fp value and a fp2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x2 operator % (fp lhs, fp2x2 rhs) { return new fp2x2 (lhs % rhs.c0, lhs % rhs.c1); }


        /// <summary>Returns the result of a componentwise increment operation on a fp2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x2 operator ++ (fp2x2 val) { return new fp2x2 (++val.c0, ++val.c1); }


        /// <summary>Returns the result of a componentwise decrement operation on a fp2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x2 operator -- (fp2x2 val) { return new fp2x2 (--val.c0, --val.c1); }


        /// <summary>Returns the result of a componentwise less than operation on two fp2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator < (fp2x2 lhs, fp2x2 rhs) { return new bool2x2 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1); }

        /// <summary>Returns the result of a componentwise less than operation on a fp2x2 matrix and a fp value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator < (fp2x2 lhs, fp rhs) { return new bool2x2 (lhs.c0 < rhs, lhs.c1 < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on a fp value and a fp2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator < (fp lhs, fp2x2 rhs) { return new bool2x2 (lhs < rhs.c0, lhs < rhs.c1); }


        /// <summary>Returns the result of a componentwise less or equal operation on two fp2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator <= (fp2x2 lhs, fp2x2 rhs) { return new bool2x2 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1); }

        /// <summary>Returns the result of a componentwise less or equal operation on a fp2x2 matrix and a fp value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator <= (fp2x2 lhs, fp rhs) { return new bool2x2 (lhs.c0 <= rhs, lhs.c1 <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on a fp value and a fp2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator <= (fp lhs, fp2x2 rhs) { return new bool2x2 (lhs <= rhs.c0, lhs <= rhs.c1); }


        /// <summary>Returns the result of a componentwise greater than operation on two fp2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator > (fp2x2 lhs, fp2x2 rhs) { return new bool2x2 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1); }

        /// <summary>Returns the result of a componentwise greater than operation on a fp2x2 matrix and a fp value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator > (fp2x2 lhs, fp rhs) { return new bool2x2 (lhs.c0 > rhs, lhs.c1 > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on a fp value and a fp2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator > (fp lhs, fp2x2 rhs) { return new bool2x2 (lhs > rhs.c0, lhs > rhs.c1); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two fp2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator >= (fp2x2 lhs, fp2x2 rhs) { return new bool2x2 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a fp2x2 matrix and a fp value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator >= (fp2x2 lhs, fp rhs) { return new bool2x2 (lhs.c0 >= rhs, lhs.c1 >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a fp value and a fp2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator >= (fp lhs, fp2x2 rhs) { return new bool2x2 (lhs >= rhs.c0, lhs >= rhs.c1); }


        /// <summary>Returns the result of a componentwise unary minus operation on a fp2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x2 operator - (fp2x2 val) { return new fp2x2 (-val.c0, -val.c1); }


        /// <summary>Returns the result of a componentwise unary plus operation on a fp2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x2 operator + (fp2x2 val) { return new fp2x2 (+val.c0, +val.c1); }


        /// <summary>Returns the result of a componentwise equality operation on two fp2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator == (fp2x2 lhs, fp2x2 rhs) { return new bool2x2 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1); }

        /// <summary>Returns the result of a componentwise equality operation on a fp2x2 matrix and a fp value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator == (fp2x2 lhs, fp rhs) { return new bool2x2 (lhs.c0 == rhs, lhs.c1 == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on a fp value and a fp2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator == (fp lhs, fp2x2 rhs) { return new bool2x2 (lhs == rhs.c0, lhs == rhs.c1); }


        /// <summary>Returns the result of a componentwise not equal operation on two fp2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator != (fp2x2 lhs, fp2x2 rhs) { return new bool2x2 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1); }

        /// <summary>Returns the result of a componentwise not equal operation on a fp2x2 matrix and a fp value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator != (fp2x2 lhs, fp rhs) { return new bool2x2 (lhs.c0 != rhs, lhs.c1 != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on a fp value and a fp2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator != (fp lhs, fp2x2 rhs) { return new bool2x2 (lhs != rhs.c0, lhs != rhs.c1); }



        /// <summary>Returns the fp2 element at a specified index.</summary>
        unsafe public ref fp2 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (fp2x2* array = &this) { return ref ((fp2*)array)[index]; }
            }
        }

        /// <summary>Returns true if the fp2x2 is equal to a given fp2x2, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(fp2x2 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1); }

        /// <summary>Returns true if the fp2x2 is equal to a given fp2x2, false otherwise.</summary>
        public override bool Equals(object o) { return Equals((fp2x2)o); }


        /// <summary>Returns a hash code for the fp2x2.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)fpmath.hash(this); }


        /// <summary>Returns a string representation of the fp2x2.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("fp2x2({0}, {1},  {2}, {3})", c0.x, c1.x, c0.y, c1.y);
        }

        /// <summary>Returns a string representation of the fp2x2 using a specified format and culture-specific format information.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("fp2x2({0}, {1},  {2}, {3})", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider));
        }

    }

    public static partial class fpmath
    {
        /// <summary>Returns a fp2x2 matrix constructed from two fp2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x2 fp2x2(fp2 c0, fp2 c1) { return new fp2x2(c0, c1); }

        /// <summary>Returns a fp2x2 matrix constructed from from 4 fp values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x2 fp2x2(fp m00, fp m01,
                                  fp m10, fp m11)
        {
            return new fp2x2(m00, m01,
                             m10, m11);
        }

        /// <summary>Returns a fp2x2 matrix constructed from a single fp value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x2 fp2x2(fp v) { return new fp2x2(v); }

        /// <summary>Returns a fp2x2 matrix constructed from a single int value by converting it to fp and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x2 fp2x2(int v) { return new fp2x2(v); }

        /// <summary>Return a fp2x2 matrix constructed from a int2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x2 fp2x2(int2x2 v) { return new fp2x2(v); }

        /// <summary>Returns a fp2x2 matrix constructed from a single uint value by converting it to fp and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x2 fp2x2(uint v) { return new fp2x2(v); }

        /// <summary>Return a fp2x2 matrix constructed from a uint2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x2 fp2x2(uint2x2 v) { return new fp2x2(v); }

        /// <summary>Return the fp2x2 transpose of a fp2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x2 transpose(fp2x2 v)
        {
            return fp2x2(
                v.c0.x, v.c0.y,
                v.c1.x, v.c1.y);
        }

        /// <summary>Returns a uint hash code of a fp2x2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(fp2x2 v)
        {
            return math.csum(fpmath.asuint(v.c0) * uint2(0x90A285BBu, 0x5D19E1D5u) + 
                        fpmath.asuint(v.c1) * uint2(0xFAAF07DDu, 0x625C45BDu)) + 0xC9F27FCBu;
        }

        /// <summary>
        /// Returns a uint2 vector hash code of a fp2x2 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 hashwide(fp2x2 v)
        {
            return (fpmath.asuint(v.c0) * uint2(0x6D2523B1u, 0x6E2BF6A9u) + 
                    fpmath.asuint(v.c1) * uint2(0xCC74B3B7u, 0x83B58237u)) + 0x833E3E29u;
        }

    }
}
