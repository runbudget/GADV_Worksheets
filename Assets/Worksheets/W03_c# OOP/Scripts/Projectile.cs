using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile
{

    private float speed;

    public Projectile(float initialSpeed)
    {
        speed = initialSpeed;
    }

    public void Fire()
    {
        if (speed > 0)
        {
            Debug.Log("Projectile firing at" + speed);

        }
        else
        {
            Debug.Log("Cannot fire: speed too low");
            AutoFire();
        }
    }

    private void AutoFire()
    {
        speed = 100f;
        Debug.Log("speed was zero. autofire set speed to 100 to launch");
    }
    
}
