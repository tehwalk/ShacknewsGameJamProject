using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public enum GameState{Playing, Paused, Won, Lost}
public class GameManager : MonoBehaviour
{
    GameState state;
    // Start is called before the first frame update
    void Start()
    {
        state = GameState.Playing;
    }

    // Update is called once per frame
    void Update()
    {
        switch(state)
        {
            
        }
    }
}
