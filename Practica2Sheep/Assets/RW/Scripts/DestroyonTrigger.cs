using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyonTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public string tagFilter;
   

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) // 1
    {
        if (other.CompareTag(tagFilter)) // 2
        {
            Destroy(gameObject); // 3
        }
       
    }
    
}
