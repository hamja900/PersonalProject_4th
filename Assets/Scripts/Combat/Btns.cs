using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Btns : MonoBehaviour
{
    public GameObject[] enemy;
    private HealthSystem[] _healthSystem;
    private EnemyCombat enemyCombat;

    private void Awake()
    {
        enemyCombat = CombatPopupSetting.Instance._enemyList[0].GetComponent<EnemyCombat>();
        for (int i = 0; i<CombatPopupSetting.Instance._curEnemyList.Count; i++)
        {
            enemy[i] = CombatPopupSetting.Instance._curEnemyList[i].gameObject;
            _healthSystem[i] = enemy[i].GetComponent<HealthSystem>();

        }
    }

    

    public void KnifeCard()
    {
        TargetSelect();
        gameObject.SetActive(false);    
    }
    public void LongSword()
    {
        TargetSelect();
        gameObject.SetActive(false);
    }
    public void Wand()
    {
       for(int i = 0; i<enemy.Length; i++)
        {
            Debug.Log("АјАн" + i);
            _healthSystem[i].ChangeHealth(-8);
            enemyCombat.UpdateEnemyHP();
        }
        gameObject.SetActive(false);
    }

    public void TargetSelect()
    {
        GameManager.Instance.isEnemySelectTurn = true;
    }
}
