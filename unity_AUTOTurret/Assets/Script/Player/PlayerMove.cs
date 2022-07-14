using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    PlayerInput _playerInput;
    Rigidbody _rigidbody;

    private float MoveSpeed = 6.0f;

    // Start is called before the first frame update
    void Start()
    {
        _playerInput = GetComponent<PlayerInput>();
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float XSpeed = _playerInput.X * MoveSpeed;
        float ZSpeed = _playerInput.Z * MoveSpeed;

        _rigidbody.velocity = new Vector3(XSpeed, 0, ZSpeed);
    }
}
