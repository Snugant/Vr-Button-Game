using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class muh : MonoBehaviour
{
    int test;
    public UnityEvent testThingo;

    // Start is called before the first frame update
    void Start()
    {
        test = Random.Range(1,4);        
          testThingo.Invoke();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RandomNumber()
    {
        int oldTest = test;          
        
        while(test == oldTest)
        {
            int test = Random.Range(1,4);
            
        }
        Debug.Log(test);

    }
}

