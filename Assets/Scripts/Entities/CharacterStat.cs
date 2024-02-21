using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public class CharacterStat
{
    public EnumType.StatsChangeType statsChangedType;
    [Range(1f, 20f)] public float speed;
    public int maxHP;
    public int maxMP;
  
}
