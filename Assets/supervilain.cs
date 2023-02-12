using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class supervilain : MonoBehaviour
{
    [SerializeField] private GameObject perso;
    public float speed = 0.08f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(1010, -4, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x - speed, transform.position.y, transform.position.z);
        collide();
        speed += 0.00004f;
    }
    void collide() {
        if (transform.position.x < perso.transform.position.x + 5f && transform.position.x > perso.transform.position.x - 5f && transform.position.y < perso.transform.position.y + 5f && transform.position.y > perso.transform.position.y - 5f) {
            SceneManager.LoadScene("GameOver");
        }
    }
}
