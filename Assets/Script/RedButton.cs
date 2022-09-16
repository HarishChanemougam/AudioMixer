using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.WSA;

public class RedButton : MonoBehaviour
{
    GameObject gameobject;
    TextMeshProUGUI _text;
    Renderer _renderText;
    bool _canvas;
    
    public void LaunchPanCarte()
    {
        _canvas.gameobject.Setactive(true);
        _renderText.text = _text;


        confimation.Input.action.actionMap.Enable();
        confimation.Input.action.started += waitForInput;
    }

    void waitForInput(InputAction.CallBackContext obj)
    {
        _canvas.gameobject.Setactive(false);
        _renderText.text = "";

        confimation.Input.asset.Disable();
        confimation.Input.asset.started -= waitForInput;

        onPancartStop?.Invoke();

    }
    public string GetName()
    {
        return "RedButton";
        
    }

    public void Use()
    {
        Debug.Log("I AM RED");
    }
}
