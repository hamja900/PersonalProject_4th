using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTopDownController : CharacterTopDownController
{
    GameManager gameManager;
    protected Transform ClosestTarget { get; private set; }
    [SerializeField] Transform spawnPoint;

    protected override void Awake()
    {
        base.Awake();
    }
    protected virtual void Start()
    {
        gameManager = GameManager.Instance;
        ClosestTarget = gameManager.Player;
    }
    
    protected virtual void FixedUpdate()
    {

    }

    protected float DistanceToTarget()
    {
        return Vector3.Distance(transform.position,ClosestTarget.position);
    }
    protected Vector2 DirectionToTarget()
    {
        return (ClosestTarget.position - transform.position).normalized;
    }
    protected Vector2 DirectionToFirstPlace()
    {
        return (spawnPoint.position - transform.position).normalized;
    }
}
