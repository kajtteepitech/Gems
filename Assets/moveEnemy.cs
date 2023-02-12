using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moveEnemy : MonoBehaviour
{
    [SerializeField] private GameObject perso;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x - 0.08f, transform.position.y, transform.position.z);
        collide();
    }

    void collide() {
        if (transform.position.x < perso.transform.position.x + 0.5f && transform.position.x > perso.transform.position.x - 0.5f && transform.position.y < perso.transform.position.y + 0.5f && transform.position.y > perso.transform.position.y - 0.5f) {
            SceneManager.LoadScene("GameOver");
        }
    }
}
