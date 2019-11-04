using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    float Move;
    // Start is called before the first frame update
    void Start()
    {
        Move = 0.05f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x + Move, transform.position.y + Move);
        if(Mathf.Abs(transform.position.x) >= 5)
        {
            Move = -Move;
        }
    }
}
