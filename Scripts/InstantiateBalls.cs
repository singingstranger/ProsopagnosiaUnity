using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateBalls : MonoBehaviour

{
//Basically, you can call on the voids either form in this code or from another
//and then you can change how many spawn or how far apart by changing positionspots or Random.Range
    Vector3 trub;
    Vector3 trubs;
    public GameObject others;
    public GameObject searched;
    
    
    int positionspots = 5;
    int targetposition;

    [SerializeField]
    GameObject[] spawnlocations;
    
    
    void Start()
    {
        //PresetPosition();
        //PresetPositionOrder();
    }
    void Update(){
        if (Input.GetKeyDown(KeyCode.E)){
            //PresetPositionOrder();
            PresetLocation();
        }
    }
    public void PresetPosition(){
        trub = new Vector3(Random.Range(-5,3),1,4);
        trubs = new Vector3(Random.Range(-5,3),1,4);
        GameObject go1 = (GameObject)Instantiate(others, trub, Quaternion.identity);
        GameObject go2 = (GameObject)Instantiate(searched, trubs, Quaternion.identity);
    }
    public void PresetPositionOrder(){
        targetposition = Random.Range(0,positionspots);
        for(int i = 0; i < positionspots; i++)
        {
            if (i == targetposition){
                Debug.Log("target instantiate");
                GameObject obj = Instantiate(searched);
                obj.transform.position = new Vector3(Random.Range(-7,7), 2f, Random.Range(2,10));
                obj.transform.localScale -= new Vector3(0.1f,0.1f,1);

            }
            else{
                Debug.Log("Distracters");
                GameObject obj = Instantiate(others);
                obj.transform.position = new Vector3(Random.Range(-7,7), 2f, Random.Range(2,10));
            }
        }
    

    }
    public void PresetLocation(){

        targetposition = Random.Range(0,positionspots);
        targetposition = Random.Range(0,positionspots);

        for(int i = 0; i < positionspots; i++)
        {
            if (i == targetposition){
                Debug.Log("target instantiate");
                GameObject obj = Instantiate(searched);
                obj.transform.position = spawnlocations[targetposition].transform.position;
                obj.transform.localScale -= new Vector3(0.15f,0.15f,1);
                obj.AddComponent<destroyOnButtonPress>();
            }
            else{
                Debug.Log("Distracters");
                GameObject obj = Instantiate(others);
                obj.transform.position = spawnlocations[i].transform.position; //I tried using positionspot and it didn't work
                //Debug.Log(i);
                obj.AddComponent<destroyOnButtonPress>();
            }
        }
    }
    }
