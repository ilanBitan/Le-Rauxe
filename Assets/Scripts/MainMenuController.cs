using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    public class MainMenuController : MonoBehaviour
    {
        public void playGame()
        {
           // int selectedCharacter = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);

           // GameManager.instance.CharIndex = selectedCharacter;
            
            SceneManager.LoadScene("Gameplay");
        }
       
    }
}