using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Btns : MonoBehaviour
{


    private void Awake()
    {
     
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
     
        gameObject.SetActive(false);
    }

    public void TargetSelect()
    {
        GameManager.Instance.isEnemySelectTurn = true;
    }
}
