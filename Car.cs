using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public int direction = 1;
    public float speed = 2;

    public Vector3 startPos;
    public Vector3 endPos;
        
    // Start is called before the first frame update
    void Start()
    {
        transform.position = startPos;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * direction * speed);

        if ((transform.position.x * direction) > (endPos.x * direction))
        {
            transform.position = startPos;
        }
    }
}
