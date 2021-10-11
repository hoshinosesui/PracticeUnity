using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController4 : MonoBehaviour
{
    private Rigidbody playerRb;
    private float verticalInput;
    
    public GameObject focalPoint;
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");

        playerRb.AddForce(focalPoint.transform.forward * speed * verticalInput);
    }
}
