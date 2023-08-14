using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class ObjectLayout : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(transform.childCount);

        for (int i = 0; i < transform.childCount; i++)
        {
            int j = i % 12;
            int j2 = i / 12;
            transform.GetChild(i).transform.position = Vector3.right * j*2 + Vector3.back * j2*2;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
