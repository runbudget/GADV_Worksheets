using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidRotator : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float rotationSpeed = 30f;
    // Update is called once per frame
    void Update()
    {
        // rotate the asteroid continuously
        transform.Rotate(0,0, rotationSpeed *  Time.deltaTime);
    }
}
