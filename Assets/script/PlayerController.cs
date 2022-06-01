using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] BarrelPivot barrelPivot;
    [SerializeField] Barrel barrel;

    public void OnMove(InputValue value)
    {
            barrelPivot.moveInput = value.Get<Vector2>();
    }

    public void OnFire(InputValue value) {
            barrel.shot();
    }
    public void OnIncreaseBulletSpeed(InputValue value) {
        barrel.IncreaseBulletSpeed();
    }
    public void OnDecreaseBulletSpeed(InputValue value) {
        barrel.DecreaseBulletSpeed();
    }
}
