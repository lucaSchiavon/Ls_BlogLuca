using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Reflection;
using System.Web;
using System.IO;

namespace AQuestBaseProject.Utils
{
	public static class FilesManipulationUtils
	{
		public static Dictionary<string, string> Read301CSV(string path)
		{
			if (File.Exists(path))
			{
				using (TextReader sr = new StreamReader(path))
				{
					Dictionary<string, string> redirect_dict = new Dictionary<string, string>();
					string line = "";
					while ((line = sr.ReadLine()) != null)
					{
						string[] columns = line.Split(',');
						redirect_dict.Add(columns[0], columns[1]);
					}
					return redirect_dict;
				}
			}
			else
				return null;

		}

	}
}