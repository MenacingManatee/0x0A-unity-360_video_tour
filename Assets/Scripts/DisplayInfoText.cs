using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayInfoText : MonoBehaviour
{
    public GameObject InfoBox;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void displayInfoBox() {
        InfoBox.SetActive(!InfoBox.gameObject.activeSelf);
    }
}
