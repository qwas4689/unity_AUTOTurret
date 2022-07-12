using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookingAtPlayer : MonoBehaviour
{
    public Transform Player;
    public GameObject BulletPrefab;

    private float RotateSpeed = 1.5f;
    private bool LookingForPlayer = false;
    private float ShootingTime = 0.0f;
    private float ShootingTimeMin = 0.5f;
    private float ShootingTimeMax = 3.0f;
    private float ShootFire;

    void Update()
    {
        if (LookingForPlayer)
        {
            transform.LookAt(Player);
            Shooting();
        }
        else
        {
            transform.Rotate(0, RotateSpeed, 0);
        }
    }

    private void OnTriggerEnter(Collider other) => LookingForPlayer = true;

    private void OnTriggerExit(Collider other) => LookingForPlayer = false;

    void Shooting()
    {
        ShootingTime += Time.deltaTime;
        ShootFire = Random.Range(ShootingTimeMin, ShootingTimeMax);

        if (ShootingTime >= ShootFire)
        {
            Instantiate(BulletPrefab, transform.position, transform.rotation);

            ShootingTime = 0f;
        }
    }

}