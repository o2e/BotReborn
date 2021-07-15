namespace BotReborn
{
    public class LoginResponse
    {
        public bool IsSuccessful { get; set; }
        public byte[] CaptchaImage { get; set; }
        public byte[] CaptchaSign { get; set; }
        public string VerifyUrl { get; set; }
        public string SmsPhone { get; set; }
        public string ErrorMessage { get; set; }

    }
}
