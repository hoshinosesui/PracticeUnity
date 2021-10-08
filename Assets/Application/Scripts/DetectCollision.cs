using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public GameObject effect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("ì|ÇµÇΩÇÊÅI");
        Instantiate(effect, other.transform.position, effect.transform.rotation);
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
