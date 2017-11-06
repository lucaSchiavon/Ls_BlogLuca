using PigeonCms;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AQuestBaseProject.Utils.Utils
{
	public static class TranslationUtils
	{
		public static string GetLabel(string set, string key, string defaultValue, Dictionary<string, List<ResLabel>> labelsList = null,
			ContentEditorProvider.Configuration.EditorTypeEnum textMode = ContentEditorProvider.Configuration.EditorTypeEnum.Text, bool autoAddLabel = true)
		{
			if (string.IsNullOrEmpty(set))
				throw new ArgumentException("empty resourceSet");

			if (string.IsNullOrEmpty(key))
				throw new ArgumentException("empty resourceId");

			if (labelsList == null)
				labelsList = new Dictionary<string, List<ResLabel>>();

			if (!labelsList.ContainsKey(set))
				labelsList.Add(set, LabelsProvider.GetLabelsByResourceSet(set));

			string retValue = LabelsProvider.GetLocalizedLabelFromList(set, labelsList[set], key, defaultValue, textMode, "", autoAddLabel);
			retValue = String.IsNullOrEmpty(retValue) ? defaultValue : retValue;
			retValue = WebUtility.HtmlDecode(retValue);

			return retValue;
		}
	}
}
