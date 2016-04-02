namespace QuizNight
{
    class Scorer
    {
        public Scorer() { }

        public static int AdultScore(int correctAnswer, int incorrectAnswer)
        {
            return correctAnswer * 10 - incorrectAnswer * 1;
        }

        public static int ChildScore(int correctAnswer, int incorrectAnswer)
        {
            return correctAnswer * 15 - incorrectAnswer * 0;
        }
    }
}
