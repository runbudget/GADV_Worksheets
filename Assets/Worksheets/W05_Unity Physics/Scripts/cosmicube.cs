using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cosmicube : MonoBehaviour
{
    private Renderer rend;
    private Color originalColor;
    public Color hitColor = Color.green;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        originalColor = rend.material.color;
    }


    // Update is called once per frame
    void Update()
    {
    transform.Rotate(60 * Time.deltaTime, 60 * Time.deltaTime, 60 * Time.deltaTime);
    }
    void OnCollisionEnter(Collision collision)
    {
        rend.material.color = hitColor;
    }

    void OnCollisionExit(Collision collision)
    {
        rend.material.color = originalColor;
    }

}
