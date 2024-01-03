namespace MEOS.NET.Builder.Workflow
{
	using MEOS.NET.Builder.View;

	public class RetrieveFileWorkflow
	{
		public string RetrieveFileUntilValid()
		{
			while (true)
			{
				try
				{
					return this.RetrieveFile();
				}
				catch (FileNotFoundException e)
				{
					Display.FileNotFoundMessage(e.FileName ?? string.Empty);
				}
			}
		}

		private string RetrieveFile()
		{
			Display.RetrieveFileMessage();
			var filePath = Console.ReadLine();

			if (!File.Exists(filePath) )
			{
				throw new FileNotFoundException();
			}

			return filePath;
		}
	}
}

