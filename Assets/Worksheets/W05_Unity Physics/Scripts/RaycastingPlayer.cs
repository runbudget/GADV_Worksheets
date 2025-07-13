using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastingPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CheckLineOfSight();
    }

    // Update is called once per frame
    void CheckLineOfSight()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        RaycastHit hit;

        foreach (GameObject enemy in enemies)
        {
            Vector3 direction = enemy.transform.position - transform.position;
            Debug.DrawRay(transform.position, direction, Color.red);

            if (Physics.Raycast(transform.position, direction, out hit, 30f))
            {
                if (hit.collider.CompareTag("Enemy"))
                {
                    enemy.GetComponent<Renderer>().material.color = Color.green;
                }
                else
                {
                    enemy.GetComponent<Renderer>().material.color = Color.red;
                }
            }
        }
    }
}
