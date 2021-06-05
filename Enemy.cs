using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float _speed = 4.0f; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //move down at 4mps-1
        transform.Translate(Vector3.down * _speed*Time.deltaTime);
        //if it goes bottom of screen
        if(transform.position.y < -5f)
        {
            float randomX = Random.Range(-8f,8f);
            transform.position = new Vector3(randomX,7,0);
        }
        //respawn at top with a new random x position
    }
    private void OnTriggerEnter(Collider other)
    {
        //if other is player
        if(other.tag == "Player")
        {
            Destroy(this.gameObject);
        }
        //damage or reduce lives of player
        //destory us

        //if other is laser
        if(other.tag == "Laser")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
        //laser
        //destroy us
    }
}
