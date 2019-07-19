using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public enum Worlds
    {
        Overworld,
        BattleScene
    }
   
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }


    public void TraveltoWorld(Worlds destination)
    {
        switch (destination)
        {
            case Worlds.Overworld:
                SceneManager.LoadScene("Overworld");
                break;

            
        }
    }

}
