using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float flyPower;
    public float rotationSpeed;
    private GameObject obj;
    private Rigidbody2D rb;
    public AudioClip flyClip;
    public AudioClip gameOverClip;
    private AudioSource audioSource;


    GameObject gameController;
    // Start is called before the first frame update
    void Start()
    {
        obj = gameObject;
        flyPower = 5f;
        rotationSpeed = 5f;
        audioSource = obj.GetComponent<AudioSource>();
        audioSource.clip = flyClip;
        rb = obj.GetComponent<Rigidbody2D>();

        if (gameController == null )
        {
            // Gọi Object với tag GameController từ game
            gameController = GameObject.FindGameObjectWithTag("GameController");
            audioSource.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        // 0: chuột trái, 1: chuột phải
        if (Input.GetMouseButtonDown(0)) 
        {
            // Get component  mình muốn trong Unity
            rb.velocity = Vector2.up * flyPower;
            audioSource.Play();
        }
    }

    private void FixedUpdate()
    {
        obj.transform.rotation = Quaternion.Euler(0, 0, rotationSpeed * rb.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        EndGame();  
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameController.GetComponent<GameController>().GetPoint();
    }

    void EndGame()
    {
        audioSource.clip = gameOverClip;
        audioSource.Play();
        // Gọi hàm EndGame thông qua getComponent của gameController
        gameController.GetComponent<GameController>().EndGame();
    }
}
