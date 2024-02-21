using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsHandler : MonoBehaviour
{
    [SerializeField] private CharacterStat baseStats;
    public CharacterStat CurrentStats { get; private set; }
    public List<CharacterStat> stastsModifier = new List<CharacterStat>();

    private void Awake()
    {
        UpdateCharacterStats();
    }

    private void UpdateCharacterStats()
    {
        CurrentStats = new CharacterStat();
        CurrentStats.statsChangedType = baseStats.statsChangedType;
        CurrentStats.maxHP = baseStats.maxHP;
        CurrentStats.maxMP = baseStats.maxMP;
        CurrentStats.speed = baseStats.speed;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
