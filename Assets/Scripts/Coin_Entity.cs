using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin_Entity_Behaviour : MonoBehaviour
{
    [SerializeField]
    private float _speed = 20f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move the Entity to the player
        transform.Translate(Vector3.back *_speed * Time.deltaTime);
        if (transform.position.z < -4.15f)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
