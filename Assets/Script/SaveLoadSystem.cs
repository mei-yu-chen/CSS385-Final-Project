using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveLoadSystem
{
    private static string savePath = Application.persistentDataPath + "/savefile.dat";

    public static void SaveGame(GameData data)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream(savePath, FileMode.Create);
        formatter.Serialize(stream, data);
        stream.Close();

        Debug.Log("gamedata save：" + savePath);
    }

    public static GameData LoadGame()
    {
        if (File.Exists(savePath))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(savePath, FileMode.Open);
            GameData data = formatter.Deserialize(stream) as GameData;
            stream.Close();

            Debug.Log("game is loading：" + savePath);
            return data;
        }
        else
        {
            Debug.LogWarning("can't not find, will create new data");
            return new GameData();
        }
    }
}