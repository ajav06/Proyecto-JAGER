using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.SceneManagement;

public class ObjectFactory : Singleton<ObjectFactory>
{
    
    [SerializeField] private Objecto[] availableObjects;
    [SerializeField] private float waitTime = 180.0f;
    [SerializeField] private int startingObjectos = 5;
    [SerializeField] private float minRange = 5.0f;
    [SerializeField] private float maxRange = 50.0f;

    private List<Objecto> liveObjectos = new List<Objecto>();
    private Objecto selectedObjecto;
    private Player player;

    public List<Objecto> LiveObjectos
    {
        get { return liveObjectos; }
    }

    public Objecto SelectedObjecto
    {
        get { return selectedObjecto; }
    }

    public void Awake(){
        Assert.IsNotNull(availableObjects);
    }

    void Start()
    {
        player = GameManager.Instance.CurentPlayer;
        Assert.IsNotNull(player);

        for(int i = 0; i < startingObjectos; i++){
            InstantiateObjecto();
        }

        StartCoroutine(GenerateObjectos());
    }

    public void ObjectoWasSelected(Objecto Objecto)
    {
        selectedObjecto = Objecto;
    }

    private IEnumerator GenerateObjectos() {
        while (true)
        {
            InstantiateObjecto();
            yield return new WaitForSeconds(waitTime);
        }
    }

    private void InstantiateObjecto() {
        int index = Random.Range(0, availableObjects.Length);
        float x = player.transform.position.x + GenerateRange();
        float z = player.transform.position.z + GenerateRange();
        float y = player.transform.position.y;
        liveObjectos.Add(Instantiate(availableObjects[index], new Vector3(x, y, z), Quaternion.identity));
    }

    private float GenerateRange() {
        float randomNum = Random.Range(minRange, maxRange);
        bool isPositive = Random.Range(0, 10) < 5;
        return randomNum * (isPositive ? 1 : -1);
    }
}
