using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQuestBaseProject.Utils
{
	public static class CollectionUtils
	{
		public static IEnumerable<T> FindSiblingsItems<T>(this IEnumerable<T> items, Predicate<T> matchFilling)
		{
			if (items == null)
				throw new ArgumentNullException("items");
			if (matchFilling == null)
				throw new ArgumentNullException("matchFilling");

			return FindSiblingsItemsImpl(items, matchFilling);
		}

		private static IEnumerable<T> FindSiblingsItemsImpl<T>(IEnumerable<T> items, Predicate<T> matchFilling)
		{
			using (var iter = items.GetEnumerator())
			{
				T previous = items.LastOrDefault();
				while (iter.MoveNext())
				{
					if (matchFilling(iter.Current))
					{
						yield return previous;
						yield return iter.Current;
						if (iter.MoveNext()) {
							yield return iter.Current;
						}
						else
						{
							yield return items.FirstOrDefault();

						}
						yield break;
					}
					previous = iter.Current;
				}
			}
			// If we get here nothing has been found so return three default values
			yield return default(T); // Previous
			yield return default(T); // Current
			yield return default(T); // Next
		}
	}
}
