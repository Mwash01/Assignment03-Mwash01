using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class Game : MonoBehaviour
{
    private Save CreateSaveGameObject() {
        Save save = new Save();

        save.playerName = Name.playerName;
        save.scoreNum = Data.scoreNum;
        save.playerLives = Data.playerLives;
        save.carSpeed = Data.carSpeed;

        return save;
    }

    public void SaveGame() {
        Save save = CreateSaveGameObject();

        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/gamesave.save");
        bf.Serialize(file, save);
        file.Close();
    }

    public void SaveJSON() {
        Save save = CreateSaveGameObject();
        string json = JsonUtility.ToJson(save);

        Debug.Log("Saving as JSON: " + json);
    }

    public void LoadGame() {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Open(Application.persistentDataPath + "/gamesave.save", FileMode.Open);
        Save save = (Save)bf.Deserialize(file);
        file.Close();

        Data.scoreNum = save.scoreNum;
        Name.playerName = save.playerName;
        Data.playerLives = save.playerLives;
        Data.carSpeed = save.carSpeed;

        SceneManager.LoadScene("MainScene");
    }
}
