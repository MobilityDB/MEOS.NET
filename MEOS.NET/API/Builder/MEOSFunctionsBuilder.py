import re
import os

from typing import Optional

def map_type(input_type: str) -> str:

    # To String
    mapped = input_type.replace("char*", "string")

    # To Pointers 
    #mapped = mapped.replace("Temporal**", "IntPtr")
    #mapped = mapped.replace("Temporal*", "IntPtr")
    #mapped = mapped.replace("TInstant**", "IntPtr")
    #mapped = mapped.replace("TInstant*", "IntPtr")
    #mapped = mapped.replace("TSequence**", "IntPtr")
    #mapped = mapped.replace("TSequence*", "IntPtr")
    #mapped = mapped.replace("TSequenceSet*", "IntPtr")
    #mapped = mapped.replace("TimestampTz*", "IntPtr")
    #mapped = mapped.replace("Span**", "IntPtr")
    #mapped = mapped.replace("Span*", "IntPtr")
    #mapped = mapped.replace("SpanSet*", "IntPtr")
    #mapped = mapped.replace("Set*", "IntPtr")
    #
    #mapped = mapped.replace("STBox*", "IntPtr")
    #mapped = mapped.replace("TBox*", "IntPtr")
    #mapped = mapped.replace("SkipList*", "IntPtr")
    #mapped = mapped.replace("Match*", "IntPtr")
    #mapped = mapped.replace("GSERIALIZED**", "IntPtr")
    #mapped = mapped.replace("GSERIALIZED*", "IntPtr")
    #
    #mapped = mapped.replace("Datum*", "IntPtr")
    #
    #mapped = mapped.replace("text**", "IntPtr")
    #mapped = mapped.replace("text*", "IntPtr")
    #mapped = mapped.replace("Interval*", "IntPtr")
    #
    #mapped = mapped.replace("bytea*", "IntPtr")
    #mapped = mapped.replace("uint8_t*", "IntPtr")
    #mapped = mapped.replace("size_t*", "IntPtr")
    #
    #mapped = mapped.replace("bool*", "IntPtr")
    #mapped = mapped.replace("int**", "IntPtr")
    #mapped = mapped.replace("int*", "IntPtr")
    #mapped = mapped.replace("int64*", "IntPtr")
    #mapped = mapped.replace("double*", "IntPtr")
    if "*" in mapped:
        return "IntPtr"

    # To Non-pointers
    mapped = mapped.replace("ushort_t", "ushort")
    mapped = mapped.replace("uint32", "uint")
    mapped = mapped.replace("uint64", "ulong")
    mapped = mapped.replace("size_t", "ulong")

    mapped = mapped.replace("uint8_t", "byte")
    mapped = mapped.replace("int8", "short")
    mapped = mapped.replace("int32", "int")
    mapped = mapped.replace("int64", "double")

    mapped = mapped.replace("TimestampTz", "DateTimeOffset")
    mapped = mapped.replace("Timestamp", "DateTime")

    mapped = mapped.replace("Datum", "object")

    mapped = mapped.replace("TimeADT", "int")
    mapped = mapped.replace("DateADT", "long") # https://doxygen.postgresql.org/date_8h_source.html

    # To Enums
    mapped = mapped.replace("interpType", "InterpolationType")
    
    return mapped

def transform_fn_args(args: str) -> str:
    if args.strip() == "void":
        return ""

    splitted = args.split(',')
    arg_pattern = r'(?:\s*const)?\s*([\w\s]+)\s+(\*{0,2})\s*(\w+)\s*'

    mapped_args = []

    for arg in splitted:
        match = re.match(arg_pattern, arg)

        if match:
            new_type = map_type(match.group(1).strip() + match.group(2).strip())
            name = match.group(3).strip()
            
            mapped_args.append(f"{new_type} {name}")
           
    return ','.join(mapped_args)
    

def process_line(line: str) -> Optional[str] :
    pattern = r'^\s*extern\s+(const\s+)?([a-zA-Z_][a-zA-Z0-9_\s]*\**)\s+(\**)([a-zA-Z_][a-zA-Z0-9_]*)\s*\((.*?)\)\s*;'
    match = re.match(pattern, line)

    if match:
        ret_type = match.group(2).strip() + match.group(3).strip()
        fn_name = match.group(4).strip()
        arg_list = transform_fn_args(match.group(5).strip())

        return f"public static extern {map_type(ret_type)} {fn_name}({arg_list});"

    return None
   

if __name__ == "__main__":
    file_path = os.path.expanduser("~/Externals/MobilityDB/meos/include/meos.h")

    print("using System.Runtime.InteropServices;\n")
    print("namespace MEOS.NET.API.Internal")
    print("{")
    print("\tpublic static class MEOSFunctions")
    print("\t{")
    print("\t\tprivate const string DllPath = @\"API\\\\Internal\\\\libmeos.so\";\n")

    with open(file_path, 'r') as file:
        for line in file:
            declaration = process_line(line)

            if declaration:
                print("\t\t[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]")
                print(f"\t\t{declaration}\n")

    print("\t}")
    print("}")
