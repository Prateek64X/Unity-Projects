using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideAfterT : MonoBehaviour
{
    public GameObject panel;
    
    void Update()
    {
        Invoke("hidePanel", 3.0f);
    }
    void hidePanel()
    {
        panel.SetActive(false);
    }
}
