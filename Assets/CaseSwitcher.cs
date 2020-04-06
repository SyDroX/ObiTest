using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaseSwitcher : MonoBehaviour
{
    public List<GameObject> gameObjects = new List<GameObject>(3);
    private int currentIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            gameObjects[currentIndex].SetActive(false);
            currentIndex++;
            currentIndex = currentIndex % gameObjects.Count;
            gameObjects[currentIndex].SetActive(true);
        }
    }
}
