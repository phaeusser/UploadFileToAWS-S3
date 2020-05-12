using Amazon;
using Amazon.S3;
using Amazon.S3.Transfer;
using System;

namespace UploadFileToAWS_S3
{
    public class Store
    {
        private static IAmazonS3 client;
        private static readonly RegionEndpoint bucketRegion = RegionEndpoint.EUCentral1;

        public static void Transfer(string bucket, string filePath, string file)
        {
            var credentials = Credentials.GetCredentials();

            client = new AmazonS3Client(credentials, bucketRegion);

            var transferUtility = new TransferUtility(client);

            try
            {
                transferUtility.Upload(filePath, bucket, file);
            }
            catch (AmazonS3Exception e)
            {
                Console.WriteLine(
                        "Error encountered ***. Message:'{0}' when writing an object"
                        , e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(
                    "Unknown encountered on server. Message:'{0}' when writing an object"
                    , e.Message);
            }

        }
    }
}
