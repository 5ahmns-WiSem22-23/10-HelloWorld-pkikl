using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloOperatoren : MonoBehaviour
{
    private bool a;
    private bool b;
    int test = 0;

    int intEins = 0;
    int intZwei = 1;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hier steht der arithmetische Operator "+ (intEins+intZwei).ToString());

        Debug.Log("Hier steht der Gleichheitsoperator " + (intEins == intZwei).ToString());

        Debug.Log("Hier steht der Vergleichssoperator " + (intEins < intZwei).ToString());

        Debug.Log("Hier steht der logische Operator " + (true && true).ToString());

        Debug.Log("Hier steht der Zuweisungssoperator " + (intEins += 1).ToString());
    }
}
