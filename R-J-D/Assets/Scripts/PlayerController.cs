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
