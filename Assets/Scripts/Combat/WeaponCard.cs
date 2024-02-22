using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class WeaponCard : MonoBehaviour
{
    public GameObject card;
    public GameObject cover;
    public AttackSO attackSO;
    private HealthSystem _enemyHealth0;
    private HealthSystem _enemyHealth1;
    private HealthSystem _enemyHealth2;


    private void Awake()
    {
        _enemyHealth0 = GameObject.Find("EnemySlot").GetComponentInChildren<HealthSystem>();
        _enemyHealth1 = GameObject.Find("EnemySlot1").GetComponentInChildren<HealthSystem>();
        _enemyHealth2 = GameObject.Find("EnemySlot2").GetComponentInChildren<HealthSystem>();
    }

    private void OnMouseEnter()
    {
        Vector3 newPos = card.transform.localPosition;
        newPos.y = 400;
        card.transform.localPosition = newPos;
    }
    private void OnMouseExit()
    {
        Vector3 newPos = card.transform.localPosition;
        newPos.y = 0;
        card.transform.localPosition = newPos;
    }

    private void OnMouseDown()
    {
        int dice = Random.Range(0, CombatPopupSetting.Instance._curEnemyList.Count);

        switch(dice)
        {
            case 0:
                _enemyHealth0.ChangeHealth(attackSO.power);
                break;
            case 1:
                _enemyHealth1.ChangeHealth(attackSO.power);
                break; 
            case 2:
                _enemyHealth2.ChangeHealth(attackSO.power);
                break;
        }
    }

   



}
