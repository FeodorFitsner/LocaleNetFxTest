using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaleNetFxTest
{
    class Program
    {
        static void Main(string[] args)
        {
			Dictionary<string, string> localeAndExpectedFormattedNumbers = new Dictionary<string, string>()
		{
			{ "bg-BG", "12,35" },
			{ "de-CH", "12.35" },
			{ "fr-CH", "12,35" }

		};

			foreach (string locale in localeAndExpectedFormattedNumbers.Keys)
			{
				string expectedFormat = localeAndExpectedFormattedNumbers[locale];
				string formattedNumber = string.Format(new CultureInfo(locale), "{0}", 12.35);

				string sameValue = expectedFormat == formattedNumber ? "OK" : "NOT";

				Console.WriteLine("Locale '{0}', expected: {1}, formatted: {2} ({3})", locale, expectedFormat, formattedNumber, sameValue);
			}
		}
    }
}
