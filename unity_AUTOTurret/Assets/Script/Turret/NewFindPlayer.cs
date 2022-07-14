using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewFindPlayer : MonoBehaviour
{

    public Transform Player;
    public Transform Turret;

    void Update()
    {
        
    }

    public float FindPlayerDot()
    {
        Vector3 distanceVector = Player.position - Turret.position;
        return Vector3.Dot(transform.forward, distanceVector.normalized);
    }

    public float FindPlayerCross()
    {
        Vector3 distanceVector = Player.position - Turret.position;
        //Debug.Log(Vector3.Cross(transform.forward, distanceVector.normalized).y);
        return Vector3.Cross(transform.forward, distanceVector.normalized).y;
    }
}
