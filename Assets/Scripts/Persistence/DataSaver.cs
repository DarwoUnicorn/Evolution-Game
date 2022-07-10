using System.IO;
using UnityEngine;
using UnityEngine.Events;

public class DataSaver : MonoBehaviour
{
    [SerializeField]
    private UnityEvent<PersistentData> DataLoaded = new UnityEvent<PersistentData>();

    [SerializeField] [HideInInspector]
    private PersistentData _persistentData;

    private string _path => Application.persistentDataPath + "/Save";

    public void Save()
    {
        File.WriteAllText(_path, JsonUtility.ToJson(this));
    }

    private void Load()
    {
        if(File.Exists(_path))
        {
            _persistentData = JsonUtility.FromJson<PersistentData>(File.ReadAllText(_path));
        }
        DataLoaded?.Invoke(_persistentData);
    }

    private void Start()
    {
        Load();
    }

    private void LateUpdate()
    {
        if(_persistentData.HasChange)
        {
            Save();
        }
    }
}
