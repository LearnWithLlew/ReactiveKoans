using System.Diagnostics;

namespace Koans.Utils
{
	public class LaunchReadme
	{
		public static void Main(string[] extra)
		{
			Process.Start(@"..\..\..\readme.rtf");
		}
	}
}