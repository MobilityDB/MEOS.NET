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
        /// <summary>The value at <paramref name="ptr"/> as the CBuffer
        /// class the model gives its runtime type.</summary>
        public static CBuffer? WrapCBuffer(IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
            {
                return null;
            }

            return new CBuffer(ptr);
        }

        /// <summary>Every element of a C array of CBuffer pointers, wrapped.</summary>
        public static CBuffer?[] WrapCBufferArray(IntPtr[] ptrs)
        {
            CBuffer?[] wrapped = new CBuffer?[ptrs.Length];
            for (int i = 0; i < ptrs.Length; i++)
            {
                wrapped[i] = WrapCBuffer(ptrs[i]);
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

        /// <summary>The value at <paramref name="ptr"/> as the NPoint
        /// class the model gives its runtime type.</summary>
        public static NPoint? WrapNPoint(IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
            {
                return null;
            }

            return new NPoint(ptr);
        }

        /// <summary>Every element of a C array of NPoint pointers, wrapped.</summary>
        public static NPoint?[] WrapNPointArray(IntPtr[] ptrs)
        {
            NPoint?[] wrapped = new NPoint?[ptrs.Length];
            for (int i = 0; i < ptrs.Length; i++)
            {
                wrapped[i] = WrapNPoint(ptrs[i]);
            }

            return wrapped;
        }

        /// <summary>The value at <paramref name="ptr"/> as the NSegment
        /// class the model gives its runtime type.</summary>
        public static NSegment? WrapNSegment(IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
            {
                return null;
            }

            return new NSegment(ptr);
        }

        /// <summary>Every element of a C array of NSegment pointers, wrapped.</summary>
        public static NSegment?[] WrapNSegmentArray(IntPtr[] ptrs)
        {
            NSegment?[] wrapped = new NSegment?[ptrs.Length];
            for (int i = 0; i < ptrs.Length; i++)
            {
                wrapped[i] = WrapNSegment(ptrs[i]);
            }

            return wrapped;
        }

        /// <summary>The value at <paramref name="ptr"/> as the Numeric
        /// class the model gives its runtime type.</summary>
        public static Numeric? WrapNumeric(IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
            {
                return null;
            }

            return new Numeric(ptr);
        }

        /// <summary>Every element of a C array of Numeric pointers, wrapped.</summary>
        public static Numeric?[] WrapNumericArray(IntPtr[] ptrs)
        {
            Numeric?[] wrapped = new Numeric?[ptrs.Length];
            for (int i = 0; i < ptrs.Length; i++)
            {
                wrapped[i] = WrapNumeric(ptrs[i]);
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

        /// <summary>The value at <paramref name="ptr"/> as the PCPatch
        /// class the model gives its runtime type.</summary>
        public static PCPatch? WrapPCPatch(IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
            {
                return null;
            }

            return new PCPatch(ptr);
        }

        /// <summary>Every element of a C array of PCPatch pointers, wrapped.</summary>
        public static PCPatch?[] WrapPCPatchArray(IntPtr[] ptrs)
        {
            PCPatch?[] wrapped = new PCPatch?[ptrs.Length];
            for (int i = 0; i < ptrs.Length; i++)
            {
                wrapped[i] = WrapPCPatch(ptrs[i]);
            }

            return wrapped;
        }

        /// <summary>The value at <paramref name="ptr"/> as the PCPoint
        /// class the model gives its runtime type.</summary>
        public static PCPoint? WrapPCPoint(IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
            {
                return null;
            }

            return new PCPoint(ptr);
        }

        /// <summary>Every element of a C array of PCPoint pointers, wrapped.</summary>
        public static PCPoint?[] WrapPCPointArray(IntPtr[] ptrs)
        {
            PCPoint?[] wrapped = new PCPoint?[ptrs.Length];
            for (int i = 0; i < ptrs.Length; i++)
            {
                wrapped[i] = WrapPCPoint(ptrs[i]);
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

        /// <summary>The value at <paramref name="ptr"/> as the RTreeNNCursor
        /// class the model gives its runtime type.</summary>
        public static RTreeNNCursor? WrapRTreeNNCursor(IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
            {
                return null;
            }

            return new RTreeNNCursor(ptr);
        }

        /// <summary>Every element of a C array of RTreeNNCursor pointers, wrapped.</summary>
        public static RTreeNNCursor?[] WrapRTreeNNCursorArray(IntPtr[] ptrs)
        {
            RTreeNNCursor?[] wrapped = new RTreeNNCursor?[ptrs.Length];
            for (int i = 0; i < ptrs.Length; i++)
            {
                wrapped[i] = WrapRTreeNNCursor(ptrs[i]);
            }

            return wrapped;
        }

        /// <summary>The value at <paramref name="ptr"/> as the RaQuet
        /// class the model gives its runtime type.</summary>
        public static RaQuet? WrapRaQuet(IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
            {
                return null;
            }

            return new RaQuet(ptr);
        }

        /// <summary>Every element of a C array of RaQuet pointers, wrapped.</summary>
        public static RaQuet?[] WrapRaQuetArray(IntPtr[] ptrs)
        {
            RaQuet?[] wrapped = new RaQuet?[ptrs.Length];
            for (int i = 0; i < ptrs.Length; i++)
            {
                wrapped[i] = WrapRaQuet(ptrs[i]);
            }

            return wrapped;
        }

        /// <summary>The value at <paramref name="ptr"/> as the Raster
        /// class the model gives its runtime type.</summary>
        public static Raster? WrapRaster(IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
            {
                return null;
            }

            return new Raster(ptr);
        }

        /// <summary>Every element of a C array of Raster pointers, wrapped.</summary>
        public static Raster?[] WrapRasterArray(IntPtr[] ptrs)
        {
            Raster?[] wrapped = new Raster?[ptrs.Length];
            for (int i = 0; i < ptrs.Length; i++)
            {
                wrapped[i] = WrapRaster(ptrs[i]);
            }

            return wrapped;
        }

        /// <summary>The value at <paramref name="ptr"/> as the SPNNCursor
        /// class the model gives its runtime type.</summary>
        public static SPNNCursor? WrapSPNNCursor(IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
            {
                return null;
            }

            return new SPNNCursor(ptr);
        }

        /// <summary>Every element of a C array of SPNNCursor pointers, wrapped.</summary>
        public static SPNNCursor?[] WrapSPNNCursorArray(IntPtr[] ptrs)
        {
            SPNNCursor?[] wrapped = new SPNNCursor?[ptrs.Length];
            for (int i = 0; i < ptrs.Length; i++)
            {
                wrapped[i] = WrapSPNNCursor(ptrs[i]);
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
                49 => new NPointSet(ptr),  // T_NPOINTSET
                55 => new PoseSet(ptr),  // T_POSESET
                58 => new CBufferSet(ptr),  // T_CBUFFERSET
                65 => new JsonbSet(ptr),  // T_JSONBSET
                69 => new H3IndexSet(ptr),  // T_H3INDEXSET
                72 => new QuadbinSet(ptr),  // T_QUADBINSET
                75 => new PCPointSet(ptr),  // T_PCPOINTSET
                78 => new PCPatchSet(ptr),  // T_PCPATCHSET
                83 => new PoseChainSet(ptr),  // T_POSECHAINSET
                86 => new S2CellSet(ptr),  // T_S2CELLSET
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

        /// <summary>The value at <paramref name="ptr"/> as the SkipList
        /// class the model gives its runtime type.</summary>
        public static SkipList? WrapSkipList(IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
            {
                return null;
            }

            return new SkipList(ptr);
        }

        /// <summary>Every element of a C array of SkipList pointers, wrapped.</summary>
        public static SkipList?[] WrapSkipListArray(IntPtr[] ptrs)
        {
            SkipList?[] wrapped = new SkipList?[ptrs.Length];
            for (int i = 0; i < ptrs.Length; i++)
            {
                wrapped[i] = WrapSkipList(ptrs[i]);
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
                51 => WrapTNPointSubtype(ptr),  // T_TNPOINT
                56 => WrapTPoseSubtype(ptr),  // T_TPOSE
                59 => WrapTCBufferSubtype(ptr),  // T_TCBUFFER
                60 => WrapTGeometrySubtype(ptr),  // T_TGEOMETRY
                61 => WrapTGeographySubtype(ptr),  // T_TGEOGRAPHY
                62 => WrapTRGeometrySubtype(ptr),  // T_TRGEOMETRY
                66 => WrapTJsonbSubtype(ptr),  // T_TJSONB
                67 => WrapTBigIntSubtype(ptr),  // T_TBIGINT
                70 => WrapTH3IndexSubtype(ptr),  // T_TH3INDEX
                73 => WrapTQuadbinSubtype(ptr),  // T_TQUADBIN
                76 => WrapTPCPointSubtype(ptr),  // T_TPCPOINT
                79 => WrapTPCPatchSubtype(ptr),  // T_TPCPATCH
                84 => WrapTPoseChainSubtype(ptr),  // T_TPOSECHAIN
                87 => WrapTS2CellSubtype(ptr),  // T_TS2CELL
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

        /// <summary>The concrete TBigInt class for the template subtype
        /// at byte 5.</summary>
        private static TBigInt WrapTBigIntSubtype(IntPtr ptr)
            => Marshal.ReadByte(ptr, 5) switch
            {
                1 => new TBigIntInst(ptr),
                2 => new TBigIntSeq(ptr),
                3 => new TBigIntSeqSet(ptr),
                _ => new TBigInt(ptr),
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

        /// <summary>The concrete TCBuffer class for the template subtype
        /// at byte 5.</summary>
        private static TCBuffer WrapTCBufferSubtype(IntPtr ptr)
            => Marshal.ReadByte(ptr, 5) switch
            {
                1 => new TCBufferInst(ptr),
                2 => new TCBufferSeq(ptr),
                3 => new TCBufferSeqSet(ptr),
                _ => new TCBuffer(ptr),
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

        /// <summary>The concrete TH3Index class for the template subtype
        /// at byte 5.</summary>
        private static TH3Index WrapTH3IndexSubtype(IntPtr ptr)
            => Marshal.ReadByte(ptr, 5) switch
            {
                1 => new TH3IndexInst(ptr),
                2 => new TH3IndexSeq(ptr),
                3 => new TH3IndexSeqSet(ptr),
                _ => new TH3Index(ptr),
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

        /// <summary>The concrete TNPoint class for the template subtype
        /// at byte 5.</summary>
        private static TNPoint WrapTNPointSubtype(IntPtr ptr)
            => Marshal.ReadByte(ptr, 5) switch
            {
                1 => new TNPointInst(ptr),
                2 => new TNPointSeq(ptr),
                3 => new TNPointSeqSet(ptr),
                _ => new TNPoint(ptr),
            };

        /// <summary>The concrete TPCPatch class for the template subtype
        /// at byte 5.</summary>
        private static TPCPatch WrapTPCPatchSubtype(IntPtr ptr)
            => Marshal.ReadByte(ptr, 5) switch
            {
                1 => new TPCPatchInst(ptr),
                2 => new TPCPatchSeq(ptr),
                3 => new TPCPatchSeqSet(ptr),
                _ => new TPCPatch(ptr),
            };

        /// <summary>The concrete TPCPoint class for the template subtype
        /// at byte 5.</summary>
        private static TPCPoint WrapTPCPointSubtype(IntPtr ptr)
            => Marshal.ReadByte(ptr, 5) switch
            {
                1 => new TPCPointInst(ptr),
                2 => new TPCPointSeq(ptr),
                3 => new TPCPointSeqSet(ptr),
                _ => new TPCPoint(ptr),
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

        /// <summary>The concrete TPoseChain class for the template subtype
        /// at byte 5.</summary>
        private static TPoseChain WrapTPoseChainSubtype(IntPtr ptr)
            => Marshal.ReadByte(ptr, 5) switch
            {
                1 => new TPoseChainInst(ptr),
                2 => new TPoseChainSeq(ptr),
                3 => new TPoseChainSeqSet(ptr),
                _ => new TPoseChain(ptr),
            };

        /// <summary>The concrete TQuadbin class for the template subtype
        /// at byte 5.</summary>
        private static TQuadbin WrapTQuadbinSubtype(IntPtr ptr)
            => Marshal.ReadByte(ptr, 5) switch
            {
                1 => new TQuadbinInst(ptr),
                2 => new TQuadbinSeq(ptr),
                3 => new TQuadbinSeqSet(ptr),
                _ => new TQuadbin(ptr),
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

        /// <summary>The concrete TS2Cell class for the template subtype
        /// at byte 5.</summary>
        private static TS2Cell WrapTS2CellSubtype(IntPtr ptr)
            => Marshal.ReadByte(ptr, 5) switch
            {
                1 => new TS2CellInst(ptr),
                2 => new TS2CellSeq(ptr),
                3 => new TS2CellSeqSet(ptr),
                _ => new TS2Cell(ptr),
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
