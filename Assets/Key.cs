using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject door;
    public GameObject floor;
    public GameObject floor2;

    private void OnTriggerEnter(Collider other)
    {
        Destroy(door);
        Destroy(gameObject);
        Destroy(floor);
        Destroy(floor2);
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
