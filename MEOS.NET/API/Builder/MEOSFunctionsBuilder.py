import re

header_file_path = "/home/totojr/Externals/MobilityDB/meos/include/meos.h"
output = "./API/Internal/Output.cs"

dll_path = "API\\Internal\\libmeos.so"

def parse_h_file():
    with open(header_file_path, 'r') as h_file:
        h_contents = h_file.read()

    cs_functions = re.findall(r'extern\s+(.*?)\s+(.*?)\((.*?)\);', h_contents)
    return cs_functions

def generate_csharp_declarations(cs_functions):
    csharp_declarations = []

    for ret_type, func_name, param_list in cs_functions:
        csharp_declaration = f"\t\t[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]\n"
        csharp_declaration += f"\t\tpublic static extern {ret_type} {func_name}({param_list});\n\n"

        csharp_declarations.append(csharp_declaration)
    return csharp_declarations

def write_to_cs_file(cs_functions):
    functions_signatures = generate_csharp_declarations(cs_functions)

    with open(output, 'w') as cs_file:
        cs_file.write("using System.Runtime.InteropServices;\n\n")
        cs_file.write("namespace MEOS.NET.API.Internal\n{\n")
        cs_file.write("\tpublic class MEOSFunctions\n\t{\n")
        cs_file.write("\t\tprivate const string DllPath = @\"API\\\\Internal\\\\libmeos.so\";\n\n")

        for declaration in functions_signatures:
            cs_file.write(declaration)

        cs_file.write("\t}\n")
        cs_file.write("}\n")

if __name__ == "__main__":
    cs_functions = parse_h_file()
    write_to_cs_file(cs_functions)

