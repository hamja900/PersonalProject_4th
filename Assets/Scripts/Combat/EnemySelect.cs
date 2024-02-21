using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySelect : MonoBehaviour
{
    public GameObject Arrow;
    private void OnMouseEnter()
    {
        Arrow.SetActive(true);
    }
    private void OnMouseExit()
    {
        Arrow.SetActive(false);
    }
}
