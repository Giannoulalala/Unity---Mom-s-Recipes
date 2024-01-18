using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float rotationSpeed;
    public GameObject dust;
    
    
    

    private void FixedUpdate()
    {
        transform.Rotate(0, 0, rotationSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            
            GameManager.Instance.IncrementScore();
            
            
            Destroy(gameObject);

            
            //Destroy(collision.gameObject);
            
            
        }
        else if(collision.gameObject.tag == "Ground")
        {
            GameManager.Instance.IncrementOuch();
            //GameManager.Instance.Ouch();
            
            
            
            GameObject dustEffect = Instantiate(dust, transform.position, Quaternion.identity);
            Destroy(dustEffect, 1f);
            Destroy(gameObject, 1f);
        }
            
    }

   
}
