namespace STEMFair
{
    public static class SecretValidator
    {
        public static bool ValidateQuestion(string answer)
        {
            return answer == "pizza";
        }

        public static bool ValidateCode(string answer)
        {
            return answer == "4853";
        }

        public static bool ValidateSelection(int answer)
        {
            return answer == 3;
        }

    }
}
