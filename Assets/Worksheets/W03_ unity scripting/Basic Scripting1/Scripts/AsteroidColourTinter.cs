using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidColourTinter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // access the spriterenderer component
            SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();

            // change color to blue
            spriteRenderer.color = Color.blue;
        }
    }
}
