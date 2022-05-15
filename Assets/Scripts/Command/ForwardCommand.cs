using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class ForwardCommand : Command
{
    private Vector3 startPosition;
    private Vector3 endPosition;

    [SerializeField]
    private float time = 2f;
    private float delta = 0f;


    // Start is called before the first frame update
    void Start()
    {
        startPosition = GameObject.Find("GameManager").GetComponent<GameplayManager>().getPostion(player.index);
        int[] next_index = (int[])player.index.Clone();
        next_index[0] += Math.Sign(2 - player.orientation) * (player.orientation % 2);
        next_index[2] += Math.Sign(2 - player.orientation) * ((player.orientation+1) % 2);
        endPosition = GameObject.Find("GameManager").GetComponent<GameplayManager>().getPostion(next_index);
        delta = 0;
    }

    // Update is called once per frame

    private void Update()
    {
        delta += Time.deltaTime;
        if (delta > time)
        {
            Stop();
        }
        Vector3 current = Vector3.Lerp(startPosition, endPosition, delta / time);
        player.transform.localPosition = current;

        Debug.Log("Start position" + startPosition);
        Debug.Log("End position" + endPosition);
    }

    public override void Stop()
    {
        player.transform.localPosition = endPosition;
        base.Stop();
    }
}
