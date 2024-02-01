namespace MEOS.NET.Builder.Workflow
{
	using MEOS.NET.Builder.View;

	public class RetrieveFileWorkflow
	{
		public string RetrieveFileUntilValid(Action writeInputMessageFn)
		{
			while (true)
			{
				try
				{
					return this.RetrieveFile(writeInputMessageFn);
				}
				catch (FileNotFoundException e)
				{
					Display.FileNotFoundMessage(e.FileName ?? string.Empty);
				}
			}
		}

		private string RetrieveFile(Action writeInputMessageFn)
		{
			writeInputMessageFn();
			var filePath = Console.ReadLine();

			if (!File.Exists(filePath) )
			{
				throw new FileNotFoundException();
			}

			return filePath;
		}
	}
}

