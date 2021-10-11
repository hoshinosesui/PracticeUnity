using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController4 : MonoBehaviour
{
    public float rotationSpeed;

    private float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Rotate(Vector3.up, Time.deltaTime * rotationSpeed * horizontalInput);
    }
}
