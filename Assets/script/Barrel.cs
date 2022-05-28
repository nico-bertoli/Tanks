using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Barrel : MonoBehaviour
{
    [SerializeField] float rotationSpeed;
    [SerializeField] float minRotation;
    [SerializeField] float maxRotation;
    private bool beginning = true;
    private Vector2 moveInput;

    private void Update() {
        Move();
    }

    public void OnMove(InputValue value)   //chiamato automaticamente quando l'utente preme un pulsante di spostamento
    {
        if (beginning) {
            beginning = false;
            return;
        }
        else
            moveInput = value.Get<Vector2>();
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
