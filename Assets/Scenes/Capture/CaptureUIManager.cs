using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureUIManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void toggleScene()
    {
        SceneTransitionManager.Instance.GoToScene(JagerConstants.SCENE_WORLD, new List<GameObject>());
    }
}
