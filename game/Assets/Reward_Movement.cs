using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reward_Movement : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    private Rigidbody2D _rewardbody;

    [SerializeField] private float _acceleration = 25;

    void Start()
    {
        _rewardbody = GetComponent<Rigidbody2D>();
        SetDirection(new Vector2(0,1));
    }

    // Update is called once per frame
    void SetDirection(Vector2 newDirection)
    {
        _rewardbody.velocity = newDirection * _acceleration;
    }
}
