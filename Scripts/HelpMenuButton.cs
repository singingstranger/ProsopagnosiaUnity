using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelpMenuButton : MonoBehaviour
{
    public Button starter;
    public Button closer;
    public GameObject menu;
    // Start is called before the first frame update
    void Start()
    {
        menu.SetActive(false);
        starter.gameObject.SetActive(true);
        closer.gameObject.SetActive(false);
        starter.onClick.AddListener(MenuOpen);
        closer.onClick.AddListener(MenuClose);
    }

    void MenuOpen(){
        menu.SetActive(true);
        starter.gameObject.SetActive(false);
        closer.gameObject.SetActive(true);
    }
    void MenuClose(){
        menu.SetActive(false);
        starter.gameObject.SetActive(true);
        closer.gameObject.SetActive(false);
    }


}
