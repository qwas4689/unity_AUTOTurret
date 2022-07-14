using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float BulletSpeed = 3.0f;
    private float DestroyBulletTime = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, DestroyBulletTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, BulletSpeed * Time.deltaTime);
    }
}
