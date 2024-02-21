using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponCard : MonoBehaviour
{
    public GameObject card;
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

}
