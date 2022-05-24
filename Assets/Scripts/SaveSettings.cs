using UnityEngine;
using UnityEngine.UI;
using Newtonsoft.Json;

public class SaveSettings : MonoBehaviour
{

    public Slider sound;
    public Slider music;
    public Dropdown graphic;
    public Dropdown language;

    private SettingData settings;

    private void Awake()
    {
        LoadData();
    }

    private void LoadData()
    {
        settings = JsonUtility.FromJson<SettingData>(PlayerPrefs.GetString("setting"));
        if (settings != null)
        {
            sound.value = settings.sound;
            music.value = settings.music;
            graphic.value = settings.graphic;
            language.value = settings.language;
        }
        else
        {
            settings = new SettingData();
        }
    }

    private void SaveData()
    {
        PlayerPrefs.SetString("setting", JsonUtility.ToJson(settings));
    }


}
