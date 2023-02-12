using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    // Start is called before the first frame update
    float init_pos;
    void Start()
    {
        init_pos = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x - 0.08f, transform.position.y, transform.position.z);
        if (transform.position.x < init_pos - 20.66)
        {
            transform.position = new Vector3(init_pos, transform.position.y, transform.position.z);
        }
    }
}
