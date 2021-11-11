using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
 {
     public float speed = 1.0f;
     public int score = 0 ;
     
      Rigidbody2D rigidbody;
       
       public void AddScore()
       {
           score = score + 1;
       }
       public int GetScore()
       {
           return score;
       }

        private void Start()
     {
          rigidbody = GetComponent<Rigidbody2D>();
     }
     private void Update()
     {
        
         Vector2 f = new Vector2(0, 0);
         
         if (Input.GetKey(KeyCode.D))
         {
             f = new Vector2(speed, 0);
         }
         else if (Input.GetKey(KeyCode.A))
         {
              f = new Vector2(-speed, 0);
         }
         
         rigidbody.AddForce(f);
     }
    
    
 }
