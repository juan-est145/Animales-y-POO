using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animals : MonoBehaviour
{
    private float horizontalInput;
    private float turnSpeed = 120.0f;
    private Vector3 angleRotation = new Vector3(0, 5, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected virtual void Rotation()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(angleRotation, Time.deltaTime * turnSpeed * - horizontalInput);
    }
}
