namespace QuestTesterLibrary.TestServices;
//common even if not testing for adding techs for character files to need this.
//when i do the complete system, if i am wrong, rethink.
public class CompleteTechsCharacterService : BaseTechsCharacterService 
{
    public override void AddTechs()
    {
        this.AddMilestoneTechs()
            .AddTraitTechs()
            .AddWonderTechs()
            .AddAdvisorTechs()
            .SaveTechs();
    }
}