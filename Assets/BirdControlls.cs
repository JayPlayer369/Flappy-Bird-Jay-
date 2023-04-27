using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BirdControlls : MonoBehaviour
{
    public Rigidbody2D rb;

    public int score = 0;
    // true or false value that depends on the bird being alive or not
    public bool isAlive;

    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isAlive = true;
    }
    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Space))
        rb.AddForce (new Vector2(0,1 * 200));
            
    }
    

     // Once you activate a trigger, on trigger enter will come in
     public void OnTriggerEnter2D(Collider2D other)
    {
        score++;

        scoreText.text = "score" + score;
        Debug.Log(score);
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        // 
        isAlive = false;
    }
}
