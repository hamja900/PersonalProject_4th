using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterTopDownController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;
    protected StatsHandler statsHandler { get; private set; }
    protected virtual void Awake()
    {
        statsHandler = GetComponent<StatsHandler>();
    }
    public void CallMoveEvent(Vector2 dir)
    {
        OnMoveEvent?.Invoke(dir);
    }
    public void CallLookEvent(Vector2 dir)
    {
        OnLookEvent?.Invoke(dir);
    }
}
