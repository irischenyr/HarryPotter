using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vb : MonoBehaviour
{
    public AudioSource audio;//添加新变量
    

    public void OnButtonPressed(VirtualButtonBehaviour vbb)
    {
        audio.Play();
        Debug.Log("BTM Pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vbb)
    {
        audio.Pause();
        Debug.Log("BTM Released");
    }
    // Start is called before the first frame update
    void Start()
    {
        //audio = AudioSource.Find("ClickButton1");
        audio.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        audio.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
