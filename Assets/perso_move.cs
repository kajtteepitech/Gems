using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class perso_move : MonoBehaviour
{
    public float speed = 0.0005f;
    public float rotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (transform.position.y < -4f)
            {
                speed = 0f;
                transform.position = new Vector3(transform.position.x, -4f, transform.position.z);
            }
            else if (transform.position.y < 4f) {
                speed += 0.005f;
                transform.position = new Vector3(transform.position.x, transform.position.y + speed, transform.position.z);
            }
            else {
                speed = 0f;
                transform.position = new Vector3(transform.position.x, 4f, transform.position.z);
            }
        }
        else
        {
            if (transform.position.y > 4f)
            {
                speed = 0f;
                transform.position = new Vector3(transform.position.x, 4f, transform.position.z);
            }
            else if (transform.position.y > -4f) {
                speed -= 0.005f;
                transform.position = new Vector3(transform.position.x, transform.position.y + speed, transform.position.z);
            }
            else
            {
                speed = 0f;
                transform.position = new Vector3(transform.position.x, -4f, transform.position.z);
            }
        }
    }
}
