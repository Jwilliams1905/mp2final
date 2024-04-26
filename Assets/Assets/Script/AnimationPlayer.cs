using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPlayer : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.B)){
        animator.SetTrigger("Bow");
        Debug.Log("You pressed the 'b' key!");
        }
       if(Input.GetKeyDown(KeyCode.T)){
       animator.SetTrigger("Talk");
       }
    }
}
