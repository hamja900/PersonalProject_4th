using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputSystem : CharacterTopDownController
{
   private Camera _camera;

    private void Awake()
    {
        _camera = Camera.main;
    }

    public void OnMovement(InputValue value)
    {
        Debug.Log("OnMove"+value.ToString());
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }

    public void OnLook(InputValue value)
    {
        Debug.Log("OnLook" + value.ToString());
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldMousePos = _camera.ScreenToWorldPoint(newAim);
        newAim = (worldMousePos - (Vector2)transform.position).normalized;

        if(newAim.magnitude >= 0.9f)
        {
            CallLookEvent(newAim);
        }
    }
}
