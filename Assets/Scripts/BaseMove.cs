using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMove : MonoBehaviour
{
    public float moveRange;
    public float moveSpeed;
    private Vector3 oldPos;
    private GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
        obj = gameObject;
        moveSpeed = 2;
        moveRange = 5;
        oldPos = obj.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
