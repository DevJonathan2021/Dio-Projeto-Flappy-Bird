using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    private Rigidbody thisRigidbody;
    void Start()
    {
        thisRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        bool jumpInput = Input.GetKey(KeyCode.Space);
        if(jumpInput){
            thisRigidbody.AddForce(new Vector3(0, 10, 0), ForceMode.Impulse);
        }
    }
}
