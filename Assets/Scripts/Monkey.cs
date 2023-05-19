using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monkey : Animals
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
}
