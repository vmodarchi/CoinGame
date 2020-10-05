using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Entity : MonoBehaviour
{
    private float _speed = 20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back *_speed * Time.deltaTime);
    }
}
