namespace WebAppLivres.Models.TokenAuthentification
{
    public interface ITokenManager
    {
        bool Authenticate(string user, string pwd);
        Token NewToken();
        bool VerifyToken(string tokenValue);
    }
}