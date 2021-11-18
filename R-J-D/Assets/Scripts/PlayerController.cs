using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public bool canJump;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        canJump = true;
    }

    // Update is called once per frame
    void Update()
    {
        //Left
        if (canJump && Input.GetKeyDown(KeyCode.LeftArrow))
        {
            playerRb.AddForce(Vector3.left * 7, ForceMode.Impulse);
        }

        if(transform.position.x < -3)
        {
            transform.position = new Vector3(-3, transform.position.y, transform.position.z);
        }

        //Right
        if (canJump && Input.GetKeyDown(KeyCode.RightArrow))
        {
            playerRb.AddForce(Vector3.right * 7, ForceMode.Impulse);

        }

        if (transform.position.x > 3)
        {
            transform.position = new Vector3(3 , transform.position.y, transform.position.z);
        }

        //Z
        if (transform.position.z != -7)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -7);
        }

        //Jump
        if (canJump == true && Input.GetKeyDown(KeyCode.UpArrow)) 
        {
            playerRb.AddForce(Vector3.up * 6, ForceMode.Impulse);
        }
    }

    void OnCollisionEnter(Collision collison) 
    {
        if (collison.gameObject.name == "Road")
        {
            canJump = true;
        }
    }

    void OnCollisionExit(Collision collison)
    {
        if (collison.gameObject.name == "Road")
        {
            canJump = false;
        }
    }
}
