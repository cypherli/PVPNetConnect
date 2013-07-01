using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PVPNetConnect.RiotObjects.Platform.Statistics
{

public class LeaverPenaltyStats : RiotGamesObject
{
public override string TypeName
{
get
{
return this.type;
}
}

private string type = "com.riotgames.platform.statistics.LeaverPenaltyStats";

public LeaverPenaltyStats(Callback callback)
{
this.callback = callback;
}

public LeaverPenaltyStats(TypedObject result)
{
base.SetFields(this, result);
}

public delegate void Callback(LeaverPenaltyStats result);

private Callback callback;

public override void DoCallback(TypedObject result)
{
base.SetFields(this, result);
callback(this);
}

[InternalName("lastLevelIncrease")]
public object LastLevelIncrease { get; set; }

[InternalName("level")]
public int Level { get; set; }

[InternalName("lastDecay")]
public DateTime LastDecay { get; set; }

[InternalName("userInformed")]
public bool UserInformed { get; set; }

[InternalName("points")]
public int Points { get; set; }

}
}
