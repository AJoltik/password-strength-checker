# PasswordStrengthChecker
This program evaluates the strength of a given password based on its length and character diversity. 
It provides users with a rating ranging from Very Weak to Very Strong based on predefined criteria.

# How To Run
Prerequisites: 
  1. .NET SDK (if running from source)
  2. A C# compiler (if compiling manually)

Running the Program:
Clone the repository: 
- git clone https://github.com/AJoltik/password-strength-checker
- cd PasswordStrengthChecker

Build the project:
- dotnet build

Run the program:
- dotnet run

Enter a password when prompted, and the program will output its strength.

# Limitations
- This program is intended for educational purposes only and should not be used to assess real-world password security.
- The password strength algorithm is simple and does not consider entropy, dictionary attacks, or advanced security threats.
- This program does not suggest ways to improve weak passwords; it only categorizes them.
https://www.uic.edu/apps/strong-password/ by the University of Illinois Chicago is a secure, insightful, and thorough alternative.

# Ethical Considerations and Responsible Use
- Users should not assume that a password marked "Very Strong" is completely secure. 
- Proper password management and multi-factor authentication should always be used.
- This program should not be modified to deceive users about password security or be used in malicious contexts.

# License
This project is released under the MIT License. See LICENSE for details.
