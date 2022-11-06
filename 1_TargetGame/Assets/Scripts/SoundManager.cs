using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource tick;
    [SerializeField] private AudioSource shot;
    [SerializeField] private AudioSource hurray;

    public void playShot()
    {
        shot.Play();
    }

    public void playTick()
    {
        tick.Play();
    }
    public void playHurray()
    {
        hurray.Play();
    }
}
