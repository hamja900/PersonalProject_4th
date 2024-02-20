using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CombatPopupSetting : MonoBehaviour
{
    public GameObject[] enemySlots;
    public GameObject[] CardSlots;
    public Slider hpBar;
    public Slider mpBar;
    private StatsHandler statsHandler;

    public List<GameObject> _enemyList = new List<GameObject>();
    public List<GameObject> _curEnemyList = new List<GameObject>();
    public List<GameObject> _CardList = new List<GameObject>();
    public List<GameObject> _handList = new List<GameObject>();

    private void Awake()
    {
        statsHandler = GetComponent<StatsHandler>();


    }
    // Start is called before the first frame update
    void Start()
    {
        ResetPopup();
        RandomGenEnemy();
        RandomGenCard();
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
            for(int i = 0; i< 3; i++)
            {
                    _handList[i]=_CardList[Random.Range(0,_CardList.Count-1)];
            }
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
