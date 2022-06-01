using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BarrelPivot : MonoBehaviour
{
    [SerializeField] float rotationSpeed;
    [SerializeField] float minRotation;
    [SerializeField] float maxRotation;
    public Vector2 moveInput { get; set; }


    private void Start() {
        moveInput = new Vector2(0, 0);
    }

    private void Update() {
        Move();
    }

    private void Move() {
        if (moveInput == Vector2.right && transform.localRotation.eulerAngles.z > minRotation) {
            transform.Rotate(Vector3.back * Time.deltaTime * rotationSpeed);
        }
        else if (moveInput == Vector2.left && transform.localRotation.eulerAngles.z < maxRotation) {
            transform.Rotate(Vector3.forward * Time.deltaTime * rotationSpeed);
        }
    }

}
