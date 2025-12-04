namespace AOEOBasicDataLibrary.Helpers;
public static class MiscXElementHelpers
{
    extension(XElement source)
    {
        public BasicList<XElement> GetUnits() => source.Descendants("Unit").ToBasicList();
        public void SetTechElement()
        {
            source.SetAttributeValue("type", "Normal");
            source.SetElementValue("DBID", "4728");
            source.SetElementValue("Status", "UNOBTAINABLE");
            source.SetElementValue("ContentPack", "22");
            source.SetElementValue("Flag", "IsAward");
        }
        //this is so common, best to have here now.
        public string AttributeName => source.Attribute("name")!.Value;
    }
    extension(IEnumerable<XElement> list)
    {
        /// <summary>
        /// this can be used for either tech or unit since they use the same xml
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public XElement GetName(string name, string category) => list.Single(xx => xx.Attribute("name")!.Value == name && (xx.Attribute("category")!.Value == category || xx.Attribute("category")!.Value == "Any"));
        public XElement GetName(string name) => list.Single(xx => xx.Attribute("name")!.Value == name);
        public XElement StartNewHiddenTech(string name)
        {
            XElement element = list.GetName(name);
            element.SetTechElement();
            return element;
        }
        public XElement StartNewHiddenTech(string name, string category)
        {
            XElement element = list.GetName(name, category);
            element.SetTechElement();
            return element;
        }
    }
}