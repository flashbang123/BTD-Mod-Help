﻿using Assets.Scripts.Data.MapSets;
using Assets.Scripts.Models.Map;
using Assets.Scripts.Simulation.SMath;
using System.Collections.Generic;

namespace BTD_Mod_Helper.Api.Scenarios;

internal class TestMap : ModMap
{
    public override string Name => "Test Map";
    public override MapDifficulty Difficulty => MapDifficulty.Beginner;
    protected override string MapImageName => "Minecraft TopDown";

    public TestMap()
    {
        AddPath(new List<Vector2>()
        {
            new(-48.70371f, -113.0834f),
            new(-45.00001f, 23.85197f)
        });

        AddAreaModel(AreaType.water, new List<Vector2>()
        {
            new(3, 5),
            new(3, 5),
            new(3, 5),
            new(3, 5),
        });
    }
}