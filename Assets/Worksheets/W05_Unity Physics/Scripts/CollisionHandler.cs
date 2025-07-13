using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("CosmicCube has collided with: " + collision.gameObject.name);
    }

    void OnCollisionStay(Collision collision)
    {
        Debug.Log("CosmicCube is still touching: " + collision.gameObject.name);
    }

    void OnCollisionExit(Collision collision)
    {
        Debug.Log("CosmicCube stopped colliding with: " + collision.gameObject.name);
    }
}
