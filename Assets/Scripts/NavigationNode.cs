using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationNode : Node
{
    public List<Node> neighbors;
    public override bool isCommandValid()
    {
        return true;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
