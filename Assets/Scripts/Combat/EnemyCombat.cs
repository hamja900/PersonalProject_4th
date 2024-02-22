using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyCombat : MonoBehaviour
{
    private StatsHandler _statsHandler;
    private HealthSystem _healthSystem;

    [SerializeField] private GameObject pointArrow;
    [SerializeField]private Slider enemyHpBar;

    private void Awake()
    {
        _healthSystem = GetComponent<HealthSystem>();
        _statsHandler = GetComponent<StatsHandler>();
    }

    private void Start()
    {
       UpdateEnemyHP();
    }

    public void UpdateEnemyHP()
    {
        enemyHpBar.value = _healthSystem.CurrentHealth / _statsHandler.CurrentStats.maxHP;
    }

    private void OnMouseEnter()
    {
        if(GameManager.Instance.isEnemySelectMode)
        {
            if (GameManager.Instance.isWandAttack)
            {
            }
            pointArrow.SetActive(true);
        }
    }
    private void OnMouseExit()
    {
        if(GameManager.Instance.isEnemySelectMode)
        {
            if (GameManager.Instance.isWandAttack)
            {
            }
            pointArrow?.SetActive(false);
        }
    }
    private void OnMouseDown()
    {
        if(GameManager.Instance.isEnemySelectMode && GameManager.Instance.isWandAttack)
        {
            UpdateEnemyHP() ;
        }
    }


}
