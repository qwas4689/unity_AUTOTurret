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
    private float FindDot;
    private float FindCross;
    private float TargetAngle = 10f / 6f;

    void Update()
    {
        if (LookingForPlayer)
        {
            Shooting();
        }
        else
        {
            transform.Rotate(0, RotateSpeed, 0);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        FindDot = FindObjectOfType<NewFindPlayer>().FindPlayerDot();
        FindCross = FindObjectOfType<NewFindPlayer>().FindPlayerCross();

        if (FindDot >= 0.0f && FindDot <= TargetAngle && FindCross < 0.0f)
        {
            LookingForPlayer = true;
        }
        else
        {
            LookingForPlayer = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        LookingForPlayer = false;
    }

    void Shooting()
    {
        transform.LookAt(Player);
        ShootingTime += Time.deltaTime;
        ShootFire = Random.Range(ShootingTimeMin, ShootingTimeMax);

        if (ShootingTime >= ShootFire)
        {
            Instantiate(BulletPrefab, transform.position, transform.rotation);

            ShootingTime = 0f;
        }
    }


}