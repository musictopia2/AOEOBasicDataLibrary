namespace AOEOBasicDataLibrary.Helpers;
public static class CharacterHelpers
{
    //now its public since it can be accessed from anywhere now.

    extension (string civ)
    {
        public string CharacterPath => $@"{dd1.RawCharacterLocations}\{civ}.character"; //now needs this one
    }
    extension (XElement techs)
    {
        public void AddCharacterTech(string techName, string value = "active")
        {
            XElement element = new("tech");
            element.SetAttributeValue("status", value);
            element.SetAttributeValue("persistentcitystatus", value);
            element.Value = techName; //hopefully this simple now.
            techs.Add(element); //these are additional techs being added.
        }
    }
    public static void CleanCharacterFiles()
    {
        BasicList<string> olds = dd1.GetCharacters();
        olds.ForEach(ff1.DeleteFile);
    }
    extension (ICharacterFileModifierService file)
    {
        public ICharacterFileModifierService SaveCharacterFile()
        {
            file.Source!.Save(file.CharacterPath);
            return file;
        }
    }
}