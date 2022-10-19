using Language;
using Object = UnityEngine.Object;

namespace HKMirror.Reflection.StaticClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of Language allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public static class LanguageR
{
    public static string settingsAssetPath = Language.Language.settingsAssetPath;

    public static LocalizationSettings _settings
    {
        get => ReflectionHelper.GetField<LocalizationSettings>(typeof(Language.Language), "_settings");
        set => ReflectionHelper.SetField(typeof(Language.Language), "_settings", value);
    }

    public static List<string> availableLanguages
    {
        get => ReflectionHelper.GetField<List<string>>(typeof(Language.Language), "availableLanguages");
        set => ReflectionHelper.SetField(typeof(Language.Language), "availableLanguages", value);
    }

    public static LanguageCode currentLanguage
    {
        get => ReflectionHelper.GetField<LanguageCode>(typeof(Language.Language), "currentLanguage");
        set => ReflectionHelper.SetField(typeof(Language.Language), "currentLanguage", value);
    }

    public static Dictionary<string, Dictionary<string, string>> currentEntrySheets
    {
        get => ReflectionHelper.GetField<Dictionary<string, Dictionary<string, string>>>(typeof(Language.Language),
            "currentEntrySheets");
        set => ReflectionHelper.SetField(typeof(Language.Language), "currentEntrySheets", value);
    }

    public static string LastLanguageKey =>
        ReflectionHelper.GetField<string>(typeof(Language.Language), "M2H_lastLanguage");

    public static LocalizationSettings settings => Language.Language.settings;

    public static void LoadLanguage()
    {
        Language.Language.LoadLanguage();
    }

    public static string RestoreLanguageSelection()
    {
        return ReflectionHelper.CallMethod<string>(typeof(Language.Language), "RestoreLanguageSelection");
    }

    public static void LoadAvailableLanguages()
    {
        Language.Language.LoadAvailableLanguages();
    }

    public static string[] GetLanguages()
    {
        return Language.Language.GetLanguages();
    }

    public static bool SwitchLanguage(string langCode)
    {
        return Language.Language.SwitchLanguage(langCode);
    }

    public static bool SwitchLanguage(LanguageCode code)
    {
        return Language.Language.SwitchLanguage(code);
    }

    public static void DoSwitch(LanguageCode newLang)
    {
        ReflectionHelper.CallMethod(typeof(Language.Language), "DoSwitch", newLang);
    }

    public static Object GetAsset(string name)
    {
        return Language.Language.GetAsset(name);
    }

    public static bool HasLanguageFile(string lang, string sheetTitle)
    {
        return ReflectionHelper.CallMethod<bool>(typeof(Language.Language), "HasLanguageFile", lang, sheetTitle);
    }


    public static string GetLanguageFileContents(string sheetTitle)
    {
        return ReflectionHelper.CallMethod<string>(typeof(Language.Language), "GetLanguageFileContents", sheetTitle);
    }

    public static LanguageCode CurrentLanguage()
    {
        return Language.Language.CurrentLanguage();
    }

    public static string Get(string key)
    {
        return Language.Language.Get(key);
    }

    public static string Get(string key, string sheetTitle)
    {
        return Language.Language.Get(key, sheetTitle);
    }

    public static bool Has(string key)
    {
        return Language.Language.Has(key);
    }

    public static bool Has(string key, string sheetTitle)
    {
        return Language.Language.Has(key, sheetTitle);
    }

    public static void SendMonoMessage(string methodString, params object[] parameters)
    {
        ReflectionHelper.CallMethod(typeof(Language.Language), "SendMonoMessage", methodString, parameters);
    }

    public static LanguageCode LanguageNameToCode(SystemLanguage name)
    {
        return Language.Language.LanguageNameToCode(name);
    }

    public static string GetInternal(string key, string sheetTitle)
    {
        return Language.Language.GetInternal(key, sheetTitle);
    }

    public static string orig_Get(string key, string sheetTitle)
    {
        return Language.Language.orig_Get(key, sheetTitle);
    }
}