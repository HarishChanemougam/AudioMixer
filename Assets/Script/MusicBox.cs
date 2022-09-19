using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;

public class MusicBox : MonoBehaviour, IUsable
{
    [SerializeField] string _sourdineName;
    [SerializeField, Range(0,22000)] float _sourdineOn;
    [SerializeField] float _sourdineMax;
    [SerializeField] float _sourdineMin;

    [SerializeField] AudioMixer _mixer;

    bool _isOpen;

    void Start()
    {
        
    }
    public string GetName() => "MusicBox";

    void IUsable.use()
    {
        if(_isOpen)
        {
            _isOpen = false;
            _mixer.SetFloat(_sourdineName, _sourdineMin);
        }

        else
        {
            _isOpen = true;
            _mixer.SetFloat(_sourdineName, _sourdineMax);
        }
    }
}
