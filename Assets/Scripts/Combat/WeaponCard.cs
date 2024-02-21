using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class WeaponCard : MonoBehaviour
{
    public GameObject card;
    private void OnMouseOver()
    {
       card.transform.position = new Vector3(0, card.transform.position.y+400, 0);
    }



}
