using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AQuestBaseProject.Utils
{
	public static class JsonUtils
	{
		public static string JsonObjToLocalizedString(string defaultCultureCode, string currentCultureCode, string jsonObjectString)
		{
			var valueToReturn = "";

			jsonObjectString = jsonObjectString == null ? "" : jsonObjectString;
			jsonObjectString = jsonObjectString.Trim();
			jsonObjectString = jsonObjectString.Trim(new char[] { '[', ']' });

			jsonObjectString = jsonObjectString == "{}" ? "" : jsonObjectString;

			if (!String.IsNullOrEmpty(jsonObjectString))
			{
				var obj = JObject.Parse(jsonObjectString);

				try
				{
					valueToReturn = obj[currentCultureCode].ToString();
				}
				catch
				{
					valueToReturn = obj[defaultCultureCode].ToString();
				}
			}
			
			return valueToReturn;
		}

		public static List<string> JsonArrayToLocalizedListOfString(string defaultCultureCode, string currentCultureCode, string jsonArrayString)
		{
			var value = "";
			List<string> listToReturn = new List<string>();

			jsonArrayString = jsonArrayString == null ? "" : jsonArrayString;
			jsonArrayString = jsonArrayString.Trim();

			if (!String.IsNullOrEmpty(jsonArrayString))
			{
				if (!jsonArrayString.StartsWith("["))
				{
					jsonArrayString = "[" + jsonArrayString;
				}

				if (!jsonArrayString.EndsWith("]"))
				{
					jsonArrayString = jsonArrayString + "]";
				}

				JArray jArray = JArray.Parse(jsonArrayString);

				foreach (var token in jArray)
				{
					try
					{
						value = token[currentCultureCode].ToString();
					}
					catch
					{
						value = token[defaultCultureCode].ToString();
					}

					listToReturn.Add(value);
				}

			}

			return listToReturn;
		}

		public static string JsonObjToString(string jsonObjectString, string key)
		{
			jsonObjectString = jsonObjectString == null ? "" : jsonObjectString;
			jsonObjectString = jsonObjectString.Trim();
			jsonObjectString = jsonObjectString.Trim(new char[] { '[', ']' });

			return JObject.Parse(jsonObjectString)[key].ToString();
		}
	}
}
