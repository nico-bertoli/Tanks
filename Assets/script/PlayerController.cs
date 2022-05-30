using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    bool beginningBarrelPivot = true;
    bool beginningFire = true;
    [SerializeField] BarrelPivot barrelPivot;
    [SerializeField] Barrel barrel;

    public void OnMove(InputValue value)
    {
        if (beginningBarrelPivot) {
            beginningBarrelPivot = false;
            return;
        }
        else
            barrelPivot.moveInput = value.Get<Vector2>();
    }

    public void OnFire(InputValue value) {
        if (beginningFire) {
            beginningFire=false;
            return;
        }
        else
            barrel.shot();
    }
    public void OnIncreaseBulletSpeed(InputValue value) {
        barrel.IncreaseBulletSpeed();
    }
    public void OnDecreaseBulletSpeed(InputValue value) {
        barrel.DecreaseBulletSpeed();
    }
}
