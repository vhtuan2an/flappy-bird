using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMove : MonoBehaviour
{
    public float moveRange;
    public float moveSpeed;
    public float oldPos;
    public float minY;
    public float maxY;

    private GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        obj = gameObject;
        moveSpeed = 2;
        oldPos = 6;
        minY = -1;
        maxY = 1;
    }

    // Update is called once per frame
    void Update()
    {
        obj.transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Wall");
        if (collision.gameObject.tag == "Reset")
        {
            obj.transform.position = new Vector3(oldPos, Random.Range(minY, maxY + 1), 0);
        }
    }
}
