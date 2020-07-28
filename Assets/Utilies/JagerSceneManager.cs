using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class JagerSceneManager : MonoBehaviour
{
    public abstract void playerTapped(GameObject player);
    public abstract void objectTapped(GameObject obj);
}
