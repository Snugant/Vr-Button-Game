using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Randomiser : MonoBehaviour
{
    public int test;
    bool FunctionCalled;
    public float delay = 1f;
    float timer;

    public UnityEvent ButtonChange;


    // Start is called before the first frame update
    void Start()
    {     
        test = Random.Range(1,4);
    }

    // Update is called once per frame
    private void Update()
    {
            ButtonChange.Invoke();
            timer += Time.deltaTime;
            if(timer > delay)
            {
                RandomNumber();
                timer -= delay;
            }
    }

    public void RandomNumber()
    {
        
        int oldTest = test;          
        
        do
        {
            test = Random.Range(1,4);
        } while(test == oldTest);
        Debug.Log(test);
        ButtonChange.Invoke();  
    }
}
