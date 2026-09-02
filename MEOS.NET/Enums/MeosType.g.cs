#nullable enable

namespace MEOS.NET.Enums
{
    /// <summary>The MEOS <c>MeosType</c> enum, from <c>meos_catalog.h</c>.</summary>
    [System.CodeDom.Compiler.GeneratedCode("MEOS.NET.ObjectGen", "0.1.0")]
    public enum MeosType
    {
        /// <summary><c>T_UNKNOWN</c></summary>
        TUnknown = 0,

        /// <summary><c>T_BOOL</c></summary>
        TBool = 1,

        /// <summary><c>T_DATE</c></summary>
        TDate = 2,

        /// <summary><c>T_DATEMULTIRANGE</c></summary>
        TDatemultirange = 3,

        /// <summary><c>T_DATERANGE</c></summary>
        TDaterange = 4,

        /// <summary><c>T_DATESET</c></summary>
        TDateset = 5,

        /// <summary><c>T_DATESPAN</c></summary>
        TDatespan = 6,

        /// <summary><c>T_DATESPANSET</c></summary>
        TDatespanset = 7,

        /// <summary><c>T_DOUBLE2</c></summary>
        TDouble2 = 8,

        /// <summary><c>T_DOUBLE3</c></summary>
        TDouble3 = 9,

        /// <summary><c>T_DOUBLE4</c></summary>
        TDouble4 = 10,

        /// <summary><c>T_FLOAT8</c></summary>
        TFloat8 = 11,

        /// <summary><c>T_FLOATSET</c></summary>
        TFloatset = 12,

        /// <summary><c>T_FLOATSPAN</c></summary>
        TFloatspan = 13,

        /// <summary><c>T_FLOATSPANSET</c></summary>
        TFloatspanset = 14,

        /// <summary><c>T_INT4</c></summary>
        TInt4 = 15,

        /// <summary><c>T_INT4MULTIRANGE</c></summary>
        TInt4multirange = 16,

        /// <summary><c>T_INT4RANGE</c></summary>
        TInt4range = 17,

        /// <summary><c>T_INTSET</c></summary>
        TIntset = 18,

        /// <summary><c>T_INTSPAN</c></summary>
        TIntspan = 19,

        /// <summary><c>T_INTSPANSET</c></summary>
        TIntspanset = 20,

        /// <summary><c>T_INT8</c></summary>
        TInt8 = 21,

        /// <summary><c>T_INT8MULTIRANGE</c></summary>
        TInt8multirange = 52,

        /// <summary><c>T_INT8RANGE</c></summary>
        TInt8range = 53,

        /// <summary><c>T_BIGINTSET</c></summary>
        TBigintset = 22,

        /// <summary><c>T_BIGINTSPAN</c></summary>
        TBigintspan = 23,

        /// <summary><c>T_BIGINTSPANSET</c></summary>
        TBigintspanset = 24,

        /// <summary><c>T_STBOX</c></summary>
        TStbox = 25,

        /// <summary><c>T_TBOOL</c></summary>
        TTbool = 26,

        /// <summary><c>T_TBOX</c></summary>
        TTbox = 27,

        /// <summary><c>T_TDOUBLE2</c></summary>
        TTdouble2 = 28,

        /// <summary><c>T_TDOUBLE3</c></summary>
        TTdouble3 = 29,

        /// <summary><c>T_TDOUBLE4</c></summary>
        TTdouble4 = 30,

        /// <summary><c>T_TEXT</c></summary>
        TText = 31,

        /// <summary><c>T_TEXTSET</c></summary>
        TTextset = 32,

        /// <summary><c>T_TFLOAT</c></summary>
        TTfloat = 33,

        /// <summary><c>T_TIMESTAMPTZ</c></summary>
        TTimestamptz = 34,

        /// <summary><c>T_TINT</c></summary>
        TTint = 35,

        /// <summary><c>T_TSTZMULTIRANGE</c></summary>
        TTstzmultirange = 36,

        /// <summary><c>T_TSTZRANGE</c></summary>
        TTstzrange = 37,

        /// <summary><c>T_TSTZSET</c></summary>
        TTstzset = 38,

        /// <summary><c>T_TSTZSPAN</c></summary>
        TTstzspan = 39,

        /// <summary><c>T_TSTZSPANSET</c></summary>
        TTstzspanset = 40,

        /// <summary><c>T_TTEXT</c></summary>
        TTtext = 41,

        /// <summary><c>T_GEOMETRY</c></summary>
        TGeometry = 42,

        /// <summary><c>T_GEOMSET</c></summary>
        TGeomset = 43,

        /// <summary><c>T_GEOGRAPHY</c></summary>
        TGeography = 44,

        /// <summary><c>T_GEOGSET</c></summary>
        TGeogset = 45,

        /// <summary><c>T_TGEOMPOINT</c></summary>
        TTgeompoint = 46,

        /// <summary><c>T_TGEOGPOINT</c></summary>
        TTgeogpoint = 47,

        /// <summary><c>T_NPOINT</c></summary>
        TNpoint = 48,

        /// <summary><c>T_NPOINTSET</c></summary>
        TNpointset = 49,

        /// <summary><c>T_NSEGMENT</c></summary>
        TNsegment = 50,

        /// <summary><c>T_TNPOINT</c></summary>
        TTnpoint = 51,

        /// <summary><c>T_POSE</c></summary>
        TPose = 54,

        /// <summary><c>T_POSESET</c></summary>
        TPoseset = 55,

        /// <summary><c>T_TPOSE</c></summary>
        TTpose = 56,

        /// <summary><c>T_CBUFFER</c></summary>
        TCbuffer = 57,

        /// <summary><c>T_CBUFFERSET</c></summary>
        TCbufferset = 58,

        /// <summary><c>T_TCBUFFER</c></summary>
        TTcbuffer = 59,

        /// <summary><c>T_TGEOMETRY</c></summary>
        TTgeometry = 60,

        /// <summary><c>T_TGEOGRAPHY</c></summary>
        TTgeography = 61,

        /// <summary><c>T_TRGEOMETRY</c></summary>
        TTrgeometry = 62,

        /// <summary><c>T_JSONB</c></summary>
        TJsonb = 63,

        /// <summary><c>T_JSONPATH</c></summary>
        TJsonpath = 64,

        /// <summary><c>T_JSONBSET</c></summary>
        TJsonbset = 65,

        /// <summary><c>T_TJSONB</c></summary>
        TTjsonb = 66,

        /// <summary><c>T_TBIGINT</c></summary>
        TTbigint = 67,

        /// <summary><c>T_H3INDEX</c></summary>
        TH3index = 68,

        /// <summary><c>T_H3INDEXSET</c></summary>
        TH3indexset = 69,

        /// <summary><c>T_TH3INDEX</c></summary>
        TTh3index = 70,

        /// <summary><c>T_QUADBIN</c></summary>
        TQuadbin = 71,

        /// <summary><c>T_QUADBINSET</c></summary>
        TQuadbinset = 72,

        /// <summary><c>T_TQUADBIN</c></summary>
        TTquadbin = 73,

        /// <summary><c>T_PCPOINT</c></summary>
        TPcpoint = 74,

        /// <summary><c>T_PCPOINTSET</c></summary>
        TPcpointset = 75,

        /// <summary><c>T_TPCPOINT</c></summary>
        TTpcpoint = 76,

        /// <summary><c>T_PCPATCH</c></summary>
        TPcpatch = 77,

        /// <summary><c>T_PCPATCHSET</c></summary>
        TPcpatchset = 78,

        /// <summary><c>T_TPCPATCH</c></summary>
        TTpcpatch = 79,

        /// <summary><c>T_TPCBOX</c></summary>
        TTpcbox = 80,

        /// <summary><c>T_RAQUET</c></summary>
        TRaquet = 81,

        /// <summary><c>T_POSECHAIN</c></summary>
        TPosechain = 82,

        /// <summary><c>T_POSECHAINSET</c></summary>
        TPosechainset = 83,

        /// <summary><c>T_TPOSECHAIN</c></summary>
        TTposechain = 84,

        /// <summary><c>T_S2CELL</c></summary>
        TS2cell = 85,

        /// <summary><c>T_S2CELLSET</c></summary>
        TS2cellset = 86,

        /// <summary><c>T_TS2CELL</c></summary>
        TTs2cell = 87,

        /// <summary><c>NUM_MEOS_TYPES</c></summary>
        NumMeosTypes = 88,

    }
}
