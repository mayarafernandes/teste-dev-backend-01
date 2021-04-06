using Owner.JogoGourmet.Engine;
using System;
using System.Windows.Forms;

namespace Owner.JogoGourmet.GUI
{
    public partial class JogoGourmet : Form
    {
        private readonly GameEngine _gameEngine;
        private GameStepType _currentStepType;

        public JogoGourmet()
        {
            InitializeComponent();
            _gameEngine = new GameEngine();
            LoadStep(_gameEngine.Start());
        }

        private void LoadInfo(string info)
        {
            labelQuestion.Text = info;
            textBoxAnswer.Text = string.Empty;
            textBoxAnswer.Visible = false;
            buttonYes.Visible = buttonNo.Visible = false;
            buttonOk.Visible = true;
            buttonOk.Focus();
        }

        private void LoadGuess(string question)
        {
            labelQuestion.Text = question;
            textBoxAnswer.Text = string.Empty;
            textBoxAnswer.Visible = false;
            buttonYes.Visible = buttonNo.Visible = true;
            buttonOk.Visible = false;
        }

        private void LoadQuestion(string question)
        {
            labelQuestion.Text = question;
            textBoxAnswer.Text = string.Empty;
            textBoxAnswer.Visible = true;
            textBoxAnswer.Focus();
            buttonYes.Visible = buttonNo.Visible = false;
            buttonOk.Visible = true;
        }

        private void LoadStep(GameStep currentStep)
        {
            _currentStepType = currentStep.Type;
            if (_currentStepType == GameStepType.Guess)
                LoadGuess(currentStep.Message);
            else if (_currentStepType == GameStepType.Start || _currentStepType == GameStepType.End)
                LoadInfo(currentStep.Message);            
            else if (_currentStepType == GameStepType.QuestionCategory || _currentStepType == GameStepType.QuestionDish)
                LoadQuestion(currentStep.Message);
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (_currentStepType == GameStepType.QuestionCategory || _currentStepType == GameStepType.QuestionDish)
                LoadStep(_gameEngine.Next(textBoxAnswer.Text.Trim()));
            else
                LoadStep(_gameEngine.Next());
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            LoadStep(_gameEngine.Answer(true));
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            LoadStep(_gameEngine.Answer(false));
        }
    }
}
