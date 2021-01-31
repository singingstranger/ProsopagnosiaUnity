using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Draw : MonoBehaviour
{
    public GameObject dialogue;
    float time;
    private TrailRenderer tr;
    public Slider progressbar;
    public static int mode; //0=haven't started, 1=normal mode, 2=freedraw mode, 3=credits

    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<TrailRenderer>();
        mode = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (mode==0){
            time=0;
            GetComponent<TrailRenderer>().time = 10;
            Progress(10);

        }
        else if (mode==1){
            if (time>30){//can reduce for testing
                //Debug.Log("Time");
                dialogue.GetComponent<HideButton>().ShowButton();
                mode=0;
            }
            else if (Input.GetMouseButton(0)){
                Vector3 temp = Input.mousePosition;
                temp.z = 4f; // Set this to be the distance you want the object to be placed in front of the camera.
                this.transform.position = Camera.main.ScreenToWorldPoint(temp);
                

                time = tr.time;
                time+=0.5f*Time.deltaTime;
                Progress(time);
                GetComponent<TrailRenderer>().time = time;
            }
            else{
                Vector3 temp = Input.mousePosition;
                temp.z = 6f;
                this.transform.position = Camera.main.ScreenToWorldPoint(temp);
            }
        }
        else if (mode==2){ //free draw mode, time increases to 30 and stops increasing then
            if (Input.GetMouseButton(0)){
                Vector3 temp = Input.mousePosition;
                temp.z = 4f; // Set this to be the distance you want the object to be placed in front of the camera.
                this.transform.position = Camera.main.ScreenToWorldPoint(temp);
                
                time = tr.time;
                if (time < 20){ 
                    time+=0.5f*Time.deltaTime;
                    //Progress(time);
                    GetComponent<TrailRenderer>().time = time;
                }
            }
            else{
                Vector3 temp = Input.mousePosition;
                temp.z = 6f;
                this.transform.position = Camera.main.ScreenToWorldPoint(temp);
            }
        }
        else if (mode==3){ //extra mode for credits
            return;
            
        }
    }
    void Progress(float prog){
        progressbar.value = prog;
    }
}
