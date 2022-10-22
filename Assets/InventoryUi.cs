using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUi : MonoBehaviour
{
    private TextMeshProUGUI plasticText;
    private TextMeshProUGUI paperText;
    private TextMeshProUGUI glassText;
    private TextMeshProUGUI ironText;
    private TextMeshProUGUI aluminumText;


    private void Start()
    {
        plasticText = GetComponent<TextMeshProUGUI>();
        paperText = GetComponent<TextMeshProUGUI>();
        glassText = GetComponent<TextMeshProUGUI>();
        ironText = GetComponent<TextMeshProUGUI>();
        aluminumText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateTrashText(playerInventory playerInventory)
    {
        plasticText.text = playerInventory.NumberOfPlastic.ToString();
        
    }

    public void UpdatePaperText(playerInventory playerInventory)
    {
        paperText.text = playerInventory.NumberOfPaper.ToString();
    }

    public void UpdateGlassText(playerInventory playerInventory)
    {
        glassText.text = playerInventory.NumberOfGlass.ToString();
    }

    public void UpdateIronText(playerInventory playerInventory)
    {
        ironText.text = playerInventory.NumberOfIron.ToString();
    }

    public void UpdateAlumýnumText(playerInventory playerInventory)
    {
        aluminumText.text = playerInventory.NumberOfAluminum.ToString();
    }

}