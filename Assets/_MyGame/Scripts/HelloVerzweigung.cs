using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloVerzweigung : MonoBehaviour
{
    bool condition = true;

    int tolleInt;
    int switchCases = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(condition)
        {
            tolleInt += 1;
            return;
        }
        else
        {
            tolleInt = 0;
        }
        switch (switchCases)
        {
            case 5:
                Debug.Log("case 5");
                break;
            case 4:
                Debug.Log("case 4");
                break;
            case 3:
                Debug.Log("case 3");
                break;
            case 2:
                Debug.Log("case 2");
                break;
            case 1:
                Debug.Log("case 1");
                break;
            default:
                Debug.Log("case default");
                break;
        }

        if (condition)
        {
            tolleInt *= 3;
        }

        else if(tolleInt == 20)
        {
            tolleInt += 3;
        }
    }
}
