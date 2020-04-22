using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float movementSpeed;
    public float horizontalBoundary = 22;

    private void UpdateMovement()
    {
        Debug.Log(transform.position.x);
        float horizontalInput = Input.GetAxisRaw("Horizontal"); // 1
        if (horizontalInput < 0 && transform.position.x > -horizontalBoundary) // 2
        {
            transform.Translate(transform.right * -movementSpeed * Time.deltaTime);
        }
        else if (horizontalInput > 0 && transform.position.x < horizontalBoundary) // 3
        {
            transform.Translate(transform.right * movementSpeed * Time.deltaTime);
        }
    }



    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        UpdateMovement();
    }
}
