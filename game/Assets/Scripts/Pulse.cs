using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulse : MonoBehaviour
{
    [SerializeField]
    private float expansionRate;
    private SpriteRenderer renderer; 

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate() {
        this.transform.localScale += new Vector3(expansionRate, expansionRate, 0);
        Color tmp = renderer.color;
        tmp.a -= .01f;
        renderer.color = tmp;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "asteroid") {
            Debug.Log("Found Asteroid");
        }
    }
}
