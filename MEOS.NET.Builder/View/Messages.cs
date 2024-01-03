namespace MEOS.NET.Builder.View
{
	public static class Messages
	{
		public const string Introduction = "Welcome to the builder for MEOS functions\n" +
            "This is a tool helping to the development of MEOS.NET\n" +
            "From a C header file, it will write the C# methods that will be called in MEOS.NET";

		public const string InputMEOSHeaderPath = "Please enter the path to the MEOS header file...";

		public static string FileNotFound(string path)
			=> $"File was not found ({path})";
	}
}

