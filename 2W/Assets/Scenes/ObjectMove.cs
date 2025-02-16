using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    void Start()
    {
    }

    void Update()
    {
        /*Vector3 vec = new Vector3(1, 0, 0);
        transform.Translate(vec);*/
        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        transform.Translate(vec);
    }
}
