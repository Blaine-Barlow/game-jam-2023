using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid2 : MonoBehaviour
{
    // public Sprite[] sprites;

    public float size = 1.0f;

    public float minSize = 0.5f;

    public float maxSize = 1.5f;

    public float speed = 50.0f;

    public float maxLifetime = 30.0f;

    private SpriteRenderer _spriteRenderer;

    private Rigidbody2D _rigidbody;

    public float xAngle, yAngle;
    private int life;
    public GameObject drop;
    public GameObject explosion;
    private CircleCollider2D circleCollider;
    // private Sprite lastSprite;

    private void Awake() {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _rigidbody = GetComponent<Rigidbody2D>();
        circleCollider = GetComponent<CircleCollider2D>();
    }

    // Start is called before the first frame update
    private void Start() {
        // _spriteRenderer.sprite = sprites[Random.Range(0, sprites.Length)];

        this.transform.eulerAngles = new Vector3(0.0f, 0.0f, Random.value * 360.0f);
        this.transform.localScale = Vector3.one * this.size;

        _rigidbody.mass = this.size * 3f;
        
    }

    public void SetTrajectory(Vector2 direction) {
        _rigidbody.AddForce(direction * this.speed);
        // UpdateColliderSize();
        Destroy(this.gameObject, this.maxLifetime);
    }

    public void setLife(int newlife) {
        life = newlife;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.Rotate(0, 0, xAngle, Space.Self);
    }

    public void hit() {
        life -= 1;
        if (life == 0) {
            destroyMe();
        }
    }

    private void destroyMe() {
        GetComponent<AudioSource>().Play();
        int howManyDrops = Random.Range(1, 4);
        for (int i = 0; i < howManyDrops; i++) {
            GameObject myDrop = Instantiate(drop, this.transform.position, this.transform.rotation);
            int x = Random.Range(0,100);
            int y = Random.Range(0, 100);
            Vector2 v2 = new Vector2(x,y);
            myDrop.GetComponent<PowerUp>().SetTrajectory(v2.normalized);
        }
        var temp = Instantiate(explosion, this.transform.position, this.transform.rotation);
        _spriteRenderer.enabled = false;
        Destroy(temp, 3);
        Destroy(this.gameObject,1);
    }

    // private void UpdateColliderSize() {
    //     Vector3 spriteHalfSize = _spriteRenderer.sprite.bounds.extents;
    //     // circleCollider.radius = spriteHalfSize.x > spriteHalfSize.y ? spriteHalfSize.x : spriteHalfSize.y;
    //     // lastSprite = _spriteRenderer.sprite;
    //     circleCollider.radius = spriteHalfSize.x;
    // }

}
