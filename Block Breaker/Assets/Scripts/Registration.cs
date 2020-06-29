using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class Registration : MonoBehaviour {
    public InputField username;
    public InputField password;
    public Button button;
	
	
	
    public void CallRegister()
    {
        StartCoroutine(Upload());
    }
   
    
    IEnumerator Upload()
    {
        WWWForm form = new WWWForm();
        form.AddField("name", username.text);
        form.AddField("password", password.text);
        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/sqlconnect/Untitled-2.php", form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log("Form upload complete!");
                UnityEngine.SceneManagement.SceneManager.LoadScene(0);
            }
        }
    }

    public void VerifyInput() {
        button.interactable = (username.text.Length > 0 && password.text.Length > 0);
        
    }
}
