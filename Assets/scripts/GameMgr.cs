using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Newtonsoft.Json;
public class GameMgr : MonoBehaviour
{
    public RawImage img;
    public Texture2D[] bgs;
    private int showIndex;
    public InputField inputField;
    public InputField inputField_year;
    public InputField inputField_m;
    public Text text_count;
    List<NoteInfo> noteInfos = new List<NoteInfo>();
    int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        showIndex = 0;
        ChangeBg();
       string json= PlayerPrefs.GetString("Note", string.Empty);
        if (!string.IsNullOrEmpty(json))
        {
           var infos= JsonConvert.DeserializeObject<List<NoteInfo>>(json);
            for (int i = 0; i < infos.Count; i++)
            {
                noteInfos.Add(infos[i]);
            }
        }
        index = noteInfos.Count>0? noteInfos.Count-1: 0;
        UpdateUi();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            showIndex += 1;
            ChangeBg();
            if (showIndex + 1 >= bgs.Length)
                showIndex = -1;
        }
    }

    private void ChangeBg()
    {
        img.texture = bgs[showIndex];
    }

    public void Save()
    {
        if (string.IsNullOrEmpty(inputField.text)) return;
        NoteInfo noteInfo = new NoteInfo();
        noteInfo.content = inputField.text;
        noteInfo.year = inputField_year.text;
        noteInfo.month = inputField_m.text;
        noteInfos.Add(noteInfo);
        string json=JsonConvert.SerializeObject(noteInfos);
        PlayerPrefs.SetString("Note", json);
        Debug.Log(json);
        
    }
    public void Next()
    {
        index++;
        if(index>= noteInfos.Count)
        {
            index = noteInfos.Count;
        }
        UpdateUi();
    }
    public void Last()
    {
        index--;
        if (index < 0)
        {
            index =0;
        }
        UpdateUi();
    }
    public void UpdateUi()
    {
        if(index == noteInfos.Count)
        {
            inputField.text = "";
            inputField_year.text = "";
            inputField_m.text = "";
            text_count.text = $"{noteInfos.Count}/{noteInfos.Count}";
        }
        else
        {
            NoteInfo n = noteInfos[index];
            inputField.text = n.content;
            inputField_year.text = n.year;
            inputField_m.text = n.month;
            text_count.text = $"{index + 1}/{noteInfos.Count}";
        }
      
    }
    public void DeleteAll()
    {
        PlayerPrefs.DeleteKey("Note");
        noteInfos.Clear();
        index = 0;
        UpdateUi();
    }
}
public class NoteInfo
{
    public string content;
    public string year;
    public string month;
}
