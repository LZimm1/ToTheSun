using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject nail;
    [SerializeField]
    private float yPos;
    [SerializeField]
    private float waitTime;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnNails());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public IEnumerator SpawnNails(){
        while(true){
            yield return new WaitForSeconds(waitTime);
            Instantiate(nail);
            int xPos = Random.Range(-10,10);
            nail.transform.position = new Vector3(xPos, yPos,transform.position.z);
        }
    }
}
