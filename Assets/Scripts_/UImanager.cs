using UnityEngine;

public class UImanager : MonoBehaviour
{
    public GameObject endGamePanel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(GameController.GameOver)
        {
            endGamePanel.SetActive(true);
        }
    }
}
