using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : Animals
{
    // Start is called before the first frame update
    void Start()
    {
        playerAnimator = GetComponent<Animator>();
    }

    private void Update()
    {
        StandardAnimation();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Rotation();
    }

    protected override void StandardAnimation()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            playerAnimator.SetBool("Idle_c_bool", true);
        }

        else if (Input.GetKeyDown(KeyCode.X))
        {
            playerAnimator.SetBool("Idle_c_bool", false);
        }
    }
}
