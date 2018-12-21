using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class TrackingObject : MonoBehaviour, ITrackableEventHandler
{
    private TrackableBehaviour mTrackableBehaviour;
    public bool is_detected_ = false;
    public TextMesh obj_text_mesh_;
    //public string name_;
    //public int atk_;
    //public int def_;
    //public int hp_;


    // Use this for initialization
    void Start()
    {
        //obj_text_mesh_.text = name_ + "\n HP:" + hp_;
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED || newStatus == TrackableBehaviour.Status.TRACKED)
        {
            is_detected_ = true;
        }
        else
        {
            is_detected_ = false;
        }
    }
}
