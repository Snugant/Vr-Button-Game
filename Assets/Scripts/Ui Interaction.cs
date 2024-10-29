using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UiInteraction : MonoBehaviour
{
    public UnityEvent Enter;
    public UnityEvent Release;    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider UI)
    {
        Enter.Invoke();
    }

    private void OnTriggerExit(Collider UI)
    {
        Release.Invoke();
    }

}
