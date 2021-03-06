/* 
 * Authorize.net REST API
 *
 * Authorize.net REST API
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using RestSharp;
using NUnit.Framework;
using NMock;

using AuthorizeNet.Rest.Client;
using AuthorizeNet.Rest.Api;
using AuthorizeNet.Rest.Model;
using System.Net;
using System.Security.Cryptography;

namespace AuthorizeNet.Rest.Test
{
    /// <summary>
    ///  Class for testing AddressesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AddressesApiTests
    {
        private AddressesApi instance;

        private MockFactory mockFactory = new MockFactory();
        
        private Mock<IRestClient> mockRestClient;

        private RestResponse addressCollectionResponse = null;
        private RestResponse addressResponse = null;
        private RestResponse deleteResponse = null;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            mockRestClient = mockFactory.CreateMock<IRestClient>();
            mockRestClient.Expects.AtLeastOne.GetProperty(_ => _.Timeout).WillReturn(60000);
            mockRestClient.Expects.AtLeastOne.GetProperty(_ => _.UserAgent).WillReturn("asdasd");
            mockRestClient.Expects.AtLeastOne.SetPropertyTo(_ => _.Timeout = 60000);
            mockRestClient.Expects.AtLeastOne.SetPropertyTo(_ => _.UserAgent = "asdasd");

            addressResponse = new RestResponse
            {
                StatusCode = HttpStatusCode.OK,
                Content = @"  
                  {
                        ""address1"": ""dfgdfg"",
                        ""administrativeArea"": ""fhgfh"",
                        ""company"": ""dgfdgfdfg"",
                        ""country"": ""dfgdfg"",
                        ""firstName"": ""hdfhdfh"",
                        ""lastName"": ""dgfdfg"",
                        ""locality"": ""dfgdfg"",
                        ""phoneNumber"": ""456456"",
                        ""postalCode"": ""64564564"",
                        ""id"": ""1812686620"",
                        ""_links"": {
                            ""self"": {
                            ""href"": ""/rest/v1/customers/1813850313/addresses/1812686620"",
                            ""method"": ""GET""
                        },
                        ""customer"": {
                        ""href"": ""/rest/v1/customers/1813850313"",
                        ""method"": ""GET""
                        }
                    }
                }"
            };

            addressCollectionResponse = new RestResponse
            {
                StatusCode = HttpStatusCode.OK,
                Content = @"{
                    ""links"": {
                    ""self"": {
                        ""href"": ""/rest/v1/customers/1813850313/addresses?offset=0&limit=100"",
                        ""method"": ""GET""
                        }
                       },
                    ""embedded"": {
                    ""addresses"": [
                    {
                        ""id"": ""1812686620"",
                        ""address1"": ""dfgdfg"",
                        ""administrativeArea"": ""fhgfh"",
                        ""company"": ""dgfdgfdfg"",
                        ""country"": ""dfgdfg"",
                        ""firstName"": ""hdfhdfh"",
                        ""lastName"": ""dgfdfg"",
                        ""locality"": ""dfgdfg"",
                        ""phoneNumber"": ""456456"",
                        ""postalCode"": ""64564564"",
                    ""_links"": {
                        ""self"": {
                        ""href"": ""/rest/v1/customers/1813850313/addresses/1812686620"",
                        ""method"": ""GET""
                    },
                    ""customer"": {
                    ""href"": ""/rest/v1/customers/1813850313"",
                    ""method"": ""GET""
                                }
                                }
                            }
                    ]
                },
            ""totalAddresses"": 1
            }"
            };

            deleteResponse = new RestResponse
            {
                StatusCode = HttpStatusCode.OK,
                Content = @""
            };
        }

        private static readonly RNGCryptoServiceProvider RandStr = new RNGCryptoServiceProvider();
        public static string Random()
        {


            byte rand1 = 0;
            byte rand2 = 0;
            byte[] random = new byte[1];
            RandStr.GetBytes(random);
            rand1 = random[0];
            RandStr.GetBytes(random);
            rand2 = random[0];
            return rand1 + "" + rand2;
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test CreateCustomerAddress
        /// </summary>
        [Test]
        public void CreateCustomerAddressTest()
        {
            string authorization = "Basic asdadsa";
            string customerId = "123123";

            CreateCustomerAddress createCustomerAddress = new CreateCustomerAddress("Electonics City Phase 1");

            mockRestClient.Expects.One.Method(v => v.Execute(new RestRequest())).With(NMock.Is.TypeOf(typeof(RestRequest))).WillReturn(addressResponse);
            ApiClient apiClient = new ApiClient(mockRestClient.MockObject);
            apiClient.Configuration = null;

            Configuration configuration = new Configuration
            {
                ApiClient = apiClient,
                Username = "Asdads",
                Password = "asdasd",
                AccessToken = null,
                ApiKey = null,
                ApiKeyPrefix = null,
                TempFolderPath = null,
                DateTimeFormat = null,
                Timeout = 60000,
                UserAgent = "asdasd"
            };

            instance = new AddressesApi(configuration);

            var response = instance.CreateCustomerAddress(customerId, createCustomerAddress, authorization);
            Assert.IsInstanceOf<Address>(response, "response is Customer");
        }
        
        /// <summary>
        /// Test DeleteAddress
        /// </summary>
        [Test]
        public void DeleteAddressTest()
        {
            string authorization = "Basic asdadsa";
            string customerId = "123123";
            string addressId = "1234";

            mockRestClient.Expects.One.Method(v => v.Execute(new RestRequest())).With(NMock.Is.TypeOf(typeof(RestRequest))).WillReturn(deleteResponse);
            ApiClient apiClient = new ApiClient(mockRestClient.MockObject);
            apiClient.Configuration = null;

            Configuration configuration = new Configuration
            {
                ApiClient = apiClient,
                Username = "Asdads",
                Password = "asdasd",
                AccessToken = null,
                ApiKey = null,
                ApiKeyPrefix = null,
                TempFolderPath = null,
                DateTimeFormat = null,
                Timeout = 60000,
                UserAgent = "asdasd"
            };

            instance = new AddressesApi(configuration);
            instance.DeleteAddress(authorization, customerId, addressId);
        }
        
        /// <summary>
        /// Test GetAllCustomerAddresses
        /// </summary>
        [Test]
        public void GetAllCustomerAddressesTest()
        {
            string authorization = "Basic asdadsa";
            string customerId = "123123";

            mockRestClient.Expects.One.Method(v => v.Execute(new RestRequest())).With(NMock.Is.TypeOf(typeof(RestRequest))).WillReturn(addressCollectionResponse);
            ApiClient apiClient = new ApiClient(mockRestClient.MockObject);
            apiClient.Configuration = null;

            Configuration configuration = new Configuration
            {
                ApiClient = apiClient,
                Username = "Asdads",
                Password = "asdasd",
                AccessToken = null,
                ApiKey = null,
                ApiKeyPrefix = null,
                TempFolderPath = null,
                DateTimeFormat = null,
                Timeout = 60000,
                UserAgent = "asdasd"
            };

            instance = new AddressesApi(configuration);

            var response = instance.GetAllCustomerAddresses(authorization, customerId);
            Assert.IsInstanceOf<AddressCollection>(response, "response is Customer");
        }
        
        /// <summary>
        /// Test GetCustomerAddress
        /// </summary>
        [Test]
        public void GetCustomerAddressTest()
        {
            string authorization = "Basic asdadsa";
            string customerId = "123123";
            string addressId = "1234";

            mockRestClient.Expects.One.Method(v => v.Execute(new RestRequest())).With(NMock.Is.TypeOf(typeof(RestRequest))).WillReturn(addressResponse);
            ApiClient apiClient = new ApiClient(mockRestClient.MockObject);
            apiClient.Configuration = null;

            Configuration configuration = new Configuration
            {
                ApiClient = apiClient,
                Username = "Asdads",
                Password = "asdasd",
                AccessToken = null,
                ApiKey = null,
                ApiKeyPrefix = null,
                TempFolderPath = null,
                DateTimeFormat = null,
                Timeout = 60000,
                UserAgent = "asdasd"
            };

            instance = new AddressesApi(configuration);

            var response = instance.GetCustomerAddress(authorization, customerId, addressId);
            Assert.IsInstanceOf<Address>(response, "response is Customer");
        }
        
        /// <summary>
        /// Test UpdateCustomerAddress
        /// </summary>
        [Test]
        public void UpdateCustomerAddressTest()
        {
            string authorization = "Basic asdadsa";
            string customerId = "123123";
            string addressId = "1234";
            CreateCustomerAddress updateCustomerAddress = new CreateCustomerAddress("Electonics City Phase 1");

            mockRestClient.Expects.One.Method(v => v.Execute(new RestRequest())).With(NMock.Is.TypeOf(typeof(RestRequest))).WillReturn(addressResponse);
            ApiClient apiClient = new ApiClient(mockRestClient.MockObject);
            apiClient.Configuration = null;

            Configuration configuration = new Configuration
            {
                ApiClient = apiClient,
                Username = "Asdads",
                Password = "asdasd",
                AccessToken = null,
                ApiKey = null,
                ApiKeyPrefix = null,
                TempFolderPath = null,
                DateTimeFormat = null,
                Timeout = 60000,
                UserAgent = "asdasd"
            };

            instance = new AddressesApi(configuration);

            var response = instance.UpdateCustomerAddress(customerId, addressId, updateCustomerAddress, authorization);
            Assert.IsInstanceOf<Address>(response, "response is Customer");
        }
    }
}
