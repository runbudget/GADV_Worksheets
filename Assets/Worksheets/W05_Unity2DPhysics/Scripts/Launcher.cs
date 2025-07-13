using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject ProjectilePrefab;
    public Transform firePoint;
    public float force = 20f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject clone = Instantiate(
                  ProjectilePrefab,
                  firePoint.position,
                  Quaternion.identity);

            Rigidbody2D rb = clone.GetComponent<Rigidbody2D>();

            rb.AddForce(firePoint.right * force);
        }

    }
}
