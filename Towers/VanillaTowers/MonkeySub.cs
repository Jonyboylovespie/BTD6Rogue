﻿using Il2CppAssets.Scripts.Models.Towers;
using UnityEngine;

namespace BTD6Rogue;

public class MonkeySub : RogueTower {
    public override string BaseTower => TowerType.MonkeySub;

    public override int[] LeadUpgradeTiers => new int[3] { -1, 2, -1 };

    public override int[] CamoUpgradeTiers => new int[3] { -3, -1, -1 };

    public override PathType[] UpgradePathTypes => new PathType[3] { PathType.Support, PathType.Damage, PathType.Damage };

    public override Vector2Int[] TowerAmountRanges => new Vector2Int[3] { new Vector2Int(), new Vector2Int(), new Vector2Int(2, 5) };

    public override void Register() { }
}