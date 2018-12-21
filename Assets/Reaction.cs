using System.Collections;
using UnityEngine;
using Vuforia;


//public enum eGameState
//{
//    Ready = 0,
//    Battle,
//    Result
//}

public class Reaction : MonoBehaviour
{
    //public TrackingObject obj_lancekun_;
    //public TrackingObject obj_jombie_;
    public TrackingObject obj_63building;
    public TrackingObject obj_ddp;
    public TrackingObject obj_dongdaemun;
    public TrackingObject obj_gwanghwamun;
    public TrackingObject obj_gyeongbokgung;
    public TrackingObject obj_hongjimoon;
    public TrackingObject obj_jonggak;
    public TrackingObject obj_lotteworldtower;
    public TrackingObject obj_nseoultower;
    public TrackingObject obj_worldcup;

    //public eGameState game_state_ = eGameState.Ready;

    //Use this for initialization

    private void OnGUI()
    {

        GUIStyle gui_style = new GUIStyle();
        gui_style.fontSize = 60;
        gui_style.normal.textColor = Color.yellow;
        gui_style.normal.textColor = Color.yellow;
        //int label_width;
        //int button_width;

        //label_width = 200;
        //button_width = 300;

        //GUI.Label(new Rect(Screen.width / 2 - 150 / 2, 150, 150, 60), "State: " + game_state_.ToString(), gui_style);

        GUIStyle gui_style_btn = new GUIStyle("Button");
        gui_style_btn.fontSize = 50;
        //if (obj_lancekun_.is_detected_ && obj_jombie_.is_detected_ && game_state_ == eGameState.Ready)
        //{
        //    if (GUI.Button(new Rect(Screen.width / 2 - 300 / 2, 500, 300, 150), "Start Battle: ", gui_style_btn))
        //    {
        //        game_state_ = eGameState.Battle;
        //        StartCoroutine(RollTheDices());
        //    }
        //}

        if (obj_63building.is_detected_)
        {

            GUI.Button(new Rect(300, 300, 240, 120), "obj_63building");
        }
        if (obj_ddp.is_detected_)
        {
            GUI.Button(new Rect(600, 300, 240, 120), "obj_ddp");
        }
        if (obj_dongdaemun.is_detected_)
        {
            GUI.Button(new Rect(600, 300, 240, 120), "obj_dongdaemun");
        }
        if (obj_gwanghwamun.is_detected_)
        {
            GUI.Button(new Rect(600, 300, 240, 120), "obj_gwanghwamun");
        }
        if (obj_gyeongbokgung.is_detected_)
        {
            GUI.Button(new Rect(600, 300, 240, 120), "obj_gyeongbokgung");
        }
        if (obj_hongjimoon.is_detected_)
        {
            GUI.Button(new Rect(600, 300, 240, 120), "obj_hongjimoon");
        }
        if (obj_jonggak.is_detected_)
        {
            GUI.Button(new Rect(600, 300, 240, 120), "obj_jonggak");
        }
        if (obj_lotteworldtower.is_detected_)
        {
            GUI.Button(new Rect(600, 300, 240, 120), "obj_lotteworldtower");
        }
        if (obj_nseoultower.is_detected_)
        {
            GUI.Button(new Rect(600, 300, 240, 120), "obj_nseoultower");
        }
        if (obj_worldcup.is_detected_)
        {
            GUI.Button(new Rect(600, 300, 240, 120), "obj_worldcup");
        }
    }
    //IEnumerator RollTheDices()
    //{
    //    obj_lancekun_.obj_text_mesh_.text = "주사위 : " + 6;
    //    obj_jombie_.obj_text_mesh_.text = "주사위 : " + 1;
    //    yield return null;
    //}
}
