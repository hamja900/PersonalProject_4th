using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class WeaponCard : MonoBehaviour
{
    public GameObject card;
    public GameObject cover;
    public AttackSO[] attackSO;
    private Collider2D _collider;

    private bool selectMode;
    private void Awake()
    {
        selectMode = GameManager.Instance.isEnemySelectMode = false;
        _collider = GetComponent<Collider2D>();
    }

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

    private void OnMouseDown()
    {
       
        selectMode = true;
        _collider.enabled = false;
        if (selectMode == true)
        {
            if (GameObject.Find("Cover") == null)
            {
                Instantiate(cover, GameObject.Find("CardBox").transform);
            }
            else
            {
                GameObject.Find("Cover").SetActive(true);
            }
        }
        else
        {
            GameObject.Find("Cover").SetActive(false);
        }

       
    }

   

}
