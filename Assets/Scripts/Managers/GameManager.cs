using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public HealthSystem healthSystem;
    public GameObject Player;
    public GameObject[] weaponCards;

    public bool isEnemySelectMode = false ;
    public bool isWandAttack=false ;

    private void Awake()
    {
        Instance = this;
        healthSystem = Player.GetComponent<HealthSystem>();
        
    }
    
    public float PlayerCurHp()
    {
        float playerCurHP = healthSystem.CurrentHealth;
        return playerCurHP;
    }
    public float PlayerCurMp()
    {
        float playerCurMP = healthSystem.CurrentMP;
        return playerCurMP;
    }
}
