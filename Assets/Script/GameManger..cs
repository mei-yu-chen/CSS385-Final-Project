using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Video;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public int currentScore;
    public int itemCount;

    [Header("Trigger Music & Video")]
    public AudioSource TriggerMusicPlayer;
    public VideoPlayer winVideoPlayer;
    public int totalItems = 3;
    void Awake()
    {
        totalItems = 3;
    }

    void Update()
    {
        if (Keyboard.current.sKey.wasPressedThisFrame)
            SaveGame();

        if (Keyboard.current.lKey.wasPressedThisFrame)
            LoadGame();

        Debug.Log("Update running: itemCount = " + itemCount);
        CheckWinCondition();
    }

    void CheckWinCondition()
    {
        Debug.Log("Checking Win Condition: itemCount = " + itemCount + ", totalItems = " + totalItems);
        if (itemCount >= totalItems)
        {
            Debug.Log("Triggered Win Music & Video!");
            PlayWinMusicAndVideo();
        }

    }


    void PlayWinMusicAndVideo()
    {
        Debug.Log("Triggered Win Music & Video!");

        if (!TriggerMusicPlayer.isPlaying)
            TriggerMusicPlayer.Play();

        if (!winVideoPlayer.isPlaying)
            winVideoPlayer.Play();
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
