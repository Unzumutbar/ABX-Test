
namespace Simple_ABX_test.Objects
{
    public class Result
    {
        public int TestNumber { get; set; }
        public string SelectedAnswer { get; set; }
        public string CorrectAnswer { get; set; }

        public bool Passed
        {
            get { return SelectedAnswer == CorrectAnswer; }
        }

        public string Proband { get; set; }
        public string RowName { get; set; }

        public string SoundFileA { get; set; }
        public string SoundFileB { get; set; }
    }
}
