using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyCombat : MonoBehaviour
{
    private StatsHandler _statsHandler;
    private HealthSystem _healthSystem;
    private WeaponCard _weaponCard;

    [SerializeField] private GameObject pointArrow;
    [SerializeField]private Slider enemyHpBar;

    private void Awake()
    {
        //공격시도중인 카드의 스크립트가 올 자리

        _weaponCard = CombatPopupSetting.Instance.cardScript;
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
    //private void OnMouseDown()
    //{
    //    if(GameManager.Instance.isEnemySelectMode)
    //    {
    //        //플레이어의 적 공격함수가 올 자리
    //        _weaponCard.EnemyHit(_healthSystem);
    //        UpdateEnemyHP() ;
    //    }
    //}

 


}
