namespace AOEOBasicDataLibrary.Helpers;
public static class TechHelpers
{
    public static Func<XElement, bool>? EffectAllowed { get; set; }
    public static XElement GetTechElements()
    {
        return XElement.Load(dd1.NewTechLocation); //i think.
    }
    public static async Task CopyTechsAsync()
    {
        await ff1.FileCopyAsync(dd1.RawTechLocation, dd1.NewTechLocation);
    }
    extension(XElement source)
    {
        public BasicList<XElement> Techs => source.Descendants("Tech").ToBasicList();
        public string TechTitle
        {
            get
            {
                string output = source.Element("DisplayNameID")!.Value;
                return QuestStringTableHelpers.GetQuestStringValue(int.Parse(output));
            }
        }
        public string TechDescription
        {
            get
            {
                string output = source.Element("RolloverTextID")!.Value;
                return QuestStringTableHelpers.GetQuestStringValue(int.Parse(output));

            }
        }
        //its simply name now.
        //public string TechName => source.Attribute("name")!.Value;

        public bool OptionalOnlyAllowEffectsAccumulateNoStone
        {
            get
            {
                var firsts = source.Attribute("subtype");
                if (firsts is null)
                {
                    return true;
                }
                if (firsts.Value == "Cost")
                {
                    return true; //doing something with stone cost is proper.
                }
                var item = source.Attribute("resource");
                if (item is null)
                {
                    return true;
                }
                if (item.Value == "Stone")
                {
                    return false;
                }
                return true;
            }
        }
    }


    //this will allow for any implementation of processing tech files that involve getting additional techs from file.
    //since file is a common way to store data (obviously, a person is not limited to just file storage).


    extension (string path)
    {
        public BasicList<XElement> GetTechElements()
        {
            XElement firsts = XElement.Load(ll1.GetLocation(path));
            return firsts.Elements("Tech").ToBasicList();
        }
        public XElement GetSingleTechElement()
        {
            XElement firsts = XElement.Load(ll1.GetLocation(path));
            return firsts.Elements("Tech").Single();
        }
    }

    extension (IAddTechsToTechTreeService techs)
    {
        public IAddTechsToTechTreeService AddAdvisorTechs(string path)
        {
            //this is if you are using file storage
            BasicList<XElement> list = path.GetTechElements();
            if (list.Count != 4)
            {
                throw new CustomBasicException("Must have 4 techs for advisors");
            }
            foreach (XElement tech in list)
            {
                techs.AddEffects(tech);
            }
            return techs;
        }
        private void AddEffects(XElement tech)
        {
            tech.SetTechElement();
            //risk not doing the settechelement if i am wrong, rethink

            BasicList<XElement> effects = tech.Elements("Effects").Single().Elements().ToBasicList();
            BasicList<XElement> others = effects.ToBasicList();
            foreach (var effect in effects)
            {
                if (EffectAllowed is not null)
                {
                    bool rets = EffectAllowed(effect);
                    if (rets == false)
                    {
                        others.RemoveSpecificItem(effect);
                    }
                }
            }
            tech.Elements("Effects").Single().ReplaceAll(others);
            techs.Source!.Add(tech);
        }
        public IAddTechsToTechTreeService AddMultipleMiscTechs(string path)
        {
            BasicList<XElement> list = path.GetTechElements();
            foreach (var tech in list)
            {
                techs.AddEffects(tech);
            }
            return techs;
        }
        public IAddTechsToTechTreeService AddSingleTech(string path)
        {
            XElement tech = path.GetSingleTechElement();
            techs.AddEffects(tech);
            return techs;
        }
    }
}