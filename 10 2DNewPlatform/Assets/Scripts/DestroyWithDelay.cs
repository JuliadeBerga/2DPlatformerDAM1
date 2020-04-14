using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWithDelay : MonoBehaviour
{
    public float delay;

    // Start is called before the first frame update
    void Start()
    {        
        Destroy(gameObject, delay);
        Debug.Log("Enric");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
