using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameScript : MonoBehaviour {
    fire11 dousenscript;

    public Text timeLabel;
    public GameObject Balldesu;
    public GameObject cylinder;
    public GameObject exp;


    float timer=0.0f;
    int flag=0;

    // Use this for initialization
    void Start () {
        //dousenscript = GetComponent<fire11>;
        timeLabel.text = "StopGame";

    }

    // Update is called once per frame
    void Update () {
        if (flag == 1) {
            timer += Time.deltaTime;
            timeLabel.text = timer.ToString ("f1");
        }
    }

    public void StartButton1(){
        flag = 1;

        cylinder.SendMessage ("StartFire");
        timer = 0.0f;
    }

    public void StopButton1(){
        flag = 0;
        if ((0.0f < timer && timer < 9.5f)||(10.5f<timer&&timer<20.0f)) {
            transform.localScale *= 2;
            Expload ();

        }
        if (9.6f < timer && timer < 10.4f) {
            timeLabel.text = "Safe";
            cylinder.SendMessage ("Safe");
        }
        timer = 0.0f;

    }


    void Expload(){

        GetComponent<Renderer>().material.color = Color.black;
        Instantiate(exp, new Vector3(2.01f, 0.35f, 1.38f), Quaternion.identity);
        Destroy (Balldesu);
        Destroy (cylinder);


    }



}
