using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIPopup : MonoBehaviour
{
    bool isup = false;
    TMP_Text txt;
    public GameObject panel;
    public void toggle()
    {
        isup = !isup;
    }

    void Start()
    {
        txt = GetComponentInChildren<TMP_Text>();
    }

    void Update()
    {
        if(isup) {panel.SetActive(true); txt.text = "─";}
        else {panel.SetActive(false); txt.text = "+";}
    }
}
