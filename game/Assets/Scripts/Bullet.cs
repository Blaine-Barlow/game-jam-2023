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

    // private void Start() {
    //     rb.velocity = direction * speed;
    // }
    public void PassInfo(Vector3 direction){
        // Debug.Log(direction);
        rb.velocity = direction * speed;
        Destroy(this.gameObject, lifetime);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "asteroid") {
            other.GetComponent<Asteroid>().hit();
            Destroy(this.gameObject);
        }
    }

}
