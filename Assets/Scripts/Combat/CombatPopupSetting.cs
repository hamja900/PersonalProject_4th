using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CombatPopupSetting : MonoBehaviour
{
    public static CombatPopupSetting Instance;

    public GameObject[] enemySlots;
    public GameObject[] CardSlots;
    public Slider hpBar;
    public Slider mpBar;
    private StatsHandler _statsHandler;
    private HealthSystem _healthSystem;
    public HealthSystem enemyHS;
    public EnemyCombat enemyCombat;
    public EnemyCombat enemyHPBar;
    public WeaponCard cardScript;
     

    public List<GameObject> _enemyList = new List<GameObject>();
    public List<GameObject> _curEnemyList = new List<GameObject>();
    public List<GameObject> _CardList = new List<GameObject>();
    public List<GameObject> _handList = new List<GameObject>();

    public AttackSO enemyAttackSO;
    public AttackSO[] cardAttackSO;


    private void Awake()
    {
        Instance = this;
        _statsHandler = GameManager.Instance.Player.GetComponent<StatsHandler>();
        _healthSystem = GameManager.Instance.Player.GetComponent<HealthSystem>();
        enemyCombat = _enemyList[0].GetComponent<EnemyCombat>();
    }
    // Start is called before the first frame update
    void Start()
    {
        ResetPopup();
        RandomGenEnemy();
        
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
            GameObject enemyGo = Instantiate(_curEnemyList[j], enemySlots[j].transform);
            enemyHS = enemyGo.GetComponent<HealthSystem>();
            enemyHPBar = enemyGo.GetComponent<EnemyCombat>();
            
        }
    }
    public void RandomGenCard()
    {
        while (_handList.Count < 3)
        {
            _handList.Add(_CardList[Random.Range(0, _CardList.Count)]);
        }
        for (int j = 0; j < CardSlots.Length; j++)
        {
            GameObject cardGo = Instantiate(_handList[j], CardSlots[j].transform);
            cardScript = cardGo.GetComponent<WeaponCard>();
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
        RandomGenCard();
        //EnemyTurn();
    }

    private void EnemyTurn()
    {
        for (int i = 0; i< _curEnemyList.Count; i++)
        {
            SkelAttack();
            HpBar();
            Thread.Sleep(100);
        }
        PlayerTurn();
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
