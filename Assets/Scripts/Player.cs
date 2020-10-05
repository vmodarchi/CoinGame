using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    
    [SerializeField]
    private float _speed = 10f;

    public float horizontalInput;
    
    

    public List<GameObject> snakeTail = new List<GameObject>();
    

    void Start()
    {
        //Move player to starting point
        transform.position = new Vector3(0, -0.5f, 0);
       
    }

    // Update is called once per frame
    void Update()
    {
        //Player Movement
        float horizontalInput = Input.GetAxis("Horizontal");

        //Move player in real time 10m/s
        transform.Translate(Vector3.right * horizontalInput * _speed * Time.deltaTime);

        //Restrain player from moving out of bounds
        if(transform.position.x > 6.6f)
        {
            transform.position = new Vector3(6.6f , -0.5f,transform.position.z);
        }
        else if (transform.position.x < -6.6f)
        {
            transform.position = new Vector3(-6.6f, -0.5f, transform.position.z);
        }
        

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(this.gameObject);
            Time.timeScale = 0;
            Application.Quit();
        }
        if(other.tag == "Coin_EntityTag")
        {
            
            
            
        }
    }

}
