using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	public Text playerScoreText;
	public Text ComputerScoreText;
	private int _playerScore;
	private int _computerScore;
	public Ball ball;

	public void ComputerScores()
	{
		_computerScore++;
		this.ball.ResetPosition();
		ComputerScoreText.text = _computerScore.ToString();
	}
	public void PlayerScores()
	{
		_playerScore++;
		this.ball.ResetPosition();
		playerScoreText.text = _playerScore.ToString();
	}
}
