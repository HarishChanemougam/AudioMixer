using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(menuName = "Iteams")]
public class IteamSO : ScriptableObject
{
    [SerializeField] string _name; 
    [SerializeField] int _price; 
    [SerializeField] int _weight;
    [SerializeField] Sprite _sprite;
    public string Name { get => _name; }
    public int Price { get => _price; }
    public int Weight { get => _weight; }

    public Sprite Sprite { get => _sprite; }


    //[SerializeField] class Objects
    //{
    //
    //
    //    public List<IteamSO> iteamSOs = new List<IteamSO>();
    //
    // public GamesManager gamesManager;
    /*private void Start()
    {
        gamesManager = GameObject.Find("Iteam").GetComponent<IteamSO>();
    }*/
    //
    //     [SerializeField] List<Iteam> _stats;
    //
    //     public Iteams.GetStateByLevel{ int level => State.Firest(i => i.level = level) };
    //}


}
