using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    public int ButtonNum;
    public Material[] material;
    Renderer rend;
    public GameObject Button;
    public int Btn;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];

        Button = GameObject.FindGameObjectWithTag("MainButton");

        if(ButtonNum == Btn)
        {
            rend.sharedMaterial = material[1];
        }
        else
        {
            rend.sharedMaterial = material[0];
        }        
    }

    void Update()
    {
        Btn = Button.GetComponent<Randomiser>().RandNum;
    }

    public void turnOn()
    {
        rend.sharedMaterial = material[1];
    }

    public void turnOff()
    {
        rend.sharedMaterial = material[0];
    }

    public void SwitchSet()
    {
        if(ButtonNum == Btn)
        {
            rend.sharedMaterial = material[1];
        }
        else
        {
            rend.sharedMaterial = material[0];
        }
    }


}
