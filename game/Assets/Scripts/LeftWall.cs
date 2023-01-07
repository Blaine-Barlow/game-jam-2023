using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftWall : MonoBehaviour
{
    [SerializeField]
    private float moveLocation;
    
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player") {
            // Debug.Log("Hit left Wall");
            other.gameObject.transform.position = new Vector3(moveLocation, other.gameObject.transform.position.y, other.gameObject.transform.position.z);
        }
    }
}
