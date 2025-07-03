using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private float speed;


    //constructor to st the speed
    public Projectile(float initialSpeed)
    {
        speed = initialSpeed;
    }

    //modifyfire
    public void Fire()
    {
        if (speed > 0)
        {
            Debug.Log("Projectile firing at speed:" + speed);
        }
        else
        {
            Debug.Log("Cannot fire: spped too low.");
            AutoFire();
        }
    }

    private void AutoFire()
    {
        speed = 100f;
        Debug.Log("Speed was zero.autofire set to 100 and launched");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
