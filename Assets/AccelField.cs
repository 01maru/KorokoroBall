using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelField : MonoBehaviour
{
    public float power = 3;
    private void OnTriggerStay(Collider other)
    {
        Rigidbody r = other.GetComponent<Rigidbody>();
        if (r != null)
        {
            r.AddForce(-transform.right * power);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
