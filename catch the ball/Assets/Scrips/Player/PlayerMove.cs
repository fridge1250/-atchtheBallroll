using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _speed = 30;
    void Update()
    {
        float MoveX = Input.GetAxis("Horizontal") * _speed * Time.deltaTime;
        float MoveY = Input.GetAxis("Vertical") * _speed * Time.deltaTime;

        transform.Translate(MoveX, MoveY, 0f);
        
    }
}
