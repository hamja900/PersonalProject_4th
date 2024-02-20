using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommonEnemyTopDowncontroller : EnemyTopDownController
{
    [SerializeField]
    [Range(0f, 10f)] private float followRange;
    [SerializeField] private string targetTag = "Player";
    private bool _isCollidingWithTarget;

   
    protected override void Start()
    {
        base.Start();
    }

    protected override void FixedUpdate()
    {
        base.FixedUpdate();
        Vector2 dir = Vector2.zero;
        if(DistanceToTarget() < followRange)
        {
            dir = DirectionToTarget();
        }
        else if( DistanceToTarget() > followRange)
        {
            dir = DirectionToFirstPlace();
        }
        CallMoveEvent(dir);

    }

}
