using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private Transform player;
    private float moveSpeed = 1.5f;
    private float yPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player != null){
            yPos += moveSpeed * Time.deltaTime;
            transform.position = new Vector3(transform.position.x, yPos, transform.position.z);
        }
    }
}
