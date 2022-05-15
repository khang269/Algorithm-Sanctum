using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public int[] index;

    public int orientation;

    private void Awake()
    {
        index = new int[] { 0, 0, 0 };
        orientation = 0;
    }

    void Start()
    {
        index = GameObject.Find("GameManager").GetComponent<GameplayManager>().getIndex(transform.localPosition);

        Debug.Log("Player Index" + index[0] + " " + index[1] + " " + index[2]);
    }

    // Update is called once per frame
    void Update()
    {
        index = GameObject.Find("GameManager").GetComponent<GameplayManager>().getIndex(transform.localPosition);
    }
}
