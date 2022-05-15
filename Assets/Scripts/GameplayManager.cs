using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    [SerializeField]
    private List<CommandValidator> commandValidators;
    private Grid3D grid
    { get; set; }

    [SerializeField]
    private GameObject test;

    private Node[,,] nodes;
    // Start is called before the first frame update

    private void Awake()
    {
        grid = new Grid3D(15, 15, 15);
        nodes = new Node[grid.getXsize(),grid.getYsize(),grid.getZsize()];
    }

    void Start()
    {
        Instantiate(test);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public bool validateCommand(Command command, Node node)
    {
        bool result = true;
        foreach(CommandValidator commandValidator in commandValidators)
        {
            result = result && commandValidator.validate(node, command);
        }
        return result;
    }

    public void registerNode(Node node)
    {
        int[] index = grid.getIndex(node.transform.localPosition);
        nodes[index[0], index[1], index[2]] = node;
    }

    public Node getNode(int[] index)
    {
        return nodes[index[0], index[1], index[2]];
    }

    public Vector3 getPostion(int[] index)
    {
        return grid.getPosition(index);
    }

    public int[] getIndex(Vector3 position)
    {
        return (int[])grid.getIndex(position).Clone();
    }
}
