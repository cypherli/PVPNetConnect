using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PVPNetConnect.RiotObjects.Platform.Summoner;

namespace PVPNetConnect.RiotObjects.Platform.Summoner.Masterybook
{

public class TalentEntry : RiotGamesObject
{
public override string TypeName
{
get
{
return this.type;
}
}

private string type = "com.riotgames.platform.summoner.masterybook.TalentEntry";

public TalentEntry(Callback callback)
{
this.callback = callback;
}

public TalentEntry(TypedObject result)
{
base.SetFields(this, result);
}

public delegate void Callback(TalentEntry result);

private Callback callback;

public override void DoCallback(TypedObject result)
{
base.SetFields(this, result);
callback(this);
}

[InternalName("rank")]
public int Rank { get; set; }

[InternalName("talentId")]
public int TalentId { get; set; }

[InternalName("talent")]
public Talent Talent { get; set; }

[InternalName("summonerId")]
public double SummonerId { get; set; }

}
}
