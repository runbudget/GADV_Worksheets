using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        float x = Input.GetAxis("Mouse X") * 2;
        float y = -Input.GetAxis("Mouse Y");

        //VERticle tilting
        float yClamped = transform.eulerAngles.x + y;
        transform.rotation = Quaternion.Euler(
                                    yClamped,
                                    transform.eulerAngles.y,
                                    transform.eulerAngles.z);
        //horizontal orbitting
        transform.RotateAround(
            new Vector3(0, 3, 0),
            Vector3.up, x);
    }

    private void FixedUpdate()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject projectile = Instantiate(
                                          projectilePrefab,
                                          transform.position,
                                          transform.rotation);
            Rigidbody rb = projectile.GetComponent<Rigidbody>();
            rb.AddRelativeForce(new Vector3(0, 0, 2000));
        }
    }
}
