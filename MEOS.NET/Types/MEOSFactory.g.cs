#nullable enable

using System.Runtime.InteropServices;

namespace MEOS.NET.Types
{
    /// <summary>
    /// Wraps a MEOS pointer in the class the model gives its runtime type.
    /// The discriminator is the struct field the catalog records, read at the
    /// offset the catalog's own field layout puts it at.
    /// </summary>
    /// <remarks>
    /// This is the way back from a function on
    /// <see cref="MEOS.NET.Functions.Meos"/>, which answers the MEOS pointer,
    /// into the object layer.
    /// </remarks>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public static class MEOSFactory
    {
        /// <summary>The value at <paramref name="ptr"/> as the Cbuffer
        /// class the model gives its runtime type.</summary>
        public static Cbuffer? WrapCbuffer(IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
            {
                return null;
            }

            return new Cbuffer(ptr);
        }

        /// <summary>Every element of a C array of Cbuffer pointers, wrapped.</summary>
        public static Cbuffer?[] WrapCbufferArray(IntPtr[] ptrs)
        {
            Cbuffer?[] wrapped = new Cbuffer?[ptrs.Length];
            for (int i = 0; i < ptrs.Length; i++)
            {
                wrapped[i] = WrapCbuffer(ptrs[i]);
            }

            return wrapped;
        }

        /// <summary>The value at <paramref name="ptr"/> as the Geo
        /// class the model gives its runtime type.</summary>
        public static Geo? WrapGeo(IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
            {
                return null;
            }

            return new Geo(ptr);
        }

        /// <summary>Every element of a C array of Geo pointers, wrapped.</summary>
        public static Geo?[] WrapGeoArray(IntPtr[] ptrs)
        {
            Geo?[] wrapped = new Geo?[ptrs.Length];
            for (int i = 0; i < ptrs.Length; i++)
            {
                wrapped[i] = WrapGeo(ptrs[i]);
            }

            return wrapped;
        }

        /// <summary>The value at <paramref name="ptr"/> as the JsonPath
        /// class the model gives its runtime type.</summary>
        public static JsonPath? WrapJsonPath(IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
            {
                return null;
            }

            return new JsonPath(ptr);
        }

        /// <summary>Every element of a C array of JsonPath pointers, wrapped.</summary>
        public static JsonPath?[] WrapJsonPathArray(IntPtr[] ptrs)
        {
            JsonPath?[] wrapped = new JsonPath?[ptrs.Length];
            for (int i = 0; i < ptrs.Length; i++)
            {
                wrapped[i] = WrapJsonPath(ptrs[i]);
            }

            return wrapped;
        }

        /// <summary>The value at <paramref name="ptr"/> as the Jsonb
        /// class the model gives its runtime type.</summary>
        public static Jsonb? WrapJsonb(IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
            {
                return null;
            }

            return new Jsonb(ptr);
        }

        /// <summary>Every element of a C array of Jsonb pointers, wrapped.</summary>
        public static Jsonb?[] WrapJsonbArray(IntPtr[] ptrs)
        {
            Jsonb?[] wrapped = new Jsonb?[ptrs.Length];
            for (int i = 0; i < ptrs.Length; i++)
            {
                wrapped[i] = WrapJsonb(ptrs[i]);
            }

            return wrapped;
        }

        /// <summary>The value at <paramref name="ptr"/> as the MeosArray
        /// class the model gives its runtime type.</summary>
        public static MeosArray? WrapMeosArray(IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
            {
                return null;
            }

            return new MeosArray(ptr);
        }

        /// <summary>Every element of a C array of MeosArray pointers, wrapped.</summary>
        public static MeosArray?[] WrapMeosArrayArray(IntPtr[] ptrs)
        {
            MeosArray?[] wrapped = new MeosArray?[ptrs.Length];
            for (int i = 0; i < ptrs.Length; i++)
            {
                wrapped[i] = WrapMeosArray(ptrs[i]);
            }

            return wrapped;
        }

        /// <summary>The value at <paramref name="ptr"/> as the Npoint
        /// class the model gives its runtime type.</summary>
        public static Npoint? WrapNpoint(IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
            {
                return null;
            }

            return new Npoint(ptr);
        }

        /// <summary>Every element of a C array of Npoint pointers, wrapped.</summary>
        public static Npoint?[] WrapNpointArray(IntPtr[] ptrs)
        {
            Npoint?[] wrapped = new Npoint?[ptrs.Length];
            for (int i = 0; i < ptrs.Length; i++)
            {
                wrapped[i] = WrapNpoint(ptrs[i]);
            }

            return wrapped;
        }

        /// <summary>The value at <paramref name="ptr"/> as the Nsegment
        /// class the model gives its runtime type.</summary>
        public static Nsegment? WrapNsegment(IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
            {
                return null;
            }

            return new Nsegment(ptr);
        }

        /// <summary>Every element of a C array of Nsegment pointers, wrapped.</summary>
        public static Nsegment?[] WrapNsegmentArray(IntPtr[] ptrs)
        {
            Nsegment?[] wrapped = new Nsegment?[ptrs.Length];
            for (int i = 0; i < ptrs.Length; i++)
            {
                wrapped[i] = WrapNsegment(ptrs[i]);
            }

            return wrapped;
        }

        /// <summary>The value at <paramref name="ptr"/> as the Pcschema
        /// class the model gives its runtime type.</summary>
        public static Pcschema? WrapPcschema(IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
            {
                return null;
            }

            return new Pcschema(ptr);
        }

        /// <summary>Every element of a C array of Pcschema pointers, wrapped.</summary>
        public static Pcschema?[] WrapPcschemaArray(IntPtr[] ptrs)
        {
            Pcschema?[] wrapped = new Pcschema?[ptrs.Length];
            for (int i = 0; i < ptrs.Length; i++)
            {
                wrapped[i] = WrapPcschema(ptrs[i]);
            }

            return wrapped;
        }

        /// <summary>The value at <paramref name="ptr"/> as the Pcpatch
        /// class the model gives its runtime type.</summary>
        public static Pcpatch? WrapPcpatch(IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
            {
                return null;
            }

            return new Pcpatch(ptr);
        }

        /// <summary>Every element of a C array of Pcpatch pointers, wrapped.</summary>
        public static Pcpatch?[] WrapPcpatchArray(IntPtr[] ptrs)
        {
            Pcpatch?[] wrapped = new Pcpatch?[ptrs.Length];
            for (int i = 0; i < ptrs.Length; i++)
            {
                wrapped[i] = WrapPcpatch(ptrs[i]);
            }

            return wrapped;
        }

        /// <summary>The value at <paramref name="ptr"/> as the Pcpoint
        /// class the model gives its runtime type.</summary>
        public static Pcpoint? WrapPcpoint(IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
            {
                return null;
            }

            return new Pcpoint(ptr);
        }

        /// <summary>Every element of a C array of Pcpoint pointers, wrapped.</summary>
        public static Pcpoint?[] WrapPcpointArray(IntPtr[] ptrs)
        {
            Pcpoint?[] wrapped = new Pcpoint?[ptrs.Length];
            for (int i = 0; i < ptrs.Length; i++)
            {
                wrapped[i] = WrapPcpoint(ptrs[i]);
            }

            return wrapped;
        }

        /// <summary>The value at <paramref name="ptr"/> as the Pose
        /// class the model gives its runtime type.</summary>
        public static Pose? WrapPose(IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
            {
                return null;
            }

            return new Pose(ptr);
        }

        /// <summary>Every element of a C array of Pose pointers, wrapped.</summary>
        public static Pose?[] WrapPoseArray(IntPtr[] ptrs)
        {
            Pose?[] wrapped = new Pose?[ptrs.Length];
            for (int i = 0; i < ptrs.Length; i++)
            {
                wrapped[i] = WrapPose(ptrs[i]);
            }

            return wrapped;
        }

        /// <summary>The value at <paramref name="ptr"/> as the PoseChain
        /// class the model gives its runtime type.</summary>
        public static PoseChain? WrapPoseChain(IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
            {
                return null;
            }

            return new PoseChain(ptr);
        }

        /// <summary>Every element of a C array of PoseChain pointers, wrapped.</summary>
        public static PoseChain?[] WrapPoseChainArray(IntPtr[] ptrs)
        {
            PoseChain?[] wrapped = new PoseChain?[ptrs.Length];
            for (int i = 0; i < ptrs.Length; i++)
            {
                wrapped[i] = WrapPoseChain(ptrs[i]);
            }

            return wrapped;
        }

        /// <summary>The value at <paramref name="ptr"/> as the RTree
        /// class the model gives its runtime type.</summary>
        public static RTree? WrapRTree(IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
            {
                return null;
            }

            return new RTree(ptr);
        }

        /// <summary>Every element of a C array of RTree pointers, wrapped.</summary>
        public static RTree?[] WrapRTreeArray(IntPtr[] ptrs)
        {
            RTree?[] wrapped = new RTree?[ptrs.Length];
            for (int i = 0; i < ptrs.Length; i++)
            {
                wrapped[i] = WrapRTree(ptrs[i]);
            }

            return wrapped;
        }

        /// <summary>The value at <paramref name="ptr"/> as the Raquet
        /// class the model gives its runtime type.</summary>
        public static Raquet? WrapRaquet(IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
            {
                return null;
            }

            return new Raquet(ptr);
        }

        /// <summary>Every element of a C array of Raquet pointers, wrapped.</summary>
        public static Raquet?[] WrapRaquetArray(IntPtr[] ptrs)
        {
            Raquet?[] wrapped = new Raquet?[ptrs.Length];
            for (int i = 0; i < ptrs.Length; i++)
            {
                wrapped[i] = WrapRaquet(ptrs[i]);
            }

            return wrapped;
        }

        /// <summary>The value at <paramref name="ptr"/> as the SPTree
        /// class the model gives its runtime type.</summary>
        public static SPTree? WrapSPTree(IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
            {
                return null;
            }

            return new SPTree(ptr);
        }

        /// <summary>Every element of a C array of SPTree pointers, wrapped.</summary>
        public static SPTree?[] WrapSPTreeArray(IntPtr[] ptrs)
        {
            SPTree?[] wrapped = new SPTree?[ptrs.Length];
            for (int i = 0; i < ptrs.Length; i++)
            {
                wrapped[i] = WrapSPTree(ptrs[i]);
            }

            return wrapped;
        }

        /// <summary>The value at <paramref name="ptr"/> as the STBox
        /// class the model gives its runtime type.</summary>
        public static STBox? WrapSTBox(IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
            {
                return null;
            }

            return new STBox(ptr);
        }

        /// <summary>Every element of a C array of STBox pointers, wrapped.</summary>
        public static STBox?[] WrapSTBoxArray(IntPtr[] ptrs)
        {
            STBox?[] wrapped = new STBox?[ptrs.Length];
            for (int i = 0; i < ptrs.Length; i++)
            {
                wrapped[i] = WrapSTBox(ptrs[i]);
            }

            return wrapped;
        }

        /// <summary>The value at <paramref name="ptr"/> as the Set
        /// class the model gives its runtime type.</summary>
        public static Set? WrapSet(IntPtr ptr)
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
        public static Set?[] WrapSetArray(IntPtr[] ptrs)
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
        public static Span? WrapSpan(IntPtr ptr)
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
        public static Span?[] WrapSpanArray(IntPtr[] ptrs)
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
        public static SpanSet? WrapSpanSet(IntPtr ptr)
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
        public static SpanSet?[] WrapSpanSetArray(IntPtr[] ptrs)
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
        public static TBox? WrapTBox(IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
            {
                return null;
            }

            return new TBox(ptr);
        }

        /// <summary>Every element of a C array of TBox pointers, wrapped.</summary>
        public static TBox?[] WrapTBoxArray(IntPtr[] ptrs)
        {
            TBox?[] wrapped = new TBox?[ptrs.Length];
            for (int i = 0; i < ptrs.Length; i++)
            {
                wrapped[i] = WrapTBox(ptrs[i]);
            }

            return wrapped;
        }

        /// <summary>The value at <paramref name="ptr"/> as the TPCBox
        /// class the model gives its runtime type.</summary>
        public static TPCBox? WrapTPCBox(IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
            {
                return null;
            }

            return new TPCBox(ptr);
        }

        /// <summary>Every element of a C array of TPCBox pointers, wrapped.</summary>
        public static TPCBox?[] WrapTPCBoxArray(IntPtr[] ptrs)
        {
            TPCBox?[] wrapped = new TPCBox?[ptrs.Length];
            for (int i = 0; i < ptrs.Length; i++)
            {
                wrapped[i] = WrapTPCBox(ptrs[i]);
            }

            return wrapped;
        }

        /// <summary>The value at <paramref name="ptr"/> as the Temporal
        /// class the model gives its runtime type.</summary>
        public static Temporal? WrapTemporal(IntPtr ptr)
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
        public static Temporal?[] WrapTemporalArray(IntPtr[] ptrs)
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

        /// <summary>The value at <paramref name="ptr"/> as the Text
        /// class the model gives its runtime type.</summary>
        public static Text? WrapText(IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
            {
                return null;
            }

            return new Text(ptr);
        }

        /// <summary>Every element of a C array of Text pointers, wrapped.</summary>
        public static Text?[] WrapTextArray(IntPtr[] ptrs)
        {
            Text?[] wrapped = new Text?[ptrs.Length];
            for (int i = 0; i < ptrs.Length; i++)
            {
                wrapped[i] = WrapText(ptrs[i]);
            }

            return wrapped;
        }

    }
}
