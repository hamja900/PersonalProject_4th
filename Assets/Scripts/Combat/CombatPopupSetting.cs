using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CombatPopupSetting : MonoBehaviour
{
    public GameObject[] enemySlots;
    public GameObject[] CardSlots;
    public Slider hpBar;
    public Slider mpBar;
    private StatsHandler _statsHandler;
    private HealthSystem _healthSystem;
     

    public List<GameObject> _enemyList = new List<GameObject>();
    public List<GameObject> _curEnemyList = new List<GameObject>();
    public List<GameObject> _CardList = new List<GameObject>();
    public List<GameObject> _handList = new List<GameObject>();

    public AttackSO enemyAttackSO;
    public AttackSO[] cardAttackSO;


    private void Awake()
    {
        _statsHandler = GameManager.Instance.Player.GetComponent<StatsHandler>();
        _healthSystem = GameManager.Instance.Player.GetComponent<HealthSystem>();

    }
    // Start is called before the first frame update
    void Start()
    {
        ResetPopup();
        RandomGenEnemy();
        RandomGenCard();
        HpBar();
        MpBar();
        PlayerTurn();
    }

    private void RandomGenEnemy()
    {
        while (_curEnemyList.Count < Random.Range(1, 4))
        {
            for (int i = 0; i < _enemyList.Count; i++)
            {
                _curEnemyList.Add(_enemyList[i]);
            }
        }

        for (int j = 0; j < _curEnemyList.Count; j++)
        {
            Instantiate(_curEnemyList[j], enemySlots[j].transform);
        }
    }
    private void RandomGenCard()
    {
        while (_handList.Count < 4)
        {
            _handList.Add(_CardList[Random.Range(0, _CardList.Count)]);

        }
        for (int j = 0; j < 3; j++)
        {
            Instantiate(_handList[j], CardSlots[j].transform);
        }
    }

    private void ResetPopup()
    {
        _handList.Clear();
        _curEnemyList.Clear();
    }

    private void HpBar()
    {
        hpBar.value = GameManager.Instance.PlayerCurHp() / _statsHandler.CurrentStats.maxHP;
    }

    private void MpBar()
    {
        mpBar.value = GameManager.Instance.PlayerCurMp() / _statsHandler.CurrentStats.maxMP;
    }

    public void SkelAttack()
    {
        _healthSystem.ChangeHealth(-enemyAttackSO.power);
    }

    private void PlayerTurn()
    {
        EnemyTurn();
    }

    private void EnemyTurn()
    {
        for (int i = 0; i< _curEnemyList.Count; i++)
        {
            SkelAttack();
            HpBar();
            Thread.Sleep(100);
        }
    }

    public void OnRunBtn()
    {
        int dice = Random.Range(0, 10);
        //if (dice > 8)
        //{
        //    return;
        //}
        Destroy(gameObject);

    }
}
