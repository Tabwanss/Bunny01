using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAble : MonoBehaviour
{
    [SerializeField] public float jump = 1.0f;
    
     public float xAngle, yAngle, zAngle; 
    
    private void OnTriggerStay2D(Collider2D collision)
    {
         if (collision.CompareTag("Platform"))
         {
           Debug.Log("OK");
           Rigidbody2D rigidbody2d = gameObject.GetComponentInParent<Rigidbody2D>();
            rigidbody2d.AddForce(new Vector2(0,jump),ForceMode2D.Impulse);   
        
         }
         else if (collision.CompareTag("Spikes"))
        {
            Debug.Log(" dead");
            Rigidbody2D rigidbody2d = gameObject.GetComponentInParent<Rigidbody2D>();
            rigidbody2d.transform.Rotate(90f,0.0f,0.0f, Space.Self);
        }

         
    
    }

    
}
