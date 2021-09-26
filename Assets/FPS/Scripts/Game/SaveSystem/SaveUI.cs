using IMIRT.SaveSystem;
using UnityEngine;

namespace Unity.FPS.Game
{
    public class SaveUI : MonoBehaviour
    {
        private ISaveSystem saveSystem;

        private void Awake()
        {
            saveSystem = GetComponent<ISaveSystem>();
        }

        public void SaveGame()
        {
            SaveDataFPS data = BuildSaveData();

            Debug.Log(data.currentHealth);

            saveSystem.Save(data);
        }

        public void LoadGame()
        {
            SaveDataFPS saveDataFPS = saveSystem.Load<SaveDataFPS>();

            ApplySaveData(saveDataFPS);
        }

        private SaveDataFPS BuildSaveData()
        {
            Health health = FindObjectOfType<Health>();

            SaveDataFPS saveData = new SaveDataFPS(health.CurrentHealth);

            return saveData;
        }

        private void ApplySaveData(SaveDataFPS saveData)
        {
            Health health = FindObjectOfType<Health>();

            Debug.Log(health);

            health.CurrentHealth = saveData.currentHealth;
        }
    }
}

