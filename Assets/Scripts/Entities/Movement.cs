using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private CharacterTopDownController _controller;

    private Vector2 _movementDirection = Vector2.zero;
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _controller = GetComponent<CharacterTopDownController>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        _controller.OnMoveEvent += Move;
    }
    private void FixedUpdate()
    {
        ApplyMovement(_movementDirection);
    }
    private void Move(Vector2 dir)
    {
        _movementDirection = dir;
    }

    private void ApplyMovement(Vector2 dir)
    {
        dir = dir * 5;
        _rigidbody.velocity = dir;

    }
}
