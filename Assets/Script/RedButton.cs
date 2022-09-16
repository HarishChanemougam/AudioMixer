using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedButton : MonoBehaviour
{
    public string GetName()
    {
        return "RedButton";
    }

    public void Use()
    {
        Debug.Log("I AM RED");
    }
}
