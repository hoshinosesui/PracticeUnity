using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContoroller2 : MonoBehaviour
{
    private float speed = 20;
    private float horizontalInput;
    private float xRange = 13;

    public GameObject generatePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(generatePrefab, transform.position, generatePrefab.transform.rotation);
        }
    }
}
