﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Stats : ScriptableObject
{
    public int attackRange;
    public int speed;
    public float statusResist;
    public float damageResist;

    public void Copy(BaseStats baseStats)
    {
        attackRange = baseStats.attackRange;
        speed = baseStats.speed;
        statusResist = baseStats.statusResist;
        damageResist = baseStats.damageResist;
    }
}
