using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollowPlayer : MonoBehaviour
{
    public Transform player;
    public float smoothing;
    public Vector3 offset;

    void Update()
    {
        if(player !=null)
        {
            //Vector3 newPosition = Vector3.Lerp(transform.position, player.transform.position + offset, smoothing); this added ugly ass motion blur could possibly be the scaling on my end at the time of me creating it
            transform.position = player.position + offset;
        }

    }
}
