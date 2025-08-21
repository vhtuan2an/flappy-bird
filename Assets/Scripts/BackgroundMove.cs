using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    public float speed;
    [SerializeField] 
    private Renderer bgRenderer;
    private GameObject obj;


    // Start is called before the first frame update
    void Start()
    {
        // obj đại diện cho gameObject giúp tăng performance, nếu gọi transform không thì game sẽ phải tìm object để transform
        // => giảm performance
        obj = gameObject;       
    }

    // Update is called once per frame
    void Update()
    {
        // Vector3.left: Vector (-1, 0, 0)
        bgRenderer.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0);
    }
}
