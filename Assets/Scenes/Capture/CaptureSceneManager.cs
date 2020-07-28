using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureSceneManager : JagerSceneManager
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void objectTapped(GameObject obj)
    {
        print("CaptureSceneManger.objectTapped activated");
    }

    public override void playerTapped(GameObject player)
    {
        print("CaptureSceneManger.playerTapped activated");
    }
}
