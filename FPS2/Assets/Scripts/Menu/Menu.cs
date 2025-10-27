using Photon.Pun;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject menuP;
    [SerializeField] private GameObject menuO;
    [SerializeField] private GameObject menuC;

    [SerializeField] private TMP_InputField nombreInputField;


    void Start()
    {
        
    }

    public void Jugar()
    {
        SceneManager.LoadScene(1);
    }

    public void Multijugador()
    {
        guardarNombre();
        SceneManager.LoadScene(2);
    }

    public void guardarNombre()
    {
        if (nombreInputField != null && !string.IsNullOrEmpty(nombreInputField.text))
        {
            PhotonNetwork.NickName = nombreInputField.text;
        }
        else
        {
            PhotonNetwork.NickName = "Player" + Random.Range(1000, 9999);
            Debug.LogWarning("Nombre vacío, usando nombre aleatorio: " + PhotonNetwork.NickName);
        }
    }

    public void opciones()
    {
        menuP.SetActive(false);
        menuO.SetActive(true);
    }

    public void creditos()
    {
        menuP.SetActive(false);
        menuO.SetActive(true);
    }

    public void salir()
    {
        Application.Quit();
    }

    public void volver()
    {
        menuP.SetActive(true);
        menuO.SetActive(false);
        menuC.SetActive(false);
    }


}
