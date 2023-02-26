using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    Animator anim1;
 
    void Start()
    {
        anim1 = GetComponent<Animator>();
    }
 
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            anim1.SetTrigger("MouseClick");
        }
        
    }
}
