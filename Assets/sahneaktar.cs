using UnityEngine;
using UnityEngine.SceneManagement;

public class sahneaktar : MonoBehaviour
{
    // Sahneyi yüklemek için kullanılacak olan sahne adını değişken olarak tanımlayın
    public string sahneAdi;

    // Sahneyi yükleme işlevi
    public void SahneYukle()
    {
        SceneManager.LoadScene("oyun");
    }
        public void ilkbahar()
    {
        SceneManager.LoadScene("ilkbahar");
    }
        public void sonbahar()
    {
        SceneManager.LoadScene("sonbahar");
    }
        public void yaz()
    {
        SceneManager.LoadScene("yaz");
    }
        public void kis()
    {
        SceneManager.LoadScene("kis");
    }

    // Uygulamadan çıkış işlevi
    public void Cikis()
    {
        Application.Quit();
    }
    public void istedigin()
    {
        SceneManager.LoadScene(sahneAdi);
    }
}
