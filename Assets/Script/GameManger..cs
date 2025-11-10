using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public int currentScore;
    public int itemCount;

    void Update()
    {
        if (Keyboard.current.sKey.wasPressedThisFrame)
        {
            SaveGame();
        }

        if (Keyboard.current.lKey.wasPressedThisFrame)
        {
            LoadGame();
        }
    }

    public void SaveGame()
    {
        GameData data = new GameData();
        data.score = currentScore;
        data.collectedItems = itemCount;
        data.playerPosX = player.transform.position.x;
        data.playerPosY = player.transform.position.y;

        SaveLoadSystem.SaveGame(data);
    }

    public void LoadGame()
    {
        GameData data = SaveLoadSystem.LoadGame();
        currentScore = data.score;
        itemCount = data.collectedItems;
        player.transform.position = new Vector2(data.playerPosX, data.playerPosY);
    }
}