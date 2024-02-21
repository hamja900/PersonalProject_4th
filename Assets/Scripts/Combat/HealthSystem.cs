using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealthSystem : MonoBehaviour
{
    private StatsHandler _statsHandler;

    public event Action OnDamage;
    public event Action OnDeath;



    public float CurrentHealth { get; private set; }
    public float CurrentMP { get; private set; }
    public float maxHP => _statsHandler.CurrentStats.maxHP;
    public float maxMP => _statsHandler.CurrentStats.maxMP;

    private void Awake()
    {
        _statsHandler = GetComponent<StatsHandler>();
    }
    private void Start()
    {
        CurrentHealth = _statsHandler.CurrentStats.maxHP;
        CurrentMP = _statsHandler.CurrentStats.maxMP;
    }

    public bool ChangeHealth(float change)
    {
        CurrentHealth += change;
        CurrentHealth = CurrentHealth > maxHP ? maxHP : CurrentHealth;
        CurrentHealth = CurrentHealth < 0 ? 0 : CurrentHealth;

        if (change < 0)
        {
            OnDamage?.Invoke();
        }
        if (CurrentHealth > 0)
        {
            CallDeath();
        }
        return true;
    }

   

    public bool ChangeMp(float change)
    {
        CurrentMP += change;
        CurrentMP = CurrentMP > maxMP ? maxMP : CurrentMP;
        CurrentMP = CurrentMP < 0 ? 0 : CurrentMP;

        return true;
    }

    private void CallDeath()
    {
        OnDeath?.Invoke();
    }
}
