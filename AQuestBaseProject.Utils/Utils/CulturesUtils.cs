using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AQuestBaseProject.Utils
{
	public static class CulturesUtils
	{
		public static string GetLocalizedValueFromDictionary(string defaultCultureCode, string currentCultureCode, Dictionary<string, object> translationsDictionary)
		{
			object res;
			translationsDictionary.TryGetValue(currentCultureCode, out res);
			if (res == null || (res != null && res.ToString() == ""))
			{
				translationsDictionary.TryGetValue(defaultCultureCode, out res);
			}
			return res.ToString();
		}

		public static string LangCodeToCultureCode(string langCode) 
		{
			var retValue = "";

			switch (langCode)
			{
				case "fr":
					retValue = "fr-FR";
					break;
				case "en":
					retValue = "en-US";
					break;
				default:
					retValue = "it-IT";
					break;
			}

			return retValue;
		}

		public static void InitializeCurrentThreadCulture(string cultureCode)
		{
			try
			{
				Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(cultureCode);
				Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultureCode);
			}
			catch (Exception e)
			{
				throw new NotSupportedException(String.Format("ERROR: Invalid culture code '{0}'.", cultureCode));
			}
		}
	}
}
