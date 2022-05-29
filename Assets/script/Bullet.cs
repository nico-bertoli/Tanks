using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody myRigidbody;

    private void Awake() {
        myRigidbody = GetComponent<Rigidbody>();
    }

    public void SetSpeed(Vector3 speed) {
        Debug.Log("speed: " + speed);

        myRigidbody.velocity = speed;
    }

}
