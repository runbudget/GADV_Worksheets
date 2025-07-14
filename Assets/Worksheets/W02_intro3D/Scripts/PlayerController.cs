using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator animator;
    bool isRunning;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    // animation event handler method
    public void HandleFall()
    {
        Debug.Log("OOf i didnt expect that!");
    }
    // Update is called once per frame
    private void Update()
    {
       // example 1: transition to running
       isRunning = true;
        animator.SetBool("Run", isRunning);

      // example 2: trigger jump animation
      if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Jump");
        }
      // example 3: trigger the fall animation
      if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Fall");
        }
    }
}
