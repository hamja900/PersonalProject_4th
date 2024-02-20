using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommonEnemyTopDowncontroller : EnemyTopDownController
{
    [SerializeField] GameObject combatPopup;
    [SerializeField] Transform UI;
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
        if (DistanceToTarget() < followRange)
        {
            dir = DirectionToTarget();
        }
        else if (DistanceToTarget() > followRange)
        {
            dir = DirectionToFirstPlace();
        }
        CallMoveEvent(dir);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Instantiate(combatPopup, UI);
            

        }
    }



}
