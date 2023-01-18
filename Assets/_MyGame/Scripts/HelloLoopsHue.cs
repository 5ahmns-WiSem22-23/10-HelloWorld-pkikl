using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloLoopsHue : MonoBehaviour
{


    char[,] alphabetArray = new char[4, 3];

    public void Start()
    {

        int letterIndex = 0;
        for (int row = 0; row < 4; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                alphabetArray[row, col] = (char)('A' + letterIndex);
                letterIndex++;
            }
        }
        for (int row = 0; row < 4; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                Debug.Log(alphabetArray[row, col] + " ");
            }
        }
        Debug.Log(alphabetArray.GetLength(0));
        Debug.Log(alphabetArray.GetLength(1));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
