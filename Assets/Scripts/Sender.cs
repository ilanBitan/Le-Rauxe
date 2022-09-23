using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sender : MonoBehaviour
{
    public delegate float PlayerDied(Vector3 player, Vector3 target);
    public static event PlayerDied playerDiedInfo;

    private bool isAlive;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("ExecuteEvent", 3f);
    }

    // Update is called once per frame
    void ExecuteEvent()
    {
        if(playerDiedInfo != null)
        {
            playerDiedInfo(new Vector3(1f, 1f, 1f), new Vector3(2f, 2f, 2f));
        }
    }
}
