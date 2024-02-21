using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyCombat : MonoBehaviour
{
    private StatsHandler _statsHandler;
    private HealthSystem _healthSystem;

    [SerializeField]private Slider enemyHpBar;

    private void Awake()
    {
        _healthSystem = GetComponent<HealthSystem>();
        _statsHandler = GetComponent<StatsHandler>();
    }

    private void Start()
    {
        enemyHpBar.value = _healthSystem.CurrentHealth / _statsHandler.CurrentStats.maxHP;
    }

   
}
