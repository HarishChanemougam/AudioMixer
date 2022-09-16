using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IUsable
{
    void use();
}
public class Interacatable : MonoBehaviour, IUsable
{
    public void use()
    {
        Debug.Log("yo ohaio");
    }

    private void Start()
    {
        
    }
}
