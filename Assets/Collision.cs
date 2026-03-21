using UnityEngine;

public class Collision : MonoBehaviour
{
   void OnCollisionEnter2D(Collision2D other)
    {
            Debug.Log("Ouch! That hurt!");
    }
    void OnTriggerEnter2D(Collider2D other)
    {
            Debug.Log("What the heck was that?!");
    }   
    
            
    
}
