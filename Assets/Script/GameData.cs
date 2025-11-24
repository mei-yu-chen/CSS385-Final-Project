[System.Serializable]
public class GameData
{
    public int score;
    public int collectedItems;
    public float playerPosX;
    public float playerPosY;

    public GameData()
    {
        score = 0;
        collectedItems = 0;
        playerPosX = 0f;
        playerPosY = 0f;
    }
}