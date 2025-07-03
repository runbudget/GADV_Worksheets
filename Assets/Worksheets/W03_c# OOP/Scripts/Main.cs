using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

// to test the script on the object

public class ProjectileTester : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        Projectile p1 = new Projectile(0f);
        p1.Fire();

        Projectile p2 = new Projectile(100f);
        p2.Fire();
    }

    // Update is called once per frame
    void Update()
    {

    }
}

