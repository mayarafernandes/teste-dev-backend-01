using Owner.JogoGourmet.KnowledgeBase;

namespace Owner.JogoGourmet.Engine
{
    public class GameEngine
    {
        public const string START_INSTRUCTION = "Pense em um prato que você gosta...";
        public const string QUESTION_GUESS = "O prato que você pensou é {0}?";
        public const string QUESTION_DISH = "Qual prato você pensou?";
        public const string QUESTION_CATEGORY = "{0} é ....... mas não é {1}.";
        public const string RIGHT_GUESS = "Acertei de novo!";

        private readonly KnowledgeBaseBinaryTree _knowledgeBase;
        private GameStepType _currentStepType;
        private string _newDish;

        public GameEngine()
        {
            _knowledgeBase = new KnowledgeBaseBinaryTree();
        }

        public GameStep Start()
        {
            return CurrentStep(GameStepType.Start, START_INSTRUCTION);
        }

        public GameStep Next()
        {
            if (_currentStepType == GameStepType.End)
                return Start();
            if (_currentStepType == GameStepType.Start)
                return CurrentStep(GameStepType.Guess, string.Format(QUESTION_GUESS, _knowledgeBase.FirstCategory));
            return new GameStep();
        }

        public GameStep Next(string answer)
        {            
            if (_knowledgeBase.IsCurrentItemDish)
            {
                _knowledgeBase.AddItem(answer);
                return Start();
            }
            if (_currentStepType == GameStepType.QuestionDish)
            {
                _newDish = answer;
                return CurrentStep(GameStepType.QuestionCategory, string.Format(QUESTION_CATEGORY, _newDish, _knowledgeBase.CurrentItem));
            }
            else if (_currentStepType == GameStepType.QuestionCategory)
            {
                _knowledgeBase.AddItem(_newDish, answer);
                return Start();
            }
            return new GameStep();                
        }

        public GameStep Answer(bool guessed)
        {
            if (guessed)
            {
                if (!_knowledgeBase.IsCurrentItemDish)
                    return CurrentStep(GameStepType.Guess, string.Format(QUESTION_GUESS, _knowledgeBase.FirstDish));
                else
                    return CurrentStep(GameStepType.End, RIGHT_GUESS);
            }
            else if (_knowledgeBase.HasNextItem)
            {
                return CurrentStep(GameStepType.Guess, string.Format(QUESTION_GUESS, _knowledgeBase.NextItem));
            }
            return CurrentStep(GameStepType.QuestionDish, QUESTION_DISH);
        }

        private GameStep CurrentStep(GameStepType type, string message)
        {
            _currentStepType = type;
            return new GameStep(message, _currentStepType);
        }
    }
}
