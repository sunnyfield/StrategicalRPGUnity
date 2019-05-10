using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instancer : MonoBehaviour
{
    public static GameObject Spawn(GameObject obj)
    {
        GameObject spawnedObj;
        spawnedObj = Instantiate(obj);
        return spawnedObj;
    }
}
