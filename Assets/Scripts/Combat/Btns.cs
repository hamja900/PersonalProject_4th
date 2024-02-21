using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Btns : MonoBehaviour
{
    public void OnRunBtn()
    {
        int dice = Random.Range(0, 10);
        //if (dice > 8)
        //{
        //    return;
        //}
        Destroy(gameObject);

    }
    

    public void KnifeCard()
    {

    }
    public void LongSword()
    {

    }
    public void Wand()
    {

    }
}
