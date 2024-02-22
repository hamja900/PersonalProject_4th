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
    public AttackSO attackSO;
    private Collider2D _collider;


    private void Awake()
    {
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
        CombatPopupSetting.Instance.enemyHS.ChangeHealth(attackSO.power);
        CombatPopupSetting.Instance.enemyHPBar.UpdateEnemyHP();

    }

    private void IntoSelectMode()
    {

        GameManager.Instance.isEnemySelectMode = true;
        _collider.enabled = false;
        if (GameManager.Instance.isEnemySelectMode == true)
        {
<<<<<<< Updated upstream
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
=======
            case 0:
                _enemyHealth0.ChangeHealth(-attackSO.power);
                break;
            case 1:
                _enemyHealth1.ChangeHealth(-attackSO.power);
                break; 
            case 2:
                _enemyHealth2.ChangeHealth(-attackSO.power);
                break;
>>>>>>> Stashed changes
        }

        CombatPopupSetting.Instance.enemyCombat.UpdateEnemyHP();
    }




}
