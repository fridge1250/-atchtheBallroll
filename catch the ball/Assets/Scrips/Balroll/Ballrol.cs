using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]

public class BallrolMove : MonoBehaviour
{
    private Rigidbody _rigidbody;
    [SerializeField] private float _moveSpeed = 10f;
    [SerializeField] private float _timer = 0f;
    [SerializeField] private float _changeDirectionTime = 2f;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.constraints = RigidbodyConstraints.FreezePositionX;
    }
    private void Update()
    {
        _timer += Time.deltaTime;

        if (_timer >= _changeDirectionTime)
        {
            ChangeDirection();
            _timer = 0f;
        }

        MoveBallrol();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("wall"))
        {          
            Vector3 normal = collision.contacts[0].normal;
            Vector3 reflectedDirection = Vector3.Reflect(_rigidbody.velocity.normalized, normal);
            _rigidbody.velocity = reflectedDirection * _rigidbody.velocity.magnitude;
        }
    }
    private void MoveBallrol()
    {
        Vector3 movement = new Vector2(_rigidbody.velocity.x, _rigidbody.velocity.y).normalized * _moveSpeed;
        _rigidbody.velocity = movement;
    }

    private void ChangeDirection()
    {
        float randomX = Random.Range(-1f, 1f);
        float randomY = Random.Range(-1f, 1f);
        

        Vector3 newDirection = new Vector2(randomX, randomY).normalized;
        _rigidbody.velocity = newDirection * _moveSpeed;
    }
}
