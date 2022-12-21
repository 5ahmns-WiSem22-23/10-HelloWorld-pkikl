using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloMethoden : MonoBehaviour
{
 
    private int startValue = 0;
    private int startValue3 = 0;
    private int startValue4 = 10;

    void Start()
    {
        Debug.Log("Hallo Methoden");

        Debug.Log("before startValue:" + startValue);

        IncrementByone();

        Debug.Log("after startValue:" + startValue);

        Debug.Log("before startValue3:" + startValue);

        IncrementByX(Random.Range(1, 10));

        Debug.Log("after start Value3:" + startValue);

        Debug.Log("before startValue4:" + startValue);

        DecrementByOne(startValue4);

        Debug.Log("after start Value4:" + startValue);
    }



    void DecrementByOne(int val)
    {
        val--;
        Debug.Log("val:" + val);
    }

    void IncrementByX(int valToAdd)
    {
        startValue3 += valToAdd;
    }

    void IncrementByone()
    {
        startValue++;
    }

}