using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody2D rb;
    public float lifetime = 10.0f;

    private void Awake(){
        rb = GetComponent<Rigidbody2D>();
    }

    public void PassInfo(Vector2 direction){
        rb.velocity = direction * speed;
        Destroy(this.gameObject, lifetime);
    }

}
