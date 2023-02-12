using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musk : MonoBehaviour
{
    public float speed = 0.08f;
    public float total = 0;
    public bool isMax = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        speed += 0.00004f;
        total += speed;
        if (total > 400f) {
            if (transform.position.y < 0f && isMax == false)
                transform.position = new Vector3(transform.position.x, transform.position.y + 0.05f, transform.position.z);
            else if (transform.position.y > -10f) {
                isMax = true;
                transform.position = new Vector3(transform.position.x, transform.position.y - 0.05f, transform.position.z);
            }
        }
    }
}
