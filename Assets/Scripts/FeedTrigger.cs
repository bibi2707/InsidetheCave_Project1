using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedTrigger : MonoBehaviour
{
    public Animator myAnimator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("e"))
        {
            myAnimator.SetTrigger("FeedTrigger");
        }
    }
}
