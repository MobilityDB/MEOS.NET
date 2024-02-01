namespace MEOS.NET.Builder.View
{
	public static class Display
	{
		public static void IntroductionMessage()
			=> Console.WriteLine(Messages.Introduction);

		public static void RetrieveHeaderFileMessage()
			=> Console.WriteLine(Messages.InputMEOSHeaderPath);

		public static void RetrieveCompiledLibraryFileMessage()
			=> Console.WriteLine(Messages.InputCompiledMEOSPath);

		public static void FileNotFoundMessage(string filePath)
			=> Console.WriteLine(Messages.FileNotFound(filePath));

		public static void WriteMessage(string message)
			=> Console.WriteLine(message);
	}
}

