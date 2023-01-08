using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulse : MonoBehaviour
{
    [SerializeField]
    private float expansionRate;
    private SpriteRenderer rend; 
    private CircleCollider2D circleCollider;
    private Sprite lastSprite;

    private Color[] colors = { new Color(.48f, .21f, .01f, 1.0f), new Color(0.5f,0.5f,0.5f, 1.0f), 
    new Color(.3f, .25f, .12f, .8f)};
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        circleCollider = GetComponent<CircleCollider2D>();
        UpdateColliderSize();
        Destroy(this.gameObject, 2);
    }

    private void FixedUpdate() {
        this.transform.localScale += new Vector3(expansionRate, expansionRate, 0);
        if (rend.sprite != lastSprite) {
            UpdateColliderSize();
        }
        Color tmp = rend.color;
        tmp.a -= .01f;
        rend.color = tmp;
    }

    private void UpdateColliderSize() {
        Vector3 spriteHalfSize = rend.sprite.bounds.extents;
        circleCollider.radius = spriteHalfSize.x > spriteHalfSize.y ? spriteHalfSize.x : spriteHalfSize.y;
        lastSprite = rend.sprite;
    }


    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "asteroid") {
            // Debug.Log("Found Asteroid");
            int temp = Random.Range(0,3);
            other.GetComponent<SpriteRenderer>().color = colors[temp];

        }
    }
}
