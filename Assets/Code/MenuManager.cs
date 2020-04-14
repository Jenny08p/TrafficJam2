using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public static MenuManager instance;
    public GameObject[] Menus;
    private int menuIndex = 0;
    private float slideSpeed = 15;
    public bool center = true;
    private Vector3 slideOutPos;
    private Vector3 slideInPos;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        //assiging the position the menu will slide out/in to
        slideOutPos = new Vector3(transform.position.x + 5, transform.position.y, transform.position.z);
        slideInPos = transform.position;
        ClearMenus();
        ShowMenu();
    }
    private void FixedUpdate()
    {
        if (center)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(slideInPos.x, transform.position.y, slideInPos.z), slideSpeed * Time.deltaTime);
        }
        else if (!center)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(slideOutPos.x, transform.position.y, slideOutPos.z), slideSpeed * Time.deltaTime);
        }
    }
        //Change menu function using the menuIndex variable
    public void CatagoryChange(int index)
    {
        menuIndex = index;
        StartCoroutine(MenuSlideOut());
    }

    //turns ALL menus off usually before enabling the current one
    public void ClearMenus()
    {
        foreach (GameObject m in Menus)
        {
            m.SetActive(false);
        }
    }
    public void ShowMenu()
    {
        Menus[menuIndex].SetActive(true);

    }
    IEnumerator MenuSlideOut()
    {
        center = false;
        yield return new WaitForSeconds(.35f);
        ClearMenus();
        ShowMenu();
        center = true;
    }
}
