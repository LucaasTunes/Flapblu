using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicSc : MonoBehaviour
{
    // Variáveis públicas
    public int playerScore = 0;  // Inicializa o score
    public Text scoreText;
    public GameObject gameOverScreen;

    // Método para adicionar pontos
    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;  // Maneira mais curta de escrever
        UpdateScoreText();
    }

    // Atualiza o texto do placar
    void UpdateScoreText()
    {
        if (scoreText != null)  // Verifica se o componente está atribuído
        {
            scoreText.text = playerScore.ToString();
        }
        else
        {
            Debug.LogWarning("scoreText não está atribuído no Inspector!");
        }
    }

    // Método para reiniciar o jogo
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Pode ser utilizado para lógica que precisa rodar a cada frame
    public void gameOver ()
    {
        gameOverScreen.SetActive(true);
    }
}
