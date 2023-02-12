using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemies : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    public float speed = 0.08f;
    // Start is called before the first frame update
    void Start()
    {
        GenerateGrid();
    }

    // Update is called once per frame
    void GenerateGrid() {
        for (int x = 10; x < 1000; x += 10) {
            int i = Random.Range(0,5);
            int[] array = {-4, -2, 0, 2, 4};
            for (; i > 0; i--) {
                int y = array[Random.Range(0, array.Length)];
                var spawnedEnemy = Instantiate(enemy, new Vector3(x, y, 0), Quaternion.identity);
                int[] new_array;
                if (array.Length == 1) {
                    new_array = new int[0];
                } else {
                    new_array = new int[array.Length - 1];
                }
                int index = 0;
                for (int j = 0; j < array.Length; j++) {
                    if (array[j] != y) {
                        new_array[index] = array[j];
                        index++;
                    }
                }
                array = new_array;
                spawnedEnemy.name = $"Enemy {x}, {y}";

            } 
        }
    }
}
