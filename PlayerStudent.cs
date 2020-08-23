using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStudent : MonoBehaviour
{
    public bool playerIsAlive = true;
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerIsAlive == true && Input.GetKeyDown(KeyCode.W) && transform.position.y < gameManager.levelConstraintTop)
        {
            transform.position = transform.position + new Vector3(0, 1, 0);
        }
        else if (playerIsAlive == true && Input.GetKeyDown(KeyCode.S) && transform.position.y > gameManager.levelConstraintBottom)
        {
            transform.position = transform.position + new Vector3(0, -1, 0);
        }
        else if (playerIsAlive == true && Input.GetKeyDown(KeyCode.A) && transform.position.x > gameManager.levelConstraintLeft)
        {
            transform.position = transform.position + new Vector3(-1, 0, 0);
        }
        else if (playerIsAlive == true && Input.GetKeyDown(KeyCode.D) && transform.position.x < gameManager.levelConstraintRight)
        {
            transform.position = transform.position + new Vector3(1, 0, 0);
        }
    }

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.tag == "Vehicle")
        {
            print("hit");
            playerIsAlive = false;

        }
        else if(collision.transform.tag == "water")
        {
            print("drowned");
            playerIsAlive = false;
        }
        else if(collision.transform.tag == "Finish")
        {
            print("win");
        }
       // playerIsAlive = false;
    }
}


