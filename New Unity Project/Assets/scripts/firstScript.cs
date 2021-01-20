using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class firstScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int score = 0;

        Debug.Log(score);

        int numA = 20;
        int numB = 15;

        if(numA > numB)
        {
            Debug.Log("numA is greater than numB");
        } 
        else if(numA < numB)
        {
            Debug.Log("numA is less than numB");
        }
        else
        {
            Debug.Log("numA is equal to numB");
        }

        Debug.Log(transform.position);

        Vector3 testVector = new Vector3(10, 2, -5);

        transform.position = testVector;

        Debug.Log(transform.position);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
