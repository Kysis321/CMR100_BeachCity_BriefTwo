﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemSpin : MonoBehaviour
{
    private GameObject go;
    public GameObject gem;
    private Vector3 currentRotation;
    public float ySpinSpeed = 2;
    
     


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, ySpinSpeed, 0);
        ySpinSpeed = ySpinSpeed + 1F;
        
    }






}
