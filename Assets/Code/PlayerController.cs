using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb2d;

    public Text countText;
    private int count;


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        count = 0;
        SetCountText();
    }

    void Update()
    {
        if (Input.GetKey("escape"))
        Application.Quit();
    }

    private void FixedUpdate()
    {
        Debug.Log(rb2d.velocity);
        float moveHorizontal = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(moveHorizontal, 0);

        rb2d.AddForce(movement);

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }

        if (other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.SetActive(false);
            Application.LoadLevel("GameOver");
        }

        if (other.gameObject.CompareTag("Finish"))
        {
            other.gameObject.SetActive(false);
            Application.LoadLevel("WinMenu");
        }

    }

    void SetCountText()
    {
        countText.text = ":" + count.ToString();
    }
}