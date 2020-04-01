﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class AIS2 : AITreeNode
{
    public override AITreeNodeState Execute()
    {
        BattleManager.instance.currentChar.SkillTwo(AITree.AIstarget.GetCurrentTile());
        return AITreeNodeState.Succeeded;
    }
}