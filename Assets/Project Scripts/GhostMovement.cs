using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostMovement : MonoBehaviour
{
    public float speed = 10.0f;
    public float turnSpeed;
    public float horizontalInput;
    public float forwardInput;
    public GameObject orbPrefab;
   

    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        Vector3 spawnPos = new Vector3(transform.position.x, transform.position.y, (transform.position.z + 1));
        //Move ghost forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        transform.Rotate(Vector3.up * turnSpeed * horizontalInput * Time.deltaTime);

        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(orbPrefab, spawnPos, orbPrefab.transform.rotation);
        }
        
    }
}
