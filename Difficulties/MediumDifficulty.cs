﻿using System.Collections.Generic;

namespace BTD6Rogue;

public class MediumDifficulty : RogueDifficulty {
    public override string DisplayName => "Medium";
    public override Dictionary<int, string> GameHintOverrides => new Dictionary<int, string>();
    public override int BloonSendOffset => 0;
    public override Dictionary<string, int> BloonSendOffsets => new Dictionary<string, int>();


    public override void Register() { }
}