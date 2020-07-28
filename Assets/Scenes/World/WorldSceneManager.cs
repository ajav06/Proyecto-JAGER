using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldSceneManager : JagerSceneManager
{
    private GameObject obj;
    private AsyncOperation loadScene;

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
        List<GameObject> list = new List<GameObject>();
        list.Add(obj);
        SceneTransitionManager.Instance.
            GoToScene(JagerConstants.SCENE_CAPTURE, list);
        print("WorldSceneManger.objectTapped activated");
    }

    public override void playerTapped(GameObject player)
    {

    }
}
