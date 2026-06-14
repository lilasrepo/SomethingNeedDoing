using FFXIVClientStructs.FFXIV.Client.Game.UI;
using SomethingNeedDoing.Core.Interfaces;

namespace SomethingNeedDoing.LuaMacro.Wrappers;

public unsafe class BuddyWrapper : IWrapper
{
    [LuaDocs][Changelog("12.22")] public List<BuddyMemberWrapper> BuddyMember => [.. UIState.Instance()->Buddy.BattleBuddies.ToArray().Select(b => new BuddyMemberWrapper(b))];
    [LuaDocs][Changelog("12.22")] public CompanionInfoWrapper CompanionInfo => new();
    [LuaDocs][Changelog("12.22")] public PetInfoWrapper PetInfo => new();
}

public class BuddyMemberWrapper(Buddy.BuddyMember buddy) : IWrapper
{
    [LuaDocs][Changelog("12.22")] public uint EntityId => buddy.EntityId;
    [LuaDocs][Changelog("12.22")] public uint CurrentHealth => buddy.CurrentHealth;
    [LuaDocs][Changelog("12.22")] public uint MaxHealth => buddy.MaxHealth;
    [LuaDocs][Changelog("12.22")] public byte DataId => buddy.DataId;
    [LuaDocs][Changelog("12.22")] public byte Synced => buddy.Synced;
    [LuaDocs][Changelog("12.22")] public List<StatusWrapper> Status => [.. buddy.StatusManager.Status.ToArray().Select(s => new StatusWrapper(s))];
}

public unsafe class CompanionInfoWrapper : IWrapper
{
    [LuaDocs][Changelog("12.22")] public float TimeLeft => UIState.Instance()->Buddy.CompanionInfo.TimeLeft;
    [LuaDocs][Changelog("12.22")] public byte BardingHead => 0; // B1(api12): CompanionInfo.BuddyEquipRowIds added in 7.5 ClientStructs
    [LuaDocs][Changelog("12.22")] public byte BardingChest => 0; // B1(api12)
    [LuaDocs][Changelog("12.22")] public byte BardingFeet => 0; // B1(api12)
    [LuaDocs][Changelog("12.22")] public uint CurrentXP => UIState.Instance()->Buddy.CompanionInfo.CurrentXP;
    [LuaDocs][Changelog("12.22")] public byte Rank => UIState.Instance()->Buddy.CompanionInfo.Rank;
    [LuaDocs][Changelog("12.22")] public byte Stars => UIState.Instance()->Buddy.CompanionInfo.Stars;
    [LuaDocs][Changelog("12.22")] public byte SkillPoints => UIState.Instance()->Buddy.CompanionInfo.SkillPoints;
    [LuaDocs][Changelog("12.22")] public byte DefenderLevel => 0; // B1(api12): CompanionInfo.Levels added in 7.5 ClientStructs
    [LuaDocs][Changelog("12.22")] public byte AttackerLevel => 0; // B1(api12)
    [LuaDocs][Changelog("12.22")] public byte HealerLevel => 0; // B1(api12)
    [LuaDocs][Changelog("12.22")] public byte ActiveCommand => UIState.Instance()->Buddy.CompanionInfo.ActiveCommand;
    [LuaDocs][Changelog("12.22")] public byte FavoriteFeed => UIState.Instance()->Buddy.CompanionInfo.FavoriteFeed;
    [LuaDocs][Changelog("12.22")] public byte CurrentColorStainId => UIState.Instance()->Buddy.CompanionInfo.CurrentColorStainId;
    [LuaDocs][Changelog("12.22")] public bool Mounted => UIState.Instance()->Buddy.CompanionInfo.Mounted;
    [LuaDocs][Changelog("12.22")] public string Name => UIState.Instance()->Buddy.CompanionInfo.NameString;
    [LuaDocs][Changelog("12.22")] public bool IsBuddyEquipUnlocked(uint buddyEquipId) => UIState.Instance()->Buddy.CompanionInfo.IsBuddyEquipUnlocked(buddyEquipId);
}

public unsafe class PetInfoWrapper : IWrapper
{
    [LuaDocs][Changelog("12.22")] public byte Order => UIState.Instance()->Buddy.PetInfo.Order;
    [LuaDocs][Changelog("12.22")] public byte Stance => UIState.Instance()->Buddy.PetInfo.Stance;
}
