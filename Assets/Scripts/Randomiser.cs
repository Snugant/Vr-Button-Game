using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Randomiser : MonoBehaviour
{
    List<int> list = new List<int> {0, 1, 2 };    
    public UnityEvent startRandomiser;
    public UnityEvent button1;
    public UnityEvent button2;
    public UnityEvent button3;    

    
    public bool Check = true;
    // Start is called before the first frame update
    void Start()
    {
        startRandomiser.Invoke();
    }

List<T> GetRandomElements<T>(List<T> inputList, int count)
    {
        List<T> outputList = new List<T>();
        for (int i = 0; i < count; i++)
        {
            int index = Random.Range(0, inputList.Count);
            outputList.Add(inputList[index]);
        }
        return outputList;
    }

    // Update is called once per frame



    public void randomiser()
    {
        if(Check == true)
        {
        var randomList = GetRandomElements(list, 1);
//        Debug.Log("Random elements =" + string.Join(", ", randomList));
        int randomIndex = randomList[0];
        if(randomIndex == 0)
        {
            button1.Invoke();
            bool Check = false;
        }
        else if(randomIndex == 1)
        {
            button2.Invoke();
            bool Check = false;
        }
        else if(randomIndex == 2)
        {
            button3.Invoke();
            bool Check = false;
        }

        }
    }
}
