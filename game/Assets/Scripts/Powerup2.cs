using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup2 : MonoBehaviour
{
    // public Sprite[] sprites;

    public float size = 1.0f;

    public float speed = 50.0f;

    public float maxLifetime = 30.0f;

    private SpriteRenderer _spriteRenderer;

    private Rigidbody2D _rigidbody;

    private void Awake() {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }


    // Start is called before the first frame update
    private void Start() {
        // _spriteRenderer.sprite = sprites[Random.Range(0, sprites.Length)];

        // this.transform.eulerAngles = new Vector3(0.0f, 0.0f, Random.value * 360.0f);
        // this.transform.localScale = Vector3.one * this.size;

        _rigidbody.mass = this.size;
    }

    public void SetTrajectory(Vector2 direction) {
        _rigidbody.AddForce(direction * this.speed);

        Destroy(this.gameObject, this.maxLifetime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player") {
            // Debug.Log("Hit Player");
            // Game Manager



            Destroy(this.gameObject);
        }
    }
}
