namespace UploadFileToAWS_S3
{
    class Program
    {
        static void Main(string[] args)
        {
            string bucket = "PUT-YOUR-BUCKET-NAME-HERE";
            
            string fileNameWithPathOnDisk = @"C:\Temp\testfile.zip";
            
            string fileNameToUseInBucket = "testfile.zip";
            
            Store.Transfer(bucket, fileNameWithPathOnDisk, fileNameToUseInBucket);
        }
    }
}
