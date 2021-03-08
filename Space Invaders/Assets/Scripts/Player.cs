using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  public GameObject bullet;
    public Transform player;
  public Transform shottingOffset;
    public Rigidbody2D rb;

    void Start()
    {
        player = GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space))
      {
        GameObject shot = Instantiate(bullet, shottingOffset.position, Quaternion.identity);
        Debug.Log("Bang!");

        Destroy(shot, 3f);

      }
    }

    void playermovement()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.AddForce(Vector2.left);
        }
    }
}
