using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moveEnemy : MonoBehaviour
{
    [SerializeField] private GameObject perso;
    public float speed = 0.08f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x - speed, transform.position.y, transform.position.z);
        collide();
        speed += 0.00004f;
    }

    void collide() {
        if (transform.position.x < perso.transform.position.x + 1.4f && transform.position.x > perso.transform.position.x - 1.4f && transform.position.y < perso.transform.position.y + 0.3f && transform.position.y > perso.transform.position.y - 1f) {
            SceneManager.LoadScene("GameOver");
        }
    }
}
