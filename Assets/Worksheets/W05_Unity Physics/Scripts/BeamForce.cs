using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamForce : MonoBehaviour
{
    public float torqueForce = 50f;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            rb.AddTorque(Vector3.forward * -torqueForce, ForceMode.Impulse); // Clockwise
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            rb.AddTorque(Vector3.forward * torqueForce, ForceMode.Impulse); // Anticlockwise
        }
    }
}
