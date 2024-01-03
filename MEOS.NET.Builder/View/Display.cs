namespace MEOS.NET.Builder.View
{
	public static class Display
	{
		public static void IntroductionMessage()
			=> Console.WriteLine(Messages.Introduction);

		public static void RetrieveFileMessage()
			=> Console.WriteLine(Messages.InputMEOSHeaderPath);

		public static void FileNotFoundMessage(string filePath)
			=> Console.WriteLine(Messages.FileNotFound(filePath));
	}
}

