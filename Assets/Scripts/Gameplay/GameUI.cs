using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{
    private UIDocument _uiDoc;
    private ProgressBar _healthbar;
    private ProgressBar _manabar;
    public Button _fleeB;

    public void Awake()
    {
        _uiDoc = GetComponent<UIDocument>();
        var root = GetComponent<UIDocument>().rootVisualElement;

        _healthbar = _uiDoc.rootVisualElement.Q<ProgressBar>("health");
        _manabar = _uiDoc.rootVisualElement.Q<ProgressBar>("mana");

        _fleeB = root.Q<Button>("Flee");
        _fleeB.clicked += Flee;
    }

    void Start()
    {

    }

    private void Flee(){
        Debug.Log("PENE");
        SceneManager.LoadScene("rpgScene");
    }

    public float Health{get => _healthbar.value; set => _healthbar.value = value;}
    public float Mana{get => _manabar.value; set => _manabar.value = value;}
    
    
}
