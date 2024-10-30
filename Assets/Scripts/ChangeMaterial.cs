using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    public int ButtonNum;
    public Material[] material;
    Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];        
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
        if(ButtonNum == test)
        {
            rend.sharedMaterial = material[1];
        }
        else
        {
            rend.sharedMaterial = material[0];
        }
    }


}
