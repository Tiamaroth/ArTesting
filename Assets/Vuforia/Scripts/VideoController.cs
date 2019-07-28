
using UnityEngine;
using UnityEngine.Video;
public class VideoController : MonoBehaviour
{
    public VideoPlayer mVid;

    public void PlayVideo(){
        mVid.Play();
    }

    public void StopVideo(){
        mVid.Stop();
    }
}
