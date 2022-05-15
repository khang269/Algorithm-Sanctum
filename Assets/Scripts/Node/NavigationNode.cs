using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationNode : Node
{
    // Start is called before the first frame update
    void Start()
    {
        GameplayManager manager = GameObject.Find("GameManager").GetComponent<GameplayManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
