using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public GameObject actor;

    private Animator anim;

    private Command keyQ, keyW, keyE, keySpace, keyP, keyK;
    // Start is called before the first frame update
    void Start()
    {
        keyQ = new PerformJump();
        keyW = new DoNothing();
        keyE = new PerformJump();
        keySpace = new PerformJump();
        keyP = new PerformPunch();
        keyK = new PerformKick();

        anim = actor.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            keyQ.Execute(anim);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            keyW.Execute(anim);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            keyE.Execute(anim);
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            keySpace.Execute(anim);
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            keyP.Execute(anim);
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            keyK.Execute(anim);
        }
    }
}
