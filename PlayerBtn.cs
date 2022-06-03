using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Vuforia; //导入Vuforia包
 
public class PlayerBtn : MonoBehaviour  //实现虚拟按钮接口
{
    //创建回调函数
    public UnityEvent playEvent, pauseEvent;
    //用来记录是暂停还是播放 偶数播放 基数暂停
    private int count = 1;
 
    private void Awake()    
    {
        //为虚拟按钮注册事件
        GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
    }
 
    //当按下虚拟按钮
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        count++;
        if (count % 2 == 1)
        {
            //播放视频
            playEvent.Invoke();
            Debug.Log("count =="+count);
        }
        else {
            //暂停视频
            pauseEvent.Invoke();
            Debug.Log("count ==" + count);
        }
    }
 
    //松开虚拟按钮是出发
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
       
    }
 
}
