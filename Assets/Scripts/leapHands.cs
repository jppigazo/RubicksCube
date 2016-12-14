using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using Leap;


public class leapHands : MonoBehaviour {



    // Use this for initialization
    void Start() {

        Controller controller = new Controller();
        SampleListener listener = new SampleListener();
        controller.Connect += listener.OnServiceConnect;
        controller.Device += listener.OnConnect;
        //controller.FrameReady += listener.OnFrame;

        //controller.RemoveListener(listener);
        controller.Dispose();

        Frame frame = controller.Frame();
        List<Hand> hands = frame.Hands;


    }

    // Update is called once per frame
    void Update() {

    }
}


class SampleListener
{
    public void OnServiceConnect(object sender, ConnectionEventArgs args)
    {
        Debug.Log("Service Connected");
    }

    public void OnConnect(object sender, DeviceEventArgs args)
    {
        Debug.Log("Connected");
    }

    public void OnFrame(object sender, FrameEventArgs args)
    {
        //Debug.Log("Frame Available.");
    }

}