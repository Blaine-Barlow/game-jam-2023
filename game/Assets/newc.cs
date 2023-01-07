using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newc : MonoBehaviour
{
    public Bullet b;

    float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 5000) {
            Shoot();
            timer = 0;
        }
        timer += 1;
        
    }

    public void Shoot(){
        Bullet bullet = Instantiate(this.b, this.transform.position, this.transform.rotation);
        bullet.PassInfo(this.transform.up);
    }
}
