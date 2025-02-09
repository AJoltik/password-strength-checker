namespace PasswordStrengthChecker
{
    internal class PSC
    {
        /**
         * Main method to run the password strength checker.
         */
        static void Main(string[] args)
        {
            Console.Write("Enter a password: ");
            string password = Console.ReadLine();

            PasswordChecker checker = new PasswordChecker();
            PasswordStrength strength = checker.CheckStrength(password);

            Console.WriteLine($"Password strength: {strength}");
        }

        /**
         * Password strength levels.  
         */
        public enum PasswordStrength
        {
            VeryWeak,
            Weak,
            Medium,
            Strong,
            VeryStrong
        }

        /**
         * Checks the strength of a password.
         */
        public class PasswordChecker
        {
            /**
             * Checks the strength of a password based on its length and complexity.
             * @param password The password to check.
             * @return The strength of the password.
             */
            public PasswordStrength CheckStrength(string password)
            {
                int score = 0;

                // Length check and score
                if (password.Length >= 12)
                    score += 4;
                else if (password.Length >= 8)
                    score += 2;
                else if (password.Length >= 6)
                    score += 1;
                else
                    return PasswordStrength.VeryWeak;

                // Character complexity check
                if (password.Any(char.IsUpper)) score += 2;
                if (password.Any(char.IsLower)) score += 2;
                if (password.Any(char.IsDigit)) score += 2;
                if (password.Any(ch => !char.IsLetterOrDigit(ch))) score += 2;

                // Determine strength based on score
                if (score < 4) return PasswordStrength.Weak;
                if (score < 8) return PasswordStrength.Medium;
                if (score < 12) return PasswordStrength.Strong;
                return PasswordStrength.VeryStrong;
            }
        }
    }
}
