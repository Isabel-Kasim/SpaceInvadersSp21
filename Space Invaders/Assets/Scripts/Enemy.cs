using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Enemy : MonoBehaviour
{

    public Transform enemyTransform;
    public float speed;
    public TextMeshProUGUI score;
    public TextMeshProUGUI hiscore;
    private int scorenum = 0;
    private int hiscorenum = 0;
    public Rigidbody2D rb;

    void Start()
    {
        enemyTransform = GetComponent<Transform>();
        InvokeRepeating("Enemymovement", 0.1f, 0.3f);
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject);
        scorenum++;
        //score.text = scorenum.ToString();
        
    }

    void Enemymovement()
    {
        enemyTransform.position += Vector3.right * speed;
        foreach (Transform enemy in enemyTransform)
        {
            if (enemy.position.x < -10.5 || enemy.position.x > 10.5)
            {
                speed = -speed;
                enemyTransform.position += Vector3.down * 0.5f;
                return;
            }
            if (enemy.position.y <= -5)
            {
                Time.timeScale = 0;
            }
        }
    }
}
