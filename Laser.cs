﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    private float _speed = 8.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up*_speed*Time.deltaTime);
        //if laser pos is greater than 8 on y axis
        //destroy the object
        if(transform.position.y > 8)
        {
            Destroy(this.gameObject);
        }
    }
}
