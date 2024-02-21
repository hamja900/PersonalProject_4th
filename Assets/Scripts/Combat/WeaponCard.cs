using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class WeaponCard : MonoBehaviour
{
    public GameObject card;
    private void OnMouseOver()
    {
        float cardpos = card.transform.position.y;
        cardpos += 400f;
    }



}
