using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roomGeneration : MonoBehaviour
{
    public GameObject towerParent;
    public GameObject roomPrefab;

    private GameObject initialRoom = null;
    public int roomCounter = 0;
    // Start is called before the first frame update
    void Start()
    {
        //setup first room
        //initialRoom = generateRoom(5,5,5);
        //initialRoom.transform.position = new Vector3(3.5f,2.5f,3.5f);


        
    }

    // Update is called once per frame
    void Update()
    {
        // if (initialRoom != null)
        // {
        //     createRoomsFromObject(initialRoom.transform);
        // }
        
    }

    Vector3 getRandomRoomSize()
    {
        Vector3 size = Vector3.zero;
        size.x = (float)Random.Range(5,25);
        size.y = 5f;
        size.z = (float)Random.Range(5,25);

        //temporary
        size.x = 5f;
        size.y = 5f;
        size.z = 5f;

        return size;
    }

    // Vector3 northValidRoom(Transform currentRoom, Vector3 northRoomSize)
    // {
    //     Vector3 validLoc = Vector3.zero;

    //     Vector3 centerNextRoom = new Vector3(currentRoom.transform.position.x, currentRoom.transform.position.y, //
    //     currentRoom.transform.position.z + (currentRoom.localScale.z / 2) + 1 + (northRoomSize.z / 2));

    //     //determine locations for all things
    //     Vector3 upperLeft = ;
    //     Vector3 upperRight = ;
    //     Vector3 lowerLeft = ;
    //     Vector3 lowerRight = ;

    //     return validLoc;

    // }

    void createRoomsFromObject(Transform currentRoom)
    {
        // Vector3 pos = currentRoom.transform.position;
        // float currentRoomX;
        // float currentRoomZ;

        // Vector3 northRoomSize = getRandomRoomSize();
        // Vector3 southRoomSize = getRandomRoomSize();
        // Vector3 eastRoomSize = getRandomRoomSize();
        // Vector3 westRoomSize = getRandomRoomSize();
        // //North
        // //determine center of next possible

        // Vector3 newNorthRoomLoc = northValidRoom(currentRoom, northRoomSize);
        // if (newNorthRoomLoc != Vector3.zero)
        // {
        //     Debug.Log("Instantiate Room at " + newNorthRoomLoc.ToString());
        // }


        //public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, //
        //Quaternion orientation = Quaternion.identity, float maxDistance = Mathf.Infinity, int layerMask = DefaultRaycastLayers, //
        //QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal);

        //South
        //West
        //East

        




        

        


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

