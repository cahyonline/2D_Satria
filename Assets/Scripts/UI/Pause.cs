using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    // Nama scene yang akan dituju ketika pause
    [SerializeField] private string pauseSceneName = "PauseScene";

    private bool isPaused = false;

    void Update()
    {
        // Mengecek apakah tombol Escape ditekan
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isPaused)
            {
                Pause();
            }
            else
            {
                Resume();
            }
        }
    }

    // Fungsi untuk pause game
    private void Pause()
    {
        Time.timeScale = 0; // Menghentikan waktu
        SceneManager.LoadScene(pauseSceneName, LoadSceneMode.Additive); // Memuat scene pause secara additive
        isPaused = true;
    }

    // Fungsi untuk resume game
    public void Resume()
    {
        Time.timeScale = 1; // Melanjutkan waktu
        SceneManager.UnloadSceneAsync(pauseSceneName); // Mengeluarkan scene pause
        isPaused = false;
    }
}
