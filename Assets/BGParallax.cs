using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGParallax : MonoBehaviour
{
    float init_pos;
    // Start is called before the first frame update
    void Start()
    {
        init_pos = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x - 0.04f, transform.position.y, transform.position.z);
        if (transform.position.x < init_pos - 46.36f + 1.08f)
        {
            transform.position = new Vector3(init_pos, transform.position.y, transform.position.z);
        }
    }
}
