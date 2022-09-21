using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Iteam : MonoBehaviour
{
    [SerializeField] List<IteamSO> _Sword;




    private void Start()
    {
        foreach (IteamSO el in _Sword)
        {
            if (el is IteamSO)
            {
                IteamSO iteam = (IteamSO)el;
            }
        }
    }
}
