using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Command : MonoBehaviour
{
    protected CommandManager commandManager;
    protected Player player;

    private void Awake()
    {
        commandManager = GameObject.Find("Player").GetComponent<CommandManager>();
        player = GameObject.Find("Player").GetComponent<Player>();
        validateCommand();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void Stop()
    {
        commandManager.onCommandStop();
        Destroy(gameObject);
    }
   

    protected void validateCommand()
    {
        GameplayManager manager = GameObject.Find("GameManager").GetComponent<GameplayManager>();
        if(manager.validateCommand(this, manager.getNode(new int[] { 0, 0, 0 })))
        {
           
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
