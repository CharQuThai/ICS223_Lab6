using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyPrefab;
    private GameObject[] enemies;
    private Vector3 spawnPoint = new Vector3(0, 0, 5);

    private int spawnCount = 3;

    private void Start()
    {
        enemies = new GameObject[spawnCount];
    }

    // Update is called once per frame
    void Update()
    {
        //if (System.Array.Exists(enemies, enemy => enemy == null))

       // {
            for (int i = 0; i < spawnCount; i++) {
                if (enemies[i] == null)
                {
                    enemies[i] = Instantiate(enemyPrefab) as GameObject;
                    enemies[i].transform.position = spawnPoint;
                    float angle = Random.Range(0, 360);
                    enemies[i].transform.Rotate(0, angle, 0);
                }
            }
            //Ask Chris why the enemies keep spawning so much
       // }
    }
}
