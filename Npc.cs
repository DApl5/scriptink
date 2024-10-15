using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour
{
    public int health = 5;
    public int levl = 2;
 
    // Start is called before the first frame update
    void Start()
    {
        health += levl;
        print(health);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
