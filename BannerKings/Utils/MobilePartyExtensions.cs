using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Party;

namespace BannerKings.Utils
{
    public static class MobilePartyExtensions
    {
        public static void SetSafeEscortBehavior(this MobileParty party, MobileParty target)
        {
            if (target != null && target.IsActive && !target.IsDestroyed && target.Party != null)
            {
                party.TargetParty = target;
                party.Ai.SetEscortPartyMode(target);
            }
            else
            {
                party.TargetParty = null;
                party.Ai.SetDoNothing(); // fallback behavior
            }
        }
    }
}
