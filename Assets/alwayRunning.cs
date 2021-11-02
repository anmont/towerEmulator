using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alwayRunning : MonoBehaviour
{
    GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void LateUpdate()
    {
        #region Prevent Player from going out of Bounds
        Vector3 pos = Player.transform.position;
        if (Player.transform.position.y < .2f)
        {
            //Debug.Log("Adjusting height Position");
            Player.transform.position = new Vector3(Player.transform.position.x, 2.5f, Player.transform.position.z);
        }
        if (Player.transform.position.x < 1f || Player.transform.position.x > 1023f)
        {
            if (Player.transform.position.x < 1f)
            {
                //Debug.Log("Adjusting y Position");
                Player.transform.position = new Vector3(1f, 2.5f, Player.transform.position.z);
            }
            else
            {
                //Debug.Log("Adjusting y Position");
                Player.transform.position = new Vector3(1023f, 2.5f, Player.transform.position.z);
            }
        }
        if (Player.transform.position.z < 1f || Player.transform.position.z > 1023f)
        {
            if (Player.transform.position.z < 1f)
            {
                //Debug.Log("Adjusting z Position");
                Player.transform.position = new Vector3(Player.transform.position.x, 2.5f, 1f);
            }
            else
            {
                //Debug.Log("Adjusting y Position");
                Player.transform.position = new Vector3(Player.transform.position.x, 2.5f, 1023f);
            }
        }
        #endregion
        
    }
}
