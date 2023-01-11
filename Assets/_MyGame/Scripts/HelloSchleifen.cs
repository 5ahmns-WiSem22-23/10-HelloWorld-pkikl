using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloSchleifen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 5; i++)
        {
            for( int y = 0; y <= 3; y++)
            {
                Debug.Log("Durchlauf Nr. " + y);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
