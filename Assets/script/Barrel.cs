using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Barrel : MonoBehaviour {
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] GameObject bulletInstantiationPosition;
    [SerializeField] float BulletSpeed;

    public void shot() {
        Bullet bullet = Instantiate(bulletPrefab, bulletInstantiationPosition.transform.position, Quaternion.identity).GetComponent<Bullet>();
        
        bullet.SetSpeed(BulletSpeed * transform.up);
    }




}
