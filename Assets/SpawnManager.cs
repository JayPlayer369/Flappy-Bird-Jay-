using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SpawnManager : MonoBehaviour
{
    public GameObject pipes;
    BirdControlls playerScript;
    // Start is called before the first frame update
    void Start()
    {
        // Repeats the spawning of the pipes
        InvokeRepeating("SpawnPipes" , .5f, 2);
        playerScript = GameObject.Find("Flappy Bird").GetComponent<BirdControlls>();
    }

    void SpawnPipes()
    {
        // Spawns the pipes
        Instantiate(pipes, new Vector2(7, Random.Range(3.26f, 8.79f)), Quaternion.identity);
    }


    // Update is called once per frame
    void Update()
    {
        // int lives = 1 is an assignment value or == is Comparing Values
        if(playerScript.isAlive == false)
        {
            CancelInvoke();
        }
    }
}

    
