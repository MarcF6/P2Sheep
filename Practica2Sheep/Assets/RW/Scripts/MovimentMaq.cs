using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentMaq : MonoBehaviour
{
    // Start is called before the first frame update
    public float movementSpeed;
    public float horizontalBoundary = 22;
    public GameObject hayBalePrefab;
    public Transform haySpawnpoint;
    public float shootInterval;
    private float shootTimer;




    private void UpdateShooting()
    {
        shootTimer -= Time.deltaTime;
        if (shootTimer <= 0 && Input.GetKey(KeyCode.Space))
        {
            shootTimer = shootInterval;
            ShootHay();
        }
    }
    private void ShootHay()
    {
        Instantiate(hayBalePrefab, haySpawnpoint.position, Quaternion.identity);
        SoundManager.Instance.PlayShootClip();
    }





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
        UpdateShooting();
    }
}
  