using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colorchanger : MonoBehaviour
{
SpriteRenderer sprite;
   
    void Start()
    {
        sprite = this.GetComponent<SpriteRenderer>();
    }
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {            
            // Change the 'color' property of the 'Sprite Renderer'
            sprite.color = new Color (1, 0, 0, 1); 
        }
    }
}
