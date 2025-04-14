using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonMove : MonoBehaviour
{
    private Vector3 mousePos;

    [SerializeField] 
    private GameObject balloon;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0.0f));
        if(mousePos.x <= -8.5){
            mousePos = new Vector3(-8.5f,mousePos.y,mousePos.z);
        }
        if(mousePos.x >= 8.5){
            mousePos = new Vector3(8.5f,mousePos.y,mousePos.z);
        }
        if(balloon != null){
            balloon.transform.position = new Vector3(mousePos.x,transform.position.y-3,0.0f);
        }
        
    }
}
