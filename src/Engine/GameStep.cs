namespace Owner.JogoGourmet.Engine
{
    public class GameStep
    {
        public GameStepType Type { get; set; }
        public string Message { get; set; }

        public GameStep()
        {

        }

        public GameStep(string message, GameStepType type)
        {
            Message = message;
            Type = type;
        }
    }
}
