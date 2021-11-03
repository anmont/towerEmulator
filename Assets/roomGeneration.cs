using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roomGeneration : MonoBehaviour
{
    public GameObject towerParent;
    public GameObject roomPrefab;
    public int roomCounter = 0;
    // Start is called before the first frame update
    void Start()
    {
        //setup first room
        GameObject initialRoom = generateRoom(5,5,5);
        initialRoom.transform.position = new Vector3(3.5f,2.5f,3.5f);


        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject generateRoom(float x, float y, float z)
    {
        //GameObject myRoom = (GameObject)Resources.Load("Assets/_Prefabs/Room.prefab");
        GameObject newRoom = null;
        newRoom = Instantiate(roomPrefab, Vector3.zero, Quaternion.identity,towerParent.transform);
        newRoom.gameObject.name = "Room" + roomCounter.ToString();
        newRoom.transform.localScale = new Vector3(x,y,z);
        roomCounter ++;
        return newRoom;
    }
}
