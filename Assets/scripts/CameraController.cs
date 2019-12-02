
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    //offset of camera from player
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        //save initial offset to maintain as player moves
        offset = transform.position - player.transform.position;
    }

    // LateUpdate is called once per frame after all other positions are calculated
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
