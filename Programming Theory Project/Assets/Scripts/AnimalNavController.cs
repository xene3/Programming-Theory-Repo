using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalNavController : MonoBehaviour
{
    public List<Transform> shadowPositions;

    // Start is called before the first frame update
    void Awake()
    {
        //Takes all shadows from the Game Scene
        foreach(GameObject shadow in GameObject.FindGameObjectsWithTag("Shadow"))
        {
            shadowPositions.Add(shadow.transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
