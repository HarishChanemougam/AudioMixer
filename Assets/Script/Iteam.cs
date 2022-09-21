using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Iteam : MonoBehaviour
{
    [SerializeField] IteamSO _Sword;
    [SerializeField] IteamSO _Apple;
    [SerializeField] IteamSO _Key;


    private void Start()
    {
        //Iteam = GameObject.Find("Iteams").GetComponent<IteamSO>();
    }
}
