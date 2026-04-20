using System;

public class LoginService
{
    public string Login(string email, string password)
    {
        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
        {
            return "Error: Empty fields";
        }

        if (email == "aveevtamir@gmail.com" && password == "RURGEE")
        {
            return "Success";
        }

        return "Invalid credentials";
    }
}
