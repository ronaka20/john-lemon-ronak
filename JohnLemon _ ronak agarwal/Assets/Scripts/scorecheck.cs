using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scorecheck : MonoBehaviour
{   
    public int point=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnGUI()
    {
        GUI.Label(new Rect(20,20,200,40),"COINS:"+point);

    }
}
