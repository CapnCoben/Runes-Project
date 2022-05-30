using System.Collections.Generic;
using UnityEngine;
using System;

public enum Locale
{
    en, pt
}

public static class Localization
{
    private static Dictionary<Locale, Dictionary<string, string>> localizationTable;

    private static Locale currentLocale = Locale.en;

    public static Dictionary<string, string> currentLocalizationTable => localizationTable[currentLocale];


    static Localization()
    {
        Load();
    }

    private static void Load()
    {
        var source = Resources.Load<TextAsset>("LocalizationSource"); //loading text file

        var lines = source.text.Split('\n'); //separating each row
        var header = lines[0].Split(';'); //separating each column

        var localeOrder = new List<Locale>(header.Length - 1);

        localizationTable = new Dictionary<Locale, Dictionary<string, string>>();

        for (int i = 1; i < header.Length; i++)
        { 
            var locale = (Locale)Enum.Parse(typeof(Locale), header[i]); // type casting as local enum
            localeOrder.Add(locale);
            localizationTable[locale] = new Dictionary<string, string>(lines.Length - 1);
        }

        for (int index = 1; index < lines.Length; index++)
        {
            var entry = lines[index].Split(';'); //separating lines at each semicolon
            var key = entry[0]; 

            for(var i = 0; i < localeOrder.Count; i++)
            {
                var locale = localeOrder[i];
                localizationTable[locale][key] = entry[i + 1];
            }
        }
    }
}
