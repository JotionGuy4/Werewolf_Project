using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManagement : MonoBehaviour{

    public Toggle StartToggle;
    public GameObject DifficultyToggles;
    private void Start()
    {
        StartToggle.onValueChanged.AddListener(isStartOn => DifficultyToggles.SetActive(!isStartOn));
        StartToggle.isOn = GameValues.IsStart;

        DifficultyToggles.transform.GetChild((int)GameValues.Difficulty).GetComponent<Toggle>().isOn = true;

    }

    public void PlayGame()
    {
        SceneManager.LoadScene("main");
    }

    public void SetStart(bool isOn)
    {
        GameValues.IsStart = isOn;
    }

    #region Difficulty
    public void SetEasyDifficulty(bool isOn)
    {
        if (isOn)
            GameValues.Difficulty = GameValues.Difficulties.Easy;
    }

    public void SetHardDifficulty(bool isOn)
    {
        if (isOn)
            GameValues.Difficulty = GameValues.Difficulties.Hard;
    }

    #endregion


}
