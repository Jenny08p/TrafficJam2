//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;
//using TMPro;
//public class PurchasePanelManager : MonoBehaviour
//{
//    private bool fadeIn;
//    private CanvasGroup InfoCanvas;
//    public TextMeshProUGUI purchaseBlurbText;
//    // Start is called before the first frame update
//    void Start()
//    {
//        //GRABS THE VARIABLES
//        InfoCanvas = GetComponent<CanvasGroup>();
//    }

//    // Update is called once per frame
//    public void ShowPurchasePanel()
//    {
//        //OPPOSITE OF HIDE PANEL, THIS FADES IT IN SLOWLY AND ALLOWS IT TO BE INTERACTED WITH
//        purchaseBlurbText.text = "Would you like to purchase " + ItemManager.instance.nameText.text + " for " + ItemManager.instance.costText.text + "?";
//        fadeIn = true;
//        InfoCanvas.interactable = true;
//        InfoCanvas.blocksRaycasts = true;
//    }

//    public void HidePurchasePanel()
//    {
//        //HIDES THE PANEL AND ALSO STOPS IT FROM BLOCKING CLICKS
//        fadeIn = false;
//        InfoCanvas.interactable = false;
//        InfoCanvas.blocksRaycasts = false;
//    }
//    private void Update()
//    {
//        //CONTROLS WETHER THE PURCHACE PANEL SHOULD BE FADING IN OR OUT (ITS ALPHA IS 0 BY DEFAULT)
//        if (fadeIn)
//        {
//            if (InfoCanvas.alpha <= 1)
//            {
//                InfoCanvas.alpha += 1 * Time.deltaTime;
//            }
//        }
//        if (!fadeIn)
//        {
//            if (InfoCanvas.alpha >= 0)
//            {
//                InfoCanvas.alpha -= 1 * Time.deltaTime;
//            }
//        }
//    }
//    public void PurchaseItem()
//    {
//        HidePurchasePanel();
//        //PURCHASE ITEM LOGIC GOES HERE (TAKING MONEY FROM PLAYER ETC)
//    }
//}