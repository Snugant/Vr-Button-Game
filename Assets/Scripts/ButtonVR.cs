using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonVR : MonoBehaviour
{
    public GameObject button;
    public GameObject ButtonMain;
    public UnityEvent onPress;
    public UnityEvent onRelease;
    GameObject presser;
    bool isPressed;
    bool PressableButton = false;
    public int ButtonNumber;
    public int Btn;

    void Start()
    {
        ButtonMain = GameObject.FindGameObjectWithTag("MainButton");    
        isPressed = false;
    }

    void Update()
    {
        Btn = ButtonMain.GetComponent<Randomiser>().RandNum;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(!isPressed)
        {
            button.transform.localPosition = new Vector3(0, 0.003f, 0);
            if(ButtonNumber == Btn)
            {
            presser = other.gameObject;
            onPress.Invoke();
            isPressed = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == presser)
        {
            button.transform.localPosition = new Vector3(0, 0.015f, 0);
            onRelease.Invoke();
            isPressed = false;
            bool check = true;
        }
    }

    public void SpawnSphere()
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        sphere.transform.localPosition = new Vector3(0, 1, 2);
        sphere.AddComponent<Rigidbody>();

    }
}