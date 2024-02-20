using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "AttackData",menuName ="Attack/Default")]
public class AttackSO : ScriptableObject
{
    [Header("AttackInfo")]
    public float power;
    public float speed;
    public LayerMask target;

    
}
