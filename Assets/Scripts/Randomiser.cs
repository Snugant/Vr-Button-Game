using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Randomiser : MonoBehaviour
{
    public int RandNum;
    public float delay = 1f;
    public float timer;
    public int combo = 0;


    public UnityEvent ButtonChange;


    // Start is called before the first frame update
    void Start()
    {     
        RandNum = Random.Range(1,10);
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
                combo = 0;
            }
    }

    public void RandomNumber()
    {
        
        int oldNum = RandNum;          
        
        do
        {
            RandNum = Random.Range(1,11);
        } while(RandNum == oldNum);
        Debug.Log(RandNum);
        ButtonChange.Invoke();  
    }

    public void EarlyPress()
    {
        RandomNumber();
        timer = 0;
        combo += 1;

    }
}
