using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animals : MonoBehaviour
{
    private float horizontalInput;
    private float turnSpeed = 120.0f;
    private Vector3 angleRotation = new Vector3(0, 5, 0);
    protected Animator playerAnimator;

    protected void Rotation()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(angleRotation, Time.deltaTime * turnSpeed * - horizontalInput);
    }

    protected virtual void StandardAnimation()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            playerAnimator.SetBool("Idle_a_bool", true);
        }

        else if (Input.GetKeyDown(KeyCode.X))
        {
            playerAnimator.SetBool("Idle_a_bool", false);
        }
    }
}
