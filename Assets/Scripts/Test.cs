using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [ContextMenu("Init")]
    // Start is called before the first frame update
    void Start()
    {
        int i = 0;
        if(++i > 0) //  i += 1 1 > 0 ;  i = 1
        {
            Debug.Log("true");
        }
        else
        {
            Debug.Log("false");
        }

        if(i > 0)
        {
            Debug.Log("Second true");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
