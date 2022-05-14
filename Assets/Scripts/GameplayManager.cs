using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    private Grid3D grid
    { get; set; }
    // Start is called before the first frame update
    void Start()
    {
        grid = new Grid3D(15, 15, 15);
    }

    // Update is called once per frame
    void Update()
    {

    }

    bool validateCommand(Command command, Node node)
    {
        return true;
    }
}
