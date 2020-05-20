﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float turnSpeed = 45.0f;
    [SerializeField] float speed = 10.0f;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
     
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
         
          transform.Translate(Vector3.forward*speed* Time.deltaTime*forwardInput);
          transform.Rotate(Vector3.up,turnSpeed* Time.deltaTime*horizontalInput);
		 
    }
}
