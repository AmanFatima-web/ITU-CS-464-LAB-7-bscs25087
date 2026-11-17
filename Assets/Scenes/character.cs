
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelection : MonoBehaviour
{
    public Button explorerButton;
    public Button warriorButton;
    public Button mageButton;

    public Color normalColor = new Color32(16, 44, 70, 255);
    public Color selectedColor = new Color32(217, 164, 65, 255);

    void Start()
    {
        SelectExplorer();
    }

    public void SelectExplorer()
    {
        SetSelected(explorerButton);
    }

    public void SelectWarrior()
    {
        SetSelected(warriorButton);
    }

    public void SelectMage()
    {
        SetSelected(mageButton);
    }

    void SetSelected(Button selectedButton)
    {
        explorerButton.image.color = normalColor;
        warriorButton.image.color = normalColor;
        mageButton.image.color = normalColor;

        selectedButton.image.color = selectedColor;
    }
    public GameObject confirmationText;

    public void ConfirmSelection()
    {
        confirmationText.SetActive(true);
    }
}
