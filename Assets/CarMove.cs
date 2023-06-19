using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CarMove : MonoBehaviour
{
    public GameOverScreen GameOverScreen;
    bool isGameOver = false;
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(!isGameOver)
        {
           GetComponent<Rigidbody>().velocity = Vector3.left * 20;
            if(Input.GetKey("d"))
            {
                GetComponent<Rigidbody>().AddForce(0,0,4000,ForceMode.Force);
            }

            if(Input.GetKey("a"))
            {
                GetComponent<Rigidbody>().AddForce(0,0,-4000,ForceMode.Force);
            }
        }
        else{   
            GetComponent<Rigidbody>().velocity = Vector3.zero;
        }

            
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Block")
        {
            isGameOver = true;
            GameOverScreen.Setup();

            
        }

        if(collision.collider.tag == "Coin")
        {
            Debug.Log("Coin");
            score++;
            Destroy(collision.gameObject);

        }
      
    }

    
}
