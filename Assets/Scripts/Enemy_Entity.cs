﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Entity : MonoBehaviour
{
    [SerializeField]
    private float _speed = 30f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * _speed * Time.deltaTime);
        if (transform.position.z < -4.15f)
        {
            Destroy(this.gameObject);
            
        }
    }
}
