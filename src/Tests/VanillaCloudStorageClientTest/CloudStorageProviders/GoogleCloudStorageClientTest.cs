﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Flurl.Http.Testing;
using NUnit.Framework;
using VanillaCloudStorageClient;
using VanillaCloudStorageClient.CloudStorageProviders;

namespace VanillaCloudStorageClientTest.CloudStorageProviders
{
    [TestFixture]
    public class GoogleCloudStorageClientTest
    {
        /// <summary>
        /// Setting <see cref="DoRealWebRequests"/> to true, causes the unit tests to act as
        /// integration tests, doing real web requests to the API. The constants
        /// • <see cref="ClientId"/>
        /// • <see cref="RedirectUrl"/>
        /// • <see cref="GoogleAccessToken"/>
        /// must then be set to valid credentials.
        /// </summary>
        private const bool DoRealWebRequests = false;
        private const string ClientId = "cid";
        private const string RedirectUrl = "com.example.myapp://oauth2redirect/";

        private const string GoogledriveRedirectedUrl = "GetItWith:ReallyDoOpenAuthorizationPageInBrowser";
        private const string GoogledriveAccessToken = "GetItWith:ReallyDoFetchToken_or_ReallyDoRefreshToken";
        private const string GoogledriveRefreshToken = "GetItWith:ReallyDoFetchToken";

        private const string State = "7ysv8L9s4LB9CZpA";
        private const string CodeVerifier = "abcdefghijklmnopqrstuvwxyabcdefghijklmnopqrstuvwxy";
        private HttpTest _httpTest;

        [SetUp]
        public void CreateHttpTest()
        {
            if (!DoRealWebRequests)
                _httpTest = new HttpTest(); // Put flurl into test mode
        }

        [TearDown]
        public void DisposeHttpTest()
        {
            if (!DoRealWebRequests)
                _httpTest.Dispose();
        }

        [Test]
        [Ignore("Opens the authorization page in the system browse, to get a real authorization-code")]
        public void ReallyDoOpenAuthorizationPageInBrowser()
        {
            IOAuth2CloudStorageClient client = new GoogleCloudStorageClient(ClientId, RedirectUrl);
            string requestUrl = client.BuildAuthorizationRequestUrl(State, CodeVerifier);

            Process browserProcess = new Process();
            browserProcess.StartInfo.UseShellExecute = true;
            browserProcess.StartInfo.FileName = requestUrl;
            browserProcess.Start();
        }

        [Test]
        [Ignore("Gets a real access-token")]
        public async Task ReallyDoFetchToken()
        {
            if (!DoRealWebRequests)
                return;

            // Fetch token
            IOAuth2CloudStorageClient client = new GoogleCloudStorageClient(ClientId, RedirectUrl);
            CloudStorageToken token = await client.FetchTokenAsync(GoogledriveRedirectedUrl, State, CodeVerifier);

            Assert.IsNotNull(token.AccessToken);
            Assert.IsNotNull(token.RefreshToken);
        }

        [Test]
        [Ignore("Refreshes a real token")]
        public async Task ReallyDoRefreshToken()
        {
            if (!DoRealWebRequests)
                return;

            CloudStorageToken oldToken = new CloudStorageToken
            {
                RefreshToken = GoogledriveRefreshToken,
            };

            // Refresh token
            IOAuth2CloudStorageClient client = new GoogleCloudStorageClient(ClientId, RedirectUrl);
            CloudStorageToken newToken = await client.RefreshTokenAsync(oldToken);

            Assert.IsNotNull(newToken.AccessToken);
            Assert.AreNotEqual(oldToken.AccessToken, newToken.AccessToken);
            Assert.AreEqual(oldToken.RefreshToken, newToken.RefreshToken);
        }

        [Test]
        public async Task FileLifecycleWorks()
        {
            string fileName = "unittest.dat";
            byte[] fileContent = new byte[16];
            new Random().NextBytes(fileContent);

            // 1) Test upload
            if (!DoRealWebRequests)
            {
                _httpTest.RespondWith(GetGoogleSearchFileNotFoundResponse());
                _httpTest.RespondWith(string.Empty, 200, new { Location = "https://www.googleapis.com/upload/drive/v3/files?uploadType=resumable&upload_id=FAKEID" });
            }
            Assert.DoesNotThrowAsync(() => UploadFileWorksAsync(fileName, fileContent));

            // 2) Test listing
            if (!DoRealWebRequests)
            {
                _httpTest.RespondWith(GetGoogleFileListResponse());
            }
            List<string> res = await ListFileNamesWorksAsync();
            Assert.IsTrue(res.Count >= 1);
            Assert.IsTrue(res.Contains("unittest.dat"));

            // 3) Test exists
            if (!DoRealWebRequests)
            {
                _httpTest.RespondWith(GetGoogleSearchFileFoundResponse());
            }
            bool exists = await FileExistsWorksAsync(fileName);
            Assert.IsTrue(exists);

            // 4) Test download
            if (!DoRealWebRequests)
            {
                _httpTest = new HttpTest();
                _httpTest.RespondWith(GetGoogleSearchFileFoundResponse());
                HttpContent httpContent = new ByteArrayContent(fileContent);
                _httpTest.RespondWith(() => httpContent);
            }
            Byte[] downloadedContent = await DownloadFileWorksAsync(fileName);
            Assert.AreEqual(fileContent, downloadedContent);

            // 5) Test delete
            if (!DoRealWebRequests)
            {
                _httpTest.RespondWith(GetGoogleSearchFileFoundResponse());
            }
            Assert.DoesNotThrowAsync(() => DeleteFileWorksAsync(fileName));

            // 6) Was really deleted?
            if (!DoRealWebRequests)
            {
                _httpTest.RespondWith(GetGoogleSearchFileNotFoundResponse());
            }
            exists = await FileExistsWorksAsync(fileName);
            Assert.IsFalse(exists);
        }

        private async Task UploadFileWorksAsync(string fileName, byte[] fileContent)
        {
            ICloudStorageClient client = new GoogleCloudStorageClient(ClientId, RedirectUrl);
            var credentials = new CloudStorageCredentials { Token = new CloudStorageToken { AccessToken = GoogledriveAccessToken } };
            await client.UploadFileAsync(fileName, fileContent, credentials);
        }

        private async Task<byte[]> DownloadFileWorksAsync(string fileName)
        {
            ICloudStorageClient client = new GoogleCloudStorageClient(ClientId, RedirectUrl);
            var credentials = new CloudStorageCredentials { Token = new CloudStorageToken { AccessToken = GoogledriveAccessToken } };
            return await client.DownloadFileAsync(fileName, credentials);
        }

        private async Task DeleteFileWorksAsync(string fileName)
        {
            ICloudStorageClient client = new GoogleCloudStorageClient(ClientId, RedirectUrl);
            var credentials = new CloudStorageCredentials { Token = new CloudStorageToken { AccessToken = GoogledriveAccessToken } };
            await client.DeleteFileAsync(fileName, credentials);
        }

        private async Task<List<string>> ListFileNamesWorksAsync()
        {
            ICloudStorageClient client = new GoogleCloudStorageClient(ClientId, string.Empty);
            var credentials = new CloudStorageCredentials { Token = new CloudStorageToken { AccessToken = GoogledriveAccessToken } };
            List<string> result = await client.ListFileNamesAsync(credentials);
            return result;
        }

        private async Task<bool> FileExistsWorksAsync(string filename)
        {
            ICloudStorageClient client = new GoogleCloudStorageClient(ClientId, string.Empty);
            var credentials = new CloudStorageCredentials { Token = new CloudStorageToken { AccessToken = GoogledriveAccessToken } };
            return await client.ExistsFileAsync(filename, credentials);
        }

        private string GetGoogleFileListResponse()
        {
            return
@"{
 ""incompleteSearch"": false,
 ""files"": [
  {
   ""kind"": ""drive#file"",
   ""id"": ""FakeId1"",
   ""name"": ""unittest.dat""
  },
  {
   ""kind"": ""drive#file"",
   ""id"": ""FakeId2"",
   ""name"": ""a.txt""
  },
  {
   ""kind"": ""drive#file"",
   ""id"": ""FakeId3"",
   ""name"": ""b.txt""
  }
 ]
}
";
        }

        private string GetGoogleSearchFileFoundResponse()
        {
            return
@"{
 ""incompleteSearch"": false,
 ""files"": [
  {
   ""kind"": ""drive#file"",
   ""id"": ""FAKEID"",
   ""name"": ""unittest.dat""
  }
 ]
}";
        }

        private string GetGoogleSearchFileNotFoundResponse()
        {
            return
@"{
 ""kind"": ""drive#fileList"",
 ""incompleteSearch"": false,
 ""files"": []
}";
        }
    }
}
