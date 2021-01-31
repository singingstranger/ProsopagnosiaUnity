using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ontouchdestroy : MonoBehaviour
{
    public GameObject destroyer;
    GameObject cans;
    //public GameObject destroyee;
    // Start is called before the first frame update
    void Awake()
    {
        destroyer = GameObject.Find("Player");
    }

    // Update is called once per frame
   void OnCollisionEnter(Collision collision)
     {
         if (collision.collider.gameObject == destroyer)
         {
            cans = GameObject.Find("Canvas");
            //Debug.Log ("touch");
            cans.GetComponent<PointCounter>().Point(1);
            Destroy(this.gameObject);
         }
    }

}
