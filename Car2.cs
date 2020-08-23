using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car2 : MonoBehaviour
{
    public int direction1 = 1;
    public float speed1 = 2;

    public Vector3 startPos1;
    public Vector3 endPos1;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = startPos1;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * direction1 * speed1);

        if ((transform.position.x * direction1) < (endPos1.x * direction1))
        {
            transform.position = startPos1;
        }
    }
}
