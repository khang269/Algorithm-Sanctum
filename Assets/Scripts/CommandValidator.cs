using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface CommandValidator<node,  command>   where node : Node 
                                                    where command: Command
{
    bool validate(node node, command command);
}
