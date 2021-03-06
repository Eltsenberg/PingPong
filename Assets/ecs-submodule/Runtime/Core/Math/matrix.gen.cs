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
using Unity.Mathematics;

namespace ME.ECS
{
    partial class fpmath
    {
        /// <summary>Returns the fp value result of a matrix multiplication between a fp value and a fp value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp mul(fp a, fp b)
        {
            return a * b;
        }

        /// <summary>Returns the fp value result of a matrix multiplication between a fp2 row vector and a fp2 column vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp mul(fp2 a, fp2 b)
        {
            return a.x * b.x + a.y * b.y;
        }

        /// <summary>Returns the fp2 row vector result of a matrix multiplication between a fp2 row vector and a fp2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2 mul(fp2 a, fp2x2 b)
        {
            return fp2(
                a.x * b.c0.x + a.y * b.c0.y,
                a.x * b.c1.x + a.y * b.c1.y);
        }

        /// <summary>Returns the fp3 row vector result of a matrix multiplication between a fp2 row vector and a fp2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp3 mul(fp2 a, fp2x3 b)
        {
            return fp3(
                a.x * b.c0.x + a.y * b.c0.y,
                a.x * b.c1.x + a.y * b.c1.y,
                a.x * b.c2.x + a.y * b.c2.y);
        }

        /// <summary>Returns the fp4 row vector result of a matrix multiplication between a fp2 row vector and a fp2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp4 mul(fp2 a, fp2x4 b)
        {
            return fp4(
                a.x * b.c0.x + a.y * b.c0.y,
                a.x * b.c1.x + a.y * b.c1.y,
                a.x * b.c2.x + a.y * b.c2.y,
                a.x * b.c3.x + a.y * b.c3.y);
        }

        /// <summary>Returns the fp value result of a matrix multiplication between a fp3 row vector and a fp3 column vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp mul(fp3 a, fp3 b)
        {
            return a.x * b.x + a.y * b.y + a.z * b.z;
        }

        /// <summary>Returns the fp2 row vector result of a matrix multiplication between a fp3 row vector and a fp3x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2 mul(fp3 a, fp3x2 b)
        {
            return fp2(
                a.x * b.c0.x + a.y * b.c0.y + a.z * b.c0.z,
                a.x * b.c1.x + a.y * b.c1.y + a.z * b.c1.z);
        }

        /// <summary>Returns the fp3 row vector result of a matrix multiplication between a fp3 row vector and a fp3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp3 mul(fp3 a, fp3x3 b)
        {
            return fp3(
                a.x * b.c0.x + a.y * b.c0.y + a.z * b.c0.z,
                a.x * b.c1.x + a.y * b.c1.y + a.z * b.c1.z,
                a.x * b.c2.x + a.y * b.c2.y + a.z * b.c2.z);
        }

        /// <summary>Returns the fp4 row vector result of a matrix multiplication between a fp3 row vector and a fp3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp4 mul(fp3 a, fp3x4 b)
        {
            return fp4(
                a.x * b.c0.x + a.y * b.c0.y + a.z * b.c0.z,
                a.x * b.c1.x + a.y * b.c1.y + a.z * b.c1.z,
                a.x * b.c2.x + a.y * b.c2.y + a.z * b.c2.z,
                a.x * b.c3.x + a.y * b.c3.y + a.z * b.c3.z);
        }

        /// <summary>Returns the fp value result of a matrix multiplication between a fp4 row vector and a fp4 column vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp mul(fp4 a, fp4 b)
        {
            return a.x * b.x + a.y * b.y + a.z * b.z + a.w * b.w;
        }

        /// <summary>Returns the fp2 row vector result of a matrix multiplication between a fp4 row vector and a fp4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2 mul(fp4 a, fp4x2 b)
        {
            return fp2(
                a.x * b.c0.x + a.y * b.c0.y + a.z * b.c0.z + a.w * b.c0.w,
                a.x * b.c1.x + a.y * b.c1.y + a.z * b.c1.z + a.w * b.c1.w);
        }

        /// <summary>Returns the fp3 row vector result of a matrix multiplication between a fp4 row vector and a fp4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp3 mul(fp4 a, fp4x3 b)
        {
            return fp3(
                a.x * b.c0.x + a.y * b.c0.y + a.z * b.c0.z + a.w * b.c0.w,
                a.x * b.c1.x + a.y * b.c1.y + a.z * b.c1.z + a.w * b.c1.w,
                a.x * b.c2.x + a.y * b.c2.y + a.z * b.c2.z + a.w * b.c2.w);
        }

        /// <summary>Returns the fp4 row vector result of a matrix multiplication between a fp4 row vector and a fp4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp4 mul(fp4 a, fp4x4 b)
        {
            return fp4(
                a.x * b.c0.x + a.y * b.c0.y + a.z * b.c0.z + a.w * b.c0.w,
                a.x * b.c1.x + a.y * b.c1.y + a.z * b.c1.z + a.w * b.c1.w,
                a.x * b.c2.x + a.y * b.c2.y + a.z * b.c2.z + a.w * b.c2.w,
                a.x * b.c3.x + a.y * b.c3.y + a.z * b.c3.z + a.w * b.c3.w);
        }

        /// <summary>Returns the fp2 column vector result of a matrix multiplication between a fp2x2 matrix and a fp2 column vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2 mul(fp2x2 a, fp2 b)
        {
            return a.c0 * b.x + a.c1 * b.y;
        }

        /// <summary>Returns the fp2x2 matrix result of a matrix multiplication between a fp2x2 matrix and a fp2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x2 mul(fp2x2 a, fp2x2 b)
        {
            return fp2x2(
                a.c0 * b.c0.x + a.c1 * b.c0.y,
                a.c0 * b.c1.x + a.c1 * b.c1.y);
        }

        /// <summary>Returns the fp2x3 matrix result of a matrix multiplication between a fp2x2 matrix and a fp2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x3 mul(fp2x2 a, fp2x3 b)
        {
            return fp2x3(
                a.c0 * b.c0.x + a.c1 * b.c0.y,
                a.c0 * b.c1.x + a.c1 * b.c1.y,
                a.c0 * b.c2.x + a.c1 * b.c2.y);
        }

        /// <summary>Returns the fp2x4 matrix result of a matrix multiplication between a fp2x2 matrix and a fp2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x4 mul(fp2x2 a, fp2x4 b)
        {
            return fp2x4(
                a.c0 * b.c0.x + a.c1 * b.c0.y,
                a.c0 * b.c1.x + a.c1 * b.c1.y,
                a.c0 * b.c2.x + a.c1 * b.c2.y,
                a.c0 * b.c3.x + a.c1 * b.c3.y);
        }

        /// <summary>Returns the fp2 column vector result of a matrix multiplication between a fp2x3 matrix and a fp3 column vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2 mul(fp2x3 a, fp3 b)
        {
            return a.c0 * b.x + a.c1 * b.y + a.c2 * b.z;
        }

        /// <summary>Returns the fp2x2 matrix result of a matrix multiplication between a fp2x3 matrix and a fp3x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x2 mul(fp2x3 a, fp3x2 b)
        {
            return fp2x2(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z);
        }

        /// <summary>Returns the fp2x3 matrix result of a matrix multiplication between a fp2x3 matrix and a fp3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x3 mul(fp2x3 a, fp3x3 b)
        {
            return fp2x3(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z,
                a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z);
        }

        /// <summary>Returns the fp2x4 matrix result of a matrix multiplication between a fp2x3 matrix and a fp3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x4 mul(fp2x3 a, fp3x4 b)
        {
            return fp2x4(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z,
                a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z,
                a.c0 * b.c3.x + a.c1 * b.c3.y + a.c2 * b.c3.z);
        }

        /// <summary>Returns the fp2 column vector result of a matrix multiplication between a fp2x4 matrix and a fp4 column vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2 mul(fp2x4 a, fp4 b)
        {
            return a.c0 * b.x + a.c1 * b.y + a.c2 * b.z + a.c3 * b.w;
        }

        /// <summary>Returns the fp2x2 matrix result of a matrix multiplication between a fp2x4 matrix and a fp4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x2 mul(fp2x4 a, fp4x2 b)
        {
            return fp2x2(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w);
        }

        /// <summary>Returns the fp2x3 matrix result of a matrix multiplication between a fp2x4 matrix and a fp4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x3 mul(fp2x4 a, fp4x3 b)
        {
            return fp2x3(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w,
                a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z + a.c3 * b.c2.w);
        }

        /// <summary>Returns the fp2x4 matrix result of a matrix multiplication between a fp2x4 matrix and a fp4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x4 mul(fp2x4 a, fp4x4 b)
        {
            return fp2x4(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w,
                a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z + a.c3 * b.c2.w,
                a.c0 * b.c3.x + a.c1 * b.c3.y + a.c2 * b.c3.z + a.c3 * b.c3.w);
        }

        /// <summary>Returns the fp3 column vector result of a matrix multiplication between a fp3x2 matrix and a fp2 column vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp3 mul(fp3x2 a, fp2 b)
        {
            return a.c0 * b.x + a.c1 * b.y;
        }

        /// <summary>Returns the fp3x2 matrix result of a matrix multiplication between a fp3x2 matrix and a fp2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp3x2 mul(fp3x2 a, fp2x2 b)
        {
            return fp3x2(
                a.c0 * b.c0.x + a.c1 * b.c0.y,
                a.c0 * b.c1.x + a.c1 * b.c1.y);
        }

        /// <summary>Returns the fp3x3 matrix result of a matrix multiplication between a fp3x2 matrix and a fp2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp3x3 mul(fp3x2 a, fp2x3 b)
        {
            return fp3x3(
                a.c0 * b.c0.x + a.c1 * b.c0.y,
                a.c0 * b.c1.x + a.c1 * b.c1.y,
                a.c0 * b.c2.x + a.c1 * b.c2.y);
        }

        /// <summary>Returns the fp3x4 matrix result of a matrix multiplication between a fp3x2 matrix and a fp2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp3x4 mul(fp3x2 a, fp2x4 b)
        {
            return fp3x4(
                a.c0 * b.c0.x + a.c1 * b.c0.y,
                a.c0 * b.c1.x + a.c1 * b.c1.y,
                a.c0 * b.c2.x + a.c1 * b.c2.y,
                a.c0 * b.c3.x + a.c1 * b.c3.y);
        }

        /// <summary>Returns the fp3 column vector result of a matrix multiplication between a fp3x3 matrix and a fp3 column vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp3 mul(fp3x3 a, fp3 b)
        {
            return a.c0 * b.x + a.c1 * b.y + a.c2 * b.z;
        }

        /// <summary>Returns the fp3x2 matrix result of a matrix multiplication between a fp3x3 matrix and a fp3x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp3x2 mul(fp3x3 a, fp3x2 b)
        {
            return fp3x2(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z);
        }

        /// <summary>Returns the fp3x3 matrix result of a matrix multiplication between a fp3x3 matrix and a fp3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp3x3 mul(fp3x3 a, fp3x3 b)
        {
            return fp3x3(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z,
                a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z);
        }

        /// <summary>Returns the fp3x4 matrix result of a matrix multiplication between a fp3x3 matrix and a fp3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp3x4 mul(fp3x3 a, fp3x4 b)
        {
            return fp3x4(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z,
                a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z,
                a.c0 * b.c3.x + a.c1 * b.c3.y + a.c2 * b.c3.z);
        }

        /// <summary>Returns the fp3 column vector result of a matrix multiplication between a fp3x4 matrix and a fp4 column vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp3 mul(fp3x4 a, fp4 b)
        {
            return a.c0 * b.x + a.c1 * b.y + a.c2 * b.z + a.c3 * b.w;
        }

        /// <summary>Returns the fp3x2 matrix result of a matrix multiplication between a fp3x4 matrix and a fp4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp3x2 mul(fp3x4 a, fp4x2 b)
        {
            return fp3x2(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w);
        }

        /// <summary>Returns the fp3x3 matrix result of a matrix multiplication between a fp3x4 matrix and a fp4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp3x3 mul(fp3x4 a, fp4x3 b)
        {
            return fp3x3(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w,
                a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z + a.c3 * b.c2.w);
        }

        /// <summary>Returns the fp3x4 matrix result of a matrix multiplication between a fp3x4 matrix and a fp4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp3x4 mul(fp3x4 a, fp4x4 b)
        {
            return fp3x4(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w,
                a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z + a.c3 * b.c2.w,
                a.c0 * b.c3.x + a.c1 * b.c3.y + a.c2 * b.c3.z + a.c3 * b.c3.w);
        }

        /// <summary>Returns the fp4 column vector result of a matrix multiplication between a fp4x2 matrix and a fp2 column vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp4 mul(fp4x2 a, fp2 b)
        {
            return a.c0 * b.x + a.c1 * b.y;
        }

        /// <summary>Returns the fp4x2 matrix result of a matrix multiplication between a fp4x2 matrix and a fp2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp4x2 mul(fp4x2 a, fp2x2 b)
        {
            return fp4x2(
                a.c0 * b.c0.x + a.c1 * b.c0.y,
                a.c0 * b.c1.x + a.c1 * b.c1.y);
        }

        /// <summary>Returns the fp4x3 matrix result of a matrix multiplication between a fp4x2 matrix and a fp2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp4x3 mul(fp4x2 a, fp2x3 b)
        {
            return fp4x3(
                a.c0 * b.c0.x + a.c1 * b.c0.y,
                a.c0 * b.c1.x + a.c1 * b.c1.y,
                a.c0 * b.c2.x + a.c1 * b.c2.y);
        }

        /// <summary>Returns the fp4x4 matrix result of a matrix multiplication between a fp4x2 matrix and a fp2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp4x4 mul(fp4x2 a, fp2x4 b)
        {
            return fp4x4(
                a.c0 * b.c0.x + a.c1 * b.c0.y,
                a.c0 * b.c1.x + a.c1 * b.c1.y,
                a.c0 * b.c2.x + a.c1 * b.c2.y,
                a.c0 * b.c3.x + a.c1 * b.c3.y);
        }

        /// <summary>Returns the fp4 column vector result of a matrix multiplication between a fp4x3 matrix and a fp3 column vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp4 mul(fp4x3 a, fp3 b)
        {
            return a.c0 * b.x + a.c1 * b.y + a.c2 * b.z;
        }

        /// <summary>Returns the fp4x2 matrix result of a matrix multiplication between a fp4x3 matrix and a fp3x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp4x2 mul(fp4x3 a, fp3x2 b)
        {
            return fp4x2(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z);
        }

        /// <summary>Returns the fp4x3 matrix result of a matrix multiplication between a fp4x3 matrix and a fp3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp4x3 mul(fp4x3 a, fp3x3 b)
        {
            return fp4x3(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z,
                a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z);
        }

        /// <summary>Returns the fp4x4 matrix result of a matrix multiplication between a fp4x3 matrix and a fp3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp4x4 mul(fp4x3 a, fp3x4 b)
        {
            return fp4x4(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z,
                a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z,
                a.c0 * b.c3.x + a.c1 * b.c3.y + a.c2 * b.c3.z);
        }

        /// <summary>Returns the fp4 column vector result of a matrix multiplication between a fp4x4 matrix and a fp4 column vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp4 mul(fp4x4 a, fp4 b)
        {
            return a.c0 * b.x + a.c1 * b.y + a.c2 * b.z + a.c3 * b.w;
        }

        /// <summary>Returns the fp4x2 matrix result of a matrix multiplication between a fp4x4 matrix and a fp4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp4x2 mul(fp4x4 a, fp4x2 b)
        {
            return fp4x2(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w);
        }

        /// <summary>Returns the fp4x3 matrix result of a matrix multiplication between a fp4x4 matrix and a fp4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp4x3 mul(fp4x4 a, fp4x3 b)
        {
            return fp4x3(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w,
                a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z + a.c3 * b.c2.w);
        }

        /// <summary>Returns the fp4x4 matrix result of a matrix multiplication between a fp4x4 matrix and a fp4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp4x4 mul(fp4x4 a, fp4x4 b)
        {
            return fp4x4(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w,
                a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z + a.c3 * b.c2.w,
                a.c0 * b.c3.x + a.c1 * b.c3.y + a.c2 * b.c3.z + a.c3 * b.c3.w);
        }

    }
}
