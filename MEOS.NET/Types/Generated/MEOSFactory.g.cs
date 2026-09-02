#nullable enable

using System.Runtime.InteropServices;

namespace MEOS.NET.Types.Generated
{
    /// <summary>
    /// Wraps a MEOS pointer in the class the model gives its runtime type.
    /// The discriminator is the struct field the catalog records, read at the
    /// offset the catalog's own field layout puts it at.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    internal static class MEOSFactory
    {
        /// <summary>The value at <paramref name="ptr"/> as the Temporal
        /// class the model gives its runtime type.</summary>
        internal static Temporal? WrapTemporal(IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
            {
                return null;
            }

            // Temporal.temptype, at byte 4
            return Marshal.ReadByte(ptr, 4) switch
            {
                26 => WrapTBoolSubtype(ptr),  // T_TBOOL
                33 => WrapTFloatSubtype(ptr),  // T_TFLOAT
                35 => WrapTIntSubtype(ptr),  // T_TINT
                41 => WrapTTextSubtype(ptr),  // T_TTEXT
                46 => WrapTGeomPointSubtype(ptr),  // T_TGEOMPOINT
                47 => WrapTGeogPointSubtype(ptr),  // T_TGEOGPOINT
                51 => WrapTNpointSubtype(ptr),  // T_TNPOINT
                56 => WrapTPoseSubtype(ptr),  // T_TPOSE
                59 => WrapTCbufferSubtype(ptr),  // T_TCBUFFER
                60 => WrapTGeometrySubtype(ptr),  // T_TGEOMETRY
                61 => WrapTGeographySubtype(ptr),  // T_TGEOGRAPHY
                62 => WrapTRGeometrySubtype(ptr),  // T_TRGEOMETRY
                66 => WrapTJsonbSubtype(ptr),  // T_TJSONB
                67 => WrapTBigintSubtype(ptr),  // T_TBIGINT
                _ => new Temporal(ptr),
            };
        }

        /// <summary>Every element of a C array of Temporal pointers, wrapped.</summary>
        internal static Temporal?[] WrapTemporalArray(IntPtr[] ptrs)
        {
            Temporal?[] wrapped = new Temporal?[ptrs.Length];
            for (int i = 0; i < ptrs.Length; i++)
            {
                wrapped[i] = WrapTemporal(ptrs[i]);
            }

            return wrapped;
        }

        /// <summary>The concrete TBigint class for the template subtype
        /// at byte 5.</summary>
        private static TBigint WrapTBigintSubtype(IntPtr ptr)
            => Marshal.ReadByte(ptr, 5) switch
            {
                1 => new TBigintInst(ptr),
                2 => new TBigintSeq(ptr),
                3 => new TBigintSeqSet(ptr),
                _ => new TBigint(ptr),
            };

        /// <summary>The concrete TBool class for the template subtype
        /// at byte 5.</summary>
        private static TBool WrapTBoolSubtype(IntPtr ptr)
            => Marshal.ReadByte(ptr, 5) switch
            {
                1 => new TBoolInst(ptr),
                2 => new TBoolSeq(ptr),
                3 => new TBoolSeqSet(ptr),
                _ => new TBool(ptr),
            };

        /// <summary>The concrete TCbuffer class for the template subtype
        /// at byte 5.</summary>
        private static TCbuffer WrapTCbufferSubtype(IntPtr ptr)
            => Marshal.ReadByte(ptr, 5) switch
            {
                1 => new TCbufferInst(ptr),
                2 => new TCbufferSeq(ptr),
                3 => new TCbufferSeqSet(ptr),
                _ => new TCbuffer(ptr),
            };

        /// <summary>The concrete TFloat class for the template subtype
        /// at byte 5.</summary>
        private static TFloat WrapTFloatSubtype(IntPtr ptr)
            => Marshal.ReadByte(ptr, 5) switch
            {
                1 => new TFloatInst(ptr),
                2 => new TFloatSeq(ptr),
                3 => new TFloatSeqSet(ptr),
                _ => new TFloat(ptr),
            };

        /// <summary>The concrete TGeogPoint class for the template subtype
        /// at byte 5.</summary>
        private static TGeogPoint WrapTGeogPointSubtype(IntPtr ptr)
            => Marshal.ReadByte(ptr, 5) switch
            {
                1 => new TGeogPointInst(ptr),
                2 => new TGeogPointSeq(ptr),
                3 => new TGeogPointSeqSet(ptr),
                _ => new TGeogPoint(ptr),
            };

        /// <summary>The concrete TGeography class for the template subtype
        /// at byte 5.</summary>
        private static TGeography WrapTGeographySubtype(IntPtr ptr)
            => Marshal.ReadByte(ptr, 5) switch
            {
                1 => new TGeographyInst(ptr),
                2 => new TGeographySeq(ptr),
                3 => new TGeographySeqSet(ptr),
                _ => new TGeography(ptr),
            };

        /// <summary>The concrete TGeomPoint class for the template subtype
        /// at byte 5.</summary>
        private static TGeomPoint WrapTGeomPointSubtype(IntPtr ptr)
            => Marshal.ReadByte(ptr, 5) switch
            {
                1 => new TGeomPointInst(ptr),
                2 => new TGeomPointSeq(ptr),
                3 => new TGeomPointSeqSet(ptr),
                _ => new TGeomPoint(ptr),
            };

        /// <summary>The concrete TGeometry class for the template subtype
        /// at byte 5.</summary>
        private static TGeometry WrapTGeometrySubtype(IntPtr ptr)
            => Marshal.ReadByte(ptr, 5) switch
            {
                1 => new TGeometryInst(ptr),
                2 => new TGeometrySeq(ptr),
                3 => new TGeometrySeqSet(ptr),
                _ => new TGeometry(ptr),
            };

        /// <summary>The concrete TInt class for the template subtype
        /// at byte 5.</summary>
        private static TInt WrapTIntSubtype(IntPtr ptr)
            => Marshal.ReadByte(ptr, 5) switch
            {
                1 => new TIntInst(ptr),
                2 => new TIntSeq(ptr),
                3 => new TIntSeqSet(ptr),
                _ => new TInt(ptr),
            };

        /// <summary>The concrete TJsonb class for the template subtype
        /// at byte 5.</summary>
        private static TJsonb WrapTJsonbSubtype(IntPtr ptr)
            => Marshal.ReadByte(ptr, 5) switch
            {
                1 => new TJsonbInst(ptr),
                2 => new TJsonbSeq(ptr),
                3 => new TJsonbSeqSet(ptr),
                _ => new TJsonb(ptr),
            };

        /// <summary>The concrete TNpoint class for the template subtype
        /// at byte 5.</summary>
        private static TNpoint WrapTNpointSubtype(IntPtr ptr)
            => Marshal.ReadByte(ptr, 5) switch
            {
                1 => new TNpointInst(ptr),
                2 => new TNpointSeq(ptr),
                3 => new TNpointSeqSet(ptr),
                _ => new TNpoint(ptr),
            };

        /// <summary>The concrete TPose class for the template subtype
        /// at byte 5.</summary>
        private static TPose WrapTPoseSubtype(IntPtr ptr)
            => Marshal.ReadByte(ptr, 5) switch
            {
                1 => new TPoseInst(ptr),
                2 => new TPoseSeq(ptr),
                3 => new TPoseSeqSet(ptr),
                _ => new TPose(ptr),
            };

        /// <summary>The concrete TRGeometry class for the template subtype
        /// at byte 5.</summary>
        private static TRGeometry WrapTRGeometrySubtype(IntPtr ptr)
            => Marshal.ReadByte(ptr, 5) switch
            {
                1 => new TRGeometryInst(ptr),
                2 => new TRGeometrySeq(ptr),
                3 => new TRGeometrySeqSet(ptr),
                _ => new TRGeometry(ptr),
            };

        /// <summary>The concrete TText class for the template subtype
        /// at byte 5.</summary>
        private static TText WrapTTextSubtype(IntPtr ptr)
            => Marshal.ReadByte(ptr, 5) switch
            {
                1 => new TTextInst(ptr),
                2 => new TTextSeq(ptr),
                3 => new TTextSeqSet(ptr),
                _ => new TText(ptr),
            };

        /// <summary>The value at <paramref name="ptr"/> as the Set
        /// class the model gives its runtime type.</summary>
        internal static Set? WrapSet(IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
            {
                return null;
            }

            // Set.settype, at byte 4
            return Marshal.ReadByte(ptr, 4) switch
            {
                5 => new DateSet(ptr),  // T_DATESET
                12 => new FloatSet(ptr),  // T_FLOATSET
                18 => new IntSet(ptr),  // T_INTSET
                22 => new BigIntSet(ptr),  // T_BIGINTSET
                32 => new TextSet(ptr),  // T_TEXTSET
                38 => new TsTzSet(ptr),  // T_TSTZSET
                43 => new GeomSet(ptr),  // T_GEOMSET
                45 => new GeogSet(ptr),  // T_GEOGSET
                49 => new NpointSet(ptr),  // T_NPOINTSET
                55 => new PoseSet(ptr),  // T_POSESET
                58 => new CbufferSet(ptr),  // T_CBUFFERSET
                _ => new Set(ptr),
            };
        }

        /// <summary>Every element of a C array of Set pointers, wrapped.</summary>
        internal static Set?[] WrapSetArray(IntPtr[] ptrs)
        {
            Set?[] wrapped = new Set?[ptrs.Length];
            for (int i = 0; i < ptrs.Length; i++)
            {
                wrapped[i] = WrapSet(ptrs[i]);
            }

            return wrapped;
        }

        /// <summary>The value at <paramref name="ptr"/> as the Span
        /// class the model gives its runtime type.</summary>
        internal static Span? WrapSpan(IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
            {
                return null;
            }

            // Span.spantype, at byte 0
            return Marshal.ReadByte(ptr, 0) switch
            {
                6 => new DateSpan(ptr),  // T_DATESPAN
                13 => new FloatSpan(ptr),  // T_FLOATSPAN
                19 => new IntSpan(ptr),  // T_INTSPAN
                23 => new BigIntSpan(ptr),  // T_BIGINTSPAN
                39 => new TsTzSpan(ptr),  // T_TSTZSPAN
                _ => new Span(ptr),
            };
        }

        /// <summary>Every element of a C array of Span pointers, wrapped.</summary>
        internal static Span?[] WrapSpanArray(IntPtr[] ptrs)
        {
            Span?[] wrapped = new Span?[ptrs.Length];
            for (int i = 0; i < ptrs.Length; i++)
            {
                wrapped[i] = WrapSpan(ptrs[i]);
            }

            return wrapped;
        }

        /// <summary>The value at <paramref name="ptr"/> as the SpanSet
        /// class the model gives its runtime type.</summary>
        internal static SpanSet? WrapSpanSet(IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
            {
                return null;
            }

            // SpanSet.spansettype, at byte 4
            return Marshal.ReadByte(ptr, 4) switch
            {
                7 => new DateSpanSet(ptr),  // T_DATESPANSET
                14 => new FloatSpanSet(ptr),  // T_FLOATSPANSET
                20 => new IntSpanSet(ptr),  // T_INTSPANSET
                24 => new BigIntSpanSet(ptr),  // T_BIGINTSPANSET
                40 => new TsTzSpanSet(ptr),  // T_TSTZSPANSET
                _ => new SpanSet(ptr),
            };
        }

        /// <summary>Every element of a C array of SpanSet pointers, wrapped.</summary>
        internal static SpanSet?[] WrapSpanSetArray(IntPtr[] ptrs)
        {
            SpanSet?[] wrapped = new SpanSet?[ptrs.Length];
            for (int i = 0; i < ptrs.Length; i++)
            {
                wrapped[i] = WrapSpanSet(ptrs[i]);
            }

            return wrapped;
        }

        /// <summary>The value at <paramref name="ptr"/> as the TBox
        /// class the model gives its runtime type.</summary>
        internal static TBox? WrapTBox(IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
            {
                return null;
            }

            return new TBox(ptr);
        }

        /// <summary>Every element of a C array of TBox pointers, wrapped.</summary>
        internal static TBox?[] WrapTBoxArray(IntPtr[] ptrs)
        {
            TBox?[] wrapped = new TBox?[ptrs.Length];
            for (int i = 0; i < ptrs.Length; i++)
            {
                wrapped[i] = WrapTBox(ptrs[i]);
            }

            return wrapped;
        }

        /// <summary>The value at <paramref name="ptr"/> as the STBox
        /// class the model gives its runtime type.</summary>
        internal static STBox? WrapSTBox(IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
            {
                return null;
            }

            return new STBox(ptr);
        }

        /// <summary>Every element of a C array of STBox pointers, wrapped.</summary>
        internal static STBox?[] WrapSTBoxArray(IntPtr[] ptrs)
        {
            STBox?[] wrapped = new STBox?[ptrs.Length];
            for (int i = 0; i < ptrs.Length; i++)
            {
                wrapped[i] = WrapSTBox(ptrs[i]);
            }

            return wrapped;
        }

    }
}
