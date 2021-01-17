using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainScript : MonoBehaviour
{
    public Camera cam;
    public Color color1 = Color.red;
    public Color color2 = Color.blue;
    public float duration = 3.0F;

    public AudioSource audioSource;
    public AudioSource audioSourceBonus1;
    public AudioSource audioSourceBonus2;
    public AudioSource audioSourceBonus3;
    public AudioSource audioSourceBonus4;

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
        cam.clearFlags = CameraClearFlags.SolidColor;

        audioSource = GetComponent<AudioSource>();
        audioSource.Play(0);

        audioSourceBonus1 = GameObject.Find("AudioSourceBonus1").gameObject.GetComponent<AudioSource>();
        audioSourceBonus2 = GameObject.Find("AudioSourceBonus2").gameObject.GetComponent<AudioSource>();
        audioSourceBonus3 = GameObject.Find("AudioSourceBonus3").gameObject.GetComponent<AudioSource>();
        audioSourceBonus4 = GameObject.Find("AudioSourceBonus4").gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //play sound
        if (Input.GetKeyDown(KeyCode.Space))
        {
            audioSourceBonus1.Play(0);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            audioSourceBonus2.Play(0);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            audioSourceBonus3.Play(0);
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            audioSourceBonus4.Play(0);
        }
        else if (Input.anyKeyDown)
        {
            Debug.Log("Some key was pressed.");

            audioSource.Play(0);
        }

        //change background color
        if (Input.anyKeyDown)
        {
            cam.backgroundColor = Random.ColorHSV(0f, 1f, 1f, 1f, 0.1f, 0.2f);
        }
    }
}
