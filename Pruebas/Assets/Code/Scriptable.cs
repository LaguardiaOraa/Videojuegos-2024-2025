using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Aparicion", order = 1)]
public class SpawnManagerScriptableObject : ScriptableObject
{
    public int NumItems;
    public GameObject Objeto;
}


