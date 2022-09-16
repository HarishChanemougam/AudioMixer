using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenButton : MonoBehaviour, IUsable
{
    public string GetName()
    {
        return "GreenButton";
    }

    public void use()
    {
        Debug.Log("I AM Green");
    }
}
