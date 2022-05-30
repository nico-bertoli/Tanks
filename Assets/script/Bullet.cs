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
        myRigidbody.velocity = speed;
    }

    private void Update() {
        if (myRigidbody.velocity.x > 0)
            transform.up = myRigidbody.velocity;
    }

    private void OnCollisionEnter(Collision other) {
        Debug.Log("collision");
        if(other.gameObject.tag == "Enemy") {
            Destroy(other.gameObject);
            Debug.Log("enemy hit");
        }
           
        Destroy(this.gameObject);
    }

}
