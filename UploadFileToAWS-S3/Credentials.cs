namespace UploadFileToAWS_S3
{
    public class Credentials
    {
        public static Amazon.Runtime.BasicAWSCredentials GetCredentials()
        {
            string accessId = "PUT_YOUR_USER_ID_HERE";
            string secret = "PUT_YOUR_PASSWORD_HERE";
            return new Amazon.Runtime.BasicAWSCredentials(accessId, secret);
        }
    }
}
