using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Barrel : MonoBehaviour {
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] GameObject bulletInstantiationPosition;
    [SerializeField] float BulletSpeed;
    [SerializeField] float speedChangeAmmount;

    LineRenderer lineRenderer;
    [SerializeField] int bulletPathPointsNum;
    GameObject[] bulletPathPoints;
    [SerializeField] GameObject BulletPathPointPrefab;



    private void Start() {
        //GameObject emptyObj = new GameObject();
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = bulletPathPointsNum;
        bulletPathPoints = new GameObject[bulletPathPointsNum];

        for (int i = 0; i < bulletPathPointsNum; i++) {
            bulletPathPoints[i] = Instantiate(BulletPathPointPrefab, bulletInstantiationPosition.transform.position,Quaternion.identity);
            bulletPathPoints[i].SetActive(false);
        }
    }

    public void shot() {
        Bullet bullet = Instantiate(
            bulletPrefab,
            bulletInstantiationPosition.transform.position,
            Quaternion.identity).GetComponent<Bullet>();
        
        bullet.SetSpeed(BulletSpeed * transform.up);
    }

    public void IncreaseBulletSpeed() {
        BulletSpeed += speedChangeAmmount;
    }
    public void DecreaseBulletSpeed() {
        BulletSpeed -= speedChangeAmmount;
    }

    //https://www.youtube.com/watch?v=3DUmpVi82q8&ab_channel=TheGameGuy
    Vector3 PointPosition(float t) {
        Vector3 risPos = (Vector3) bulletInstantiationPosition.transform.position + (BulletSpeed * transform.up *t) + 0.5f * Physics.gravity * (t*t);
        return risPos;
    }

    private void Update() {
        for (int i = 0; i < bulletPathPoints.Length; i++) {
            bulletPathPoints[i].transform.position = PointPosition(i * 0.1f);
            lineRenderer.SetPosition(i, bulletPathPoints[i].transform.position);
        }
    }
}
